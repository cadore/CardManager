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
using CardManager.Utils;
using System.IO;
using CardManagerRepo;
using ModelsCardManager.Utils;
using DevExpress.XtraSplashScreen;
using CardManager.UI.SplashScreens;
using ModelsCardManager;
using CardManager.Utils.CPFCNPJ;
using CardManager.UI.Credentialeds.Payments;

namespace CardManager.UI.Credentialeds
{
    public partial class CredentialedForm : CardManager.UI.Utils.UserControlUtil
    {
        address _address;
        public CredentialedForm(credentialed c)
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            try
            {
                SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
                if (c == null)
                {
                    c = new credentialed();
                    _address = new address();
                    btnInactive.Enabled = false;
                    IsNew = true;
                }
                else
                {                
                    peLogo.Image = new FTPUtil().getImageFromFile(c.directory_logo);
                    pCNPJ.Enabled = false;
                    _address = address.SingleOrDefault(c.address_id);
                    pData.Enabled = true;

                    if (c.inactive)
                    {
                        btnInactive.Visible = false;
                        btnSave.Visible = false;
                        //pData.Enabled = false;
                    }
                    else
                        btnReceivePayment.Enabled = true;
                    IsNew = false;
                }

                bdgStates.DataSource = state.Fetch("");

                bdgCredentialed.DataSource = c;
                bdgAddress.DataSource = _address;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
                btnSave.Enabled = false;
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        private void btnSearchCNPJ_Click(object sender, EventArgs e)
        {
            if (!validatorCNPJ.Validate())
                return;
            try
            {
                //validações
                var countcnpj = credentialed.repo.ExecuteScalar<string>("SELECT COUNT(id) FROM credentialeds WHERE cnpj=@0", 
                    tfCNPJ.EditValue);
                if (!countcnpj.Equals(DBNull.Value) && !String.IsNullOrEmpty(countcnpj))
                {
                    if (Convert.ToInt32(countcnpj) >= 1)
                    {
                        DialogResult rs = XtraMessageBox.Show("CNPJ já consta cadastrado, deseja carregar os dados?", 
                            "Cadore Tecnologia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (rs == DialogResult.No)
                            return;
                        credentialed cre = credentialed.SingleOrDefault("WHERE cnpj=@0", tfCNPJ.EditValue);
                        bdgAddress.DataSource = address.SingleOrDefault(cre.address_id);
                        bdgCredentialed.DataSource = cre;
                        peLogo.Image = new FTPUtil().getImageFromFile(cre.directory_logo);
                        pCNPJ.Enabled = false;
                        pData.Enabled = true;
                        IsNew = false;
                        return;
                    }
                }
                SearchCPFCNPJUtil cc = new SearchCPFCNPJUtil();
                if (cc.Search(Document.CNPJ, tfCNPJ.Text))
                {
                    credentialed cre = new credentialed() { registered_at = null, inactived_at = null };
                    address d = new address();

                    cre.cnpj = cc.NCNPJ;
                    cre.company_name = cc.RAZAOSOCIAL;
                    cre.fantasy_name = cc.FANTASIA;
                    cre.opening_at = Convert.ToDateTime(cc.ABERTURA);                    
                    d.name = cc.ENDERECO;
                    d.number = cc.NUMERO;
                    d.complement = cc.COMPLEMENTO;
                    d.district = cc.BAIRRO;
                    d.cep = cc.CEP;
                    state st = state.SingleOrDefault("WHERE symbol=@0", cc.UF);
                    d.state_id = st != null ? st.id : 0;
                    List<city> lci = city.Fetch("WHERE name ILIKE @0 AND state_id=@1", city.Concat(cc.CIDADE), st.id);
                    d.city_id = lci[0] != null ? lci[0].id : 0;

                    string[] f = cc.TELEFONE.Replace(" ", "").Split('/');
                    if (f.Length >= 1)
                        cre.phone_fixed = f[0];
                    if (f.Length >= 2)
                        cre.phone_mobile = f[1];

                    bdgAddress.DataSource = d;
                    bdgCredentialed.DataSource = cre;

                    pCNPJ.Enabled = false;
                    pData.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
        }

        private void tfDirectoryLogo_Leave(object sender, EventArgs e)
        {
            /*try
            {
                peLogo.Image = null;
                if (!String.IsNullOrWhiteSpace(tfDirectoryLogo.EditValue.ToString()))
                {                    
                    peLogo.ImageLocation = (tfDirectoryLogo.EditValue.ToString());
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }*/
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void lbViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckViewPassword.Checked)
                tfPassword.Properties.UseSystemPasswordChar = false;
            else
                tfPassword.Properties.UseSystemPasswordChar = true;
        }

        private void tfCNPJ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchCNPJ_Click(sender, e);
        }

        private void cbState_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
                bdgCity.DataSource = city.Fetch("WHERE state_id=@0 ORDER BY name", cbState.EditValue);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro.\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }            
        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
            DialogResult rs = XtraMessageBox.Show("Tem certeza que deseja inativar este credenciado?"
                + "\nNão sera possivel reverter esta ação!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    credentialed c = ((credentialed)bdgCredentialed.Current);
                    c.inactive = true;
                    c.inactived_at = credentialed.Now();
                    c.Update();
                    XtraMessageBox.Show("Credenciado inativado com sucesso!");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
                }
            }
        }

        private void OpenLogo_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files (*.*)|*.*";
            ofd.Title = "Selecione a logo do Credenciado";
            ofd.Multiselect = false;
            DialogResult rs = ofd.ShowDialog();
            if (rs != DialogResult.OK)
                return;
            peLogo.Image = null;
            FileInfo fileInfo = new FileInfo(ofd.FileName);
            if (fileInfo.Extension == ".jpg" || fileInfo.Extension == ".jpeg" || fileInfo.Extension == ".png")
            {
                Image i = Image.FromFile(fileInfo.FullName);
                if (i.Width == 250 && i.Height == 150)
                {
                    peLogo.Image = i;
                    peLogo.Image.Tag = "Image";
                    lbFileLogo.Text = fileInfo.FullName;
                }
                else
                {
                    XtraMessageBox.Show("Imagem inválida, por favor selecione uma imagem válida, no tamanho de 250X150.");
                    lbFileLogo.Text = "Nenhum arquivo selecionado";
                }
            }
            else
            {                
                XtraMessageBox.Show("Imagem inválida, por favor selecione uma imagem válida, no formato JPG ou PNG.");
                lbFileLogo.Text = "Nenhum arquivo selecionado";
            }                
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            if (lbFileLogo.Text.Equals("Nenhum arquivo selecionado") && Convert.ToInt64(tfId.EditValue) == 0)
            {
                XtraMessageBox.Show("Selecione a Logo do Credenciado");
                OpenLogo_DoubleClick(sender, e);
                return;
            }

            using (var scope = credentialed.repo.GetTransaction())
            {
                try
                {
                    credentialed c = (credentialed)bdgCredentialed.Current;
                    FTPUtil ftp = new FTPUtil();
                    address ad = ((address)bdgAddress.Current);                                       
                    ad.Save();                    
                    if(IsNew)
                        c.registered_at = credentialed.Now();
                    c.address_id = ad.id;
                    c.business_id = Singleton.getCurrentBusiness().id;
                    string localFile = ftp.dirCredentialeds + Util.RemoveSpecialCharacters(c.cnpj) + ".jpg";
                    if(peLogo.Image.Tag != null && !String.Equals(peLogo.Image.Tag, "ERROR"))
                        ftp.uploadImage(localFile, peLogo.Image);
                    c.directory_logo = localFile;
                    if (String.IsNullOrEmpty(tfPassword.EditValue.ToString()))
                        c.password = Util.RemoveSpecialCharacters(c.cnpj);
                    c.Save();
                    scope.Complete();
                    tfId.EditValue = c.id;
                    tfRegisteredAt.EditValue = c.registered_at;
                    if (this.MessageToSave("Credenciado"))
                        desk.AddTabAndCloseCurrent(new CredentialedForm(null), "Novo credenciado", false);
                        
                }
                catch (Exception ex)
                {
                    credentialed.repo.AbortTransaction();
                    XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
                }
            }
        }

        private void btnReceivePayment_Click(object sender, EventArgs e)
        {
            DateTime now = receipts_credentialeds.Now();
            credentialed cre = (credentialed)bdgCredentialed.Current;
            receipts_credentialeds rc = new receipts_credentialeds() 
            { 
                credentialed_id =  cre.id, 
                credentialed_name = cre.company_name, 
                date = now, 
                month = now.Month, 
                year = now.Year
            };
            NewPaymentForm npf = new NewPaymentForm(rc);
            npf.ShowDialog();
        }
    }
}
