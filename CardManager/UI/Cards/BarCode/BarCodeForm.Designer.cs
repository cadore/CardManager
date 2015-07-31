namespace CardManager.UI.Cards.BarCode
{
    partial class BarCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarCodeForm));
            this.lbCod = new DevExpress.XtraEditors.LabelControl();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.barCode = new DSBarCode.BarCodeCtrl();
            this.SuspendLayout();
            // 
            // lbCod
            // 
            this.lbCod.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCod.Location = new System.Drawing.Point(44, 62);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(73, 26);
            this.lbCod.TabIndex = 1;
            this.lbCod.Text = "lbCode";
            // 
            // btnExport
            // 
            this.btnExport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(12, 110);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 33);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Exportar";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExit
            // 
            this.btnExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(121, 110);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 33);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Fechar";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // barCode
            // 
            this.barCode.BarCode = "NULL";
            this.barCode.BarCodeHeight = 30;
            this.barCode.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.barCode.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.barCode.HeaderText = "BarCode Demo";
            this.barCode.LeftMargin = 10;
            this.barCode.Location = new System.Drawing.Point(12, 12);
            this.barCode.Name = "barCode";
            this.barCode.ShowFooter = false;
            this.barCode.ShowHeader = false;
            this.barCode.Size = new System.Drawing.Size(209, 44);
            this.barCode.TabIndex = 0;
            this.barCode.TabStop = false;
            this.barCode.TopMargin = 10;
            this.barCode.VertAlign = DSBarCode.BarCodeCtrl.AlignType.Center;
            this.barCode.Weight = DSBarCode.BarCodeCtrl.BarCodeWeight.Small;
            // 
            // BarCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 151);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lbCod);
            this.Controls.Add(this.barCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "BarCodeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BarCodeForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarCodeForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSBarCode.BarCodeCtrl barCode;
        private DevExpress.XtraEditors.LabelControl lbCod;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnExit;
    }
}