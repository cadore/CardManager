using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using ModelsCardManager;
using CardManagerRepo;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTab;
using DevExpress.XtraEditors;
using CardManager.Utils;
using CardManager.UI.Customers;
using CardManager.UI.Users;
using CardManager.UI.Utils;
using DevExpress.XtraSplashScreen;
using System.Threading;
using ModelsCardManager.Utils;
using CardManager.UI.SplashScreens;
using CardManager.UI.Credentialeds;
using CardManager.UI.Cards.Print;
using System.Drawing.Printing;
using CardManager.UI.Cards;
using DevExpress.XtraReports.Native;
using CardManager.UI.Inputs;
using MobiDLL;
using CardManager.UI.Outputs;
using CardManager.UI.Cashier;

namespace CardManager.UI
{
    public partial class DesktopForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        TabControlUtil tabUtil;
        public DesktopForm()
        {
            InitializeComponent();
            UserControlUtil.desk = this;
            business b = Singleton.getCurrentBusiness();
            user u = Singleton.getCurrentUser();
            this.Text = String.Format("{0} - {1} Usuário: {2} / Card Manager - Cadore Tecnologia",
                b.corporate_name, b.cnpj, u.full_name);
            tabUtil = new TabControlUtil(this);
            loadPermissionsUser(u);
            SplashScreenManager.CloseForm(false);
        }

        void loadPermissionsUser(user u)
        {
            btnChangeCurrentBusiness.Enabled = u.change_business;
        }

        public void AddTab(XtraUserControl userControl, string titleTab, bool newTab)
        {
            tabUtil.AddTab(userControl, titleTab, newTab, true);
        }

        public void AddTabAndCloseCurrent(XtraUserControl userControl, string titleTab, bool newTab)
        {
            tabUtil.CloseSelectedPage();
            tabUtil.AddTab(userControl, titleTab, newTab, true);
        }

        public void CloseCurrentTab()
        {
            tabUtil.CloseSelectedPage();
        }

        private void btnNewCredentialed_ItemClick(object sender, ItemClickEventArgs e)
        {
            CredentialedForm cdf = new CredentialedForm(null);
            AddTab(cdf, "Novo Credenciado", false);
        }

        private void btnSearchCredentialeds_ItemClick(object sender, ItemClickEventArgs e)
        {
            SearchCredentialedsForm scf = new SearchCredentialedsForm();
            AddTab(scf, "Pesquisa de Credenciados", false);
        }

        private void btnNewUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserForm uf = new UserForm(null);
            AddTab(uf, "Novo Usuário", false);
        }

        private void btnSearchUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            SearchUsersForm suf = new SearchUsersForm();
            AddTab(suf, "Busca de Usuários", false);
        }

        private void tabControl_ControlAdded(object sender, ControlEventArgs e)
        {
            if(tabUtil != null)
                tabUtil.CenterControlsInPanel();
        }

        private void tabControl_Resize(object sender, EventArgs e)
        {
            if (tabUtil != null)
                tabUtil.CenterControlsInPanel();
        }

        private void tabControl_CustomHeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs e)
        {
            if (Convert.ToInt32(e.Button.Tag) != 1 
                || this.tabControl.TabPages.Count <= 0 
                || XtraMessageBox.Show("Tem certeza que deseja fechar todas as guias?", "Confirmação de fechamento",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;
            this.tabControl.TabPages.Clear();
        }

        private void tabControl_CloseButtonClick(object sender, EventArgs e)
        {
            this.tabControl.TabPages.Remove((e as ClosePageButtonEventArgs).Page as XtraTabPage);
        }

        private void DesktopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tabControl.TabPages.Count > 0)
            {
                DialogResult rs = XtraMessageBox.Show("Deseja realmente sair?", "Confirmação de Saída",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (rs == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void btnChangePwd_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ChangePasswordUserForm cpuf = new ChangePasswordUserForm(Util.Decrypt(Singleton.getCurrentUser().password));
                if (cpuf.ShowDialog() == DialogResult.OK)
                {
                    SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
                    user u = Singleton.getCurrentUser();
                    u.password = Util.Encrypt(cpuf.NewPassword);
                    u.Update();
                    Singleton.setCurrentUser(u);
                    SplashScreenManager.CloseForm(false);
                    XtraMessageBox.Show("Senha atualizada com sucesso!", "Cadore Tecnologia");                    
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException), "Cadore Tecnologia");
            }
        }

        private void btnNewCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            CustomerForm cf = new CustomerForm(null);
            AddTab(cf, "Novo Cliente", false);
        }

        private void btnSearchCustomers_ItemClick(object sender, ItemClickEventArgs e)
        {
            SearchCustomersForm scf = new SearchCustomersForm();
            AddTab(scf, "Pesquisa de Clientes", false);
        }

        private void btnManagerCards_ItemClick(object sender, ItemClickEventArgs e)
        {
            EmissionCardForm ecf = new EmissionCardForm();
            ecf.ShowDialog();
        }

        private void btnChangeCurrentBusiness_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void DesktopForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (((Keys.Control | Keys.Alt) | Keys.Shift) | Keys.C))
            {
                btnChangeCurrentBusiness_ItemClick(sender, null);
            }
        }

        private void btnNewInput_ItemClick(object sender, ItemClickEventArgs e)
        {
            InputForm inf = new InputForm(null);
            AddTab(inf, "Nova Entrada Avulsa", false);
        }

        private void btnSearchInputs_ItemClick(object sender, ItemClickEventArgs e)
        {
            SearchInputForm sif = new SearchInputForm();
            AddTab(sif, "Pesquisa de Entradas Avulsas", false);
        }

        private void btnNewOutput_ItemClick(object sender, ItemClickEventArgs e)
        {
            OutputForm of = new OutputForm(null);
            AddTab(of, "Nova Saida", false);
        }

        private void btnSearchOutputs_ItemClick(object sender, ItemClickEventArgs e)
        {
            SearchOutputsForm sof = new SearchOutputsForm();
            AddTab(sof, "Pesquisar Saidas", false);
        }

        private void btnViewCashFlow_ItemClick(object sender, ItemClickEventArgs e)
        {
            CashFlowForm cff = new CashFlowForm();
            AddTab(cff, "Visualizar Fluxo de Caixa", false);
        }
    }
}