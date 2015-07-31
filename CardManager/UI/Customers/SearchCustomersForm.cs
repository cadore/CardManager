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
using DevExpress.XtraSplashScreen;
using CardManager.UI.SplashScreens;
using ModelsCardManager;
using CardManagerRepo;

namespace CardManager.UI.Customers
{
    public partial class SearchCustomersForm : CardManager.UI.Utils.UserControlUtil
    {
        public SearchCustomersForm()
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            rgTypeSearch.EditValue = "name";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
                List<customer> listC = null;
                if (tfSearch.Text.Length > 0)
                {
                    string typeSearch = rgTypeSearch.EditValue.ToString();
                    if (typeSearch.Equals("name"))
                        listC = customer.Fetch("WHERE name ILIKE @0 AND business_id=@1 ORDER BY name", 
                            customer.Concat(tfSearch.EditValue), Singleton.getCurrentBusiness().id);
                    else
                        listC = customer.Fetch("WHERE barcode=@0 AND business_id=@1 ORDER BY name", 
                            tfSearch.EditValue, Singleton.getCurrentBusiness().id);
                }
                else
                {
                    listC = customer.Fetch("WHERE business_id=@0 ORDER BY name", Singleton.getCurrentBusiness().id);
                }
                bdgCustomers.DataSource = listC;
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

        private void rgTypeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            tfSearch.Focus();
            tfSearch.SelectAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            desk.CloseCurrentTab();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            customer c = (customer)bdgCustomers.Current;
            if (c != null)
            {
                CustomerForm cf = new CustomerForm(c);
                desk.AddTab(cf, "Edição de Cliente", true);
            }
        }
    }
}
