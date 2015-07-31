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

namespace CardManager.UI.Credentialeds.Payments
{
    public partial class NewPaymentForm : DevExpress.XtraEditors.XtraForm
    {
        public NewPaymentForm(receipts_credentialeds rc)
        {
            InitializeComponent();
            if (rc == null)
                rc = new receipts_credentialeds();
            bdgReceipts.DataSource = rc;
        }

        private void NewPaymentForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnCancel_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            try
            {
                receipts_credentialeds rc = (receipts_credentialeds)bdgReceipts.Current;
                rc.Save();                
                this.DialogResult = DialogResult.OK;
                XtraMessageBox.Show("Pagamento recebido com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Abort;
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
        }
    }
}