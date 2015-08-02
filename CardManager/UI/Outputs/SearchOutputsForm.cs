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

namespace CardManager.UI.Outputs
{
    public partial class SearchOutputsForm : CardManager.UI.Utils.UserControlUtil
    {
        public SearchOutputsForm()
        {
            InitializeComponent();
            DateTime now = input.Now();
            tfStart.DateTime = new DateTime(now.Year, now.Month, 01);
            tfEnd.DateTime = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (bdgOutput.Current != null)
            {
                OutputForm of = new OutputForm((output)bdgOutput.Current);
                desk.AddTab(of, "Editar Saida", true);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!ckAll.Checked)
                if (!validator.Validate())
                    return;
            string sql = "";
            if (!ckAll.Checked)
                sql += String.Format("WHERE date BETWEEN to_date('{0:yyyy-MM-dd}', 'yyyy-MM-dd') AND to_date('{1:yyyy-MM-dd}', 'yyyy-MM-dd')", tfStart.DateTime, tfEnd.DateTime);
            sql += "ORDER BY date";
            bdgOutput.DataSource = output.Fetch(sql);
        }

        private void tfStard_EditValueChanged(object sender, EventArgs e)
        {
            tfEnd.Properties.MinValue = tfStart.DateTime;
        }

        private void tfEnd_EditValueChanged(object sender, EventArgs e)
        {
            tfStart.Properties.MaxValue = tfEnd.DateTime;
        }

        private void ckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAll.Checked)
            {
                tfStart.EditValue = null;
                tfEnd.EditValue = null;
                tfStart.Properties.ReadOnly = true;
                tfEnd.Properties.ReadOnly = true;
                validator.RemoveControlError(tfStart);
                validator.RemoveControlError(tfEnd);
            }
            else
            {
                tfStart.Properties.ReadOnly = false;
                tfEnd.Properties.ReadOnly = false;
            }
        }
    }
}
