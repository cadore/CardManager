using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ModelsCardManager.Utils;
using CardManagerRepo;
using ModelsCardManager;
using CardManager.UI.Helper;
using DevExpress.XtraSplashScreen;
using System.Threading;
using CardManager.UI.SplashScreens;
using System.Net;

namespace CardManager.UI.Login
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            Thread.Sleep(1000);
            SplashScreenManager.CloseForm(false);
            this.DialogResult = DialogResult.Cancel;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            business b = Singleton.getCurrentBusiness();
            this.Text = String.Format("{0}-{1} / Card Manager - Cadore Tecnologia",
                b.corporate_name, b.cnpj);
            if (Environment.MachineName == "CADORE-NOTE")
            {
                tfCPF.EditValue = "050.425.459-64";
                tfPassword.EditValue = "a1s2 d3f4";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!validatorLogin.Validate())
                return;

            SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
            if (Login())
            {

                //logs of logins
                logins lo = new logins() 
                {
                    user_id = Singleton.getCurrentUser().id,
                    date = logins.Now(),
                    computer = Environment.MachineName,
                    local_ip = Util.getInternalIp(),
                    external_ip = Util.getExternalIp()
                };
                lo.Save();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool Login()
        {            
            string l = tfCPF.EditValue.ToString();
            string p = Util.Encrypt(tfPassword.EditValue.ToString());

            user u = user.SingleOrDefault("WHERE cpf=@0 AND password=@1 AND inactive=FALSE;", l, p);
            if (u == null)
            {
                SplashScreenManager.CloseForm(false);
                XtraMessageBox.Show("CPF e/ou Senha incorretos, verifique", "Cadore Tecnologia");
                tfPassword.Text = "";
                tfCPF.Select();
                tfCPF.Focus();
                return false;
            }                
            else
            {
                if (Singleton.getCurrentBusiness().id == u.business_id || u.business_id == -1)
                {
                    Singleton.setCurrentUser(u);
                    return true;
                }
                else
                {
                    SplashScreenManager.CloseForm(false);
                    XtraMessageBox.Show("Você não tem permição para acessar os dados desta filial.", "Cadore Tecnologia");
                    return false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.btnCancel_Click(sender, e);
            else if (e.KeyCode == Keys.Enter)
                this.btnLogin_Click(sender, e);
        }

        private void lbNeedHelp_Click(object sender, EventArgs e)
        {
            NeedHelpForm nhf = new NeedHelpForm();
            nhf.ShowDialog();
        }

        private void tfCPF_KeyUp(object sender, KeyEventArgs e)
        {
            string cpf = tfCPF.Text.Replace("_", "").Replace(".", "").Replace("-", "");
            if (cpf.Length == 11)
                tfPassword.Focus();
        }

        private void lbNeedHelp_MouseEnter(object sender, EventArgs e)
        {
            lbNeedHelp.ForeColor = Color.Blue;
        }

        private void lbNeedHelp_MouseLeave(object sender, EventArgs e)
        {
            lbNeedHelp.ForeColor = Color.Black;
        }
    }
}