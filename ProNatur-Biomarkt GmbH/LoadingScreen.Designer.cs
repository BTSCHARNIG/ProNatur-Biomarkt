namespace ProNatur_Biomarkt_GmbH
{
    partial class LoadingScreen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            this.loadingprogressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoadingValue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadingbarTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingprogressBar
            // 
            this.loadingprogressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingprogressBar.Location = new System.Drawing.Point(12, 326);
            this.loadingprogressBar.Name = "loadingprogressBar";
            this.loadingprogressBar.Size = new System.Drawing.Size(660, 23);
            this.loadingprogressBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loading";
            // 
            // lblLoadingValue
            // 
            this.lblLoadingValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblLoadingValue.AutoSize = true;
            this.lblLoadingValue.Location = new System.Drawing.Point(418, 310);
            this.lblLoadingValue.Name = "lblLoadingValue";
            this.lblLoadingValue.Size = new System.Drawing.Size(33, 13);
            this.lblLoadingValue.TabIndex = 2;
            this.lblLoadingValue.Text = "100%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // loadingbarTimer
            // 
            this.loadingbarTimer.Tick += new System.EventHandler(this.loadingbarTimer_Tick);
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLoadingValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadingprogressBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProNoatur-Biomarkt GmbH";
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar loadingprogressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoadingValue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer loadingbarTimer;
        private System.Windows.Forms.Timer timer1;
    }
}

