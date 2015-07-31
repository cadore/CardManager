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
using CardManagerRepo;
using ModelsCardManager.Utils;
using System.IO;
using DevExpress.XtraSplashScreen;
using CardManager.UI.SplashScreens;
using ModelsCardManager;


namespace CardManager.UI.Customers
{
    public partial class CustomerForm : CardManager.UI.Utils.UserControlUtil
    {
        public CustomerForm(customer c)
        {
            try
            {
                SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
                address ad;
                InitializeComponent();
                ControlsUtil.SetBackColor(this.Controls);
                if (c == null)
                {
                    c = new customer();
                    ad = new address();
                    IsNew = true;
                }
                else
                {
                    IsNew = false;
                    ad = address.SingleOrDefault(c.address_id);
                    foreach (phones_customer pc in phones_customer.Fetch("WHERE customer_id=@0", c.id))
                        listPhones.Items.Add(pc.phone);
                    pePicture.Image = new FTPUtil().getImageFromFile(c.directory_picture);
                    cbOrganEmitter.EditValue = c.organ_emitter_rg.Split('/')[0];
                    cbStateRG.EditValue = c.organ_emitter_rg.Split('/')[1];
                }

                List<state> listS = state.Fetch("");
                bdgStates.DataSource = listS;
                foreach (state e in listS)
                    cbStateRG.Properties.Items.Add(e.symbol);
                bdgOrganEmitter.DataSource = organ_emitter.Fetch("");
                bdgAddress.DataSource = ad;
                bdgCustomer.DataSource = c;                

                Validations.ValidatorCPFCNPJ vcpf = new Validations.ValidatorCPFCNPJ() { ErrorText = "O CPF informado é inválido." };
                validatorCustomer.SetValidationRule(tfCPF, vcpf);
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

        private void btnSearchCPF_Click(object sender, EventArgs e)
        {
            /*
            //pnData.Enabled = true;
            if (!validatorCPF.Validate())
                return;
            try
            {
                //validações
                SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
                var countcpf = customer.repo.ExecuteScalar<string>("SELECT COUNT(id) FROM customers WHERE cpf=@0", tfCPF.EditValue);
                SplashScreenManager.CloseForm(false);
                if (!countcpf.Equals(DBNull.Value) && !String.IsNullOrEmpty(countcpf))
                {
                    if (Convert.ToInt32(countcpf) >= 1)
                    {
                        DialogResult rs = XtraMessageBox.Show("CPF já consta cadastrado, deseja carregar os dados?",
                            "Cadore Tecnologia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (rs == DialogResult.No)
                            return;
                        SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
                        customer cre = customer.SingleOrDefault("WHERE cpf=@0", tfCPF.EditValue);
                        address d = address.SingleOrDefault(cre.address_id);
                        bdgAddress.DataSource = d;
                        bdgCustomer.DataSource = cre;
                        
                        pnCPF.Enabled = false;
                        pnData.Enabled = true;
                        IsNew = false;
                        SplashScreenManager.CloseForm(false);
                        return;
                    }
                }

                SearchCPFCNPJUtil cc = new SearchCPFCNPJUtil();
                if (cc.Search(Document.CPF, Util.RemoveSpecialCharacters(tfCPF.Text)))
                {
                    customer cus = new customer() 
                    { 
                        name = cc.NOME,
                        cpf = cc.NCPF,
                        emission_card_at = null, 
                        inactive_at = null, 
                        registered_at = null, 
                        last_using = null,
                        validate_card = null, 
                        birthday = null 
                    };

                    bdgCustomer.DataSource = cus;
                    bdgAddress.DataSource = new address();
                    pnData.Enabled = true;
                    pnCPF.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm(false);
                pnData.Enabled = false;
                pnCPF.Enabled = true;
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
            */
        }

        private void tfBirthday_EditValueChanged(object sender, EventArgs e)
        {
            int age = Util.CalculateAge(customer.Now(), tfBirthday.DateTime);
            lbBirthday.Text = String.Format("Idade: {0} anos", age);
        }

        private void listPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPhones.Items.Count > 0)
                btnRemovePhone.Enabled = true;
            else
                btnRemovePhone.Enabled = false;
        }

        private void btnRemovePhone_Click(object sender, EventArgs e)
        {
            if (listPhones.Items.Count > 0)
            {
                if (IsNew)
                {
                    listPhones.Items.RemoveAt(listPhones.SelectedIndex);
                }
                else
                {
                    SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
                    phones_customer.Delete("WHERE phone=@0 AND customer_id=@1", listPhones.SelectedItem, tfId.EditValue);
                    listPhones.Items.Clear();
                    foreach (phones_customer pc in phones_customer.Fetch("WHERE customer_id=@0", tfId.EditValue))
                        listPhones.Items.Add(pc.phone);
                    SplashScreenManager.CloseForm(false);
                }
            }                
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            if (tfPhone.Text.Replace("_", "").Length == 13)
            {                
                if (!listPhones.Items.Contains(tfPhone.Text))
                    listPhones.Items.Add(tfPhone.Text);
                tfPhone.Text = "";
                tfPhone.Focus();

            }
            else
            {
                XtraMessageBox.Show("Informe o telefone para adicionar", "Cadore Tecnologia");
                tfPhone.Focus();
                return;
            }
        }

        private void tfPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAddPhone_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void OpenImage_DoubleClick(object sender, EventArgs e)
        {            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Escolha a foto do cliente";
            ofd.Filter = "All files (*.*)|*.*";
            ofd.Multiselect = false;
            DialogResult rs = ofd.ShowDialog();
            if (rs != DialogResult.OK)
                return;
            SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
            pePicture.Image = null;
            FileInfo fileInfo = new FileInfo(ofd.FileName);
            if (fileInfo.Extension == ".jpg" || fileInfo.Extension == ".jpeg" || fileInfo.Extension == ".png")
            {
                pePicture.Image = Image.FromFile(fileInfo.FullName);
                pePicture.Image.Tag =  "Image";
                SplashScreenManager.CloseForm(false);
            }
            else
            {
                SplashScreenManager.CloseForm(false);
                XtraMessageBox.Show("Imagem inválida, por favor selecione uma imagem válida, no formato JPG ou PNG.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!validatorCustomer.Validate())
                return;
            if (listPhones.ItemCount == 0)
            {
                XtraMessageBox.Show("Informe no mínimo 1 numero de contato para o cliente");
                return;
            }
            if (pePicture.Image == null)
            {
                XtraMessageBox.Show("Selecione a Imagem do Cliente");
                OpenImage_DoubleClick(sender, e);
                return;
            }
            using (var scope = customer.repo.GetTransaction())
            {
                try
                {
                    Console.WriteLine(0);
                    SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
                    FTPUtil ftp = new FTPUtil();
                    customer c = (customer)bdgCustomer.Current;
                    address ad = (address)bdgAddress.Current;
                    Console.WriteLine(1);
                    ad.Save();
                    Console.WriteLine(2);
                    if (IsNew)
                        c.registered_at = credentialed.Now();
                    Console.WriteLine(3);
                    c.address_id = ad.id;
                    string localFile = ftp.dirCustomers + Util.RemoveSpecialCharacters(c.cpf) + ".jpg";
                    Console.WriteLine(4);
                    if (pePicture.Image.Tag != null && !String.Equals(pePicture.Image.Tag, "ERROR"))
                        ftp.uploadImage(localFile, pePicture.Image);
                    c.directory_picture = localFile;
                    Console.WriteLine(5);
                    c.organ_emitter_rg = String.Format("{0}/{1}", cbOrganEmitter.Text, cbStateRG.Text);
                    Console.WriteLine(6);
                    c.business_id = Singleton.getCurrentBusiness().id;
                    c.registred_by = Singleton.getCurrentUser().id;
                    c.Save();
                    Console.WriteLine(7);
                    foreach (string s in listPhones.Items)
                    {
                        phones_customer pc = new phones_customer() 
                        { 
                            customer_id = c.id,
                            phone = s 
                        };
                        if (pc.IsNew())
                            pc.Save();
                    }
                    Console.WriteLine(8);
                    scope.Complete();
                    Console.WriteLine(9);
                    tfId.EditValue = c.id;
                    tfRegistredAt.EditValue = c.registered_at;
                    if (this.MessageToSave("Cliente"))
                        desk.AddTabAndCloseCurrent(new CustomerForm(null), "Novo cliente", false);

                }
                catch (Exception ex)
                {
                    customer.repo.AbortTransaction();
                    XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
                }
                finally
                {
                    SplashScreenManager.CloseForm(false);
                }
            }
        }        

        private void tfCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchCPF_Click(sender, e);
        }

        private void cbStateAddress_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
                bdgCity.DataSource = city.Fetch("WHERE state_id=@0", cbStateAddress.EditValue);
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

        private void cbCity_EditValueChanged(object sender, EventArgs e)
        {            
            /*try
            {
                SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
                if (Convert.ToInt64(cbCity.EditValue) > 0)
                {
                    city c = city.SingleOrDefault(cbCity.EditValue);
                    if (!String.IsNullOrEmpty(c.zip_code))
                    {
                        tfCep.EditValue = c.zip_code;
                        ((address)bdgAddress.Current).cep = c.zip_code;
                    }                        
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro.\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }*/
        }
    }
}
