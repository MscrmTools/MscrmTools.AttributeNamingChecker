namespace MscrmTools.AttributeNamingChecker.Forms
{
    partial class SummaryForm
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbValidAttributes = new System.Windows.Forms.GroupBox();
            this.lvValidAttributes = new System.Windows.Forms.ListView();
            this.chValidAttributeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValidAttributeEntity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbInvalidAttributes = new System.Windows.Forms.GroupBox();
            this.lvInvalidAttributes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDetailsTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbValidAttributes.SuspendLayout();
            this.gbInvalidAttributes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 100);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Visible = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 636);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 80);
            this.pnlBottom.TabIndex = 1;
            this.pnlBottom.Visible = false;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Controls.Add(this.splitContainer1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 100);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 536);
            this.pnlMain.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.lblDetailsTitle);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(800, 536);
            this.splitContainer1.SplitterDistance = 330;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 30);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbValidAttributes);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbInvalidAttributes);
            this.splitContainer2.Size = new System.Drawing.Size(800, 172);
            this.splitContainer2.SplitterDistance = 400;
            this.splitContainer2.TabIndex = 1;
            // 
            // gbValidAttributes
            // 
            this.gbValidAttributes.Controls.Add(this.lvValidAttributes);
            this.gbValidAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbValidAttributes.Location = new System.Drawing.Point(0, 0);
            this.gbValidAttributes.Name = "gbValidAttributes";
            this.gbValidAttributes.Size = new System.Drawing.Size(400, 172);
            this.gbValidAttributes.TabIndex = 0;
            this.gbValidAttributes.TabStop = false;
            this.gbValidAttributes.Text = "Valid attributes";
            // 
            // lvValidAttributes
            // 
            this.lvValidAttributes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chValidAttributeName,
            this.chValidAttributeEntity});
            this.lvValidAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvValidAttributes.HideSelection = false;
            this.lvValidAttributes.Location = new System.Drawing.Point(3, 22);
            this.lvValidAttributes.Name = "lvValidAttributes";
            this.lvValidAttributes.Size = new System.Drawing.Size(394, 147);
            this.lvValidAttributes.TabIndex = 0;
            this.lvValidAttributes.UseCompatibleStateImageBehavior = false;
            this.lvValidAttributes.View = System.Windows.Forms.View.Details;
            this.lvValidAttributes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView_ColumnClick);
            // 
            // chValidAttributeName
            // 
            this.chValidAttributeName.Text = "Attribute name";
            this.chValidAttributeName.Width = 200;
            // 
            // chValidAttributeEntity
            // 
            this.chValidAttributeEntity.Text = "Entity";
            this.chValidAttributeEntity.Width = 150;
            // 
            // gbInvalidAttributes
            // 
            this.gbInvalidAttributes.Controls.Add(this.lvInvalidAttributes);
            this.gbInvalidAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInvalidAttributes.Location = new System.Drawing.Point(0, 0);
            this.gbInvalidAttributes.Name = "gbInvalidAttributes";
            this.gbInvalidAttributes.Size = new System.Drawing.Size(396, 172);
            this.gbInvalidAttributes.TabIndex = 1;
            this.gbInvalidAttributes.TabStop = false;
            this.gbInvalidAttributes.Text = "Invalid attributes";
            // 
            // lvInvalidAttributes
            // 
            this.lvInvalidAttributes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvInvalidAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvInvalidAttributes.HideSelection = false;
            this.lvInvalidAttributes.Location = new System.Drawing.Point(3, 22);
            this.lvInvalidAttributes.Name = "lvInvalidAttributes";
            this.lvInvalidAttributes.Size = new System.Drawing.Size(390, 147);
            this.lvInvalidAttributes.TabIndex = 1;
            this.lvInvalidAttributes.UseCompatibleStateImageBehavior = false;
            this.lvInvalidAttributes.View = System.Windows.Forms.View.Details;
            this.lvInvalidAttributes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Attribute name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Entity";
            this.columnHeader2.Width = 150;
            // 
            // lblDetailsTitle
            // 
            this.lblDetailsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblDetailsTitle.Name = "lblDetailsTitle";
            this.lblDetailsTitle.Size = new System.Drawing.Size(800, 30);
            this.lblDetailsTitle.TabIndex = 2;
            this.lblDetailsTitle.Text = "label1";
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 716);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "SummaryForm";
            this.Text = "Summary";
            this.Resize += new System.EventHandler(this.SummaryForm_Resize);
            this.pnlMain.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbValidAttributes.ResumeLayout(false);
            this.gbInvalidAttributes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gbValidAttributes;
        private System.Windows.Forms.ListView lvValidAttributes;
        private System.Windows.Forms.ColumnHeader chValidAttributeName;
        private System.Windows.Forms.ColumnHeader chValidAttributeEntity;
        private System.Windows.Forms.GroupBox gbInvalidAttributes;
        private System.Windows.Forms.ListView lvInvalidAttributes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblDetailsTitle;
    }
}