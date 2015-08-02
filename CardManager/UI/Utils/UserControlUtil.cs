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
using ModelsCardManager;
using DevExpress.XtraSplashScreen;
using CardManager.UI.SplashScreens;

namespace CardManager.UI.Utils
{
    public partial class UserControlUtil : DevExpress.XtraEditors.XtraUserControl
    {
        public static DesktopForm desk = null;
        protected bool IsNew;
        public UserControlUtil()
        {
            SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        protected bool MessageToSave(string s)
        {
            if (IsNew)
            {
                DialogResult rs = XtraMessageBox.Show(String.Format("{0} salvo(a) com sucesso, deseja cadastrar um(a) novo(a)?", s), "Cadore Tecnologia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                    return true;
            }
            else
            {
                XtraMessageBox.Show(String.Format("{0} atualizado(a) com sucesso", s), "Cadore Tecnologia");
            }
            desk.CloseCurrentTab();
            return false;
        }
    }
}
