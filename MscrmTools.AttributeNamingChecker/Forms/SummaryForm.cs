using MscrmTools.AttributeNamingChecker.AppCode;
using MscrmTools.AttributeNamingChecker.CustomControls;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace MscrmTools.AttributeNamingChecker.Forms
{
    public partial class SummaryForm : DockContent
    {
        private int _lastOrderedColumn = -1;
        private Settings _settings;

        public SummaryForm()
        {
            InitializeComponent();
        }

        public Settings Settings
        {
            set => _settings = value;
        }

        public void DisplayResults(List<CheckData> results)
        {
            splitContainer1.Panel1.Controls.Clear();

            foreach (var result in results)
            {
                var ctrl = new CheckResultControl(result, _settings);
                ctrl.Dock = DockStyle.Left;
                ctrl.OnDisplayResults += Ctrl_OnDisplayResults;
                splitContainer1.Panel1.Controls.Add(ctrl);
                splitContainer1.Panel1.Controls.SetChildIndex(ctrl, 0);
            }

            SummaryForm_Resize(null, null);
        }

        private void Ctrl_OnDisplayResults(object sender, System.EventArgs e)
        {
            var data = ((CheckResultControl)sender).Data;

            lvValidAttributes.Items.Clear();
            lvInvalidAttributes.Items.Clear();

            lvValidAttributes.Items.AddRange(data.ValidAttributes.Select(a => new ListViewItem(a.SchemaName)
            { SubItems = { a.EntityLogicalName } }).ToArray());

            lvInvalidAttributes.Items.AddRange(data.InvalidAttributes.Select(a => new ListViewItem(a.SchemaName)
            { SubItems = { a.EntityLogicalName } }).ToArray());

            splitContainer1.Panel2Collapsed = false;
            SummaryForm_Resize(null, null);

            lblDetailsTitle.Text = $@"Details for {(data.Type == "All" ? "All attributes" : data.Type)}";
        }

        private void ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortOrder order;
            if (e.Column != _lastOrderedColumn)
            {
                order = SortOrder.Ascending;
            }
            else
            {
                order = ((ListView)sender).Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            }

            ((ListView)sender).ListViewItemSorter = new ListViewItemComparer(e.Column, order);
            _lastOrderedColumn = e.Column;
            ((ListView)sender).Sorting = order;
        }

        private void SummaryForm_Resize(object sender, System.EventArgs e)
        {
            splitContainer2.SplitterDistance = Width / 2;
            splitContainer1.SplitterDistance = 250;
        }
    }
}