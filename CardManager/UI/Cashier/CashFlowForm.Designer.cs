namespace CardManager.UI.Cashier
{
    partial class CashFlowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashFlowForm));
            this.bdgCashFlow = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.ckAll = new DevExpress.XtraEditors.CheckEdit();
            this.tfEnd = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tfStart = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new WCButtons.Black.ButtonSearchBlack();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnExit = new WCButtons.Black.ButtonCancelBlack();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdgCashFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // bdgCashFlow
            // 
            this.bdgCashFlow.DataSource = typeof(CardManagerRepo.cash_flow);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 45);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(860, 346);
            this.panelControl2.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdgCashFlow;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(856, 272);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltype,
            this.coldescription,
            this.coldate,
            this.colvalue,
            this.colbalance});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // coltype
            // 
            this.coltype.Caption = "Tipo";
            this.coltype.FieldName = "type";
            this.coltype.Name = "coltype";
            this.coltype.OptionsColumn.AllowEdit = false;
            this.coltype.Visible = true;
            this.coltype.VisibleIndex = 0;
            this.coltype.Width = 107;
            // 
            // coldescription
            // 
            this.coldescription.Caption = "Descrição";
            this.coldescription.FieldName = "description";
            this.coldescription.Name = "coldescription";
            this.coldescription.OptionsColumn.AllowEdit = false;
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 1;
            this.coldescription.Width = 336;
            // 
            // coldate
            // 
            this.coldate.Caption = "Data";
            this.coldate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.coldate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldate.FieldName = "date";
            this.coldate.Name = "coldate";
            this.coldate.OptionsColumn.AllowEdit = false;
            this.coldate.Visible = true;
            this.coldate.VisibleIndex = 2;
            this.coldate.Width = 128;
            // 
            // colvalue
            // 
            this.colvalue.Caption = "R$ Valor";
            this.colvalue.DisplayFormat.FormatString = "c2";
            this.colvalue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalue.FieldName = "value";
            this.colvalue.Name = "colvalue";
            this.colvalue.OptionsColumn.AllowEdit = false;
            this.colvalue.Visible = true;
            this.colvalue.VisibleIndex = 3;
            this.colvalue.Width = 128;
            // 
            // colbalance
            // 
            this.colbalance.Caption = "R$ Saldo";
            this.colbalance.DisplayFormat.FormatString = "c2";
            this.colbalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colbalance.FieldName = "balance";
            this.colbalance.Name = "colbalance";
            this.colbalance.OptionsColumn.AllowEdit = false;
            this.colbalance.Visible = true;
            this.colbalance.VisibleIndex = 4;
            this.colbalance.Width = 139;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.ckAll);
            this.panelControl3.Controls.Add(this.tfEnd);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.tfStart);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.btnSearch);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(860, 45);
            this.panelControl3.TabIndex = 2;
            // 
            // ckAll
            // 
            this.ckAll.Location = new System.Drawing.Point(316, 16);
            this.ckAll.Name = "ckAll";
            this.ckAll.Properties.Caption = "Todo Caixa";
            this.ckAll.Size = new System.Drawing.Size(75, 15);
            this.ckAll.TabIndex = 3;
            // 
            // tfEnd
            // 
            this.tfEnd.EditValue = null;
            this.tfEnd.Location = new System.Drawing.Point(190, 14);
            this.tfEnd.Name = "tfEnd";
            this.tfEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfEnd.Size = new System.Drawing.Size(100, 20);
            this.tfEnd.TabIndex = 2;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe a Data final";
            this.validator.SetValidationRule(this.tfEnd, conditionValidationRule1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(172, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(12, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = " à ";
            // 
            // tfStart
            // 
            this.tfStart.EditValue = null;
            this.tfStart.Location = new System.Drawing.Point(66, 14);
            this.tfStart.Name = "tfStart";
            this.tfStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfStart.Size = new System.Drawing.Size(100, 20);
            this.tfStart.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Informe a Data inicial";
            this.validator.SetValidationRule(this.tfStart, conditionValidationRule2);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Período de:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(745, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 33);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnExit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 391);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(860, 45);
            this.panelControl1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(745, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // CashFlowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "CashFlowForm";
            this.Size = new System.Drawing.Size(860, 436);
            ((System.ComponentModel.ISupportInitialize)(this.bdgCashFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private WCButtons.Black.ButtonCancelBlack btnExit;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private WCButtons.Black.ButtonSearchBlack btnSearch;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DateEdit tfEnd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit tfStart;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit ckAll;
        private System.Windows.Forms.BindingSource bdgCashFlow;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coltype;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraGrid.Columns.GridColumn coldate;
        private DevExpress.XtraGrid.Columns.GridColumn colvalue;
        private DevExpress.XtraGrid.Columns.GridColumn colbalance;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
    }
}
