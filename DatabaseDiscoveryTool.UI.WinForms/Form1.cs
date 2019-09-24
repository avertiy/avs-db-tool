using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AV.WinForms.Common;
using AV.WinForms.Common.Forms;
//using Alba.CsCss.Style;
using DatabaseDiscoveryTool.UI.WinForms.Controllers;
//using DatabaseDiscoveryTool.UI.WinForms.Css;
using DatabaseDiscoveryTool.UI.WinForms.Helpers;
using DatabaseDiscoveryTool.UI.WinForms.Menu;
using DatabaseDiscoveryTool.UI.WinForms.Models;
using DatabaseDiscoveryTool.UI.WinForms.Utils;
using DatabaseDiscoveryTool.UI.WinForms.Views;
//using ExCSS;

namespace DatabaseDiscoveryTool.UI.WinForms
{
    public partial class Form1 : Form, ISearchConditionsTabView
    {
        private ConsoleWindow _consoleWindow;
        public Form1()
        {
            InitializeComponent();
            menuStrip1.Renderer = new NativeRenderer(ToolbarTheme.MediaToolbar);
            _consoleWindow = new ConsoleWindow();
            this.toolStripStatusLabel1.Text =String.Empty;
        }

        

        #region Settings tab
        private void btnLoadSettings_Click(object sender, EventArgs e)
        {
            var settings = ObjectStateManager.Get<UserSettings>();
            tbConnectionString1.Text = settings.ConnectionString1;
            tbConnectionString2.Text = settings.ConnectionString2;
            tbConnectionString3.Text = settings.ConnectionString3;
            tbDefaultDeploymentProfile.Text = settings.DefaultProfileName;
        }
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            var coll = ObjectStateManager.Get<ProfilesCollection>();
            string defaultProfile = tbDefaultDeploymentProfile.Text;
            if (!string.IsNullOrWhiteSpace(defaultProfile) && !coll.Any(p => p.ProfileName == defaultProfile))
            {
                defaultProfile = String.Empty;
                MessageBox.Show("Deployment profile [" + tbDefaultDeploymentProfile.Text + "] doesn't exist");
            }
            var settings = new UserSettings
            {
                ConnectionString1 = tbConnectionString1.Text,
                ConnectionString2 = tbConnectionString2.Text,
                ConnectionString3 = tbConnectionString3.Text,

                DefaultProfileName = defaultProfile
            };
            ObjectStateManager.Set(settings);
        }


        private void btnTestConn1_Click(object sender, EventArgs e)
        {
            if (TestConnectionStrng(tbConnectionString1.Text))
            {
                MessageBox.Show("Connection string is OK");
            }
        }
        private void btnTestConn2_Click(object sender, EventArgs e)
        {
            if (TestConnectionStrng(tbConnectionString2.Text))
            {
                MessageBox.Show("Connection string is OK");
            }
        }

        private void btnTestConn3_Click(object sender, EventArgs e)
        {
            if (TestConnectionStrng(tbConnectionString3.Text))
            {
                MessageBox.Show("Connection string is OK");
            }
        }

        private CancellationTokenSource pingSqlServerCancellationTokenSource;
        private PingOptions pingWebSiteArgs;
        private StringBuilder _pingSqlServerLog;

        private void btnPingWebSite_Click(object sender, EventArgs e)
        {
            if (pingWebSiteArgs == null)
            {
                int frequency = int.Parse(tbPingFrequency.Text);
                var pollInterval = 60/frequency;
                pingWebSiteArgs = new PingOptions(TimeSpan.FromSeconds(pollInterval))
                {
                    Url ="http://yourshoes.com.ua",
                    TestIsAlive = html => html.Contains("<nav class=\"user-links navbar-right\">")
                };
                pingWebSiteArgs = PingHelper.PingWebsiteTask(pingWebSiteArgs);
                btnStopPingWebSite.Enabled = true;
                btnPingWebSite.Enabled = false;
            }
        }
        private void btnStopPingWebSite_Click(object sender, EventArgs e)
        {
            if (pingWebSiteArgs != null)
            {
                pingWebSiteArgs.CancellationTokenSource.Cancel();
                _consoleWindow.OutputText = String.Empty;
                _consoleWindow.OutputText = pingWebSiteArgs.Log + pingWebSiteArgs.ToString();
                _consoleWindow.ShowDialog();

                var fails = pingWebSiteArgs.GetFailedPings();
                toolStripStatusLabel1.Text = "Failed pings count #" + fails.Count;
                if (fails.Any())
                {
                    _consoleWindow.OutputText += String.Format("\r\n\r\n ------- FAILURES --------\r\n");
                    foreach (var dateTime in fails)
                    {
                        _consoleWindow.OutputText += String.Format("\r\n {0:yyyy-MMM-dd hh:mm:ss}   - url {1} response failed", dateTime, pingWebSiteArgs.Url);
                    }
                    
                }


                pingWebSiteArgs = null;
                btnPingWebSite.Enabled = true;
                btnStopPingWebSite.Enabled = false;

            }
        }


        private void btnStartPing_Click(object sender, EventArgs e)
        {
            if (pingSqlServerCancellationTokenSource == null)
            {
                
                var settings = ObjectStateManager.Get<UserSettings>();
                int frequency = int.Parse(tbPingFrequency.Text);
                var pollInterval = 60 / frequency;
                _pingSqlServerLog = new StringBuilder();
                pingSqlServerCancellationTokenSource = PingHelper.PingSqlServerTask(settings.ConnectionString3, TimeSpan.FromSeconds(pollInterval), _pingSqlServerLog);
                btnStartPing.Enabled = false;
                btnStopPing.Enabled = true;
            }
        }
        private void btnStopPing_Click(object sender, EventArgs e)
        {
            if (pingSqlServerCancellationTokenSource != null)
            {
                pingSqlServerCancellationTokenSource.Cancel();
                _consoleWindow.OutputText = String.Empty;
                _consoleWindow.OutputText = _pingSqlServerLog.ToString();
                _pingSqlServerLog = null;
                pingSqlServerCancellationTokenSource = null;
                _consoleWindow.ShowDialog();
                btnStartPing.Enabled = true;
                btnStopPing.Enabled = false;
            }
        }

        

        bool TestConnectionStrng(string connectionString)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FAIL");
                return false;
            }
        } 
        #endregion

        #region ISearchConditionsTabView
        
        private IController _controller;

        public void SetController(IController controller)
        {
            _controller = controller;
        }
        
        void ISearchConditionsTabView.SetSelected()
        {
            tabControl1.SelectedIndex = 5;
        }

        #region prop-s
        public string Search1
        {
            get { return tbSearch1.Text; }
            set { tbSearch1.Text = value; }
        }

        public string Search2
        {
            get { return tbSearch2.Text; }
            set { tbSearch2.Text = value; }
        }

        public string SearchValue
        {
            get { return tbSearchValue.Text; }
            set { tbSearchValue.Text = value; }
        }

        public string PreferredConnectionStringName
        {
            get
            {
                if (rbUse1stConnectionString.Checked)
                {
                    return "NOP";
                }
                if (rbUse2ndConnectionString.Checked)
                {
                    return "AX";
                }
                throw new NotImplementedException();
            }
            set
            {
                if (value == "AX")
                {
                    rbUse2ndConnectionString.Checked = true;
                }
                else if (value == "NOP")
                {
                    rbUse1stConnectionString.Checked = true;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        public bool SearchByValueEnabled
        {
            get { return cbLookupForValue.Checked; }
            set
            {
                tbSearchValue.Enabled = value;
                cbLookupForValue.Checked = value;
            }
        }

        public bool Search2Enabled
        {
            get { return cbUseSearch2.Checked; }
            set
            {
                tbSearch2.Enabled = value;
                cbUseSearch2.Checked = value;
            }
        }

        public string SearchQueryText
        {
            get { return tbSearchSqlQueryText.Text; }
            set
            {
                tbSearchSqlQueryText.Text = value;
            }
        }
        
        #endregion
        
        #region event hndlr-s

        private void tbSearch1_TextChanged(object sender, EventArgs e)
        {
            ((SearchConditionsController)_controller).SearchConditionsUpdated();
        }

        private void tbSearch2_TextChanged(object sender, EventArgs e)
        {
            ((SearchConditionsController)_controller).SearchConditionsUpdated();
        }

        private void cbLookupForValue_CheckedChanged(object sender, EventArgs e)
        {
            tbSearchValue.Enabled = cbLookupForValue.Checked;
            if (!tbSearchValue.Enabled)
            {
                tbSearchValue.Text = "";
            }
            else
            {
                tbSearch1.Text = "";
                tbSearch2.Text = "";
            }
        }

        private void tbSearchValue_TextChanged(object sender, EventArgs e)
        {
            ((SearchConditionsController)_controller).SearchConditionsUpdated();
        }
        
        private void cbUseSearch2_CheckedChanged(object sender, EventArgs e)
        {
            tbSearch2.Enabled = cbUseSearch2.Checked;
            if (!tbSearch2.Enabled)
            {
                tbSearch2.Text = "";
            }
        }

        private void rbUse1stConnectionString_CheckedChanged(object sender, EventArgs e)
        {
            ((SearchConditionsController)_controller).SearchConditionsUpdated();
        }

        private void rbUse2ndConnectionString_CheckedChanged(object sender, EventArgs e)
        {
            ((SearchConditionsController)_controller).SearchConditionsUpdated();
        } 
        #endregion

        #endregion
        
        private void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            try
            {
                var condition = ObjectStateManager.Get<SearchConditions>();
                using (SqlConnection conn = new SqlConnection(condition.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(condition.GetQuery(), conn);
                    var adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    //     dataTable_InformationSchema = ds.Tables[0];
                    dataGridView.DataSource = ds.Tables[0];
                    tabControl1.SelectedIndex = 2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (backgroundWorker1.IsBusy)
                return;
            DataGridViewRow row = dataGridView.Rows[e.RowIndex];
            string cmdtext;
            if (row.DataGridView.Columns.Contains("TABLE_SCHEMA"))
            {
                var schema = row.Cells["TABLE_SCHEMA"].Value.ToString();
                var tablename = row.Cells["TABLE_NAME"].Value.ToString();
                cmdtext = string.Format("SELECT TOP 20 * FROM {0}.{1}", schema, tablename);
            }
            else
            {
                var table = row.Cells["TABLE"].Value.ToString();
                cmdtext = string.Format("SELECT TOP 20 * FROM {0}",table);
            }
            
            if (tbPreviewDataQueryText.Text == cmdtext)
                return;
            tbPreviewDataQueryText.Text = cmdtext;
            Cursor.Current = Cursors.WaitCursor;
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnExecuteQuery2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var cmdtext = tbPreviewDataQueryText.Text;
                var condition = ObjectStateManager.Get<SearchConditions>();
                using (var conn = new SqlConnection(condition.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(cmdtext, conn);
                    var adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    e.Result = ds;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                DataSet ds = (DataSet) e.Result;
                dataGridView2.DataSource = ds.Tables[0];
                Cursor.Current = Cursors.Default;
            }
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show(this, e.Exception.Message, "Error");
            e.ThrowException = false;
            e.Cancel = false;
        }

        private void cleanUpASPNETTempFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.toolStripStatusLabel1.Text = "IIS sites stopping..";
                IISHelper.StopActiveSites();
                this.toolStripStatusLabel1.Text = "Cleaning Temporary ASP.NET Files..";
                CleanupTempAspNetFiles("Framework\v2.0.50727");
                CleanupTempAspNetFiles("Framework64\v2.0.50727");
                CleanupTempAspNetFiles("Framework\v3.5");
                CleanupTempAspNetFiles("Framework64\v3.5");
                CleanupTempAspNetFiles("Framework\v4.0.30319");
                CleanupTempAspNetFiles("Framework64\v4.0.30319");
                this.toolStripStatusLabel1.Text = "Cleaning User's Temp folder..";
                string tempfolder = Path.GetTempPath();
                FileSystemUtils.CleanupDirectory(tempfolder, false);
                IISHelper.StartSites();
                this.toolStripStatusLabel1.Text =
                    "Temporary ASP.NET Files and Temp folder have been cleaned. IIS sites restarted";

            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("To perform operation application must Run as Administrator");
            }
        }

        private void CleanupTempAspNetFiles(string FrameworkVersion)
        {
            this.toolStripStatusLabel1.Text = string.Format("Cleaning Temporary ASP.NET Files at '{0}'..", FrameworkVersion);
            FileSystemUtils.CleanupDirectory(string.Format(@"C:\WINDOWS\Microsoft.NET\{0}\Temporary ASP.NET Files\",FrameworkVersion), false);
        }

        private void restartIISSitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.toolStripStatusLabel1.Text = "IIS sites restarting..";
                IISHelper.RestartActiveSites();
                this.toolStripStatusLabel1.Text = "IIS sites restarted";
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("To perform operation application must Run as Administrator");
            }
        }

        private void recyclePoolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.toolStripStatusLabel1.Text = "Recycling active application pools..";
                IISHelper.RecyclePools();
                this.toolStripStatusLabel1.Text = "IIS application pools recycled";
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("To perform operation application must Run as Administrator");
            }
        }
        private void processKbdCtrlShortcuts(object sender, KeyEventArgs e)
        {
            TextBoxBase t = (TextBoxBase)sender;
            if (e.KeyData == (Keys.C | Keys.Control))
            {
                t.Copy();
                e.Handled = true;
            }
            else if (e.KeyData == (Keys.X | Keys.Control))
            {
                t.Cut();
                e.Handled = true;
            }
            else if (e.KeyData == (Keys.V | Keys.Control))
            {
                t.Paste();
                e.Handled = true;
            }
            else if (e.KeyData == (Keys.A | Keys.Control))
            {
                t.SelectAll();
                e.Handled = true;
            }
            else if (e.KeyData == (Keys.Z | Keys.Control))
            {
                t.Undo();
                e.Handled = true;
            }
        }
        
        private void tbAllowOnlyDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnOpenSourceLocation_Click(object sender, EventArgs e)
        {

        }
        
        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _consoleWindow.Show();
        }
    }

   
    
}



