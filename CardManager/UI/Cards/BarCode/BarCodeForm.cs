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
using System.IO;
using System.Diagnostics;

namespace CardManager.UI.Cards.BarCode
{
    public partial class BarCodeForm : DevExpress.XtraEditors.XtraForm
    {
        public BarCodeForm(customer c)
        {
            InitializeComponent();
            barCode.BarCode = c.barcode;
            lbCod.Text = c.barcode;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Escolha a pasta para salvar o Código de Barras";
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string image = String.Format(@"{0}\{1}.png", fbd.SelectedPath, barCode.BarCode);
                barCode.SaveImage(image);
                DialogResult rs = XtraMessageBox.Show("Código de barras exportado com sucesso, deseja abrir a pasta destino?", "Cadore Tecnologia",
                    MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    Process.Start("Explorer", fbd.SelectedPath);
                }
                this.Close();
            }                        
        }

        private void BarCodeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnExit_Click(sender, e);
            else if (e.KeyCode == Keys.Enter)
                btnExport_Click(sender, e);
        }
    }
}