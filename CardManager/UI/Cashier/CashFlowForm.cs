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

namespace CardManager.UI.Cashier
{
    public partial class CashFlowForm : CardManager.UI.Utils.UserControlUtil
    {
        public CashFlowForm()
        {
            InitializeComponent();
            DateTime now = input.Now();
            tfStart.DateTime = new DateTime(now.Year, now.Month, 01);
            tfEnd.DateTime = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month));
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

            List<cash_flow> cf = new List<cash_flow>();
            List<input> lInputs = input.Fetch(sql);
            List<output> lOutput = output.Fetch(sql);

            foreach (input i in lInputs)
                Console.WriteLine(i.description);
            foreach (output i in lOutput)
                Console.WriteLine(i.description);
        }
    }    
}
