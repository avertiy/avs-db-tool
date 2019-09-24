using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Web.Administration;
namespace DatabaseDiscoveryTool.UI.WinForms
{
    public static class IISHelper
    {
        private static List<string> _sites;
        private static List<string> _pools;
        
        public static void RestartActiveSites()
        {
            var server = new ServerManager();
            foreach (var site in server.Sites)
            {
                if (site.State == ObjectState.Started)
                {
                    site.Stop();
                    site.Start();
                }
            }
        }
        public static void StopActiveSites()
        {
            var server = new ServerManager();

            _sites = new List<string>();

            foreach (var site in server.Sites)
            {
                if (site.State == ObjectState.Started)
                {
                    _sites.Add(site.Name);
                    site.Stop();
                }
            }
        }

        public static void RecyclePools()
        {
            var server = new ServerManager();
            foreach (var pool in server.ApplicationPools)
            {
                try
                {
                    if (pool.State == ObjectState.Started)
                    {
                        pool.Recycle();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't recycle app pool:" + pool.Name + " [state: " + pool.State + "]");
                }
            }
        }

        public static void StartSites()
        {
            var server = new ServerManager();
            
            if (_sites != null && _sites.Count > 0)
            {
                foreach (var site in server.Sites.Where(s => _sites.Contains(s.Name)))
                {
                    if (site.State == ObjectState.Stopped)
                    {
                        site.Start();
                    }
                }
            }
            _sites = null;
        }
    }
}