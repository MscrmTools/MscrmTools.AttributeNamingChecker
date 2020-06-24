namespace MscrmTools.AttributeNamingChecker
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.dpMain = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.tsbCheckSolution = new System.Windows.Forms.ToolStripButton();
            this.tsbRunAnalysisAgain = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCheckSolution,
            this.tsbRunAnalysisAgain});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(840, 34);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "tsMain";
            // 
            // dpMain
            // 
            this.dpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpMain.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dpMain.Location = new System.Drawing.Point(0, 34);
            this.dpMain.Name = "dpMain";
            this.dpMain.Size = new System.Drawing.Size(840, 418);
            this.dpMain.SupportDeeplyNestedContent = true;
            this.dpMain.TabIndex = 5;
            // 
            // tsbCheckSolution
            // 
            this.tsbCheckSolution.Image = global::MscrmTools.AttributeNamingChecker.Properties.Resources.magnifier;
            this.tsbCheckSolution.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCheckSolution.Name = "tsbCheckSolution";
            this.tsbCheckSolution.Size = new System.Drawing.Size(156, 29);
            this.tsbCheckSolution.Text = "Check solution";
            this.tsbCheckSolution.Click += new System.EventHandler(this.tsbCheckSolution_Click);
            // 
            // tsbRunAnalysisAgain
            // 
            this.tsbRunAnalysisAgain.Image = global::MscrmTools.AttributeNamingChecker.Properties.Resources.arrow_refresh;
            this.tsbRunAnalysisAgain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRunAnalysisAgain.Name = "tsbRunAnalysisAgain";
            this.tsbRunAnalysisAgain.Size = new System.Drawing.Size(119, 29);
            this.tsbRunAnalysisAgain.Text = "Run again";
            this.tsbRunAnalysisAgain.Visible = false;
            this.tsbRunAnalysisAgain.Click += new System.EventHandler(this.tsbRunAnalysisAgain_Click);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.dpMain);
            this.Controls.Add(this.toolStripMenu);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(840, 452);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dpMain;
        private System.Windows.Forms.ToolStripButton tsbCheckSolution;
        private System.Windows.Forms.ToolStripButton tsbRunAnalysisAgain;
    }
}
