namespace CardManager.UI.Customers
{
    partial class SearchCustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCustomersForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdgCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colregistered_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcpf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinactive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemission_card_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collast_using = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcard_emitted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalidate_card = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.tfSearch = new DevExpress.XtraEditors.TextEdit();
            this.rgTypeSearch = new DevExpress.XtraEditors.RadioGroup();
            this.btnSearch = new WCButtons.Black.ButtonSearchBlack();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSelect = new WCButtons.Black.ButtonConfirmBlack();
            this.btnCancel = new WCButtons.Black.ButtonCancelBlack();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTypeSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Controls.Add(this.panelControl3);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(965, 457);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Pesquisa de Clientes";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 46);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(961, 367);
            this.panelControl2.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdgCustomers;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(957, 363);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.btnSelect_Click);
            // 
            // bdgCustomers
            // 
            this.bdgCustomers.DataSource = typeof(CardManagerRepo.customer);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colbirthday,
            this.colregistered_at,
            this.colcpf,
            this.colinactive,
            this.colemission_card_at,
            this.collast_using,
            this.colbarcode,
            this.colcard_emitted,
            this.colvalidate_card});
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
            this.colid.Width = 39;
            // 
            // colname
            // 
            this.colname.Caption = "Nome";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 265;
            // 
            // colbirthday
            // 
            this.colbirthday.Caption = "Aniversário";
            this.colbirthday.FieldName = "birthday";
            this.colbirthday.Name = "colbirthday";
            this.colbirthday.OptionsColumn.AllowEdit = false;
            this.colbirthday.Width = 73;
            // 
            // colregistered_at
            // 
            this.colregistered_at.Caption = "Registrado em";
            this.colregistered_at.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colregistered_at.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colregistered_at.FieldName = "registered_at";
            this.colregistered_at.Name = "colregistered_at";
            this.colregistered_at.OptionsColumn.AllowEdit = false;
            this.colregistered_at.Visible = true;
            this.colregistered_at.VisibleIndex = 2;
            this.colregistered_at.Width = 87;
            // 
            // colcpf
            // 
            this.colcpf.Caption = "CPF";
            this.colcpf.FieldName = "cpf";
            this.colcpf.Name = "colcpf";
            this.colcpf.OptionsColumn.AllowEdit = false;
            this.colcpf.Visible = true;
            this.colcpf.VisibleIndex = 3;
            this.colcpf.Width = 112;
            // 
            // colinactive
            // 
            this.colinactive.Caption = "Inativo";
            this.colinactive.FieldName = "inactive";
            this.colinactive.Name = "colinactive";
            this.colinactive.OptionsColumn.AllowEdit = false;
            this.colinactive.Visible = true;
            this.colinactive.VisibleIndex = 4;
            this.colinactive.Width = 52;
            // 
            // colemission_card_at
            // 
            this.colemission_card_at.Caption = "Emitido em";
            this.colemission_card_at.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colemission_card_at.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colemission_card_at.FieldName = "emission_card_at";
            this.colemission_card_at.Name = "colemission_card_at";
            this.colemission_card_at.OptionsColumn.AllowEdit = false;
            this.colemission_card_at.Visible = true;
            this.colemission_card_at.VisibleIndex = 6;
            this.colemission_card_at.Width = 67;
            // 
            // collast_using
            // 
            this.collast_using.Caption = "Ultimo uso";
            this.collast_using.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.collast_using.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.collast_using.FieldName = "last_using";
            this.collast_using.Name = "collast_using";
            this.collast_using.OptionsColumn.AllowEdit = false;
            this.collast_using.Visible = true;
            this.collast_using.VisibleIndex = 8;
            this.collast_using.Width = 67;
            // 
            // colbarcode
            // 
            this.colbarcode.Caption = "Código Cartão";
            this.colbarcode.FieldName = "barcode";
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.OptionsColumn.AllowEdit = false;
            this.colbarcode.Visible = true;
            this.colbarcode.VisibleIndex = 5;
            this.colbarcode.Width = 87;
            // 
            // colcard_emitted
            // 
            this.colcard_emitted.Caption = "Emitido";
            this.colcard_emitted.FieldName = "card_emitted";
            this.colcard_emitted.Name = "colcard_emitted";
            this.colcard_emitted.OptionsColumn.AllowEdit = false;
            this.colcard_emitted.Visible = true;
            this.colcard_emitted.VisibleIndex = 9;
            this.colcard_emitted.Width = 86;
            // 
            // colvalidate_card
            // 
            this.colvalidate_card.Caption = "Validade";
            this.colvalidate_card.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colvalidate_card.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colvalidate_card.FieldName = "validate_card";
            this.colvalidate_card.Name = "colvalidate_card";
            this.colvalidate_card.OptionsColumn.AllowEdit = false;
            this.colvalidate_card.Visible = true;
            this.colvalidate_card.VisibleIndex = 7;
            this.colvalidate_card.Width = 77;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.tfSearch);
            this.panelControl3.Controls.Add(this.rgTypeSearch);
            this.panelControl3.Controls.Add(this.btnSearch);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(961, 44);
            this.panelControl3.TabIndex = 2;
            // 
            // tfSearch
            // 
            this.tfSearch.Location = new System.Drawing.Point(190, 12);
            this.tfSearch.Name = "tfSearch";
            this.tfSearch.Size = new System.Drawing.Size(651, 20);
            this.tfSearch.TabIndex = 1;
            // 
            // rgTypeSearch
            // 
            this.rgTypeSearch.Location = new System.Drawing.Point(5, 5);
            this.rgTypeSearch.Name = "rgTypeSearch";
            this.rgTypeSearch.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgTypeSearch.Properties.Appearance.Options.UseBackColor = true;
            this.rgTypeSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgTypeSearch.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("name", "Nome"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("barcode", "Cod. Cartão")});
            this.rgTypeSearch.Size = new System.Drawing.Size(160, 33);
            this.rgTypeSearch.TabIndex = 0;
            this.rgTypeSearch.SelectedIndexChanged += new System.EventHandler(this.rgTypeSearch_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(847, 5);
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
            this.panelControl1.Controls.Add(this.btnSelect);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 413);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(961, 42);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(726, 6);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(115, 33);
            this.btnSelect.TabIndex = 1;
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
            this.btnCancel.Location = new System.Drawing.Point(847, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SearchCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "SearchCustomersForm";
            this.Size = new System.Drawing.Size(965, 457);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tfSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTypeSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private WCButtons.Black.ButtonConfirmBlack btnSelect;
        private WCButtons.Black.ButtonCancelBlack btnCancel;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private WCButtons.Black.ButtonSearchBlack btnSearch;
        private DevExpress.XtraEditors.RadioGroup rgTypeSearch;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource bdgCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colbirthday;
        private DevExpress.XtraGrid.Columns.GridColumn colregistered_at;
        private DevExpress.XtraGrid.Columns.GridColumn colcpf;
        private DevExpress.XtraGrid.Columns.GridColumn colinactive;
        private DevExpress.XtraGrid.Columns.GridColumn colemission_card_at;
        private DevExpress.XtraGrid.Columns.GridColumn collast_using;
        private DevExpress.XtraGrid.Columns.GridColumn colbarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colcard_emitted;
        private DevExpress.XtraGrid.Columns.GridColumn colvalidate_card;
        private DevExpress.XtraEditors.TextEdit tfSearch;
    }
}
