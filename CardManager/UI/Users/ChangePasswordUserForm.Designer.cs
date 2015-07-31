namespace CardManager.UI.Users
{
    partial class ChangePasswordUserForm
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
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordUserForm));
            this.tfCpNV = new DevExpress.XtraEditors.TextEdit();
            this.tfNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tfCurrentPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tfConfirPassword = new DevExpress.XtraEditors.TextEdit();
            this.validatorCurrentPwd = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.validatorNewPwd = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.btnSave = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tfCpNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCurrentPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfConfirPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorCurrentPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorNewPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tfCpNV
            // 
            this.tfCpNV.Location = new System.Drawing.Point(99, 27);
            this.tfCpNV.Name = "tfCpNV";
            this.tfCpNV.Size = new System.Drawing.Size(100, 20);
            this.tfCpNV.TabIndex = 5;
            // 
            // tfNewPassword
            // 
            this.tfNewPassword.Location = new System.Drawing.Point(99, 53);
            this.tfNewPassword.Name = "tfNewPassword";
            this.tfNewPassword.Properties.UseSystemPasswordChar = true;
            this.tfNewPassword.Size = new System.Drawing.Size(361, 20);
            this.tfNewPassword.TabIndex = 1;
            this.tfNewPassword.EditValueChanged += new System.EventHandler(this.tfNewPassword_EditValueChanged);
            this.tfNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwd_KeyDown);
            this.tfNewPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passwd_KeyUp);
            this.tfNewPassword.Leave += new System.EventHandler(this.tfPasswd_FocusLeave);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Senha atual:";
            // 
            // tfCurrentPassword
            // 
            this.tfCurrentPassword.Location = new System.Drawing.Point(99, 5);
            this.tfCurrentPassword.Name = "tfCurrentPassword";
            this.tfCurrentPassword.Properties.UseSystemPasswordChar = true;
            this.tfCurrentPassword.Size = new System.Drawing.Size(361, 20);
            this.tfCurrentPassword.TabIndex = 0;
            compareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Equals;
            compareAgainstControlValidationRule1.Control = this.tfCpNV;
            compareAgainstControlValidationRule1.ErrorText = "Senha atual Incorreta, verifique!";
            this.validatorCurrentPwd.SetValidationRule(this.tfCurrentPassword, compareAgainstControlValidationRule1);
            this.tfCurrentPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwd_KeyDown);
            this.tfCurrentPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passwd_KeyUp);
            this.tfCurrentPassword.Leave += new System.EventHandler(this.tfPasswd_FocusLeave);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Nova senha:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Confirmar senha:";
            // 
            // tfConfirPassword
            // 
            this.tfConfirPassword.Location = new System.Drawing.Point(99, 79);
            this.tfConfirPassword.Name = "tfConfirPassword";
            this.tfConfirPassword.Properties.UseSystemPasswordChar = true;
            this.tfConfirPassword.Size = new System.Drawing.Size(361, 20);
            this.tfConfirPassword.TabIndex = 2;
            compareAgainstControlValidationRule2.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Equals;
            compareAgainstControlValidationRule2.Control = this.tfNewPassword;
            compareAgainstControlValidationRule2.ErrorText = "Senha não confere, verifique!";
            this.validatorNewPwd.SetValidationRule(this.tfConfirPassword, compareAgainstControlValidationRule2);
            this.tfConfirPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwd_KeyDown);
            this.tfConfirPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passwd_KeyUp);
            this.tfConfirPassword.Leave += new System.EventHandler(this.tfPasswd_FocusLeave);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(234, 105);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(350, 105);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.tfCurrentPassword);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.tfCpNV);
            this.panelControl1.Controls.Add(this.tfNewPassword);
            this.panelControl1.Controls.Add(this.tfConfirPassword);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(467, 146);
            this.panelControl1.TabIndex = 8;
            // 
            // ChangePasswordUserForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 146);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordUserForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.tfCpNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCurrentPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfConfirPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorCurrentPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorNewPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tfCurrentPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tfNewPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tfConfirPassword;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validatorCurrentPwd;
        private DevExpress.XtraEditors.TextEdit tfCpNV;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validatorNewPwd;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private WCButtons.Black.ButtonSaveBlack btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}