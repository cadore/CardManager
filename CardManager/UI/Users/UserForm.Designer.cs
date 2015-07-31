namespace CardManager.UI.Users
{
    partial class UserForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tfName = new DevExpress.XtraEditors.TextEdit();
            this.bdgUser = new System.Windows.Forms.BindingSource(this.components);
            this.tfId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tfCPF = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tfPhone = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnInactive = new DevExpress.XtraEditors.SimpleButton();
            this.btnPassword = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tfName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCPF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nome Completo:";
            // 
            // tfName
            // 
            this.tfName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgUser, "full_name", true));
            this.tfName.Location = new System.Drawing.Point(102, 14);
            this.tfName.Name = "tfName";
            this.tfName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfName.Size = new System.Drawing.Size(321, 20);
            this.tfName.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe o nome completo do usuário";
            this.validator.SetValidationRule(this.tfName, conditionValidationRule1);
            // 
            // bdgUser
            // 
            this.bdgUser.DataSource = typeof(CardManagerRepo.user);
            // 
            // tfId
            // 
            this.tfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgUser, "id", true));
            this.tfId.Location = new System.Drawing.Point(462, 14);
            this.tfId.Name = "tfId";
            this.tfId.Properties.ReadOnly = true;
            this.tfId.Size = new System.Drawing.Size(71, 20);
            this.tfId.TabIndex = 1;
            this.tfId.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(429, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Cod.:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "CPF:";
            // 
            // tfCPF
            // 
            this.tfCPF.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgUser, "cpf", true));
            this.tfCPF.Location = new System.Drawing.Point(102, 40);
            this.tfCPF.Name = "tfCPF";
            this.tfCPF.Properties.Mask.EditMask = "000.000.000-00";
            this.tfCPF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tfCPF.Size = new System.Drawing.Size(190, 20);
            this.tfCPF.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(306, 43);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Contato:";
            // 
            // tfPhone
            // 
            this.tfPhone.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgUser, "phone", true));
            this.tfPhone.Location = new System.Drawing.Point(355, 40);
            this.tfPhone.Name = "tfPhone";
            this.tfPhone.Properties.Mask.EditMask = "(\\(11\\)[9][0-9]{4}-[0-9]{4})|(\\(1[2-9]\\) [5-9][0-9]{3}-[0-9]{4})|(\\([2-9][1-9]\\) " +
    "[5-9][0-9]{3}-[0-9]{4})";
            this.tfPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tfPhone.Properties.Mask.ShowPlaceHolders = false;
            this.tfPhone.Size = new System.Drawing.Size(178, 20);
            this.tfPhone.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Informe o Celular do usuário";
            this.validator.SetValidationRule(this.tfPhone, conditionValidationRule2);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.tfId);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btnInactive);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.btnPassword);
            this.panelControl1.Controls.Add(this.tfName);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.tfPhone);
            this.panelControl1.Controls.Add(this.tfCPF);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(548, 111);
            this.panelControl1.TabIndex = 0;
            // 
            // btnInactive
            // 
            this.btnInactive.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnInactive.Image = ((System.Drawing.Image)(resources.GetObject("btnInactive.Image")));
            this.btnInactive.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnInactive.Location = new System.Drawing.Point(115, 75);
            this.btnInactive.Name = "btnInactive";
            this.btnInactive.Size = new System.Drawing.Size(92, 26);
            this.btnInactive.TabIndex = 4;
            this.btnInactive.Text = "Inativar";
            this.btnInactive.Click += new System.EventHandler(this.btnInactive_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnPassword.Image")));
            this.btnPassword.Location = new System.Drawing.Point(17, 75);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(92, 26);
            this.btnPassword.TabIndex = 3;
            this.btnPassword.Text = "Senha";
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(316, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 33);
            this.btnSave.TabIndex = 1;
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
            this.btnCancel.Location = new System.Drawing.Point(432, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "UserForm";
            this.Size = new System.Drawing.Size(548, 159);
            ((System.ComponentModel.ISupportInitialize)(this.tfName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCPF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tfName;
        private DevExpress.XtraEditors.TextEdit tfId;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tfCPF;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tfPhone;
        private DevExpress.XtraEditors.SimpleButton btnPassword;
        private DevExpress.XtraEditors.SimpleButton btnInactive;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private WCButtons.Black.ButtonSaveBlack btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource bdgUser;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
    }
}
