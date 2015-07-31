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
using ModelsCardManager.Utils;

namespace CardManager.UI.Helper
{
    public partial class NeedHelpForm : DevExpress.XtraEditors.XtraForm
    {
        public NeedHelpForm()
        {
            InitializeComponent();
            ControlsUtil.SetBackColor(this.Controls);
            tfTextHelp.Text = INI.ReadValue("SYSTEM", "MessageHelp");
            tfTextHelp.Properties.ReadOnly = true;
        }
    }
}