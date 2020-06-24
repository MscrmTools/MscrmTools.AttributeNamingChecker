using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk.Metadata;
using MscrmTools.AttributeNamingChecker.AppCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using XrmToolBox.Extensibility;

namespace MscrmTools.AttributeNamingChecker.Forms
{
    public partial class SettingsForm : DockContent
    {
        private List<StringClass> _list = new List<StringClass>();
        private Settings _settings;

        public SettingsForm()
        {
            InitializeComponent();

            var values = Enum.GetValues(typeof(AttributeTypeCode));
            foreach (var value in values)
            {
                _list.Add(new StringClass(value.ToString()));
            }

            AttributeTypeDgvColumn.DataSource = _list;
            AttributeTypeDgvColumn.ValueMember = "Self";
            AttributeTypeDgvColumn.DisplayMember = "TheString";

            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;

            settingsPropertyGrid.PropertyValueChanged += SettingsPropertyGrid_PropertyValueChanged;
        }

        public List<CheckData> AttributeDetails
        {
            get
            {
                var list = new List<CheckData>();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var type = row.Cells.OfType<DataGridViewComboBoxCell>().First();
                    var regexp = row.Cells.OfType<DataGridViewTextBoxCell>().First();

                    if (type.Value == null || regexp.Value == null) continue;

                    list.Add(new CheckData
                    {
                        Type = type.Value.ToString(),
                        RegExp = regexp.Value.ToString()
                    });
                }

                return list;
            }
        }

        public ConnectionDetail ConnectionDetail { get; set; }

        internal Settings Settings
        {
            set
            {
                _settings = value;
                settingsPropertyGrid.SelectedObject = _settings;

                dataGridView1.CellValueChanged -= DataGridView1_CellValueChanged;
                dataGridView1.Rows.Clear();
                dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;

                if (_settings.AttrRegEx != null)
                {
                    foreach (var attrRegExp in _settings.AttrRegEx)
                    {
                        if (attrRegExp == null) continue;

                        var row = dataGridView1.Rows.Add(new DataGridViewRow());

                        dataGridView1.Rows[row].Cells[0].Value =
                            _list.First(a => a.TheString == attrRegExp.AttributeType);
                        dataGridView1.Rows[row].Cells[1].Value = attrRegExp.Regex;
                    }
                }
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            StoreAttrRegexpInSettings();
        }

        private void SettingsPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            _settings = (Settings)settingsPropertyGrid.SelectedObject;
            SettingsManager.Instance.Save(typeof(MyPluginControl), _settings, $"{ConnectionDetail?.ConnectionId}{ConnectionDetail?.ConnectionName}");
        }

        private void StoreAttrRegexpInSettings()
        {
            _settings.AttrRegEx = new AttributeRegExp[dataGridView1.RowCount - 1];

            var index = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var type = row.Cells.OfType<DataGridViewComboBoxCell>().First();
                var regexp = row.Cells.OfType<DataGridViewTextBoxCell>().First();

                if (type.Value == null || regexp.Value == null) continue;

                _settings.AttrRegEx[index] = new AttributeRegExp
                {
                    AttributeType = type.Value.ToString(),
                    Regex = regexp.Value.ToString()
                };
                index++;
            }

            SettingsManager.Instance.Save(typeof(MyPluginControl), _settings, $"{ConnectionDetail?.ConnectionId}{ConnectionDetail?.ConnectionName}");
        }
    }

    internal class StringClass
    {
        public StringClass(string s)
        {
            TheString = s;
        }

        public StringClass Self => this;
        public string TheString { get; set; }

        public override string ToString()
        {
            return TheString;
        }
    }
}