namespace CardManager.UI.Login
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tfPassword = new DevExpress.XtraEditors.TextEdit();
            this.tfCPF = new DevExpress.XtraEditors.TextEdit();
            this.validatorLogin = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lbNeedHelp = new DevExpress.XtraEditors.LabelControl();
            this.btnLogin = new WCButtons.Black.ButtonConfirmBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            ((System.ComponentModel.ISupportInitialize)(this.tfPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCPF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 199);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "CPF:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(251, 199);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Senha:";
            // 
            // tfPassword
            // 
            this.tfPassword.Location = new System.Drawing.Point(291, 196);
            this.tfPassword.Name = "tfPassword";
            this.tfPassword.Properties.UseSystemPasswordChar = true;
            this.tfPassword.Size = new System.Drawing.Size(188, 20);
            this.tfPassword.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe a Senha";
            this.validatorLogin.SetValidationRule(this.tfPassword, conditionValidationRule1);
            // 
            // tfCPF
            // 
            this.tfCPF.Location = new System.Drawing.Point(38, 196);
            this.tfCPF.Name = "tfCPF";
            this.tfCPF.Properties.Mask.BeepOnError = true;
            this.tfCPF.Properties.Mask.EditMask = "000.000.000-00";
            this.tfCPF.Properties.Mask.IgnoreMaskBlank = false;
            this.tfCPF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tfCPF.Size = new System.Drawing.Size(188, 20);
            this.tfCPF.TabIndex = 0;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Informe o CPF";
            this.validatorLogin.SetValidationRule(this.tfCPF, conditionValidationRule2);
            this.tfCPF.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tfCPF_KeyUp);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureEdit1.EditValue = global::CardManager.Properties.Resources.logo_sistema_union;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(490, 174);
            this.pictureEdit1.TabIndex = 4;
            // 
            // lbNeedHelp
            // 
            this.lbNeedHelp.Location = new System.Drawing.Point(200, 251);
            this.lbNeedHelp.Name = "lbNeedHelp";
            this.lbNeedHelp.Size = new System.Drawing.Size(84, 13);
            this.lbNeedHelp.TabIndex = 5;
            this.lbNeedHelp.Text = "Precisa de ajuda?";
            this.lbNeedHelp.Click += new System.EventHandler(this.lbNeedHelp_Click);
            this.lbNeedHelp.MouseEnter += new System.EventHandler(this.lbNeedHelp_MouseEnter);
            this.lbNeedHelp.MouseLeave += new System.EventHandler(this.lbNeedHelp_MouseLeave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(9, 232);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 33);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(369, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Sair";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 273);
            this.Controls.Add(this.lbNeedHelp);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.tfCPF);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tfPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tfPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCPF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tfPassword;
        private DevExpress.XtraEditors.TextEdit tfCPF;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validatorLogin;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private WCButtons.Black.ButtonConfirmBlack btnLogin;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lbNeedHelp;

    }
}