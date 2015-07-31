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
using CardManager.UI.Utils;
using CardManagerRepo;
using DevExpress.XtraEditors.Mask;
using ModelsCardManager;

namespace CardManager.UI.Credentialeds
{
    public partial class SearchCredentialedsForm : UserControlUtil
    {
        public SearchCredentialedsForm()
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            rgSearch.EditValue = "name";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<credentialed> listCred = null;

            string s = rgSearch.EditValue.ToString();
            if (s.Equals("name"))
            {
                listCred = credentialed.Fetch("SELECT * FROM credentialeds WHERE company_name ILIKE @0 AND business_id=@1"
                + " UNION SELECT * FROM credentialeds WHERE fantasy_name ILIKE @0 AND business_id=@1",
                credentialed.Concat(tfSearch.EditValue), Singleton.getCurrentBusiness().id);
            }
            else
            {
                listCred = credentialed.Fetch("WHERE cnpj=@0 AND business_id=@1",
                    tfSearch.Text, Singleton.getCurrentBusiness().id);
            }
            
            bdgCredentialeds.DataSource = listCred;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(bdgCredentialeds.Current == null)
                return;
            CredentialedForm cf = new CredentialedForm(((credentialed)bdgCredentialeds.Current));
            desk.AddTab(cf, "Edição de Credenciado", true);
        }

        private void rgSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = rgSearch.EditValue.ToString();
            if (s.Equals("name"))
            {
                tfSearch.Text = "";
                tfSearch.Properties.Mask.EditMask = "";
                tfSearch.Properties.Mask.MaskType = MaskType.None;
            }
            else
            {
                tfSearch.Text = "";
                tfSearch.Properties.Mask.EditMask = "00.000.000/0000-00";
                tfSearch.Properties.Mask.MaskType = MaskType.Simple;
            }
            tfSearch.Focus();
        }

        private void tfSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, e);
        }
    }
}
