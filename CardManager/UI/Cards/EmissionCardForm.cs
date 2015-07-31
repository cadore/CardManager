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
using CardManagerRepo;
using ModelsCardManager.Utils;
using CardManager.Utils;
using ModelsCardManager;
using CardManager.UI.Cards.BarCode;
using DevExpress.XtraSplashScreen;
using CardManager.UI.SplashScreens;

namespace CardManager.UI.Cards
{
    public partial class EmissionCardForm : DevExpress.XtraEditors.XtraForm
    {
        public EmissionCardForm()
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            pnData.Enabled = false;
            lbStatusCard.Text = "";
            loadCustomers();
        }

        private void loadCustomers()
        {
            try
            {
                bdgCustomers.DataSource = customer.Fetch("WHERE business_id=@0", Singleton.getCurrentBusiness().id);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro ao tentard recuperar a lista de clientes.\n\n{0}\n{1}", 
                    ex.Message, ex.InnerException));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SearchCustomer(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
                if (cbCustomer.EditValue == null)
                    return;
                customer c = customer.SingleOrDefault(cbCustomer.EditValue);
                bdgInfoCard.DataSource = c;
                if (c.card_emitted)
                {
                    if (Convert.ToDateTime((c.validate_card)) < customer.Now())
                    {
                        lbStatusCard.Text = "Vencido";
                        lbStatusCard.ForeColor = Color.Red;
                        tfValidateAt.ForeColor = Color.Red;
                        btnEmitterCard.Text = "Renovar Cartão";
                        btnEmitterCard.Enabled = true;
                    }
                    else
                    {
                        lbStatusCard.Text = "Válido";
                        lbStatusCard.ForeColor = Color.Blue;
                        tfValidateAt.ForeColor = Color.Blue;
                        btnEmitterCard.Enabled = false;
                        btnExportCodeBar.Enabled = true;
                    }
                    if (c.validate_card != null)
                    {
                        tfValidateAt.EditValue = c.validate_card;
                        tfValidateAt.Properties.MaxValue = Convert.ToDateTime(c.emission_card_at).AddYears(1);
                    }
                    else
                    {
                        DateTime newyear = customer.Now().AddYears(1);
                        tfValidateAt.EditValue = newyear;
                        tfValidateAt.Properties.MaxValue = newyear;
                    }
                }                    
                else
                {
                    lbStatusCard.Text = "";
                    lbStatusCard.ForeColor = Color.Black;
                    btnEmitterCard.Enabled = true;
                    DateTime newyear = customer.Now().AddYears(1);
                    tfValidateAt.EditValue = newyear;
                    tfValidateAt.Properties.MaxValue = newyear;
                }

                pePicture.Image = new FTPUtil().getImageFromFile(c.directory_picture);
                if (c.inactive)
                {
                    lbStatusCard.Text = "Inativo";
                    lbStatusCard.ForeColor = Color.Red;
                    tfValidateAt.ForeColor = Color.Red;
                    XtraMessageBox.Show("Este cliente esta Inativo, carregado somente para visualização.");
                    btnEmitterCard.Enabled = false;
                    btnExportCodeBar.Enabled = false;
                    return;
                }
                pnData.Enabled = true;                
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

        private void btnEmitterCard_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
                customer c = customer.SingleOrDefault(cbCustomer.EditValue);

                if (Convert.ToDecimal(tfValueCard.EditValue) <= 0)
                {
                    DialogResult rs = XtraMessageBox.Show(String.Format("Confirma a {0} do cartão em R$0,00?",
                        (c.card_emitted ? "renovação" : "emissão")), "Confirmação",
                        MessageBoxButtons.OKCancel);
                    if (rs == DialogResult.Cancel)
                        return;
                }

                DialogResult cc = XtraMessageBox.Show(String.Format("Confirma a {0} do cartão para o cliente {1}?", 
                    (c.card_emitted ? "renovação" : "emissão"), c.name), "Confirmação", MessageBoxButtons.OKCancel);
                if (cc == DialogResult.Cancel)
                    return;

                using(var scope = customer.repo.GetTransaction())
                {
                    c.name = c.name.TrimStart().TrimEnd();
                    if (c.card_emitted == false)
                    {
                        c.emission_card_at = customer.Now();
                        c.emission_card_by = Singleton.getCurrentUser().id;
                    }
                    
                    c.validate_card = Convert.ToDateTime(tfValidateAt.EditValue);
                    c.value_card = Convert.ToDecimal(tfValueCard.EditValue);
                    c.CreateCardCode();
                    c.card_emitted = true;
                    if (c.value_card > 0)
                    {
                        /*
                        input i = new input()
                        { 
                            description = String.Format("Recebimento referente á {0} do cartão {1} de cliente {2}-{3}",
                                (c.card_emitted ? "renovação" : "emissão"), c.barcode, c.id, c.name),
                            observation = String.Format("Valor referente á {0} do cartão {1} do cliente {2}\n----------\n{3}\n(Automático)", 
                                (c.card_emitted ? "renovação" : "emissão"), c.barcode, c.id, c.observation),
                            credentialed_id = 0, 
                            customer_id = c.id, 
                            date = input.Now(), 
                            value = c.value_card, 
                            registred_at = input.Now(), 
                            registred_by = UserSingleton.getCurrentUser().id
                        };
                        i.Save();
                        */
                    }
                    c.Save();
                    scope.Complete();
                    bdgInfoCard.Clear();
                    bdgInfoCard.DataSource = c;

                    btnExportCodeBar.Enabled = true;
                    btnEmitterCard.Enabled = false;
                    SearchCustomer(sender, e);                    
                }
            }
            catch (Exception ex)
            {
                customer.repo.AbortTransaction();
                XtraMessageBox.Show(String.Format("Ocorreu um erro na tentativa da emissão/renovação do cartão\n\n{0}\n{1}", 
                    ex.Message, ex.InnerException));
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        private void btnExportCodeBar_Click(object sender, EventArgs e)
        {
            BarCodeForm bcf = new BarCodeForm((customer)bdgInfoCard.Current);
            bcf.ShowDialog();
        }
    }
}