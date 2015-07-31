namespace CardManager.UI.Credentialeds.Payments
{
    partial class NewPaymentForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPaymentForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tfId = new DevExpress.XtraEditors.TextEdit();
            this.bdgReceipts = new System.Windows.Forms.BindingSource(this.components);
            this.tfCorporateName = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tfDate = new DevExpress.XtraEditors.DateEdit();
            this.tfObservations = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tfValue = new DevExpress.XtraEditors.CalcEdit();
            this.cbYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tfMonth = new DevExpress.XtraScheduler.UI.MonthEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCorporateName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfObservations.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Credenciado:";
            // 
            // tfId
            // 
            this.tfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgReceipts, "credentialed_id", true));
            this.tfId.Location = new System.Drawing.Point(77, 7);
            this.tfId.Name = "tfId";
            this.tfId.Properties.ReadOnly = true;
            this.tfId.Size = new System.Drawing.Size(80, 20);
            this.tfId.TabIndex = 1;
            this.tfId.TabStop = false;
            // 
            // bdgReceipts
            // 
            this.bdgReceipts.DataSource = typeof(CardManagerRepo.receipts_credentialeds);
            // 
            // tfCorporateName
            // 
            this.tfCorporateName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgReceipts, "credentialed_name", true));
            this.tfCorporateName.Location = new System.Drawing.Point(163, 7);
            this.tfCorporateName.Name = "tfCorporateName";
            this.tfCorporateName.Properties.ReadOnly = true;
            this.tfCorporateName.Size = new System.Drawing.Size(326, 20);
            this.tfCorporateName.TabIndex = 1;
            this.tfCorporateName.TabStop = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tfDate);
            this.panelControl1.Controls.Add(this.tfObservations);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.tfValue);
            this.panelControl1.Controls.Add(this.cbYear);
            this.panelControl1.Controls.Add(this.tfMonth);
            this.panelControl1.Controls.Add(this.tfCorporateName);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.tfId);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(492, 220);
            this.panelControl1.TabIndex = 0;
            // 
            // tfDate
            // 
            this.tfDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgReceipts, "date", true));
            this.tfDate.EditValue = null;
            this.tfDate.Location = new System.Drawing.Point(77, 85);
            this.tfDate.Name = "tfDate";
            this.tfDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDate.Size = new System.Drawing.Size(144, 20);
            this.tfDate.TabIndex = 3;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe a data de recebimento";
            this.validator.SetValidationRule(this.tfDate, conditionValidationRule1);
            // 
            // tfObservations
            // 
            this.tfObservations.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgReceipts, "observations", true));
            this.tfObservations.Location = new System.Drawing.Point(5, 135);
            this.tfObservations.Name = "tfObservations";
            this.tfObservations.Size = new System.Drawing.Size(484, 78);
            this.tfObservations.TabIndex = 4;
            this.tfObservations.UseOptimizedRendering = true;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(8, 88);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Data:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(8, 116);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Observações:";
            // 
            // tfValue
            // 
            this.tfValue.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgReceipts, "value", true));
            this.tfValue.Location = new System.Drawing.Point(77, 59);
            this.tfValue.Name = "tfValue";
            this.tfValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfValue.Size = new System.Drawing.Size(144, 20);
            this.tfValue.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.GreaterOrEqual;
            conditionValidationRule2.ErrorText = "Informe o valor";
            conditionValidationRule2.Value1 = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.validator.SetValidationRule(this.tfValue, conditionValidationRule2);
            // 
            // cbYear
            // 
            this.cbYear.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgReceipts, "year", true));
            this.cbYear.Location = new System.Drawing.Point(163, 33);
            this.cbYear.Name = "cbYear";
            this.cbYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbYear.Properties.Items.AddRange(new object[] {
            "2015"});
            this.cbYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbYear.Size = new System.Drawing.Size(58, 20);
            this.cbYear.TabIndex = 1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule3.ErrorText = "Informe o ano de referência";
            conditionValidationRule3.Value1 = 2014;
            this.validator.SetValidationRule(this.cbYear, conditionValidationRule3);
            // 
            // tfMonth
            // 
            this.tfMonth.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgReceipts, "month", true));
            this.tfMonth.Location = new System.Drawing.Point(77, 33);
            this.tfMonth.Name = "tfMonth";
            this.tfMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfMonth.Size = new System.Drawing.Size(80, 20);
            this.tfMonth.TabIndex = 0;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule4.ErrorText = "Informe o mes de referência";
            conditionValidationRule4.Value1 = 0;
            this.validator.SetValidationRule(this.tfMonth, conditionValidationRule4);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 62);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Valor:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Referente à:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 220);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(492, 42);
            this.panelControl2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(263, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 33);
            this.btnSave.TabIndex = 0;
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
            this.btnCancel.Location = new System.Drawing.Point(379, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 262);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "NewPaymentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recebimento de mensalidade";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewPaymentForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCorporateName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfObservations.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tfId;
        private DevExpress.XtraEditors.TextEdit tfCorporateName;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraScheduler.UI.MonthEdit tfMonth;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbYear;
        private DevExpress.XtraEditors.CalcEdit tfValue;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit tfObservations;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit tfDate;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private WCButtons.Black.ButtonSaveBlack btnSave;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private System.Windows.Forms.BindingSource bdgReceipts;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
    }
}