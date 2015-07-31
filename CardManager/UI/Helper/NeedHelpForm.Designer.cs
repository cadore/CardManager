namespace CardManager.UI.Helper
{
    partial class NeedHelpForm
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
            this.tfTextHelp = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTextHelp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tfTextHelp
            // 
            this.tfTextHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tfTextHelp.Location = new System.Drawing.Point(0, 0);
            this.tfTextHelp.Name = "tfTextHelp";
            this.tfTextHelp.Size = new System.Drawing.Size(408, 117);
            this.tfTextHelp.TabIndex = 0;
            this.tfTextHelp.UseOptimizedRendering = true;
            // 
            // NeedHelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 117);
            this.Controls.Add(this.tfTextHelp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NeedHelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuda";
            ((System.ComponentModel.ISupportInitialize)(this.tfTextHelp.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit tfTextHelp;
    }
}