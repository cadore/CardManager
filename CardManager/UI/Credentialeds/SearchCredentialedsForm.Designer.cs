namespace CardManager.UI.Credentialeds
{
    partial class SearchCredentialedsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCredentialedsForm));
            this.rgSearch = new DevExpress.XtraEditors.RadioGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSearch = new WCButtons.Black.ButtonSearchBlack();
            this.tfSearch = new DevExpress.XtraEditors.TextEdit();
            this.lbSearch = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSelect = new WCButtons.Black.ButtonConfirmBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdgCredentialeds = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcnpj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcompany_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfantasy_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colopening_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphone_fixed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphone_mobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinactive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription_discount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalue_discount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldirectory_logo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colregistered_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinactived_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservations = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbusiness_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpassword = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rgSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCredentialeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rgSearch
            // 
            this.rgSearch.Location = new System.Drawing.Point(5, 10);
            this.rgSearch.Name = "rgSearch";
            this.rgSearch.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgSearch.Properties.Appearance.Options.UseBackColor = true;
            this.rgSearch.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("name", "Nome"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("cnpj", "CNPJ")});
            this.rgSearch.Size = new System.Drawing.Size(118, 28);
            this.rgSearch.TabIndex = 0;
            this.rgSearch.SelectedIndexChanged += new System.EventHandler(this.rgSearch_SelectedIndexChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.tfSearch);
            this.panelControl1.Controls.Add(this.lbSearch);
            this.panelControl1.Controls.Add(this.rgSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(929, 46);
            this.panelControl1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(814, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tfSearch
            // 
            this.tfSearch.Location = new System.Drawing.Point(177, 14);
            this.tfSearch.Name = "tfSearch";
            this.tfSearch.Size = new System.Drawing.Size(631, 20);
            this.tfSearch.TabIndex = 1;
            this.tfSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tfSearch_KeyDown);
            // 
            // lbSearch
            // 
            this.lbSearch.Location = new System.Drawing.Point(140, 17);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(31, 13);
            this.lbSearch.TabIndex = 1;
            this.lbSearch.Text = "Nome:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSelect);
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 410);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(929, 43);
            this.panelControl2.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(691, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(117, 33);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Selecionar";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(814, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdgCredentialeds;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 46);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(929, 364);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.btnSelect_Click);
            // 
            // bdgCredentialeds
            // 
            this.bdgCredentialeds.DataSource = typeof(CardManagerRepo.credentialed);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcnpj,
            this.colcompany_name,
            this.colfantasy_name,
            this.colopening_at,
            this.colphone_fixed,
            this.colphone_mobile,
            this.coladdress_id,
            this.colinactive,
            this.coldescription_discount,
            this.colvalue_discount,
            this.coldirectory_logo,
            this.colregistered_at,
            this.colinactived_at,
            this.colobservations,
            this.colbusiness_id,
            this.colpassword});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.Caption = "Cod.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 35;
            // 
            // colcnpj
            // 
            this.colcnpj.Caption = "CNPJ";
            this.colcnpj.FieldName = "cnpj";
            this.colcnpj.Name = "colcnpj";
            this.colcnpj.OptionsColumn.AllowEdit = false;
            this.colcnpj.Visible = true;
            this.colcnpj.VisibleIndex = 3;
            this.colcnpj.Width = 127;
            // 
            // colcompany_name
            // 
            this.colcompany_name.Caption = "Razão Social";
            this.colcompany_name.FieldName = "company_name";
            this.colcompany_name.Name = "colcompany_name";
            this.colcompany_name.OptionsColumn.AllowEdit = false;
            this.colcompany_name.Visible = true;
            this.colcompany_name.VisibleIndex = 1;
            this.colcompany_name.Width = 162;
            // 
            // colfantasy_name
            // 
            this.colfantasy_name.Caption = "Nome Fantasia";
            this.colfantasy_name.FieldName = "fantasy_name";
            this.colfantasy_name.Name = "colfantasy_name";
            this.colfantasy_name.OptionsColumn.AllowEdit = false;
            this.colfantasy_name.Visible = true;
            this.colfantasy_name.VisibleIndex = 2;
            this.colfantasy_name.Width = 166;
            // 
            // colopening_at
            // 
            this.colopening_at.FieldName = "opening_at";
            this.colopening_at.Name = "colopening_at";
            this.colopening_at.OptionsColumn.AllowEdit = false;
            // 
            // colphone_fixed
            // 
            this.colphone_fixed.Caption = "Telefone";
            this.colphone_fixed.FieldName = "phone_fixed";
            this.colphone_fixed.Name = "colphone_fixed";
            this.colphone_fixed.OptionsColumn.AllowEdit = false;
            this.colphone_fixed.Visible = true;
            this.colphone_fixed.VisibleIndex = 4;
            this.colphone_fixed.Width = 89;
            // 
            // colphone_mobile
            // 
            this.colphone_mobile.FieldName = "phone_mobile";
            this.colphone_mobile.Name = "colphone_mobile";
            this.colphone_mobile.OptionsColumn.AllowEdit = false;
            this.colphone_mobile.Width = 53;
            // 
            // coladdress_id
            // 
            this.coladdress_id.FieldName = "address_id";
            this.coladdress_id.Name = "coladdress_id";
            this.coladdress_id.OptionsColumn.AllowEdit = false;
            this.coladdress_id.Width = 53;
            // 
            // colinactive
            // 
            this.colinactive.Caption = "Inativo";
            this.colinactive.FieldName = "inactive";
            this.colinactive.Name = "colinactive";
            this.colinactive.OptionsColumn.AllowEdit = false;
            this.colinactive.Visible = true;
            this.colinactive.VisibleIndex = 7;
            this.colinactive.Width = 52;
            // 
            // coldescription_discount
            // 
            this.coldescription_discount.FieldName = "description_discount";
            this.coldescription_discount.Name = "coldescription_discount";
            this.coldescription_discount.OptionsColumn.AllowEdit = false;
            this.coldescription_discount.Width = 53;
            // 
            // colvalue_discount
            // 
            this.colvalue_discount.Caption = "Desconto";
            this.colvalue_discount.DisplayFormat.FormatString = "n2";
            this.colvalue_discount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalue_discount.FieldName = "value_discount";
            this.colvalue_discount.Name = "colvalue_discount";
            this.colvalue_discount.OptionsColumn.AllowEdit = false;
            this.colvalue_discount.Visible = true;
            this.colvalue_discount.VisibleIndex = 5;
            this.colvalue_discount.Width = 66;
            // 
            // coldirectory_logo
            // 
            this.coldirectory_logo.FieldName = "directory_logo";
            this.coldirectory_logo.Name = "coldirectory_logo";
            this.coldirectory_logo.OptionsColumn.AllowEdit = false;
            this.coldirectory_logo.Width = 53;
            // 
            // colregistered_at
            // 
            this.colregistered_at.Caption = "Registrada em";
            this.colregistered_at.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.colregistered_at.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colregistered_at.FieldName = "registered_at";
            this.colregistered_at.Name = "colregistered_at";
            this.colregistered_at.OptionsColumn.AllowEdit = false;
            this.colregistered_at.Visible = true;
            this.colregistered_at.VisibleIndex = 6;
            this.colregistered_at.Width = 104;
            // 
            // colinactived_at
            // 
            this.colinactived_at.Caption = "Inativada em";
            this.colinactived_at.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.colinactived_at.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colinactived_at.FieldName = "inactived_at";
            this.colinactived_at.Name = "colinactived_at";
            this.colinactived_at.OptionsColumn.AllowEdit = false;
            this.colinactived_at.Visible = true;
            this.colinactived_at.VisibleIndex = 8;
            this.colinactived_at.Width = 110;
            // 
            // colobservations
            // 
            this.colobservations.FieldName = "observations";
            this.colobservations.Name = "colobservations";
            this.colobservations.OptionsColumn.AllowEdit = false;
            this.colobservations.Width = 61;
            // 
            // colbusiness_id
            // 
            this.colbusiness_id.FieldName = "business_id";
            this.colbusiness_id.Name = "colbusiness_id";
            this.colbusiness_id.OptionsColumn.AllowEdit = false;
            this.colbusiness_id.Width = 61;
            // 
            // colpassword
            // 
            this.colpassword.FieldName = "password";
            this.colpassword.Name = "colpassword";
            this.colpassword.OptionsColumn.AllowEdit = false;
            this.colpassword.Width = 107;
            // 
            // SearchCredentialedsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "SearchCredentialedsForm";
            this.Size = new System.Drawing.Size(929, 453);
            ((System.ComponentModel.ISupportInitialize)(this.rgSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCredentialeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup rgSearch;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit tfSearch;
        private DevExpress.XtraEditors.LabelControl lbSearch;
        private WCButtons.Black.ButtonSearchBlack btnSearch;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private WCButtons.Black.ButtonConfirmBlack btnSelect;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource bdgCredentialeds;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcnpj;
        private DevExpress.XtraGrid.Columns.GridColumn colcompany_name;
        private DevExpress.XtraGrid.Columns.GridColumn colfantasy_name;
        private DevExpress.XtraGrid.Columns.GridColumn colopening_at;
        private DevExpress.XtraGrid.Columns.GridColumn colphone_fixed;
        private DevExpress.XtraGrid.Columns.GridColumn colphone_mobile;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress_id;
        private DevExpress.XtraGrid.Columns.GridColumn colinactive;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription_discount;
        private DevExpress.XtraGrid.Columns.GridColumn colvalue_discount;
        private DevExpress.XtraGrid.Columns.GridColumn coldirectory_logo;
        private DevExpress.XtraGrid.Columns.GridColumn colregistered_at;
        private DevExpress.XtraGrid.Columns.GridColumn colinactived_at;
        private DevExpress.XtraGrid.Columns.GridColumn colobservations;
        private DevExpress.XtraGrid.Columns.GridColumn colbusiness_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpassword;
    }
}
