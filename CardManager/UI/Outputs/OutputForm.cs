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
using DevExpress.XtraEditors;

namespace CardManager.UI.Outputs
{
    public partial class OutputForm : CardManager.UI.Utils.UserControlUtil
    {
        public OutputForm(output o)
        {
            InitializeComponent();
            loadReasons();
            if (o == null)
            {
                o = new output() { date = null };
                IsNew = true;
            }
            tfDate.Properties.MaxValue = output.Now();
            bdgOutput.DataSource = o;
        }

        void loadReasons()
        {
            cbDescription.Properties.Items.Clear();
            foreach (reasons_outputs ro in reasons_outputs.Fetch("ORDER BY description"))
                cbDescription.Properties.Items.Add(ro.description);
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
                output op = (output)bdgOutput.Current;
                op.registred_at = output.Now();
                op.registred_by = Singleton.getCurrentUser().id;
                op.Save();
                if (MessageToSave("Saida"))
                    desk.AddTabAndCloseCurrent(new OutputForm(null), "Nova Saida", false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n\n{0}\n{1}", ex.Message, ex.InnerException));
            }
        }

        private void btnAddDescription_Click(object sender, EventArgs e)
        {
            AddReasonOutputForm ar = new AddReasonOutputForm();
            DialogResult rs = ar.ShowDialog();
            if (rs == DialogResult.OK)
                loadReasons();
        }
    }
}
