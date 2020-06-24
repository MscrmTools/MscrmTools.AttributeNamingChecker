namespace MscrmTools.AttributeNamingChecker.Forms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AttributeTypeDgvColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ValidationRegExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingsPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.pnlTop.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pnlInfo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTop.Size = new System.Drawing.Size(1824, 88);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.Info;
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.lblInfo);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfo.Location = new System.Drawing.Point(10, 10);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Padding = new System.Windows.Forms.Padding(10);
            this.pnlInfo.Size = new System.Drawing.Size(1804, 68);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Location = new System.Drawing.Point(10, 10);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(1782, 46);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Use general settings on the left that applies to all custom attibutes. If you nee" +
    "d to apply check for specific attributes, use the list on the right. Settings ar" +
    "e automatically saved";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dataGridView1);
            this.pnlMain.Controls.Add(this.settingsPropertyGrid);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 88);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1824, 664);
            this.pnlMain.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttributeTypeDgvColumn,
            this.ValidationRegExp});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(488, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1336, 664);
            this.dataGridView1.TabIndex = 2;
            // 
            // AttributeTypeDgvColumn
            // 
            this.AttributeTypeDgvColumn.HeaderText = "Attribute Type";
            this.AttributeTypeDgvColumn.MinimumWidth = 10;
            this.AttributeTypeDgvColumn.Name = "AttributeTypeDgvColumn";
            this.AttributeTypeDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AttributeTypeDgvColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AttributeTypeDgvColumn.ToolTipText = "Choose an attribute type you want to apply a naming validation on";
            this.AttributeTypeDgvColumn.Width = 200;
            // 
            // ValidationRegExp
            // 
            this.ValidationRegExp.HeaderText = "Regular Expression";
            this.ValidationRegExp.MinimumWidth = 10;
            this.ValidationRegExp.Name = "ValidationRegExp";
            this.ValidationRegExp.ToolTipText = "The regular expression to validate the attribute name";
            this.ValidationRegExp.Width = 200;
            // 
            // settingsPropertyGrid
            // 
            this.settingsPropertyGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.settingsPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.settingsPropertyGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.settingsPropertyGrid.Name = "settingsPropertyGrid";
            this.settingsPropertyGrid.Size = new System.Drawing.Size(488, 664);
            this.settingsPropertyGrid.TabIndex = 1;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 752);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.pnlTop.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PropertyGrid settingsPropertyGrid;
        private System.Windows.Forms.DataGridViewComboBoxColumn AttributeTypeDgvColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidationRegExp;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfo;
    }
}