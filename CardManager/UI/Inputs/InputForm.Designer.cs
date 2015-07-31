namespace CardManager.UI.Inputs
{
    partial class InputForm
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
            DevExpress.XtraEditors.LabelControl dateLabel;
            DevExpress.XtraEditors.LabelControl descriptionLabel;
            DevExpress.XtraEditors.LabelControl idLabel;
            DevExpress.XtraEditors.LabelControl observationLabel;
            DevExpress.XtraEditors.LabelControl valueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.bdgInput = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.observationMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.valueCalcEdit = new DevExpress.XtraEditors.CalcEdit();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            dateLabel = new DevExpress.XtraEditors.LabelControl();
            descriptionLabel = new DevExpress.XtraEditors.LabelControl();
            idLabel = new DevExpress.XtraEditors.LabelControl();
            observationLabel = new DevExpress.XtraEditors.LabelControl();
            valueLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observationMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueCalcEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.Location = new System.Drawing.Point(7, 34);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(27, 13);
            dateLabel.TabIndex = 0;
            dateLabel.Text = "Data:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Location = new System.Drawing.Point(7, 8);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(50, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Descrição:";
            // 
            // idLabel
            // 
            idLabel.Location = new System.Drawing.Point(316, 8);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 13);
            idLabel.TabIndex = 4;
            idLabel.Text = "Cod.:";
            // 
            // observationLabel
            // 
            observationLabel.Location = new System.Drawing.Point(7, 70);
            observationLabel.Name = "observationLabel";
            observationLabel.Size = new System.Drawing.Size(67, 13);
            observationLabel.TabIndex = 6;
            observationLabel.Text = "Observações:";
            // 
            // valueLabel
            // 
            valueLabel.Location = new System.Drawing.Point(169, 34);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(28, 13);
            valueLabel.TabIndex = 8;
            valueLabel.Text = "Valor:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 170);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(431, 44);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(200, 6);
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
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(316, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(dateLabel);
            this.panelControl2.Controls.Add(this.dateDateEdit);
            this.panelControl2.Controls.Add(descriptionLabel);
            this.panelControl2.Controls.Add(this.descriptionTextEdit);
            this.panelControl2.Controls.Add(idLabel);
            this.panelControl2.Controls.Add(this.idTextEdit);
            this.panelControl2.Controls.Add(observationLabel);
            this.panelControl2.Controls.Add(this.observationMemoEdit);
            this.panelControl2.Controls.Add(valueLabel);
            this.panelControl2.Controls.Add(this.valueCalcEdit);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(431, 170);
            this.panelControl2.TabIndex = 1;
            // 
            // dateDateEdit
            // 
            this.dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgInput, "date", true));
            this.dateDateEdit.EditValue = null;
            this.dateDateEdit.Location = new System.Drawing.Point(63, 31);
            this.dateDateEdit.Name = "dateDateEdit";
            this.dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDateEdit.Size = new System.Drawing.Size(100, 20);
            this.dateDateEdit.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe a Data";
            this.validator.SetValidationRule(this.dateDateEdit, conditionValidationRule1);
            // 
            // bdgInput
            // 
            this.bdgInput.DataSource = typeof(CardManagerRepo.input);
            // 
            // descriptionTextEdit
            // 
            this.descriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgInput, "description", true));
            this.descriptionTextEdit.Location = new System.Drawing.Point(63, 5);
            this.descriptionTextEdit.Name = "descriptionTextEdit";
            this.descriptionTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descriptionTextEdit.Size = new System.Drawing.Size(240, 20);
            this.descriptionTextEdit.TabIndex = 3;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Informe a Descrição";
            this.validator.SetValidationRule(this.descriptionTextEdit, conditionValidationRule2);
            // 
            // idTextEdit
            // 
            this.idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgInput, "id", true));
            this.idTextEdit.Location = new System.Drawing.Point(349, 5);
            this.idTextEdit.Name = "idTextEdit";
            this.idTextEdit.Properties.ReadOnly = true;
            this.idTextEdit.Size = new System.Drawing.Size(75, 20);
            this.idTextEdit.TabIndex = 5;
            // 
            // observationMemoEdit
            // 
            this.observationMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgInput, "observations", true));
            this.observationMemoEdit.Location = new System.Drawing.Point(7, 89);
            this.observationMemoEdit.Name = "observationMemoEdit";
            this.observationMemoEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.observationMemoEdit.Size = new System.Drawing.Size(417, 72);
            this.observationMemoEdit.TabIndex = 7;
            this.observationMemoEdit.UseOptimizedRendering = true;
            // 
            // valueCalcEdit
            // 
            this.valueCalcEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgInput, "value", true));
            this.valueCalcEdit.Location = new System.Drawing.Point(203, 31);
            this.valueCalcEdit.Name = "valueCalcEdit";
            this.valueCalcEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.valueCalcEdit.Size = new System.Drawing.Size(100, 20);
            this.valueCalcEdit.TabIndex = 9;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.GreaterOrEqual;
            conditionValidationRule3.ErrorText = "Informe o Valor";
            conditionValidationRule3.Value1 = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.validator.SetValidationRule(this.valueCalcEdit, conditionValidationRule3);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "InputForm";
            this.Size = new System.Drawing.Size(431, 214);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observationMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueCalcEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private WCButtons.Black.ButtonSaveBlack btnSave;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private DevExpress.XtraEditors.DateEdit dateDateEdit;
        private System.Windows.Forms.BindingSource bdgInput;
        private DevExpress.XtraEditors.TextEdit descriptionTextEdit;
        private DevExpress.XtraEditors.TextEdit idTextEdit;
        private DevExpress.XtraEditors.MemoEdit observationMemoEdit;
        private DevExpress.XtraEditors.CalcEdit valueCalcEdit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
    }
}
