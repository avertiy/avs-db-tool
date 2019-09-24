using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using AV.WinForms.Common;
using DatabaseDiscoveryTool.UI.WinForms.Controllers;
using DatabaseDiscoveryTool.UI.WinForms.Models;
using DatabaseDiscoveryTool.UI.WinForms.Views;

namespace DatabaseDiscoveryTool.UI.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);

            if (!hasAdministrativeRight)
            {
                if (RunElevated(Application.ExecutablePath))
                {
                    Application.Exit();
                    return;
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitializeObjectStateManager();
            ISearchConditionsTabView view = new Form1();
            IController controller = new SearchConditionsController(view);
            controller.InitializeView();
            view.SetSelected();
            Application.Run((Form)view);
            //controller.LoadView();
            //view.ShowDialog();

        }

        private static bool RunElevated(string fileName)
        {
            //MessageBox.Show("Run: " + fileName);
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.Verb = "runas";
            processInfo.FileName = fileName;
            try
            {
                Process.Start(processInfo);
                return true;
            }
            catch (Win32Exception)
            {
                //Do nothing. Probably the user canceled the UAC window
            }
            return false;
        }
        
        private static void InitializeObjectStateManager()
        {
            var axconn = "Data Source=AXS-SQL.K3-DEV.local;Initial Catalog=AXS_REA_R3V26_ChannelDatabase;User Id=Realize;Password=Test123!;MultipleActiveResultSets=True";
            var nopconn ="Data Source=AVE;Initial Catalog=Nop_3_20R2_AX;Integrated Security=True;MultipleActiveResultSets=True";
            var youshoesconn = "Data Source=184.173.188.68,780;Initial Catalog=artemv2015_YourShoes;Integrated Security=False;User ID=artemv2015_iisuser;Connect Timeout=10;Encrypt=False;Packet Size=4096;Password=mSe1i7?5";


            ObjectStateManager.Set<UserSettings>(new UserSettings
            {
                ConnectionString1 = nopconn,
                ConnectionString2 = axconn,
                ConnectionString3 = youshoesconn,
                DefaultProfileName = "http://localhost:4002/ (Realize-TEST)"
            });
            ObjectStateManager.Set<SearchConditions>(new SearchConditions() { Search1 = "keyword" });


            var profile1 = new DeploymentProfile()
            {
                ProfileName = "http://localhost:4002/ (Realize-TEST)",
                ApplicationPoolName = "Realize-TEST",
                TargetSiteName = "Realize-TEST",
                TargetLocation = "",
                SourceLocation = "",
                CleanupTempAspnetFiles = true,
                RestartSite = true,
                CopyPlugins = true,
                CopyBinFolderFiles = true,
                CopyAllFiles = false
            };
            var profile2 = new DeploymentProfile()
            {
                ProfileName = "http://rea-web-dev.k3-dev.local:8050/ (Realize-DEV)",
                ApplicationPoolName = "Realize-DEV",
                TargetSiteName = "Realize-DEV",
                TargetLocation = "",
                SourceLocation = "",
                CleanupTempAspnetFiles = true,
                RestartSite = true,
                CopyPlugins = true,
                CopyBinFolderFiles = true,
                CopyAllFiles = false
            };
            var profile3 = new DeploymentProfile()
            {
                ProfileName = "http://rea-web-dev.k3-dev.local:8051/ (Realize-TEST)",
                ApplicationPoolName = "Realize-TEST",
                TargetSiteName = "Realize-TEST",
                TargetLocation = "",
                SourceLocation = "",
                CleanupTempAspnetFiles = true,
                RestartSite = true,
                CopyPlugins = true,
                CopyBinFolderFiles = true,
                CopyAllFiles = false
            };
            ObjectStateManager.Set<ProfilesCollection>(new ProfilesCollection() { profile1, profile2, profile3 });
        }
    }
}
