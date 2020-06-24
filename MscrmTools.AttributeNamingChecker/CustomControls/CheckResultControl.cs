using MscrmTools.AttributeNamingChecker.AppCode;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MscrmTools.AttributeNamingChecker.CustomControls
{
    public partial class CheckResultControl : UserControl
    {
        public event EventHandler OnDisplayResults;

        public CheckResultControl(CheckData data, Settings settings)
        {
            Data = data;

            InitializeComponent();

            lblCategory.Text = data.Type == "All" ? "All attributes" : data.Type;
            lblScore.Text = $@"{data.Percentage} %";
            lblInvalidCount.Text = data.InvalidAttributes.Count.ToString("D");
            lblValidCount.Text = data.ValidAttributes.Count.ToString("D");

            if (data.Percentage >= settings.ValidLevel) lblScore.ForeColor = Color.Green;
            else if (data.Percentage >= settings.WarningLevel) lblScore.ForeColor = Color.Orange;
            else lblScore.ForeColor = Color.Red;
        }

        public CheckData Data { get; }

        private void llDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnDisplayResults?.Invoke(this, new EventArgs());
        }
    }
}