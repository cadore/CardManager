using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CardManagerRepo;
using DevExpress.XtraTab;
using ModelsCardManager.Utils;
using ModelsCardManager;
using CardManager.Utils;
using DevExpress.XtraEditors.DXErrorProvider;

namespace CardManager.UI.Users
{
    public partial class UserForm : CardManager.UI.Utils.UserControlUtil
    {
        public string NewPassword { get; set; }
        public UserForm(user u)
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            if (u == null)
            {
                u = new user();
                btnInactive.Visible = false;
                IsNew = true;
            }
            NewPassword = u.password;
            if (u.inactive)
            {
                panelControl1.Enabled = false;
                btnInactive.Visible = false;
                btnSave.Visible = false;
                IsNew = false;
            }                
            bdgUser.DataSource = u;

            //validations
            Validations.ValidatorCPFCNPJ vldCPF = new Validations.ValidatorCPFCNPJ() 
            { 
                ErrorText = "O CPF informado é inválido.", 
                ErrorType = ErrorType.Warning 
            };
            validator.SetValidationRule(tfCPF, vldCPF);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Tem certeza que deseja inativar o usuário?\nNão sera possivel reverte esta ação!", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    user u = ((user)bdgUser.Current);
                    u.inactive = true;
                    u.Update();
                    XtraMessageBox.Show("Usuário inativado com sucesso!");
                    desk.CloseCurrentTab();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Ocorreu um erro: \n" + ex.Message);
                }
            }
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            string cp = ((user)bdgUser.Current).password;
            if (!String.IsNullOrEmpty(cp))
                cp = Util.Decrypt(cp);
            ChangePasswordUserForm cpuf = new ChangePasswordUserForm(cp) { desk = desk };
            DialogResult rs = cpuf.ShowDialog();
            if (rs == DialogResult.OK)
                this.NewPassword = Util.Encrypt(cpuf.NewPassword);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validator.Validate())
                    return;
                if (String.IsNullOrEmpty(NewPassword))
                {
                    if (XtraMessageBox.Show("Senha de acesso não informada!\nCaso não informe a senha do usuário ela será o numero "
                        + "do CPF, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    else
                        NewPassword = Util.Encrypt(tfCPF.Text.Replace(".", "").Replace("-", ""));
                }
                user u = (user)bdgUser.Current;
                u.password = NewPassword;
                u.business_id = Singleton.getCurrentBusiness().id;
                u.Save();
                if (this.MessageToSave("Usuário"))
                    desk.AddTabAndCloseCurrent(new UserForm(null), "Novo usuário", false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
        }
    }
}
