namespace CardManager.UI.Customers
{
    partial class CustomerForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule7 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule8 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule9 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.validatorCustomer = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.cbCity = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgAddress = new System.Windows.Forms.BindingSource(this.components);
            this.bdgCity = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_ibge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstate_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpopulation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldemographic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgentilic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colzip_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbStateAddress = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgStates = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsymbol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tfCep = new DevExpress.XtraEditors.TextEdit();
            this.tfDistrict = new DevExpress.XtraEditors.TextEdit();
            this.tfNumber = new DevExpress.XtraEditors.TextEdit();
            this.tfAddress = new DevExpress.XtraEditors.TextEdit();
            this.tfBirthday = new DevExpress.XtraEditors.DateEdit();
            this.bdgCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.tfName = new DevExpress.XtraEditors.TextEdit();
            this.tfCPF = new DevExpress.XtraEditors.TextEdit();
            this.cbStateRG = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tfRg = new DevExpress.XtraEditors.TextEdit();
            this.pnData = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbOrganEmitter = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgOrganEmitter = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCard = new DevExpress.XtraEditors.GroupControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.pePicture = new System.Windows.Forms.PictureBox();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.tfEmitterAt = new DevExpress.XtraEditors.TextEdit();
            this.tfLastUsing = new DevExpress.XtraEditors.TextEdit();
            this.tfValidateAt = new DevExpress.XtraEditors.TextEdit();
            this.gcObservations = new DevExpress.XtraEditors.GroupControl();
            this.tfObservations = new DevExpress.XtraEditors.MemoEdit();
            this.gcContact = new DevExpress.XtraEditors.GroupControl();
            this.btnRemovePhone = new WCButtons.Black.ButtonMinusBlack();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tfEmailPrincipal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.tfEmailOther = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.listPhones = new DevExpress.XtraEditors.ListBoxControl();
            this.btnAddPhone = new WCButtons.Black.ButtonAddBlack();
            this.tfPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.pnAddress = new DevExpress.XtraEditors.GroupControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.tfComplement = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.tfId = new DevExpress.XtraEditors.TextEdit();
            this.tfInactiveAt = new DevExpress.XtraEditors.TextEdit();
            this.tfRegistredAt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lbBirthday = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pnButtons = new DevExpress.XtraEditors.PanelControl();
            this.btnInactive = new WCButtons.Black.ButtonMinusBlack();
            this.btnSave = new WCButtons.Black.ButtonSaveBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            ((System.ComponentModel.ISupportInitialize)(this.validatorCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStateAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgStates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDistrict.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCPF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStateRG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfRg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnData)).BeginInit();
            this.pnData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrganEmitter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgOrganEmitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCard)).BeginInit();
            this.gcCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEmitterAt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfLastUsing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValidateAt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcObservations)).BeginInit();
            this.gcObservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfObservations.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcContact)).BeginInit();
            this.gcContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfEmailPrincipal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEmailOther.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPhones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnAddress)).BeginInit();
            this.pnAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfComplement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfInactiveAt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfRegistredAt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnButtons)).BeginInit();
            this.pnButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCity
            // 
            this.cbCity.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgAddress, "city_id", true));
            this.cbCity.Location = new System.Drawing.Point(474, 50);
            this.cbCity.Name = "cbCity";
            this.cbCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCity.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbCity.Properties.DataSource = this.bdgCity;
            this.cbCity.Properties.DisplayMember = "name";
            this.cbCity.Properties.NullText = "";
            this.cbCity.Properties.ValueMember = "id";
            this.cbCity.Properties.View = this.gridView1;
            this.cbCity.Size = new System.Drawing.Size(274, 20);
            this.cbCity.TabIndex = 5;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule1.ErrorText = "Informe a Cidade";
            conditionValidationRule1.Value1 = ((long)(0));
            this.validatorCustomer.SetValidationRule(this.cbCity, conditionValidationRule1);
            this.cbCity.EditValueChanged += new System.EventHandler(this.cbCity_EditValueChanged);
            // 
            // bdgAddress
            // 
            this.bdgAddress.DataSource = typeof(CardManagerRepo.address);
            // 
            // bdgCity
            // 
            this.bdgCity.DataSource = typeof(CardManagerRepo.city);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.colcod_ibge,
            this.colstate_id,
            this.colpopulation,
            this.coldemographic,
            this.colgentilic,
            this.colarea,
            this.colzip_code});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cod.";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 176;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Name";
            this.gridColumn2.FieldName = "name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 476;
            // 
            // colcod_ibge
            // 
            this.colcod_ibge.FieldName = "cod_ibge";
            this.colcod_ibge.Name = "colcod_ibge";
            this.colcod_ibge.OptionsColumn.AllowEdit = false;
            // 
            // colstate_id
            // 
            this.colstate_id.FieldName = "state_id";
            this.colstate_id.Name = "colstate_id";
            this.colstate_id.OptionsColumn.AllowEdit = false;
            // 
            // colpopulation
            // 
            this.colpopulation.FieldName = "population";
            this.colpopulation.Name = "colpopulation";
            this.colpopulation.OptionsColumn.AllowEdit = false;
            // 
            // coldemographic
            // 
            this.coldemographic.FieldName = "demographic";
            this.coldemographic.Name = "coldemographic";
            this.coldemographic.OptionsColumn.AllowEdit = false;
            // 
            // colgentilic
            // 
            this.colgentilic.FieldName = "gentilic";
            this.colgentilic.Name = "colgentilic";
            this.colgentilic.OptionsColumn.AllowEdit = false;
            // 
            // colarea
            // 
            this.colarea.FieldName = "area";
            this.colarea.Name = "colarea";
            this.colarea.OptionsColumn.AllowEdit = false;
            // 
            // colzip_code
            // 
            this.colzip_code.Caption = "CEP";
            this.colzip_code.FieldName = "zip_code";
            this.colzip_code.Name = "colzip_code";
            this.colzip_code.OptionsColumn.AllowEdit = false;
            this.colzip_code.Visible = true;
            this.colzip_code.VisibleIndex = 2;
            this.colzip_code.Width = 426;
            // 
            // cbStateAddress
            // 
            this.cbStateAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgAddress, "state_id", true));
            this.cbStateAddress.Location = new System.Drawing.Point(331, 50);
            this.cbStateAddress.Name = "cbStateAddress";
            this.cbStateAddress.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStateAddress.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cbStateAddress.Properties.DataSource = this.bdgStates;
            this.cbStateAddress.Properties.DisplayMember = "symbol";
            this.cbStateAddress.Properties.NullText = "";
            this.cbStateAddress.Properties.ValueMember = "id";
            this.cbStateAddress.Properties.View = this.searchLookUpEdit1View;
            this.cbStateAddress.Size = new System.Drawing.Size(94, 20);
            this.cbStateAddress.TabIndex = 4;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule2.ErrorText = "Informe o Estado";
            this.validatorCustomer.SetValidationRule(this.cbStateAddress, conditionValidationRule2);
            this.cbStateAddress.EditValueChanged += new System.EventHandler(this.cbStateAddress_EditValueChanged);
            // 
            // bdgStates
            // 
            this.bdgStates.DataSource = typeof(CardManagerRepo.state);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colsymbol});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "Cod.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 115;
            // 
            // colname
            // 
            this.colname.Caption = "Nome";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 480;
            // 
            // colsymbol
            // 
            this.colsymbol.Caption = "Sigla";
            this.colsymbol.FieldName = "symbol";
            this.colsymbol.Name = "colsymbol";
            this.colsymbol.OptionsColumn.AllowEdit = false;
            this.colsymbol.Visible = true;
            this.colsymbol.VisibleIndex = 2;
            this.colsymbol.Width = 483;
            // 
            // tfCep
            // 
            this.tfCep.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgAddress, "cep", true));
            this.tfCep.Location = new System.Drawing.Point(783, 50);
            this.tfCep.Name = "tfCep";
            this.tfCep.Properties.Mask.EditMask = "00000-000";
            this.tfCep.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tfCep.Size = new System.Drawing.Size(114, 20);
            this.tfCep.TabIndex = 6;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Informe o CEP";
            this.validatorCustomer.SetValidationRule(this.tfCep, conditionValidationRule3);
            // 
            // tfDistrict
            // 
            this.tfDistrict.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgAddress, "district", true));
            this.tfDistrict.Location = new System.Drawing.Point(60, 50);
            this.tfDistrict.Name = "tfDistrict";
            this.tfDistrict.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfDistrict.Size = new System.Drawing.Size(242, 20);
            this.tfDistrict.TabIndex = 3;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Informe o Bairro";
            this.validatorCustomer.SetValidationRule(this.tfDistrict, conditionValidationRule4);
            // 
            // tfNumber
            // 
            this.tfNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgAddress, "number", true));
            this.tfNumber.Location = new System.Drawing.Point(416, 24);
            this.tfNumber.Name = "tfNumber";
            this.tfNumber.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfNumber.Size = new System.Drawing.Size(94, 20);
            this.tfNumber.TabIndex = 1;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Informe o Numero";
            this.validatorCustomer.SetValidationRule(this.tfNumber, conditionValidationRule5);
            // 
            // tfAddress
            // 
            this.tfAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgAddress, "name", true));
            this.tfAddress.Location = new System.Drawing.Point(60, 24);
            this.tfAddress.Name = "tfAddress";
            this.tfAddress.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfAddress.Size = new System.Drawing.Size(296, 20);
            this.tfAddress.TabIndex = 0;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "Informe o Endereço";
            this.validatorCustomer.SetValidationRule(this.tfAddress, conditionValidationRule6);
            // 
            // tfBirthday
            // 
            this.tfBirthday.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "birthday", true));
            this.tfBirthday.EditValue = null;
            this.tfBirthday.Location = new System.Drawing.Point(591, 10);
            this.tfBirthday.Name = "tfBirthday";
            this.tfBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfBirthday.Size = new System.Drawing.Size(80, 20);
            this.tfBirthday.TabIndex = 1;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule7.ErrorText = "Informe a Data de Nascimento";
            this.validatorCustomer.SetValidationRule(this.tfBirthday, conditionValidationRule7);
            this.tfBirthday.TextChanged += new System.EventHandler(this.tfBirthday_EditValueChanged);
            // 
            // bdgCustomer
            // 
            this.bdgCustomer.DataSource = typeof(CardManagerRepo.customer);
            // 
            // tfName
            // 
            this.tfName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "name", true));
            this.tfName.Location = new System.Drawing.Point(90, 10);
            this.tfName.Name = "tfName";
            this.tfName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfName.Size = new System.Drawing.Size(418, 20);
            this.tfName.TabIndex = 0;
            conditionValidationRule8.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule8.ErrorText = "Informe o Nome do Cliente";
            this.validatorCustomer.SetValidationRule(this.tfName, conditionValidationRule8);
            // 
            // tfCPF
            // 
            this.tfCPF.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "cpf", true));
            this.tfCPF.Location = new System.Drawing.Point(90, 36);
            this.tfCPF.Name = "tfCPF";
            this.tfCPF.Properties.Mask.EditMask = "000.000.000-00";
            this.tfCPF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tfCPF.Size = new System.Drawing.Size(149, 20);
            this.tfCPF.TabIndex = 2;
            conditionValidationRule9.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule9.ErrorText = "Informe o CPF";
            this.validatorCustomer.SetValidationRule(this.tfCPF, conditionValidationRule9);
            this.tfCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tfCPF_KeyDown);
            // 
            // cbStateRG
            // 
            this.cbStateRG.Location = new System.Drawing.Point(543, 36);
            this.cbStateRG.Name = "cbStateRG";
            this.cbStateRG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStateRG.Properties.DropDownRows = 10;
            this.cbStateRG.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbStateRG.Size = new System.Drawing.Size(57, 20);
            this.cbStateRG.TabIndex = 5;
            // 
            // tfRg
            // 
            this.tfRg.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "rg", true));
            this.tfRg.Location = new System.Drawing.Point(271, 36);
            this.tfRg.Name = "tfRg";
            this.tfRg.Properties.Mask.EditMask = "d";
            this.tfRg.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfRg.Size = new System.Drawing.Size(77, 20);
            this.tfRg.TabIndex = 3;
            // 
            // pnData
            // 
            this.pnData.Controls.Add(this.tfCPF);
            this.pnData.Controls.Add(this.labelControl1);
            this.pnData.Controls.Add(this.cbOrganEmitter);
            this.pnData.Controls.Add(this.gcCard);
            this.pnData.Controls.Add(this.gcObservations);
            this.pnData.Controls.Add(this.gcContact);
            this.pnData.Controls.Add(this.pnAddress);
            this.pnData.Controls.Add(this.cbStateRG);
            this.pnData.Controls.Add(this.tfBirthday);
            this.pnData.Controls.Add(this.tfId);
            this.pnData.Controls.Add(this.tfRg);
            this.pnData.Controls.Add(this.tfInactiveAt);
            this.pnData.Controls.Add(this.tfRegistredAt);
            this.pnData.Controls.Add(this.tfName);
            this.pnData.Controls.Add(this.labelControl7);
            this.pnData.Controls.Add(this.labelControl6);
            this.pnData.Controls.Add(this.labelControl4);
            this.pnData.Controls.Add(this.labelControl5);
            this.pnData.Controls.Add(this.lbBirthday);
            this.pnData.Controls.Add(this.labelControl20);
            this.pnData.Controls.Add(this.labelControl19);
            this.pnData.Controls.Add(this.labelControl3);
            this.pnData.Controls.Add(this.labelControl2);
            this.pnData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnData.Location = new System.Drawing.Point(0, 0);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(906, 437);
            this.pnData.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "CPF:";
            // 
            // cbOrganEmitter
            // 
            this.cbOrganEmitter.Location = new System.Drawing.Point(439, 36);
            this.cbOrganEmitter.Name = "cbOrganEmitter";
            this.cbOrganEmitter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOrganEmitter.Properties.DataSource = this.bdgOrganEmitter;
            this.cbOrganEmitter.Properties.DisplayMember = "symbol";
            this.cbOrganEmitter.Properties.NullText = "";
            this.cbOrganEmitter.Properties.ValueMember = "symbol";
            this.cbOrganEmitter.Properties.View = this.gridView2;
            this.cbOrganEmitter.Size = new System.Drawing.Size(69, 20);
            this.cbOrganEmitter.TabIndex = 4;
            // 
            // bdgOrganEmitter
            // 
            this.bdgOrganEmitter.DataSource = typeof(CardManagerRepo.organ_emitter);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cod.";
            this.gridColumn3.FieldName = "id";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 95;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Orgão";
            this.gridColumn4.FieldName = "name";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 776;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Simbolo";
            this.gridColumn5.FieldName = "symbol";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 207;
            // 
            // gcCard
            // 
            this.gcCard.Controls.Add(this.labelControl22);
            this.gcCard.Controls.Add(this.labelControl23);
            this.gcCard.Controls.Add(this.pePicture);
            this.gcCard.Controls.Add(this.labelControl21);
            this.gcCard.Controls.Add(this.labelControl26);
            this.gcCard.Controls.Add(this.tfEmitterAt);
            this.gcCard.Controls.Add(this.tfLastUsing);
            this.gcCard.Controls.Add(this.tfValidateAt);
            this.gcCard.Location = new System.Drawing.Point(521, 260);
            this.gcCard.Name = "gcCard";
            this.gcCard.Size = new System.Drawing.Size(380, 172);
            this.gcCard.TabIndex = 15;
            this.gcCard.Text = "Informações do Cartão";
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(181, 73);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(51, 13);
            this.labelControl22.TabIndex = 15;
            this.labelControl22.Text = "Válido até:";
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(181, 99);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(53, 13);
            this.labelControl23.TabIndex = 15;
            this.labelControl23.Text = "Ultimo uso:";
            // 
            // pePicture
            // 
            this.pePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pePicture.InitialImage = global::CardManager.Properties.Resources.loading;
            this.pePicture.Location = new System.Drawing.Point(6, 47);
            this.pePicture.Name = "pePicture";
            this.pePicture.Size = new System.Drawing.Size(92, 114);
            this.pePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pePicture.TabIndex = 14;
            this.pePicture.TabStop = false;
            this.pePicture.DoubleClick += new System.EventHandler(this.OpenImage_DoubleClick);
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(181, 47);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(55, 13);
            this.labelControl21.TabIndex = 16;
            this.labelControl21.Text = "Emitido em:";
            // 
            // labelControl26
            // 
            this.labelControl26.Location = new System.Drawing.Point(7, 28);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(26, 13);
            this.labelControl26.TabIndex = 0;
            this.labelControl26.Text = "Foto:";
            // 
            // tfEmitterAt
            // 
            this.tfEmitterAt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "emission_card_at", true));
            this.tfEmitterAt.EditValue = "";
            this.tfEmitterAt.Location = new System.Drawing.Point(273, 44);
            this.tfEmitterAt.Name = "tfEmitterAt";
            this.tfEmitterAt.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm";
            this.tfEmitterAt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.tfEmitterAt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfEmitterAt.Properties.ReadOnly = true;
            this.tfEmitterAt.Size = new System.Drawing.Size(99, 20);
            this.tfEmitterAt.TabIndex = 17;
            this.tfEmitterAt.TabStop = false;
            // 
            // tfLastUsing
            // 
            this.tfLastUsing.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "last_using", true));
            this.tfLastUsing.EditValue = "";
            this.tfLastUsing.Location = new System.Drawing.Point(273, 96);
            this.tfLastUsing.Name = "tfLastUsing";
            this.tfLastUsing.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm";
            this.tfLastUsing.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.tfLastUsing.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfLastUsing.Properties.ReadOnly = true;
            this.tfLastUsing.Size = new System.Drawing.Size(99, 20);
            this.tfLastUsing.TabIndex = 18;
            this.tfLastUsing.TabStop = false;
            // 
            // tfValidateAt
            // 
            this.tfValidateAt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "validate_card", true));
            this.tfValidateAt.EditValue = "";
            this.tfValidateAt.Location = new System.Drawing.Point(273, 70);
            this.tfValidateAt.Name = "tfValidateAt";
            this.tfValidateAt.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm";
            this.tfValidateAt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.tfValidateAt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfValidateAt.Properties.ReadOnly = true;
            this.tfValidateAt.Size = new System.Drawing.Size(99, 20);
            this.tfValidateAt.TabIndex = 19;
            this.tfValidateAt.TabStop = false;
            // 
            // gcObservations
            // 
            this.gcObservations.Controls.Add(this.tfObservations);
            this.gcObservations.Location = new System.Drawing.Point(4, 284);
            this.gcObservations.Name = "gcObservations";
            this.gcObservations.Size = new System.Drawing.Size(508, 148);
            this.gcObservations.TabIndex = 8;
            this.gcObservations.Text = "Observações";
            // 
            // tfObservations
            // 
            this.tfObservations.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "observation", true));
            this.tfObservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tfObservations.Location = new System.Drawing.Point(2, 21);
            this.tfObservations.Name = "tfObservations";
            this.tfObservations.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfObservations.Size = new System.Drawing.Size(504, 125);
            this.tfObservations.TabIndex = 0;
            this.tfObservations.UseOptimizedRendering = true;
            // 
            // gcContact
            // 
            this.gcContact.Controls.Add(this.btnRemovePhone);
            this.gcContact.Controls.Add(this.panelControl1);
            this.gcContact.Controls.Add(this.listPhones);
            this.gcContact.Controls.Add(this.btnAddPhone);
            this.gcContact.Controls.Add(this.tfPhone);
            this.gcContact.Controls.Add(this.labelControl18);
            this.gcContact.Location = new System.Drawing.Point(2, 140);
            this.gcContact.Name = "gcContact";
            this.gcContact.Size = new System.Drawing.Size(901, 112);
            this.gcContact.TabIndex = 7;
            this.gcContact.Text = "Contatos";
            // 
            // btnRemovePhone
            // 
            this.btnRemovePhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnRemovePhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePhone.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnRemovePhone.ForeColor = System.Drawing.Color.White;
            this.btnRemovePhone.Image = ((System.Drawing.Image)(resources.GetObject("btnRemovePhone.Image")));
            this.btnRemovePhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemovePhone.Location = new System.Drawing.Point(399, 74);
            this.btnRemovePhone.Name = "btnRemovePhone";
            this.btnRemovePhone.Size = new System.Drawing.Size(37, 33);
            this.btnRemovePhone.TabIndex = 9;
            this.btnRemovePhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemovePhone.UseVisualStyleBackColor = false;
            this.btnRemovePhone.Click += new System.EventHandler(this.btnRemovePhone_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tfEmailPrincipal);
            this.panelControl1.Controls.Add(this.labelControl16);
            this.panelControl1.Controls.Add(this.tfEmailOther);
            this.panelControl1.Controls.Add(this.labelControl17);
            this.panelControl1.Location = new System.Drawing.Point(453, 26);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(443, 58);
            this.panelControl1.TabIndex = 8;
            // 
            // tfEmailPrincipal
            // 
            this.tfEmailPrincipal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "mail", true));
            this.tfEmailPrincipal.Location = new System.Drawing.Point(103, 5);
            this.tfEmailPrincipal.Name = "tfEmailPrincipal";
            this.tfEmailPrincipal.Properties.Mask.EditMask = "\\w+([\\.-]?\\w+)*@\\w+([\\.-]?\\w+)*(\\.\\w{1,3})+";
            this.tfEmailPrincipal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tfEmailPrincipal.Size = new System.Drawing.Size(334, 20);
            this.tfEmailPrincipal.TabIndex = 0;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(9, 8);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(74, 13);
            this.labelControl16.TabIndex = 0;
            this.labelControl16.Text = "E-mail Principal:";
            // 
            // tfEmailOther
            // 
            this.tfEmailOther.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "mail_other", true));
            this.tfEmailOther.Location = new System.Drawing.Point(103, 31);
            this.tfEmailOther.Name = "tfEmailOther";
            this.tfEmailOther.Properties.Mask.EditMask = "\\w+([\\.-]?\\w+)*@\\w+([\\.-]?\\w+)*(\\.\\w{1,3})+";
            this.tfEmailOther.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tfEmailOther.Size = new System.Drawing.Size(334, 20);
            this.tfEmailOther.TabIndex = 1;
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(9, 34);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(88, 13);
            this.labelControl17.TabIndex = 0;
            this.labelControl17.Text = "E-mail Secundário:";
            // 
            // listPhones
            // 
            this.listPhones.Location = new System.Drawing.Point(8, 56);
            this.listPhones.MultiColumn = true;
            this.listPhones.Name = "listPhones";
            this.listPhones.Size = new System.Drawing.Size(385, 51);
            this.listPhones.TabIndex = 3;
            this.listPhones.TabStop = false;
            this.listPhones.SelectedIndexChanged += new System.EventHandler(this.listPhones_SelectedIndexChanged);
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnAddPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPhone.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnAddPhone.ForeColor = System.Drawing.Color.White;
            this.btnAddPhone.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPhone.Image")));
            this.btnAddPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPhone.Location = new System.Drawing.Point(399, 29);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(37, 33);
            this.btnAddPhone.TabIndex = 1;
            this.btnAddPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPhone.UseVisualStyleBackColor = false;
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // tfPhone
            // 
            this.tfPhone.Location = new System.Drawing.Point(102, 30);
            this.tfPhone.Name = "tfPhone";
            this.tfPhone.Properties.Mask.EditMask = "(00)0000-0000";
            this.tfPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tfPhone.Size = new System.Drawing.Size(291, 20);
            this.tfPhone.TabIndex = 0;
            this.tfPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tfPhone_KeyDown);
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(8, 33);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(83, 13);
            this.labelControl18.TabIndex = 0;
            this.labelControl18.Text = "Telefone/Celular:";
            // 
            // pnAddress
            // 
            this.pnAddress.Controls.Add(this.cbCity);
            this.pnAddress.Controls.Add(this.cbStateAddress);
            this.pnAddress.Controls.Add(this.labelControl13);
            this.pnAddress.Controls.Add(this.tfCep);
            this.pnAddress.Controls.Add(this.tfDistrict);
            this.pnAddress.Controls.Add(this.labelControl14);
            this.pnAddress.Controls.Add(this.labelControl12);
            this.pnAddress.Controls.Add(this.labelControl11);
            this.pnAddress.Controls.Add(this.tfComplement);
            this.pnAddress.Controls.Add(this.labelControl10);
            this.pnAddress.Controls.Add(this.tfNumber);
            this.pnAddress.Controls.Add(this.labelControl9);
            this.pnAddress.Controls.Add(this.tfAddress);
            this.pnAddress.Controls.Add(this.labelControl15);
            this.pnAddress.Location = new System.Drawing.Point(2, 62);
            this.pnAddress.Name = "pnAddress";
            this.pnAddress.Size = new System.Drawing.Size(901, 77);
            this.pnAddress.TabIndex = 6;
            this.pnAddress.Text = "Endereço";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(431, 53);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(37, 13);
            this.labelControl13.TabIndex = 0;
            this.labelControl13.Text = "Cidade:";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(754, 53);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(23, 13);
            this.labelControl14.TabIndex = 0;
            this.labelControl14.Text = "CEP:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(308, 53);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(17, 13);
            this.labelControl12.TabIndex = 0;
            this.labelControl12.Text = "UF:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(4, 53);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(32, 13);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "Bairro:";
            // 
            // tfComplement
            // 
            this.tfComplement.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgAddress, "complement", true));
            this.tfComplement.Location = new System.Drawing.Point(594, 24);
            this.tfComplement.Name = "tfComplement";
            this.tfComplement.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tfComplement.Size = new System.Drawing.Size(303, 20);
            this.tfComplement.TabIndex = 2;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(519, 27);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(69, 13);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Complemento:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(369, 27);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(41, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Numero:";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(5, 27);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(49, 13);
            this.labelControl15.TabIndex = 0;
            this.labelControl15.Text = "Endereço:";
            // 
            // tfId
            // 
            this.tfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "id", true));
            this.tfId.Location = new System.Drawing.Point(835, 10);
            this.tfId.Name = "tfId";
            this.tfId.Properties.ReadOnly = true;
            this.tfId.Size = new System.Drawing.Size(64, 20);
            this.tfId.TabIndex = 1;
            this.tfId.TabStop = false;
            // 
            // tfInactiveAt
            // 
            this.tfInactiveAt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "inactive_at", true));
            this.tfInactiveAt.EditValue = "";
            this.tfInactiveAt.Location = new System.Drawing.Point(269, 258);
            this.tfInactiveAt.Name = "tfInactiveAt";
            this.tfInactiveAt.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm";
            this.tfInactiveAt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.tfInactiveAt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfInactiveAt.Properties.ReadOnly = true;
            this.tfInactiveAt.Size = new System.Drawing.Size(99, 20);
            this.tfInactiveAt.TabIndex = 1;
            this.tfInactiveAt.TabStop = false;
            // 
            // tfRegistredAt
            // 
            this.tfRegistredAt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCustomer, "registered_at", true));
            this.tfRegistredAt.EditValue = "";
            this.tfRegistredAt.Location = new System.Drawing.Point(83, 258);
            this.tfRegistredAt.Name = "tfRegistredAt";
            this.tfRegistredAt.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm";
            this.tfRegistredAt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.tfRegistredAt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfRegistredAt.Properties.ReadOnly = true;
            this.tfRegistredAt.Size = new System.Drawing.Size(99, 20);
            this.tfRegistredAt.TabIndex = 1;
            this.tfRegistredAt.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(520, 39);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(17, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "UF:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(360, 39);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Orgão Emissor:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(802, 13);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Cod.:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(247, 39);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(18, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "RG:";
            // 
            // lbBirthday
            // 
            this.lbBirthday.Location = new System.Drawing.Point(677, 13);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(0, 13);
            this.lbBirthday.TabIndex = 0;
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(190, 260);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(67, 13);
            this.labelControl20.TabIndex = 0;
            this.labelControl20.Text = "Inativado em:";
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(4, 261);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(73, 13);
            this.labelControl19.TabIndex = 0;
            this.labelControl19.Text = "Registrado em:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(526, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Nascimento:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Nome Completo:";
            // 
            // pnButtons
            // 
            this.pnButtons.Controls.Add(this.btnInactive);
            this.pnButtons.Controls.Add(this.btnSave);
            this.pnButtons.Controls.Add(this.btnCancel);
            this.pnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnButtons.Location = new System.Drawing.Point(0, 437);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(906, 45);
            this.pnButtons.TabIndex = 0;
            // 
            // btnInactive
            // 
            this.btnInactive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnInactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInactive.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnInactive.ForeColor = System.Drawing.Color.White;
            this.btnInactive.Image = ((System.Drawing.Image)(resources.GetObject("btnInactive.Image")));
            this.btnInactive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInactive.Location = new System.Drawing.Point(5, 6);
            this.btnInactive.Name = "btnInactive";
            this.btnInactive.Size = new System.Drawing.Size(110, 33);
            this.btnInactive.TabIndex = 2;
            this.btnInactive.Text = "Inativar";
            this.btnInactive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInactive.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(673, 6);
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
            this.btnCancel.Location = new System.Drawing.Point(789, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CustomerForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnData);
            this.Controls.Add(this.pnButtons);
            this.Name = "CustomerForm";
            this.Size = new System.Drawing.Size(906, 482);
            ((System.ComponentModel.ISupportInitialize)(this.validatorCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStateAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgStates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDistrict.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCPF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStateRG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfRg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnData)).EndInit();
            this.pnData.ResumeLayout(false);
            this.pnData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrganEmitter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgOrganEmitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCard)).EndInit();
            this.gcCard.ResumeLayout(false);
            this.gcCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEmitterAt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfLastUsing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValidateAt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcObservations)).EndInit();
            this.gcObservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tfObservations.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcContact)).EndInit();
            this.gcContact.ResumeLayout(false);
            this.gcContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfEmailPrincipal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEmailOther.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPhones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnAddress)).EndInit();
            this.pnAddress.ResumeLayout(false);
            this.pnAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfComplement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfInactiveAt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfRegistredAt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnButtons)).EndInit();
            this.pnButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tfCPF;
        private DevExpress.XtraEditors.PanelControl pnButtons;
        private DevExpress.XtraEditors.PanelControl pnData;
        private WCButtons.Black.ButtonMinusBlack btnInactive;
        private WCButtons.Black.ButtonSaveBlack btnSave;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private DevExpress.XtraEditors.TextEdit tfName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit tfBirthday;
        private DevExpress.XtraEditors.TextEdit tfId;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tfRg;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lbBirthday;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GroupControl pnAddress;
        private DevExpress.XtraEditors.SearchLookUpEdit cbCity;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_ibge;
        private DevExpress.XtraGrid.Columns.GridColumn colstate_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpopulation;
        private DevExpress.XtraGrid.Columns.GridColumn coldemographic;
        private DevExpress.XtraGrid.Columns.GridColumn colgentilic;
        private DevExpress.XtraGrid.Columns.GridColumn colarea;
        private DevExpress.XtraGrid.Columns.GridColumn colzip_code;
        private DevExpress.XtraEditors.SearchLookUpEdit cbStateAddress;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colsymbol;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit tfCep;
        private DevExpress.XtraEditors.TextEdit tfDistrict;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit tfComplement;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit tfNumber;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit tfAddress;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.GroupControl gcContact;
        private DevExpress.XtraEditors.ComboBoxEdit cbStateRG;
        private DevExpress.XtraEditors.TextEdit tfEmailOther;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.TextEdit tfEmailPrincipal;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ListBoxControl listPhones;
        private WCButtons.Black.ButtonAddBlack btnAddPhone;
        private DevExpress.XtraEditors.TextEdit tfPhone;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private WCButtons.Black.ButtonMinusBlack btnRemovePhone;
        private DevExpress.XtraEditors.TextEdit tfInactiveAt;
        private DevExpress.XtraEditors.TextEdit tfRegistredAt;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.GroupControl gcObservations;
        private DevExpress.XtraEditors.MemoEdit tfObservations;
        private System.Windows.Forms.PictureBox pePicture;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validatorCustomer;
        private System.Windows.Forms.BindingSource bdgCustomer;
        private System.Windows.Forms.BindingSource bdgAddress;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.TextEdit tfEmitterAt;
        private DevExpress.XtraEditors.TextEdit tfLastUsing;
        private DevExpress.XtraEditors.TextEdit tfValidateAt;
        private DevExpress.XtraEditors.GroupControl gcCard;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private System.Windows.Forms.BindingSource bdgStates;
        private System.Windows.Forms.BindingSource bdgCity;
        private DevExpress.XtraEditors.SearchLookUpEdit cbOrganEmitter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource bdgOrganEmitter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}
