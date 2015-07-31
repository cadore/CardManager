using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardManagerRepo;
using ModelsCardManager;
using DevExpress.XtraEditors;

namespace CardManager.UI.Inputs
{
    public partial class InputForm : CardManager.UI.Utils.UserControlUtil
    {
        public InputForm(input i)
        {
            InitializeComponent();
            this.dateDateEdit.Properties.MaxValue = input.Now();
            if (i == null)
            {
                i = new input() { date = null };
                IsNew = true;
            }                
            bdgInput.DataSource = i;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            try
            {
                input i = (input)bdgInput.Current;
                i.registred_at = input.Now();
                i.registred_by = Singleton.getCurrentUser().id;
                i.Save();
                if (MessageToSave("Entrada"))
                    desk.AddTabAndCloseCurrent(new InputForm(null), "Entrada Avulsa", false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
        }
    }
}
