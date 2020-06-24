namespace MscrmTools.AttributeNamingChecker.CustomControls
{
    partial class CheckResultControl
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblValidAttrTitle = new System.Windows.Forms.Label();
            this.lblValidCount = new System.Windows.Forms.Label();
            this.lblInvalidAttrTitle = new System.Windows.Forms.Label();
            this.lblInvalidCount = new System.Windows.Forms.Label();
            this.llDetails = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(10, 10);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(280, 40);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "All attributes";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(10, 50);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(280, 127);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "100%";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValidAttrTitle
            // 
            this.lblValidAttrTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblValidAttrTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidAttrTitle.Location = new System.Drawing.Point(10, 177);
            this.lblValidAttrTitle.Name = "lblValidAttrTitle";
            this.lblValidAttrTitle.Size = new System.Drawing.Size(280, 40);
            this.lblValidAttrTitle.TabIndex = 2;
            this.lblValidAttrTitle.Text = "Number of valid attributes";
            this.lblValidAttrTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValidCount
            // 
            this.lblValidCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblValidCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblValidCount.Location = new System.Drawing.Point(10, 217);
            this.lblValidCount.Name = "lblValidCount";
            this.lblValidCount.Size = new System.Drawing.Size(280, 40);
            this.lblValidCount.TabIndex = 3;
            this.lblValidCount.Text = "10";
            this.lblValidCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInvalidAttrTitle
            // 
            this.lblInvalidAttrTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInvalidAttrTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidAttrTitle.Location = new System.Drawing.Point(10, 257);
            this.lblInvalidAttrTitle.Name = "lblInvalidAttrTitle";
            this.lblInvalidAttrTitle.Size = new System.Drawing.Size(280, 40);
            this.lblInvalidAttrTitle.TabIndex = 4;
            this.lblInvalidAttrTitle.Text = "Number of invalid attributes";
            this.lblInvalidAttrTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInvalidCount
            // 
            this.lblInvalidCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInvalidCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInvalidCount.Location = new System.Drawing.Point(10, 297);
            this.lblInvalidCount.Name = "lblInvalidCount";
            this.lblInvalidCount.Size = new System.Drawing.Size(280, 40);
            this.lblInvalidCount.TabIndex = 5;
            this.lblInvalidCount.Text = "10";
            this.lblInvalidCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // llDetails
            // 
            this.llDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.llDetails.Location = new System.Drawing.Point(10, 337);
            this.llDetails.Name = "llDetails";
            this.llDetails.Size = new System.Drawing.Size(280, 23);
            this.llDetails.TabIndex = 6;
            this.llDetails.TabStop = true;
            this.llDetails.Text = "see details";
            this.llDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDetails_LinkClicked);
            // 
            // CheckResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.llDetails);
            this.Controls.Add(this.lblInvalidCount);
            this.Controls.Add(this.lblInvalidAttrTitle);
            this.Controls.Add(this.lblValidCount);
            this.Controls.Add(this.lblValidAttrTitle);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblCategory);
            this.Name = "CheckResultControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(300, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblValidAttrTitle;
        private System.Windows.Forms.Label lblValidCount;
        private System.Windows.Forms.Label lblInvalidAttrTitle;
        private System.Windows.Forms.Label lblInvalidCount;
        private System.Windows.Forms.LinkLabel llDetails;
    }
}
