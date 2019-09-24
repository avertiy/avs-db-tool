namespace DatabaseDiscoveryTool.UI.WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabPageResults = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tbPreviewDataQueryText = new System.Windows.Forms.TextBox();
            this.btnExecuteQuery2 = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbSearchSqlQueryText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbSearchValue = new System.Windows.Forms.TextBox();
            this.btnExecuteQuery = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLookupForValue = new System.Windows.Forms.CheckBox();
            this.tbSearch2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbUse2ndConnectionString = new System.Windows.Forms.RadioButton();
            this.rbUse1stConnectionString = new System.Windows.Forms.RadioButton();
            this.cbUseSearch2 = new System.Windows.Forms.CheckBox();
            this.tbSearch1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.btnStopPingWebSite = new System.Windows.Forms.Button();
            this.btnPingWebSite = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnStopPing = new System.Windows.Forms.Button();
            this.tbPingFrequency = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnStartPing = new System.Windows.Forms.Button();
            this.tbConnectionString3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDefaultDeploymentProfile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTestConn2 = new System.Windows.Forms.Button();
            this.btnTestConn1 = new System.Windows.Forms.Button();
            this.tbConnectionString2 = new System.Windows.Forms.TextBox();
            this.tbConnectionString1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOpenInNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeploy = new System.Windows.Forms.Button();
            this.btnNewDeploymentProfile = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbDeploymentProfiles = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbCopyPlugins = new System.Windows.Forms.CheckBox();
            this.cbCopyBin = new System.Windows.Forms.CheckBox();
            this.cbCopyAllFiles = new System.Windows.Forms.CheckBox();
            this.btnSetAsDefaultDeploymentProfile = new System.Windows.Forms.Button();
            this.cbRestartSiteAndAppPool = new System.Windows.Forms.CheckBox();
            this.btnDeleteDeploymentProfile = new System.Windows.Forms.Button();
            this.btnSaveDeploymentProfile = new System.Windows.Forms.Button();
            this.cbCleanUpTmpASPNETFiles = new System.Windows.Forms.CheckBox();
            this.btnRecycleAppPool = new System.Windows.Forms.Button();
            this.btnCheckAppPoolStatus = new System.Windows.Forms.Button();
            this.btnRestartSite = new System.Windows.Forms.Button();
            this.tbTargetAppPoolName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCheckSiteStatus = new System.Windows.Forms.Button();
            this.tbTargetSiteName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOpenTargetLocation = new System.Windows.Forms.Button();
            this.btnOpenSourceLocation = new System.Windows.Forms.Button();
            this.tbTargetLocation = new System.Windows.Forms.TextBox();
            this.tbSourceLocation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanUpASPNETTempFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartIISSitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recyclePoolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDlg_tabCss = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog_tabCss = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPageResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPageSearch.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.splitContainer2);
            this.tabPageResults.Location = new System.Drawing.Point(4, 22);
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResults.Size = new System.Drawing.Size(1116, 677);
            this.tabPageResults.TabIndex = 2;
            this.tabPageResults.Text = "Results";
            this.tabPageResults.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer2.Panel1.Controls.Add(this.tbPreviewDataQueryText);
            this.splitContainer2.Panel1.Controls.Add(this.btnExecuteQuery2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1110, 671);
            this.splitContainer2.SplitterDistance = 57;
            this.splitContainer2.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(195, 47);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Query type";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.Blue;
            this.radioButton3.Location = new System.Drawing.Point(65, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "update";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Blue;
            this.radioButton2.Location = new System.Drawing.Point(129, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "insert";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Blue;
            this.radioButton1.Location = new System.Drawing.Point(6, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "select";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tbPreviewDataQueryText
            // 
            this.tbPreviewDataQueryText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPreviewDataQueryText.Location = new System.Drawing.Point(204, 9);
            this.tbPreviewDataQueryText.Multiline = true;
            this.tbPreviewDataQueryText.Name = "tbPreviewDataQueryText";
            this.tbPreviewDataQueryText.Size = new System.Drawing.Size(756, 40);
            this.tbPreviewDataQueryText.TabIndex = 5;
            this.tbPreviewDataQueryText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.processKbdCtrlShortcuts);
            // 
            // btnExecuteQuery2
            // 
            this.btnExecuteQuery2.Location = new System.Drawing.Point(966, 9);
            this.btnExecuteQuery2.Name = "btnExecuteQuery2";
            this.btnExecuteQuery2.Size = new System.Drawing.Size(75, 23);
            this.btnExecuteQuery2.TabIndex = 6;
            this.btnExecuteQuery2.Text = "Execute";
            this.btnExecuteQuery2.UseVisualStyleBackColor = true;
            this.btnExecuteQuery2.Click += new System.EventHandler(this.btnExecuteQuery2_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dataGridView);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer3.Size = new System.Drawing.Size(1110, 610);
            this.splitContainer3.SplitterDistance = 417;
            this.splitContainer3.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(417, 610);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RowEnter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ShowCellErrors = false;
            this.dataGridView2.ShowRowErrors = false;
            this.dataGridView2.Size = new System.Drawing.Size(689, 610);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView2_DataError);
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.groupBox3);
            this.tabPageSearch.Controls.Add(this.groupBox2);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(1116, 677);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbSearchSqlQueryText);
            this.groupBox3.Location = new System.Drawing.Point(358, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(709, 524);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search query text";
            // 
            // tbSearchSqlQueryText
            // 
            this.tbSearchSqlQueryText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearchSqlQueryText.Location = new System.Drawing.Point(3, 16);
            this.tbSearchSqlQueryText.Multiline = true;
            this.tbSearchSqlQueryText.Name = "tbSearchSqlQueryText";
            this.tbSearchSqlQueryText.Size = new System.Drawing.Size(703, 505);
            this.tbSearchSqlQueryText.TabIndex = 5;
            this.tbSearchSqlQueryText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.processKbdCtrlShortcuts);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbSearchValue);
            this.groupBox2.Controls.Add(this.btnExecuteQuery);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbLookupForValue);
            this.groupBox2.Controls.Add(this.tbSearch2);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.cbUseSearch2);
            this.groupBox2.Controls.Add(this.tbSearch1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(30, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 314);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search conditions";
            // 
            // tbSearchValue
            // 
            this.tbSearchValue.Enabled = false;
            this.tbSearchValue.Location = new System.Drawing.Point(77, 43);
            this.tbSearchValue.Name = "tbSearchValue";
            this.tbSearchValue.Size = new System.Drawing.Size(202, 20);
            this.tbSearchValue.TabIndex = 10;
            this.tbSearchValue.TextChanged += new System.EventHandler(this.tbSearchValue_TextChanged);
            this.tbSearchValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.processKbdCtrlShortcuts);
            // 
            // btnExecuteQuery
            // 
            this.btnExecuteQuery.Location = new System.Drawing.Point(16, 175);
            this.btnExecuteQuery.Name = "btnExecuteQuery";
            this.btnExecuteQuery.Size = new System.Drawing.Size(104, 23);
            this.btnExecuteQuery.TabIndex = 8;
            this.btnExecuteQuery.Text = "Execute query";
            this.btnExecuteQuery.UseVisualStyleBackColor = true;
            this.btnExecuteQuery.Click += new System.EventHandler(this.btnExecuteQuery_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "@Value";
            // 
            // cbLookupForValue
            // 
            this.cbLookupForValue.AutoSize = true;
            this.cbLookupForValue.Location = new System.Drawing.Point(16, 18);
            this.cbLookupForValue.Name = "cbLookupForValue";
            this.cbLookupForValue.Size = new System.Drawing.Size(136, 17);
            this.cbLookupForValue.TabIndex = 8;
            this.cbLookupForValue.Text = "LOOK UP FOR VALUE";
            this.cbLookupForValue.UseVisualStyleBackColor = true;
            this.cbLookupForValue.CheckedChanged += new System.EventHandler(this.cbLookupForValue_CheckedChanged);
            // 
            // tbSearch2
            // 
            this.tbSearch2.Enabled = false;
            this.tbSearch2.Location = new System.Drawing.Point(77, 139);
            this.tbSearch2.Name = "tbSearch2";
            this.tbSearch2.Size = new System.Drawing.Size(202, 20);
            this.tbSearch2.TabIndex = 4;
            this.tbSearch2.TextChanged += new System.EventHandler(this.tbSearch2_TextChanged);
            this.tbSearch2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.processKbdCtrlShortcuts);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbUse2ndConnectionString);
            this.groupBox4.Controls.Add(this.rbUse1stConnectionString);
            this.groupBox4.Location = new System.Drawing.Point(18, 231);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 66);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connection String";
            // 
            // rbUse2ndConnectionString
            // 
            this.rbUse2ndConnectionString.AutoSize = true;
            this.rbUse2ndConnectionString.Location = new System.Drawing.Point(6, 42);
            this.rbUse2ndConnectionString.Name = "rbUse2ndConnectionString";
            this.rbUse2ndConnectionString.Size = new System.Drawing.Size(147, 17);
            this.rbUse2ndConnectionString.TabIndex = 8;
            this.rbUse2ndConnectionString.Text = "use 2nd connection string";
            this.rbUse2ndConnectionString.UseVisualStyleBackColor = true;
            this.rbUse2ndConnectionString.CheckedChanged += new System.EventHandler(this.rbUse2ndConnectionString_CheckedChanged);
            // 
            // rbUse1stConnectionString
            // 
            this.rbUse1stConnectionString.AutoSize = true;
            this.rbUse1stConnectionString.Checked = true;
            this.rbUse1stConnectionString.Location = new System.Drawing.Point(6, 19);
            this.rbUse1stConnectionString.Name = "rbUse1stConnectionString";
            this.rbUse1stConnectionString.Size = new System.Drawing.Size(143, 17);
            this.rbUse1stConnectionString.TabIndex = 7;
            this.rbUse1stConnectionString.TabStop = true;
            this.rbUse1stConnectionString.Text = "use 1st connection string";
            this.rbUse1stConnectionString.UseVisualStyleBackColor = true;
            this.rbUse1stConnectionString.CheckedChanged += new System.EventHandler(this.rbUse1stConnectionString_CheckedChanged);
            // 
            // cbUseSearch2
            // 
            this.cbUseSearch2.AutoSize = true;
            this.cbUseSearch2.Location = new System.Drawing.Point(16, 116);
            this.cbUseSearch2.Name = "cbUseSearch2";
            this.cbUseSearch2.Size = new System.Drawing.Size(172, 17);
            this.cbUseSearch2.TabIndex = 6;
            this.cbUseSearch2.Text = "AND COLUMN NAME, LIKE %";
            this.cbUseSearch2.UseVisualStyleBackColor = true;
            this.cbUseSearch2.CheckedChanged += new System.EventHandler(this.cbUseSearch2_CheckedChanged);
            // 
            // tbSearch1
            // 
            this.tbSearch1.Location = new System.Drawing.Point(77, 80);
            this.tbSearch1.Name = "tbSearch1";
            this.tbSearch1.Size = new System.Drawing.Size(202, 20);
            this.tbSearch1.TabIndex = 1;
            this.tbSearch1.TextChanged += new System.EventHandler(this.tbSearch1_TextChanged);
            this.tbSearch1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.processKbdCtrlShortcuts);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "@Search1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "@Search2";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.btnStopPingWebSite);
            this.tabPageSettings.Controls.Add(this.btnPingWebSite);
            this.tabPageSettings.Controls.Add(this.groupBox7);
            this.tabPageSettings.Controls.Add(this.btnLoadSettings);
            this.tabPageSettings.Controls.Add(this.btnSaveSettings);
            this.tabPageSettings.Controls.Add(this.groupBox1);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(1116, 677);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // btnStopPingWebSite
            // 
            this.btnStopPingWebSite.Location = new System.Drawing.Point(132, 514);
            this.btnStopPingWebSite.Name = "btnStopPingWebSite";
            this.btnStopPingWebSite.Size = new System.Drawing.Size(94, 23);
            this.btnStopPingWebSite.TabIndex = 17;
            this.btnStopPingWebSite.Text = "Stop ping";
            this.btnStopPingWebSite.UseVisualStyleBackColor = true;
            this.btnStopPingWebSite.Click += new System.EventHandler(this.btnStopPingWebSite_Click);
            // 
            // btnPingWebSite
            // 
            this.btnPingWebSite.Location = new System.Drawing.Point(32, 514);
            this.btnPingWebSite.Name = "btnPingWebSite";
            this.btnPingWebSite.Size = new System.Drawing.Size(94, 23);
            this.btnPingWebSite.TabIndex = 16;
            this.btnPingWebSite.Text = "Ping website";
            this.btnPingWebSite.UseVisualStyleBackColor = true;
            this.btnPingWebSite.Click += new System.EventHandler(this.btnPingWebSite_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button5);
            this.groupBox7.Controls.Add(this.btnStopPing);
            this.groupBox7.Controls.Add(this.tbPingFrequency);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.btnStartPing);
            this.groupBox7.Controls.Add(this.tbConnectionString3);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Location = new System.Drawing.Point(10, 319);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1058, 176);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ping settings";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(943, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Test connection";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnTestConn3_Click);
            // 
            // btnStopPing
            // 
            this.btnStopPing.Enabled = false;
            this.btnStopPing.Location = new System.Drawing.Point(122, 131);
            this.btnStopPing.Name = "btnStopPing";
            this.btnStopPing.Size = new System.Drawing.Size(94, 23);
            this.btnStopPing.TabIndex = 15;
            this.btnStopPing.Text = "Stop ping";
            this.btnStopPing.UseVisualStyleBackColor = true;
            this.btnStopPing.Click += new System.EventHandler(this.btnStopPing_Click);
            // 
            // tbPingFrequency
            // 
            this.tbPingFrequency.Location = new System.Drawing.Point(21, 95);
            this.tbPingFrequency.Name = "tbPingFrequency";
            this.tbPingFrequency.Size = new System.Drawing.Size(54, 20);
            this.tbPingFrequency.TabIndex = 14;
            this.tbPingFrequency.Text = "2";
            this.tbPingFrequency.KeyUp += new System.Windows.Forms.KeyEventHandler(this.processKbdCtrlShortcuts);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Ping Frequency (per min)";
            // 
            // btnStartPing
            // 
            this.btnStartPing.Location = new System.Drawing.Point(21, 131);
            this.btnStartPing.Name = "btnStartPing";
            this.btnStartPing.Size = new System.Drawing.Size(94, 23);
            this.btnStartPing.TabIndex = 12;
            this.btnStartPing.Text = "Start ping";
            this.btnStartPing.UseVisualStyleBackColor = true;
            this.btnStartPing.Click += new System.EventHandler(this.btnStartPing_Click);
            // 
            // tbConnectionString3
            // 
            this.tbConnectionString3.Location = new System.Drawing.Point(21, 44);
            this.tbConnectionString3.Name = "tbConnectionString3";
            this.tbConnectionString3.Size = new System.Drawing.Size(916, 20);
            this.tbConnectionString3.TabIndex = 11;
            this.tbConnectionString3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.processKbdCtrlShortcuts);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Connection string";
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Location = new System.Drawing.Point(91, 17);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(75, 23);
            this.btnLoadSettings.TabIndex = 5;
            this.btnLoadSettings.Text = "Load";
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(10, 17);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 4;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDefaultDeploymentProfile);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnTestConn2);
            this.groupBox1.Controls.Add(this.btnTestConn1);
            this.groupBox1.Controls.Add(this.tbConnectionString2);
            this.groupBox1.Controls.Add(this.tbConnectionString1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // tbDefaultDeploymentProfile
            // 
            this.tbDefaultDeploymentProfile.Location = new System.Drawing.Point(21, 201);
            this.tbDefaultDeploymentProfile.Name = "tbDefaultDeploymentProfile";
            this.tbDefaultDeploymentProfile.Size = new System.Drawing.Size(916, 20);
            this.tbDefaultDeploymentProfile.TabIndex = 9;
            this.tbDefaultDeploymentProfile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.processKbdCtrlShortcuts);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Default deployment profile";
            // 
            // btnTestConn2
            // 
            this.btnTestConn2.Location = new System.Drawing.Point(943, 85);
            this.btnTestConn2.Name = "btnTestConn2";
            this.btnTestConn2.Size = new System.Drawing.Size(94, 23);
            this.btnTestConn2.TabIndex = 7;
            this.btnTestConn2.Text = "Test connection";
            this.btnTestConn2.UseVisualStyleBackColor = true;
            this.btnTestConn2.Click += new System.EventHandler(this.btnTestConn2_Click);
            // 
            // btnTestConn1
            // 
            this.btnTestConn1.Location = new System.Drawing.Point(943, 46);
            this.btnTestConn1.Name = "btnTestConn1";
            this.btnTestConn1.Size = new System.Drawing.Size(94, 23);
            this.btnTestConn1.TabIndex = 6;
            this.btnTestConn1.Text = "Test connection";
            this.btnTestConn1.UseVisualStyleBackColor = true;
            this.btnTestConn1.Click += new System.EventHandler(this.btnTestConn1_Click);
            // 
            // tbConnectionString2
            // 
            this.tbConnectionString2.Location = new System.Drawing.Point(21, 88);
            this.tbConnectionString2.Name = "tbConnectionString2";
            this.tbConnectionString2.Size = new System.Drawing.Size(916, 20);
            this.tbConnectionString2.TabIndex = 3;
            this.tbConnectionString2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.processKbdCtrlShortcuts);
            // 
            // tbConnectionString1
            // 
            this.tbConnectionString1.Location = new System.Drawing.Point(21, 48);
            this.tbConnectionString1.Name = "tbConnectionString1";
            this.tbConnectionString1.Size = new System.Drawing.Size(916, 20);
            this.tbConnectionString1.TabIndex = 2;
            this.tbConnectionString1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.processKbdCtrlShortcuts);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Connection string 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection string 1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSettings);
            this.tabControl1.Controls.Add(this.tabPageSearch);
            this.tabControl1.Controls.Add(this.tabPageResults);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1124, 703);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.ContextMenuStrip = this.contextMenuStrip1;
            this.tabPage1.Controls.Add(this.btnDeploy);
            this.tabPage1.Controls.Add(this.btnNewDeploymentProfile);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.cbDeploymentProfiles);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1116, 677);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Deployment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenInNewWindow});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 26);
            // 
            // tsmiOpenInNewWindow
            // 
            this.tsmiOpenInNewWindow.Name = "tsmiOpenInNewWindow";
            this.tsmiOpenInNewWindow.Size = new System.Drawing.Size(186, 22);
            this.tsmiOpenInNewWindow.Text = "Open in new window";
            // 
            // btnDeploy
            // 
            this.btnDeploy.BackColor = System.Drawing.Color.LightBlue;
            this.btnDeploy.ForeColor = System.Drawing.Color.Black;
            this.btnDeploy.Location = new System.Drawing.Point(592, 15);
            this.btnDeploy.Name = "btnDeploy";
            this.btnDeploy.Size = new System.Drawing.Size(86, 23);
            this.btnDeploy.TabIndex = 19;
            this.btnDeploy.Text = "Deploy";
            this.btnDeploy.UseVisualStyleBackColor = false;
            // 
            // btnNewDeploymentProfile
            // 
            this.btnNewDeploymentProfile.Location = new System.Drawing.Point(500, 15);
            this.btnNewDeploymentProfile.Name = "btnNewDeploymentProfile";
            this.btnNewDeploymentProfile.Size = new System.Drawing.Size(86, 23);
            this.btnNewDeploymentProfile.TabIndex = 18;
            this.btnNewDeploymentProfile.Text = "New Profile";
            this.btnNewDeploymentProfile.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Select profile";
            // 
            // cbDeploymentProfiles
            // 
            this.cbDeploymentProfiles.FormattingEnabled = true;
            this.cbDeploymentProfiles.Location = new System.Drawing.Point(84, 17);
            this.cbDeploymentProfiles.Name = "cbDeploymentProfiles";
            this.cbDeploymentProfiles.Size = new System.Drawing.Size(408, 21);
            this.cbDeploymentProfiles.TabIndex = 10;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbCopyPlugins);
            this.groupBox6.Controls.Add(this.cbCopyBin);
            this.groupBox6.Controls.Add(this.cbCopyAllFiles);
            this.groupBox6.Controls.Add(this.btnSetAsDefaultDeploymentProfile);
            this.groupBox6.Controls.Add(this.cbRestartSiteAndAppPool);
            this.groupBox6.Controls.Add(this.btnDeleteDeploymentProfile);
            this.groupBox6.Controls.Add(this.btnSaveDeploymentProfile);
            this.groupBox6.Controls.Add(this.cbCleanUpTmpASPNETFiles);
            this.groupBox6.Controls.Add(this.btnRecycleAppPool);
            this.groupBox6.Controls.Add(this.btnCheckAppPoolStatus);
            this.groupBox6.Controls.Add(this.btnRestartSite);
            this.groupBox6.Controls.Add(this.tbTargetAppPoolName);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.btnCheckSiteStatus);
            this.groupBox6.Controls.Add(this.tbTargetSiteName);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.btnOpenTargetLocation);
            this.groupBox6.Controls.Add(this.btnOpenSourceLocation);
            this.groupBox6.Controls.Add(this.tbTargetLocation);
            this.groupBox6.Controls.Add(this.tbSourceLocation);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(18, 58);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1048, 323);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Settings";
            // 
            // cbCopyPlugins
            // 
            this.cbCopyPlugins.AutoSize = true;
            this.cbCopyPlugins.Checked = true;
            this.cbCopyPlugins.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCopyPlugins.Location = new System.Drawing.Point(20, 250);
            this.cbCopyPlugins.Name = "cbCopyPlugins";
            this.cbCopyPlugins.Size = new System.Drawing.Size(87, 17);
            this.cbCopyPlugins.TabIndex = 25;
            this.cbCopyPlugins.Text = "Copy Plugins";
            this.cbCopyPlugins.UseVisualStyleBackColor = true;
            // 
            // cbCopyBin
            // 
            this.cbCopyBin.AutoSize = true;
            this.cbCopyBin.Checked = true;
            this.cbCopyBin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCopyBin.Location = new System.Drawing.Point(20, 227);
            this.cbCopyBin.Name = "cbCopyBin";
            this.cbCopyBin.Size = new System.Drawing.Size(97, 17);
            this.cbCopyBin.TabIndex = 24;
            this.cbCopyBin.Text = "Copy Bin folder";
            this.cbCopyBin.UseVisualStyleBackColor = true;
            // 
            // cbCopyAllFiles
            // 
            this.cbCopyAllFiles.AutoSize = true;
            this.cbCopyAllFiles.Location = new System.Drawing.Point(20, 204);
            this.cbCopyAllFiles.Name = "cbCopyAllFiles";
            this.cbCopyAllFiles.Size = new System.Drawing.Size(84, 17);
            this.cbCopyAllFiles.TabIndex = 23;
            this.cbCopyAllFiles.Text = "Copy all files";
            this.cbCopyAllFiles.UseVisualStyleBackColor = true;
            // 
            // btnSetAsDefaultDeploymentProfile
            // 
            this.btnSetAsDefaultDeploymentProfile.Location = new System.Drawing.Point(565, 285);
            this.btnSetAsDefaultDeploymentProfile.Name = "btnSetAsDefaultDeploymentProfile";
            this.btnSetAsDefaultDeploymentProfile.Size = new System.Drawing.Size(157, 23);
            this.btnSetAsDefaultDeploymentProfile.TabIndex = 22;
            this.btnSetAsDefaultDeploymentProfile.Text = "Set as Default";
            this.btnSetAsDefaultDeploymentProfile.UseVisualStyleBackColor = true;
            // 
            // cbRestartSiteAndAppPool
            // 
            this.cbRestartSiteAndAppPool.AutoSize = true;
            this.cbRestartSiteAndAppPool.Checked = true;
            this.cbRestartSiteAndAppPool.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRestartSiteAndAppPool.Location = new System.Drawing.Point(200, 172);
            this.cbRestartSiteAndAppPool.Name = "cbRestartSiteAndAppPool";
            this.cbRestartSiteAndAppPool.Size = new System.Drawing.Size(222, 17);
            this.cbRestartSiteAndAppPool.TabIndex = 21;
            this.cbRestartSiteAndAppPool.Text = "Restart Site and Recycle Application pool";
            this.cbRestartSiteAndAppPool.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDeploymentProfile
            // 
            this.btnDeleteDeploymentProfile.Location = new System.Drawing.Point(451, 285);
            this.btnDeleteDeploymentProfile.Name = "btnDeleteDeploymentProfile";
            this.btnDeleteDeploymentProfile.Size = new System.Drawing.Size(86, 23);
            this.btnDeleteDeploymentProfile.TabIndex = 20;
            this.btnDeleteDeploymentProfile.Text = "Delete";
            this.btnDeleteDeploymentProfile.UseVisualStyleBackColor = true;
            // 
            // btnSaveDeploymentProfile
            // 
            this.btnSaveDeploymentProfile.Location = new System.Drawing.Point(359, 285);
            this.btnSaveDeploymentProfile.Name = "btnSaveDeploymentProfile";
            this.btnSaveDeploymentProfile.Size = new System.Drawing.Size(86, 23);
            this.btnSaveDeploymentProfile.TabIndex = 19;
            this.btnSaveDeploymentProfile.Text = "Save";
            this.btnSaveDeploymentProfile.UseVisualStyleBackColor = true;
            // 
            // cbCleanUpTmpASPNETFiles
            // 
            this.cbCleanUpTmpASPNETFiles.AutoSize = true;
            this.cbCleanUpTmpASPNETFiles.Checked = true;
            this.cbCleanUpTmpASPNETFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCleanUpTmpASPNETFiles.Location = new System.Drawing.Point(20, 172);
            this.cbCleanUpTmpASPNETFiles.Name = "cbCleanUpTmpASPNETFiles";
            this.cbCleanUpTmpASPNETFiles.Size = new System.Drawing.Size(174, 17);
            this.cbCleanUpTmpASPNETFiles.TabIndex = 17;
            this.cbCleanUpTmpASPNETFiles.Text = "Clean up Temp. ASP.NET Files";
            this.cbCleanUpTmpASPNETFiles.UseVisualStyleBackColor = true;
            // 
            // btnRecycleAppPool
            // 
            this.btnRecycleAppPool.Location = new System.Drawing.Point(950, 134);
            this.btnRecycleAppPool.Name = "btnRecycleAppPool";
            this.btnRecycleAppPool.Size = new System.Drawing.Size(86, 23);
            this.btnRecycleAppPool.TabIndex = 16;
            this.btnRecycleAppPool.Text = "Recycle";
            this.btnRecycleAppPool.UseVisualStyleBackColor = true;
            // 
            // btnCheckAppPoolStatus
            // 
            this.btnCheckAppPoolStatus.Location = new System.Drawing.Point(858, 134);
            this.btnCheckAppPoolStatus.Name = "btnCheckAppPoolStatus";
            this.btnCheckAppPoolStatus.Size = new System.Drawing.Size(86, 23);
            this.btnCheckAppPoolStatus.TabIndex = 15;
            this.btnCheckAppPoolStatus.Text = "Check status";
            this.btnCheckAppPoolStatus.UseVisualStyleBackColor = true;
            // 
            // btnRestartSite
            // 
            this.btnRestartSite.Location = new System.Drawing.Point(408, 134);
            this.btnRestartSite.Name = "btnRestartSite";
            this.btnRestartSite.Size = new System.Drawing.Size(86, 23);
            this.btnRestartSite.TabIndex = 14;
            this.btnRestartSite.Text = "Restart";
            this.btnRestartSite.UseVisualStyleBackColor = true;
            // 
            // tbTargetAppPoolName
            // 
            this.tbTargetAppPoolName.Location = new System.Drawing.Point(530, 136);
            this.tbTargetAppPoolName.Name = "tbTargetAppPoolName";
            this.tbTargetAppPoolName.Size = new System.Drawing.Size(322, 20);
            this.tbTargetAppPoolName.TabIndex = 11;
            this.tbTargetAppPoolName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.processKbdCtrlShortcuts);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(527, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "IIS Target Application Pool";
            // 
            // btnCheckSiteStatus
            // 
            this.btnCheckSiteStatus.Location = new System.Drawing.Point(316, 134);
            this.btnCheckSiteStatus.Name = "btnCheckSiteStatus";
            this.btnCheckSiteStatus.Size = new System.Drawing.Size(86, 23);
            this.btnCheckSiteStatus.TabIndex = 12;
            this.btnCheckSiteStatus.Text = "Check status";
            this.btnCheckSiteStatus.UseVisualStyleBackColor = true;
            // 
            // tbTargetSiteName
            // 
            this.tbTargetSiteName.Location = new System.Drawing.Point(20, 136);
            this.tbTargetSiteName.Name = "tbTargetSiteName";
            this.tbTargetSiteName.Size = new System.Drawing.Size(290, 20);
            this.tbTargetSiteName.TabIndex = 9;
            this.tbTargetSiteName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.processKbdCtrlShortcuts);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "IIS Target Site name";
            // 
            // btnOpenTargetLocation
            // 
            this.btnOpenTargetLocation.Location = new System.Drawing.Point(942, 91);
            this.btnOpenTargetLocation.Name = "btnOpenTargetLocation";
            this.btnOpenTargetLocation.Size = new System.Drawing.Size(94, 23);
            this.btnOpenTargetLocation.TabIndex = 7;
            this.btnOpenTargetLocation.Text = "Open in Explorer";
            this.btnOpenTargetLocation.UseVisualStyleBackColor = true;
            // 
            // btnOpenSourceLocation
            // 
            this.btnOpenSourceLocation.Location = new System.Drawing.Point(942, 52);
            this.btnOpenSourceLocation.Name = "btnOpenSourceLocation";
            this.btnOpenSourceLocation.Size = new System.Drawing.Size(94, 23);
            this.btnOpenSourceLocation.TabIndex = 6;
            this.btnOpenSourceLocation.Text = "Open in Explorer";
            this.btnOpenSourceLocation.UseVisualStyleBackColor = true;
            this.btnOpenSourceLocation.Click += new System.EventHandler(this.btnOpenSourceLocation_Click);
            // 
            // tbTargetLocation
            // 
            this.tbTargetLocation.Location = new System.Drawing.Point(20, 93);
            this.tbTargetLocation.Name = "tbTargetLocation";
            this.tbTargetLocation.Size = new System.Drawing.Size(916, 20);
            this.tbTargetLocation.TabIndex = 3;
            this.tbTargetLocation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.processKbdCtrlShortcuts);
            // 
            // tbSourceLocation
            // 
            this.tbSourceLocation.Location = new System.Drawing.Point(20, 54);
            this.tbSourceLocation.Name = "tbSourceLocation";
            this.tbSourceLocation.Size = new System.Drawing.Size(916, 20);
            this.tbSourceLocation.TabIndex = 2;
            this.tbSourceLocation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.processKbdCtrlShortcuts);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Target location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Source location";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1124, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.cleanUpASPNETTempFilesToolStripMenuItem,
            this.restartIISSitesToolStripMenuItem,
            this.recyclePoolsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.customizeToolStripMenuItem.Text = "&Console";
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // cleanUpASPNETTempFilesToolStripMenuItem
            // 
            this.cleanUpASPNETTempFilesToolStripMenuItem.Name = "cleanUpASPNETTempFilesToolStripMenuItem";
            this.cleanUpASPNETTempFilesToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.cleanUpASPNETTempFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F7)));
            this.cleanUpASPNETTempFilesToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.cleanUpASPNETTempFilesToolStripMenuItem.Text = "&Clean up  Temp ASP.NET files";
            this.cleanUpASPNETTempFilesToolStripMenuItem.Click += new System.EventHandler(this.cleanUpASPNETTempFilesToolStripMenuItem_Click);
            // 
            // restartIISSitesToolStripMenuItem
            // 
            this.restartIISSitesToolStripMenuItem.Name = "restartIISSitesToolStripMenuItem";
            this.restartIISSitesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F8)));
            this.restartIISSitesToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.restartIISSitesToolStripMenuItem.Text = "&Restart IIS sites";
            this.restartIISSitesToolStripMenuItem.Click += new System.EventHandler(this.restartIISSitesToolStripMenuItem_Click);
            // 
            // recyclePoolsToolStripMenuItem
            // 
            this.recyclePoolsToolStripMenuItem.Name = "recyclePoolsToolStripMenuItem";
            this.recyclePoolsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F9)));
            this.recyclePoolsToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.recyclePoolsToolStripMenuItem.Text = "&Recycle Pools";
            this.recyclePoolsToolStripMenuItem.Click += new System.EventHandler(this.recyclePoolsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // openFileDlg_tabCss
            // 
            this.openFileDlg_tabCss.DefaultExt = "All Files (*.*)|*.*";
            this.openFileDlg_tabCss.Filter = "Css files(*.css)|*.css|All Files (*.*)|*.*";
            this.openFileDlg_tabCss.Title = "Select css file for analisys";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 703);
            this.panel1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 705);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1124, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 727);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SQL Server Lookup Tool";
            this.tabPageResults.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPageSearch.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPageResults;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox tbPreviewDataQueryText;
        private System.Windows.Forms.Button btnExecuteQuery2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.Button btnExecuteQuery;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbSearchSqlQueryText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbUse2ndConnectionString;
        private System.Windows.Forms.RadioButton rbUse1stConnectionString;
        private System.Windows.Forms.CheckBox cbUseSearch2;
        private System.Windows.Forms.TextBox tbSearch2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSearch1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTestConn2;
        private System.Windows.Forms.Button btnTestConn1;
        private System.Windows.Forms.TextBox tbConnectionString2;
        private System.Windows.Forms.TextBox tbConnectionString1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenInNewWindow;
        private System.Windows.Forms.TextBox tbSearchValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbLookupForValue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanUpASPNETTempFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartIISSitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recyclePoolsToolStripMenuItem;
        private System.Windows.Forms.Button btnNewDeploymentProfile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbDeploymentProfiles;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnDeleteDeploymentProfile;
        private System.Windows.Forms.Button btnSaveDeploymentProfile;
        private System.Windows.Forms.CheckBox cbCleanUpTmpASPNETFiles;
        private System.Windows.Forms.Button btnRecycleAppPool;
        private System.Windows.Forms.Button btnCheckAppPoolStatus;
        private System.Windows.Forms.Button btnRestartSite;
        private System.Windows.Forms.TextBox tbTargetAppPoolName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCheckSiteStatus;
        private System.Windows.Forms.TextBox tbTargetSiteName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOpenTargetLocation;
        private System.Windows.Forms.Button btnOpenSourceLocation;
        private System.Windows.Forms.TextBox tbTargetLocation;
        private System.Windows.Forms.TextBox tbSourceLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeploy;
        private System.Windows.Forms.CheckBox cbRestartSiteAndAppPool;
        private System.Windows.Forms.Button btnSetAsDefaultDeploymentProfile;
        private System.Windows.Forms.TextBox tbDefaultDeploymentProfile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbCopyPlugins;
        private System.Windows.Forms.CheckBox cbCopyBin;
        private System.Windows.Forms.CheckBox cbCopyAllFiles;
        private System.Windows.Forms.OpenFileDialog openFileDlg_tabCss;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_tabCss;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbConnectionString3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPingFrequency;
        private System.Windows.Forms.Button btnStopPing;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnStartPing;
        private System.Windows.Forms.Button btnPingWebSite;
        private System.Windows.Forms.Button btnStopPingWebSite;
    }
}

