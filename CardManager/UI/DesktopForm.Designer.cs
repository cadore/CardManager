namespace CardManager.UI
{
    partial class DesktopForm
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::CardManager.UI.SplashScreens.SplashScreenForm), false, false);
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewCredentialed = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchCredentialeds = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewUser = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchUser = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePwd = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchCustomers = new DevExpress.XtraBars.BarButtonItem();
            this.btnManagerCards = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangeCurrentBusiness = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewInput = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchInputs = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnNewCredentialed,
            this.btnSearchCredentialeds,
            this.btnNewUser,
            this.btnSearchUser,
            this.btnChangePwd,
            this.btnNewCustomer,
            this.btnSearchCustomers,
            this.btnManagerCards,
            this.barButtonItem3,
            this.btnChangeCurrentBusiness,
            this.btnNewInput,
            this.btnSearchInputs,
            this.barButtonItem4});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 20;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage3,
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(941, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnNewCredentialed
            // 
            this.btnNewCredentialed.Caption = "Novo  Credenciado";
            this.btnNewCredentialed.Id = 5;
            this.btnNewCredentialed.Name = "btnNewCredentialed";
            this.btnNewCredentialed.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNewCredentialed.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewCredentialed_ItemClick);
            // 
            // btnSearchCredentialeds
            // 
            this.btnSearchCredentialeds.Caption = "Consultar Credenciados";
            this.btnSearchCredentialeds.Id = 6;
            this.btnSearchCredentialeds.Name = "btnSearchCredentialeds";
            this.btnSearchCredentialeds.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSearchCredentialeds.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSearchCredentialeds_ItemClick);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Caption = "Novo  Usuário";
            this.btnNewUser.Id = 7;
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNewUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewUser_ItemClick);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Caption = "Consulta de Usuários";
            this.btnSearchUser.Id = 8;
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSearchUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSearchUser_ItemClick);
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.Caption = "Alterar Senha";
            this.btnChangePwd.Id = 9;
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePwd_ItemClick);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Caption = "Novo  Cliente";
            this.btnNewCustomer.Id = 10;
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNewCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewCustomer_ItemClick);
            // 
            // btnSearchCustomers
            // 
            this.btnSearchCustomers.Caption = "Consultar Clientes";
            this.btnSearchCustomers.Id = 11;
            this.btnSearchCustomers.Name = "btnSearchCustomers";
            this.btnSearchCustomers.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSearchCustomers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSearchCustomers_ItemClick);
            // 
            // btnManagerCards
            // 
            this.btnManagerCards.Caption = "Gerenciar Cartões";
            this.btnManagerCards.Id = 12;
            this.btnManagerCards.Name = "btnManagerCards";
            this.btnManagerCards.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnManagerCards.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnManagerCards_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 18;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnChangeCurrentBusiness
            // 
            this.btnChangeCurrentBusiness.Caption = "Alterar Empresa Atual";
            this.btnChangeCurrentBusiness.Id = 15;
            this.btnChangeCurrentBusiness.Name = "btnChangeCurrentBusiness";
            this.btnChangeCurrentBusiness.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnChangeCurrentBusiness.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangeCurrentBusiness_ItemClick);
            // 
            // btnNewInput
            // 
            this.btnNewInput.Caption = "Nova  Entrada";
            this.btnNewInput.Id = 16;
            this.btnNewInput.Name = "btnNewInput";
            this.btnNewInput.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNewInput.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewInput_ItemClick);
            // 
            // btnSearchInputs
            // 
            this.btnSearchInputs.Caption = "Consultar Entradas";
            this.btnSearchInputs.Id = 17;
            this.btnSearchInputs.Name = "btnSearchInputs";
            this.btnSearchInputs.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSearchInputs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSearchInputs_ItemClick);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "CAIXA";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.btnNewInput);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnSearchInputs);
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            this.ribbonPageGroup6.Text = "Entradas Avulsas";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "CADASTROS";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNewCredentialed);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSearchCredentialeds);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Credenciados";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btnNewCustomer);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSearchCustomers);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Clientes";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.btnManagerCards);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Cartões";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "GERENCIAMENTO";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNewUser);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSearchUser);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnChangePwd);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Usuários";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.btnChangeCurrentBusiness);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            this.ribbonPageGroup5.Text = "Empresa";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 445);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(941, 31);
            // 
            // tabControl
            // 
            this.tabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.tabControl.CustomHeaderButtons.AddRange(new DevExpress.XtraTab.Buttons.CustomHeaderButton[] {
            new DevExpress.XtraTab.Buttons.CustomHeaderButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close, "", -1, true, true, DevExpress.XtraEditors.ImageLocation.MiddleRight, null, serializableAppearanceObject1, "", 1, null, true)});
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 144);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(941, 301);
            this.tabControl.TabIndex = 2;
            this.tabControl.CloseButtonClick += new System.EventHandler(this.tabControl_CloseButtonClick);
            this.tabControl.CustomHeaderButtonClick += new DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventHandler(this.tabControl_CustomHeaderButtonClick);
            this.tabControl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tabControl_ControlAdded);
            this.tabControl.Resize += new System.EventHandler(this.tabControl_Resize);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 19;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // DesktopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 476);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "DesktopForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DesktopForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DesktopForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnNewCredentialed;
        private DevExpress.XtraBars.BarButtonItem btnSearchCredentialeds;
        private DevExpress.XtraBars.BarButtonItem btnNewUser;
        private DevExpress.XtraBars.BarButtonItem btnSearchUser;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        public DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraBars.BarButtonItem btnChangePwd;
        private DevExpress.XtraBars.BarButtonItem btnNewCustomer;
        private DevExpress.XtraBars.BarButtonItem btnSearchCustomers;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnManagerCards;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnChangeCurrentBusiness;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnNewInput;
        private DevExpress.XtraBars.BarButtonItem btnSearchInputs;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
    }
}