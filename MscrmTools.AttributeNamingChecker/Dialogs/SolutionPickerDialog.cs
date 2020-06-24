using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using MscrmTools.AttributeNamingChecker.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;

namespace MscrmTools.AttributeNamingChecker.Dialogs
{
    public partial class SolutionPickerDialog : Form
    {
        private readonly IOrganizationService _innerService;
        private EntityCollection _solutions;

        public SolutionPickerDialog(IOrganizationService service)
        {
            InitializeComponent();

            _innerService = service;
        }

        public List<Entity> SelectedSolutions { get; set; }

        private void btnSolutionPickerCancel_Click(object sender, EventArgs e)
        {
            SelectedSolutions = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSolutionPickerValidate_Click(object sender, EventArgs e)
        {
            if (lstSolutions.SelectedItems.Count > 0)
            {
                SelectedSolutions = lstSolutions.SelectedItems.Cast<ListViewItem>().Select(i => (Entity)i.Tag).ToList();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(this, @"Please select at least one solution!", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkShowManaged_CheckedChanged(object sender, EventArgs e)
        {
            DisplaySolutions();
        }

        private void DisplaySolutions()
        {
            lstSolutions.Items.Clear();

            foreach (Entity solution in _solutions.Entities.Where(s => s.GetAttributeValue<bool>("ismanaged") && chkShowManaged.Checked
                                                                       || s.GetAttributeValue<bool>("ismanaged") == false))
            {
                ListViewItem item = new ListViewItem(solution["friendlyname"].ToString());
                item.SubItems.Add(solution["version"].ToString());
                item.SubItems.Add(((EntityReference)solution["publisherid"]).Name);
                item.Tag = solution;

                lstSolutions.Items.Add(item);
            }

            lstSolutions.Enabled = true;
            btnSolutionPickerValidate.Enabled = true;
        }

        private void lstSolutions_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            var list = (ListView)sender;
            list.Sorting = list.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            list.ListViewItemSorter = new ListViewItemComparer(e.Column, list.Sorting);
        }

        private void lstSolutions_DoubleClick(object sender, EventArgs e)
        {
            btnSolutionPickerValidate_Click(null, null);
        }

        private EntityCollection RetrieveSolutions()
        {
            try
            {
                QueryExpression qe = new QueryExpression("solution");
                qe.Distinct = true;
                qe.ColumnSet = new ColumnSet(true);
                qe.Criteria = new FilterExpression();
                qe.Criteria.AddCondition(new ConditionExpression("isvisible", ConditionOperator.Equal, true));
                qe.Criteria.AddCondition(new ConditionExpression("uniquename", ConditionOperator.NotEqual, "Default"));

                return _innerService.RetrieveMultiple(qe);
            }
            catch (Exception error)
            {
                if (error.InnerException is FaultException)
                {
                    throw new Exception("Error while retrieving solutions: " + (error.InnerException).Message);
                }

                throw new Exception("Error while retrieving solutions: " + error.Message);
            }
        }

        private void SolutionPicker_Load(object sender, EventArgs e)
        {
            lstSolutions.Items.Clear();

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            _solutions = RetrieveSolutions();
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DisplaySolutions();
        }
    }
}