namespace CardManager.UI.Cards
{
    partial class EmissionCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmissionCardForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.pnCard = new DevExpress.XtraEditors.GroupControl();
            this.btnExit = new WCButtons.Black.ButtonCancelBlack();
            this.pnData = new DevExpress.XtraEditors.PanelControl();
            this.pePicture = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.tfBarCode = new DevExpress.XtraEditors.TextEdit();
            this.bdgInfoCard = new System.Windows.Forms.BindingSource(this.components);
            this.tfValueCard = new DevExpress.XtraEditors.CalcEdit();
            this.btnEmitterCard = new WCButtons.Black.ButtonRefreshBlack();
            this.tfLastUsing = new DevExpress.XtraEditors.TextEdit();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.tfEmitterAt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.btnExportCodeBar = new WCButtons.Black.ButtonSettingsBlack();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.lbStatusCard = new DevExpress.XtraEditors.LabelControl();
            this.tfValidateAt = new DevExpress.XtraEditors.DateEdit();
            this.cbCustomer = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colregistered_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorgan_emitter_rg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcpf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinactive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinactive_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmail_other = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbusiness_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemission_card_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collast_using = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcard_emitted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalue_card = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalidate_card = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldirectory_picture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.validatorCard = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnCard)).BeginInit();
            this.pnCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnData)).BeginInit();
            this.pnData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfBarCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgInfoCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValueCard.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfLastUsing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEmitterAt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValidateAt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValidateAt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCard
            // 
            this.pnCard.Controls.Add(this.btnExit);
            this.pnCard.Controls.Add(this.pnData);
            this.pnCard.Controls.Add(this.cbCustomer);
            this.pnCard.Controls.Add(this.labelControl1);
            this.pnCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCard.Location = new System.Drawing.Point(0, 0);
            this.pnCard.Name = "pnCard";
            this.pnCard.Size = new System.Drawing.Size(530, 285);
            this.pnCard.TabIndex = 10;
            this.pnCard.Text = "Gerenciamento de Cartão";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(415, 247);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 33);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnData
            // 
            this.pnData.Controls.Add(this.pePicture);
            this.pnData.Controls.Add(this.labelControl21);
            this.pnData.Controls.Add(this.tfBarCode);
            this.pnData.Controls.Add(this.tfValueCard);
            this.pnData.Controls.Add(this.btnEmitterCard);
            this.pnData.Controls.Add(this.tfLastUsing);
            this.pnData.Controls.Add(this.labelControl25);
            this.pnData.Controls.Add(this.tfEmitterAt);
            this.pnData.Controls.Add(this.labelControl24);
            this.pnData.Controls.Add(this.btnExportCodeBar);
            this.pnData.Controls.Add(this.labelControl23);
            this.pnData.Controls.Add(this.labelControl22);
            this.pnData.Controls.Add(this.lbStatusCard);
            this.pnData.Controls.Add(this.tfValidateAt);
            this.pnData.Location = new System.Drawing.Point(5, 65);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(520, 177);
            this.pnData.TabIndex = 13;
            // 
            // pePicture
            // 
            this.pePicture.Location = new System.Drawing.Point(421, 11);
            this.pePicture.Name = "pePicture";
            this.pePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pePicture.Size = new System.Drawing.Size(92, 114);
            this.pePicture.TabIndex = 12;
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(9, 15);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(55, 13);
            this.labelControl21.TabIndex = 0;
            this.labelControl21.Text = "Emitido em:";
            // 
            // tfBarCode
            // 
            this.tfBarCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgInfoCard, "barcode", true));
            this.tfBarCode.Location = new System.Drawing.Point(101, 64);
            this.tfBarCode.Name = "tfBarCode";
            this.tfBarCode.Properties.ReadOnly = true;
            this.tfBarCode.Size = new System.Drawing.Size(128, 20);
            this.tfBarCode.TabIndex = 1;
            // 
            // bdgInfoCard
            // 
            this.bdgInfoCard.DataSource = typeof(CardManagerRepo.customer);
            // 
            // tfValueCard
            // 
            this.tfValueCard.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgInfoCard, "value_card", true));
            this.tfValueCard.Location = new System.Drawing.Point(101, 90);
            this.tfValueCard.Name = "tfValueCard";
            this.tfValueCard.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfValueCard.Properties.Precision = 2;
            this.tfValueCard.Properties.ShowCloseButton = true;
            this.tfValueCard.Size = new System.Drawing.Size(128, 20);
            this.tfValueCard.TabIndex = 11;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule1.ErrorText = "Informe o Valor do Cartão";
            conditionValidationRule1.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.validatorCard.SetValidationRule(this.tfValueCard, conditionValidationRule1);
            // 
            // btnEmitterCard
            // 
            this.btnEmitterCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnEmitterCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitterCard.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnEmitterCard.ForeColor = System.Drawing.Color.White;
            this.btnEmitterCard.Image = ((System.Drawing.Image)(resources.GetObject("btnEmitterCard.Image")));
            this.btnEmitterCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmitterCard.Location = new System.Drawing.Point(193, 133);
            this.btnEmitterCard.Name = "btnEmitterCard";
            this.btnEmitterCard.Size = new System.Drawing.Size(158, 33);
            this.btnEmitterCard.TabIndex = 10;
            this.btnEmitterCard.Text = "Emitir Cartão";
            this.btnEmitterCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmitterCard.UseVisualStyleBackColor = false;
            this.btnEmitterCard.Click += new System.EventHandler(this.btnEmitterCard_Click);
            // 
            // tfLastUsing
            // 
            this.tfLastUsing.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgInfoCard, "last_using", true));
            this.tfLastUsing.EditValue = "";
            this.tfLastUsing.Location = new System.Drawing.Point(294, 12);
            this.tfLastUsing.Name = "tfLastUsing";
            this.tfLastUsing.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm";
            this.tfLastUsing.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.tfLastUsing.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfLastUsing.Properties.ReadOnly = true;
            this.tfLastUsing.Size = new System.Drawing.Size(99, 20);
            this.tfLastUsing.TabIndex = 1;
            // 
            // labelControl25
            // 
            this.labelControl25.Location = new System.Drawing.Point(9, 67);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(37, 13);
            this.labelControl25.TabIndex = 0;
            this.labelControl25.Text = "Código:";
            // 
            // tfEmitterAt
            // 
            this.tfEmitterAt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgInfoCard, "emission_card_at", true));
            this.tfEmitterAt.EditValue = "";
            this.tfEmitterAt.Location = new System.Drawing.Point(101, 12);
            this.tfEmitterAt.Name = "tfEmitterAt";
            this.tfEmitterAt.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm";
            this.tfEmitterAt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.tfEmitterAt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfEmitterAt.Properties.ReadOnly = true;
            this.tfEmitterAt.Size = new System.Drawing.Size(128, 20);
            this.tfEmitterAt.TabIndex = 1;
            // 
            // labelControl24
            // 
            this.labelControl24.Location = new System.Drawing.Point(9, 93);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(84, 13);
            this.labelControl24.TabIndex = 0;
            this.labelControl24.Text = "Taxa de Emissão:";
            // 
            // btnExportCodeBar
            // 
            this.btnExportCodeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnExportCodeBar.Enabled = false;
            this.btnExportCodeBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCodeBar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnExportCodeBar.ForeColor = System.Drawing.Color.White;
            this.btnExportCodeBar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportCodeBar.Image")));
            this.btnExportCodeBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportCodeBar.Location = new System.Drawing.Point(355, 133);
            this.btnExportCodeBar.Name = "btnExportCodeBar";
            this.btnExportCodeBar.Size = new System.Drawing.Size(158, 33);
            this.btnExportCodeBar.TabIndex = 9;
            this.btnExportCodeBar.Text = "Código de Barras";
            this.btnExportCodeBar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportCodeBar.UseVisualStyleBackColor = false;
            this.btnExportCodeBar.Click += new System.EventHandler(this.btnExportCodeBar_Click);
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(235, 15);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(53, 13);
            this.labelControl23.TabIndex = 0;
            this.labelControl23.Text = "Ultimo uso:";
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(9, 41);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(51, 13);
            this.labelControl22.TabIndex = 0;
            this.labelControl22.Text = "Válido até:";
            // 
            // lbStatusCard
            // 
            this.lbStatusCard.Location = new System.Drawing.Point(235, 41);
            this.lbStatusCard.Name = "lbStatusCard";
            this.lbStatusCard.Size = new System.Drawing.Size(62, 13);
            this.lbStatusCard.TabIndex = 0;
            this.lbStatusCard.Text = "lbStatusCard";
            // 
            // tfValidateAt
            // 
            this.tfValidateAt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgInfoCard, "validate_card", true));
            this.tfValidateAt.EditValue = "";
            this.tfValidateAt.Location = new System.Drawing.Point(101, 38);
            this.tfValidateAt.Name = "tfValidateAt";
            this.tfValidateAt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfValidateAt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfValidateAt.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.tfValidateAt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tfValidateAt.Size = new System.Drawing.Size(128, 20);
            this.tfValidateAt.TabIndex = 1;
            // 
            // cbCustomer
            // 
            this.cbCustomer.Location = new System.Drawing.Point(53, 32);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCustomer.Properties.DataSource = this.bdgCustomers;
            this.cbCustomer.Properties.DisplayMember = "name";
            this.cbCustomer.Properties.NullText = "";
            this.cbCustomer.Properties.ValueMember = "id";
            this.cbCustomer.Properties.View = this.searchLookUpEdit1View;
            this.cbCustomer.Size = new System.Drawing.Size(470, 20);
            this.cbCustomer.TabIndex = 12;
            this.cbCustomer.EditValueChanged += new System.EventHandler(this.SearchCustomer);
            // 
            // bdgCustomers
            // 
            this.bdgCustomers.DataSource = typeof(CardManagerRepo.customer);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colbirthday,
            this.colregistered_at,
            this.colrg,
            this.colorgan_emitter_rg,
            this.colcpf,
            this.coladdress_id,
            this.colobservation,
            this.colinactive,
            this.colinactive_at,
            this.colmail,
            this.colmail_other,
            this.colbusiness_id,
            this.colemission_card_at,
            this.collast_using,
            this.colbarcode,
            this.colcard_emitted,
            this.colvalue_card,
            this.colvalidate_card,
            this.coldirectory_picture});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.searchLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colname, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colid
            // 
            this.colid.Caption = "Cod.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 90;
            // 
            // colname
            // 
            this.colname.Caption = "Nome";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 361;
            // 
            // colbirthday
            // 
            this.colbirthday.FieldName = "birthday";
            this.colbirthday.Name = "colbirthday";
            this.colbirthday.OptionsColumn.AllowEdit = false;
            this.colbirthday.Width = 51;
            // 
            // colregistered_at
            // 
            this.colregistered_at.FieldName = "registered_at";
            this.colregistered_at.Name = "colregistered_at";
            this.colregistered_at.OptionsColumn.AllowEdit = false;
            this.colregistered_at.Width = 295;
            // 
            // colrg
            // 
            this.colrg.FieldName = "rg";
            this.colrg.Name = "colrg";
            this.colrg.OptionsColumn.AllowEdit = false;
            this.colrg.Width = 50;
            // 
            // colorgan_emitter_rg
            // 
            this.colorgan_emitter_rg.FieldName = "organ_emitter_rg";
            this.colorgan_emitter_rg.Name = "colorgan_emitter_rg";
            this.colorgan_emitter_rg.OptionsColumn.AllowEdit = false;
            this.colorgan_emitter_rg.Width = 50;
            // 
            // colcpf
            // 
            this.colcpf.Caption = "CPF";
            this.colcpf.FieldName = "cpf";
            this.colcpf.Name = "colcpf";
            this.colcpf.OptionsColumn.AllowEdit = false;
            this.colcpf.Visible = true;
            this.colcpf.VisibleIndex = 2;
            this.colcpf.Width = 333;
            // 
            // coladdress_id
            // 
            this.coladdress_id.FieldName = "address_id";
            this.coladdress_id.Name = "coladdress_id";
            this.coladdress_id.OptionsColumn.AllowEdit = false;
            this.coladdress_id.Width = 50;
            // 
            // colobservation
            // 
            this.colobservation.FieldName = "observation";
            this.colobservation.Name = "colobservation";
            this.colobservation.OptionsColumn.AllowEdit = false;
            this.colobservation.Width = 50;
            // 
            // colinactive
            // 
            this.colinactive.FieldName = "inactive";
            this.colinactive.Name = "colinactive";
            this.colinactive.OptionsColumn.AllowEdit = false;
            this.colinactive.Width = 50;
            // 
            // colinactive_at
            // 
            this.colinactive_at.FieldName = "inactive_at";
            this.colinactive_at.Name = "colinactive_at";
            this.colinactive_at.OptionsColumn.AllowEdit = false;
            this.colinactive_at.Width = 50;
            // 
            // colmail
            // 
            this.colmail.FieldName = "mail";
            this.colmail.Name = "colmail";
            this.colmail.OptionsColumn.AllowEdit = false;
            this.colmail.Width = 50;
            // 
            // colmail_other
            // 
            this.colmail_other.FieldName = "mail_other";
            this.colmail_other.Name = "colmail_other";
            this.colmail_other.OptionsColumn.AllowEdit = false;
            this.colmail_other.Width = 50;
            // 
            // colbusiness_id
            // 
            this.colbusiness_id.FieldName = "business_id";
            this.colbusiness_id.Name = "colbusiness_id";
            this.colbusiness_id.OptionsColumn.AllowEdit = false;
            this.colbusiness_id.Width = 50;
            // 
            // colemission_card_at
            // 
            this.colemission_card_at.FieldName = "emission_card_at";
            this.colemission_card_at.Name = "colemission_card_at";
            this.colemission_card_at.OptionsColumn.AllowEdit = false;
            this.colemission_card_at.Width = 50;
            // 
            // collast_using
            // 
            this.collast_using.FieldName = "last_using";
            this.collast_using.Name = "collast_using";
            this.collast_using.OptionsColumn.AllowEdit = false;
            this.collast_using.Width = 50;
            // 
            // colbarcode
            // 
            this.colbarcode.Caption = "Cod. Cartão";
            this.colbarcode.FieldName = "barcode";
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.OptionsColumn.AllowEdit = false;
            this.colbarcode.Visible = true;
            this.colbarcode.VisibleIndex = 3;
            this.colbarcode.Width = 294;
            // 
            // colcard_emitted
            // 
            this.colcard_emitted.FieldName = "card_emitted";
            this.colcard_emitted.Name = "colcard_emitted";
            this.colcard_emitted.OptionsColumn.AllowEdit = false;
            this.colcard_emitted.Width = 50;
            // 
            // colvalue_card
            // 
            this.colvalue_card.FieldName = "value_card";
            this.colvalue_card.Name = "colvalue_card";
            this.colvalue_card.OptionsColumn.AllowEdit = false;
            this.colvalue_card.Width = 50;
            // 
            // colvalidate_card
            // 
            this.colvalidate_card.FieldName = "validate_card";
            this.colvalidate_card.Name = "colvalidate_card";
            this.colvalidate_card.OptionsColumn.AllowEdit = false;
            this.colvalidate_card.Width = 50;
            // 
            // coldirectory_picture
            // 
            this.coldirectory_picture.FieldName = "directory_picture";
            this.coldirectory_picture.Name = "coldirectory_picture";
            this.coldirectory_picture.OptionsColumn.AllowEdit = false;
            this.coldirectory_picture.Width = 62;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cliente:";
            // 
            // EmissionCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 285);
            this.Controls.Add(this.pnCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmissionCardForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pnCard)).EndInit();
            this.pnCard.ResumeLayout(false);
            this.pnCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnData)).EndInit();
            this.pnData.ResumeLayout(false);
            this.pnData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfBarCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgInfoCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValueCard.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfLastUsing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEmitterAt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValidateAt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValidateAt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl pnCard;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validatorCard;
        private DevExpress.XtraEditors.PanelControl pnData;
        private DevExpress.XtraEditors.PictureEdit pePicture;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.TextEdit tfBarCode;
        private DevExpress.XtraEditors.CalcEdit tfValueCard;
        private WCButtons.Black.ButtonRefreshBlack btnEmitterCard;
        private DevExpress.XtraEditors.TextEdit tfLastUsing;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.TextEdit tfEmitterAt;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private WCButtons.Black.ButtonSettingsBlack btnExportCodeBar;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl lbStatusCard;
        private DevExpress.XtraEditors.SearchLookUpEdit cbCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private WCButtons.Black.ButtonCancelBlack btnExit;
        private System.Windows.Forms.BindingSource bdgCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colbirthday;
        private DevExpress.XtraGrid.Columns.GridColumn colregistered_at;
        private DevExpress.XtraGrid.Columns.GridColumn colrg;
        private DevExpress.XtraGrid.Columns.GridColumn colorgan_emitter_rg;
        private DevExpress.XtraGrid.Columns.GridColumn colcpf;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress_id;
        private DevExpress.XtraGrid.Columns.GridColumn colobservation;
        private DevExpress.XtraGrid.Columns.GridColumn colinactive;
        private DevExpress.XtraGrid.Columns.GridColumn colinactive_at;
        private DevExpress.XtraGrid.Columns.GridColumn colmail;
        private DevExpress.XtraGrid.Columns.GridColumn colmail_other;
        private DevExpress.XtraGrid.Columns.GridColumn colbusiness_id;
        private DevExpress.XtraGrid.Columns.GridColumn colemission_card_at;
        private DevExpress.XtraGrid.Columns.GridColumn collast_using;
        private DevExpress.XtraGrid.Columns.GridColumn colbarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colcard_emitted;
        private DevExpress.XtraGrid.Columns.GridColumn colvalue_card;
        private DevExpress.XtraGrid.Columns.GridColumn colvalidate_card;
        private DevExpress.XtraGrid.Columns.GridColumn coldirectory_picture;
        private System.Windows.Forms.BindingSource bdgInfoCard;
        private DevExpress.XtraEditors.DateEdit tfValidateAt;
    }
}