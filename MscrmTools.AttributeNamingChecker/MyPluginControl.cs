using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using MscrmTools.AttributeNamingChecker.AppCode;
using MscrmTools.AttributeNamingChecker.Dialogs;
using MscrmTools.AttributeNamingChecker.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace MscrmTools.AttributeNamingChecker
{
    public partial class MyPluginControl : PluginControlBase, IGitHubPlugin, IHelpPlugin
    {
        private readonly SettingsForm _sForm;
        private readonly SummaryForm _summaryForm;
        private Settings _settings;
        private List<Entity> _solutionsList;

        public MyPluginControl()
        {
            InitializeComponent();

            SetTheme();

            _sForm = new SettingsForm();
            _sForm.Show(dpMain, DockState.Document);

            _summaryForm = new SummaryForm();
        }

        public string HelpUrl => "https://github.com/MscrmTools/MscrmTools.AttributeNamingChecker";
        public string RepositoryName => "MscrmTools.AttributeNamingChecker";

        public string UserName => "MscrmTools";

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (!SettingsManager.Instance.TryLoad(GetType(), out _settings, $"{ConnectionDetail?.ConnectionId}{ConnectionDetail?.ConnectionName}"))
            {
                _settings = new Settings();
            }

            _sForm.Settings = _settings;
            _sForm.ConnectionDetail = detail;
        }

        private void LoadEntities(bool selectSolutions = false)
        {
            if (selectSolutions)
            {
                var dialog = new SolutionPickerDialog(Service);
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    _solutionsList = dialog.SelectedSolutions;
                }
                else
                {
                    return;
                }
            }

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Retrieving metadata...",
                Work = (bw, e) =>
                {
                    var mm = new MetadataManager(Service);
                    var emds = mm.GetEntities(_solutionsList, _settings);

                    var checkList = new List<CheckData>();
                    checkList.Add(new CheckData
                    {
                        RegExp = _settings.AllAttributesRegExp,
                        Type = "All"
                    });

                    checkList.AddRange(_sForm.AttributeDetails);

                    foreach (var cd in checkList)
                    {
                        cd.CheckSchemaName = _settings.NameToCompare == NameToCompare.Schema;
                        cd.Analyse(emds, _settings);
                    }

                    e.Result = checkList;
                },
                PostWorkCallBack = e =>
                {
                    var checkList = (List<CheckData>)e.Result;

                    _summaryForm.Settings = _settings;
                    _summaryForm.DisplayResults(checkList);
                    _summaryForm.Show(dpMain, DockState.Document);

                    tsbRunAnalysisAgain.Visible = true;
                }
            });
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out _settings, $"{ConnectionDetail?.ConnectionId}{ConnectionDetail?.ConnectionName}"))
            {
                _settings = new Settings();
            }

            _sForm.Settings = _settings;
        }

        private void SetTheme()
        {
            if (XrmToolBox.Options.Instance.Theme != null)
            {
                switch (XrmToolBox.Options.Instance.Theme)
                {
                    case "Blue theme":
                        {
                            var theme = new VS2015BlueTheme();
                            dpMain.Theme = theme;
                        }
                        break;

                    case "Light theme":
                        {
                            var theme = new VS2015LightTheme();
                            dpMain.Theme = theme;
                        }
                        break;

                    case "Dark theme":
                        {
                            var theme = new VS2015DarkTheme();
                            dpMain.Theme = theme;
                        }
                        break;
                }
            }
        }

        private void tsbCheckSolution_Click(object sender, EventArgs e)
        {
            ExecuteMethod(LoadEntities, true);
        }

        private void tsbRunAnalysisAgain_Click(object sender, EventArgs e)
        {
            LoadEntities();
        }
    }
}