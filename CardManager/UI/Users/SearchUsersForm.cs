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
using DevExpress.XtraEditors.Mask;
using CardManagerRepo;
using DevExpress.XtraSplashScreen;
using CardManager.UI.SplashScreens;
using ModelsCardManager;

namespace CardManager.UI.Users
{
    public partial class SearchUsersForm : CardManager.UI.Utils.UserControlUtil
    {
        public SearchUsersForm()
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            rgSearch.EditValue = "name";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
            string s = rgSearch.EditValue.ToString();
            List<user> listUsers = null;
            if (!String.IsNullOrWhiteSpace(tfSearch.Text))
            {
                if (s.Equals("id"))
                {
                    listUsers = user.Fetch("WHERE id=@0 AND business_id=@1",
                        tfSearch.EditValue, Singleton.getCurrentBusiness().id);
                }
                else if (s.Equals("name"))
                {
                    listUsers = user.Fetch("WHERE full_name ILIKE @0 AND business_id=@1",
                        user.Concat(tfSearch.EditValue), Singleton.getCurrentBusiness().id);
                }
                if (s.Equals("cpf"))
                {
                    listUsers = user.Fetch("WHERE cpf=@0 AND business_id=@1", 
                        tfSearch.EditValue, Singleton.getCurrentBusiness().id);
                }
            }
            else
            {
                listUsers = user.Fetch("WHERE business_id=@0", Singleton.getCurrentBusiness().id);
            }
            bdgUsers.DataSource = listUsers;
            SplashScreenManager.CloseForm(false);
        }

        private void rgSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = rgSearch.EditValue.ToString();
            if (s.Equals("id"))
            {
                tfSearch.Properties.Mask.EditMask = "d";
                tfSearch.Properties.Mask.MaskType = MaskType.Numeric;
            }
            else if (s.Equals("name"))
            {
                tfSearch.Properties.Mask.EditMask = "";
                tfSearch.Properties.Mask.MaskType = MaskType.None;
            }
            else if (s.Equals("cpf"))
            {
                tfSearch.Properties.Mask.EditMask = "000.000.000-00";
                tfSearch.Properties.Mask.MaskType = MaskType.Simple;
            }
            tfSearch.Text = "";
            tfSearch.Focus();
            tfSearch.SelectAll();
        }

        private void tfSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string t = tfSearch.Text.Replace("_", "").Replace(".", "").Replace("-", "");
            if (rgSearch.EditValue.ToString().Equals("cpf") && t.Length == 11)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            btnSelect_Click(sender, e);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (bdgUsers.Current == null)
                return;
            UserForm uf = new UserForm((user)bdgUsers.Current);
            desk.AddTab(uf, "Edição de Usuário", true);
        }
    }
}
