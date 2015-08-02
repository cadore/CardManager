using CardManager.Connection;
using CardManager.UI;
using CardManager.UI.Login;
using CardManager.UI.SplashScreens;
using CardManagerRepo;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using ModelsCardManager;
using ModelsCardManager.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardManager
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Office 2013"); //Office 2013 //The Asphalt World
            verefyProcesses();
            SplashScreenManager.ShowForm(null, typeof(SplashScreenForm), false, false, false);
            startConnection();            
            login();          
        }

        private static void login()
        {
            LoginForm lf = new LoginForm();
            DialogResult dr = lf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Console.WriteLine(business.Now());
                Application.Run(new DesktopForm());
            }
            else
            {
                Exit(1);
            }
        }

        private static void verefyProcesses()
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                XtraMessageBox.Show("Já existe uma instância em execução, verifique!", "Atenção");
                Exit(-1);
            }
        }

        private static void startConnection()
        {            
            try
            {
                bool web;

                if (Environment.MachineName == "CADORE-NOTE")
                    web = true;
                else
                    web = Util.isConnectedWeb();

                if (!web)
                {
                    XtraMessageBox.Show("Sem conexão com a internet, verifique o seu status com a internet e tente novamente.");
                    Exit(-1);
                }
                else
                {
                    new ConnectionUtil();
                }                
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro ao tentar conectar\n\n{0}\n{1}", ex.Message, ex.InnerException));
                Exit(-1);
            }
        }

        static void Exit(int exit)
        {
            Environment.Exit(exit);
        }
    }
}
