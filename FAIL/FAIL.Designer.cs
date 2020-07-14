namespace FAIL
{
    partial class FAIL
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
            this.tabFailTabs = new System.Windows.Forms.TabControl();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.txtStartLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPauseSearch = new System.Windows.Forms.Button();
            this.btnStopSearch = new System.Windows.Forms.Button();
            this.btnStartSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxShardSelect = new System.Windows.Forms.ComboBox();
            this.btnLoadHouses = new System.Windows.Forms.Button();
            this.btnSaveHouses = new System.Windows.Forms.Button();
            this.txtHouseStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateNewRail = new System.Windows.Forms.Button();
            this.lblRailFile = new System.Windows.Forms.Label();
            this.btnRailFile = new System.Windows.Forms.Button();
            this.btnContinueBuildRail = new System.Windows.Forms.Button();
            this.btnPauseBuildRail = new System.Windows.Forms.Button();
            this.lblRailName = new System.Windows.Forms.Label();
            this.btnResetRails = new System.Windows.Forms.Button();
            this.btnLoadRails = new System.Windows.Forms.Button();
            this.lblRuneNumber = new System.Windows.Forms.Label();
            this.txtRailName = new System.Windows.Forms.TextBox();
            this.txtRuneNumber = new System.Windows.Forms.TextBox();
            this.btnSaveRails = new System.Windows.Forms.Button();
            this.btnStopRail = new System.Windows.Forms.Button();
            this.btnStartRail = new System.Windows.Forms.Button();
            this.btnRemoveRail = new System.Windows.Forms.Button();
            this.btnAddRail = new System.Windows.Forms.Button();
            this.lblRails = new System.Windows.Forms.Label();
            this.listRails = new System.Windows.Forms.ListBox();
            this.btnRemoveRunebook = new System.Windows.Forms.Button();
            this.btnAddRunebook = new System.Windows.Forms.Button();
            this.lblRunebooks = new System.Windows.Forms.Label();
            this.listRunebooks = new System.Windows.Forms.ListBox();
            this.tabWatch = new System.Windows.Forms.TabPage();
            this.cboxStealthLoot = new System.Windows.Forms.CheckBox();
            this.btnStopWatching = new System.Windows.Forms.Button();
            this.btnStartWatching = new System.Windows.Forms.Button();
            this.txtWatchStatus = new System.Windows.Forms.TextBox();
            this.tabLoot = new System.Windows.Forms.TabPage();
            this.btnSaveLootList = new System.Windows.Forms.Button();
            this.dataLootList = new System.Windows.Forms.DataGridView();
            this.gboxAddLoot = new System.Windows.Forms.GroupBox();
            this.btnAddLootType = new System.Windows.Forms.Button();
            this.btnAddLootName = new System.Windows.Forms.Button();
            this.lblAddLootType = new System.Windows.Forms.Label();
            this.lblAddLootName = new System.Windows.Forms.Label();
            this.txtAddlootType = new System.Windows.Forms.TextBox();
            this.txtAddLootName = new System.Windows.Forms.TextBox();
            this.btnAddLootTarget = new System.Windows.Forms.Button();
            this.tabHouses = new System.Windows.Forms.TabPage();
            this.cboxShardDisplay = new System.Windows.Forms.ComboBox();
            this.btnRefreshDataGrid = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabDebug = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDebugSearchItems = new System.Windows.Forms.Button();
            this.txtDebugStatus = new System.Windows.Forms.TextBox();
            this.btnDebugGetID = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.cboxSettingShard = new System.Windows.Forms.ComboBox();
            this.cboxStealthSearch = new System.Windows.Forms.CheckBox();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblSafeRuneNumber = new System.Windows.Forms.Label();
            this.txtSafeRuneNumber = new System.Windows.Forms.TextBox();
            this.btnSetSafeRunebook = new System.Windows.Forms.Button();
            this.tabCalendar = new System.Windows.Forms.TabPage();
            this.txtCalendarOutput = new System.Windows.Forms.TextBox();
            this.btnCalendarConnect = new System.Windows.Forms.Button();
            this.workerBuildRail = new System.ComponentModel.BackgroundWorker();
            this.workerSearch = new System.ComponentModel.BackgroundWorker();
            this.workerCheckHouses = new System.ComponentModel.BackgroundWorker();
            this.workerWatch = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLootTest = new System.Windows.Forms.Button();
            this.tabFailTabs.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabWatch.SuspendLayout();
            this.tabLoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLootList)).BeginInit();
            this.gboxAddLoot.SuspendLayout();
            this.tabHouses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabDebug.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFailTabs
            // 
            this.tabFailTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabFailTabs.Controls.Add(this.tabSearch);
            this.tabFailTabs.Controls.Add(this.tabWatch);
            this.tabFailTabs.Controls.Add(this.tabLoot);
            this.tabFailTabs.Controls.Add(this.tabHouses);
            this.tabFailTabs.Controls.Add(this.tabDebug);
            this.tabFailTabs.Controls.Add(this.tabSettings);
            this.tabFailTabs.Controls.Add(this.tabCalendar);
            this.tabFailTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFailTabs.Location = new System.Drawing.Point(0, 0);
            this.tabFailTabs.Name = "tabFailTabs";
            this.tabFailTabs.SelectedIndex = 0;
            this.tabFailTabs.Size = new System.Drawing.Size(887, 669);
            this.tabFailTabs.TabIndex = 0;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.txtStartLocation);
            this.tabSearch.Controls.Add(this.label1);
            this.tabSearch.Controls.Add(this.btnPauseSearch);
            this.tabSearch.Controls.Add(this.btnStopSearch);
            this.tabSearch.Controls.Add(this.btnStartSearch);
            this.tabSearch.Controls.Add(this.groupBox2);
            this.tabSearch.Controls.Add(this.groupBox1);
            this.tabSearch.Location = new System.Drawing.Point(4, 29);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(879, 636);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // txtStartLocation
            // 
            this.txtStartLocation.Location = new System.Drawing.Point(731, 535);
            this.txtStartLocation.Name = "txtStartLocation";
            this.txtStartLocation.Size = new System.Drawing.Size(100, 26);
            this.txtStartLocation.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Starting Location (optional for debugging): ";
            // 
            // btnPauseSearch
            // 
            this.btnPauseSearch.Location = new System.Drawing.Point(520, 567);
            this.btnPauseSearch.Name = "btnPauseSearch";
            this.btnPauseSearch.Size = new System.Drawing.Size(240, 48);
            this.btnPauseSearch.TabIndex = 1;
            this.btnPauseSearch.Text = "Pause/Continue";
            this.btnPauseSearch.UseVisualStyleBackColor = true;
            this.btnPauseSearch.Click += new System.EventHandler(this.btnPauseSearch_Click);
            // 
            // btnStopSearch
            // 
            this.btnStopSearch.Location = new System.Drawing.Point(766, 567);
            this.btnStopSearch.Name = "btnStopSearch";
            this.btnStopSearch.Size = new System.Drawing.Size(106, 48);
            this.btnStopSearch.TabIndex = 12;
            this.btnStopSearch.Text = "Stop";
            this.btnStopSearch.UseVisualStyleBackColor = true;
            this.btnStopSearch.Click += new System.EventHandler(this.btnStopSearch_Click);
            // 
            // btnStartSearch
            // 
            this.btnStartSearch.Location = new System.Drawing.Point(408, 567);
            this.btnStartSearch.Name = "btnStartSearch";
            this.btnStartSearch.Size = new System.Drawing.Size(106, 48);
            this.btnStartSearch.TabIndex = 12;
            this.btnStartSearch.Text = "Start";
            this.btnStartSearch.UseVisualStyleBackColor = true;
            this.btnStartSearch.Click += new System.EventHandler(this.btnStartSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboxShardSelect);
            this.groupBox2.Controls.Add(this.btnLoadHouses);
            this.groupBox2.Controls.Add(this.btnSaveHouses);
            this.groupBox2.Controls.Add(this.txtHouseStatus);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Location = new System.Drawing.Point(409, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 516);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // cboxShardSelect
            // 
            this.cboxShardSelect.FormattingEnabled = true;
            this.cboxShardSelect.Items.AddRange(new object[] {
            "Great Lakes",
            "Lake Superior",
            "Napa Valley"});
            this.cboxShardSelect.Location = new System.Drawing.Point(281, 329);
            this.cboxShardSelect.Name = "cboxShardSelect";
            this.cboxShardSelect.Size = new System.Drawing.Size(177, 28);
            this.cboxShardSelect.TabIndex = 4;
            this.cboxShardSelect.Text = "Select Shard";
            // 
            // btnLoadHouses
            // 
            this.btnLoadHouses.Location = new System.Drawing.Point(113, 260);
            this.btnLoadHouses.Name = "btnLoadHouses";
            this.btnLoadHouses.Size = new System.Drawing.Size(129, 51);
            this.btnLoadHouses.TabIndex = 3;
            this.btnLoadHouses.Text = "Load Houses";
            this.btnLoadHouses.UseVisualStyleBackColor = true;
            this.btnLoadHouses.Click += new System.EventHandler(this.btnLoadHouses_Click);
            // 
            // btnSaveHouses
            // 
            this.btnSaveHouses.Location = new System.Drawing.Point(248, 260);
            this.btnSaveHouses.Name = "btnSaveHouses";
            this.btnSaveHouses.Size = new System.Drawing.Size(129, 51);
            this.btnSaveHouses.TabIndex = 2;
            this.btnSaveHouses.Text = "Save Houses";
            this.btnSaveHouses.UseVisualStyleBackColor = true;
            this.btnSaveHouses.Click += new System.EventHandler(this.btnSaveHouses_Click);
            // 
            // txtHouseStatus
            // 
            this.txtHouseStatus.Location = new System.Drawing.Point(10, 25);
            this.txtHouseStatus.Multiline = true;
            this.txtHouseStatus.Name = "txtHouseStatus";
            this.txtHouseStatus.Size = new System.Drawing.Size(448, 229);
            this.txtHouseStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 340);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(6, 363);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(452, 146);
            this.txtStatus.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateNewRail);
            this.groupBox1.Controls.Add(this.lblRailFile);
            this.groupBox1.Controls.Add(this.btnRailFile);
            this.groupBox1.Controls.Add(this.btnContinueBuildRail);
            this.groupBox1.Controls.Add(this.btnPauseBuildRail);
            this.groupBox1.Controls.Add(this.lblRailName);
            this.groupBox1.Controls.Add(this.btnResetRails);
            this.groupBox1.Controls.Add(this.btnLoadRails);
            this.groupBox1.Controls.Add(this.lblRuneNumber);
            this.groupBox1.Controls.Add(this.txtRailName);
            this.groupBox1.Controls.Add(this.txtRuneNumber);
            this.groupBox1.Controls.Add(this.btnSaveRails);
            this.groupBox1.Controls.Add(this.btnStopRail);
            this.groupBox1.Controls.Add(this.btnStartRail);
            this.groupBox1.Controls.Add(this.btnRemoveRail);
            this.groupBox1.Controls.Add(this.btnAddRail);
            this.groupBox1.Controls.Add(this.lblRails);
            this.groupBox1.Controls.Add(this.listRails);
            this.groupBox1.Controls.Add(this.btnRemoveRunebook);
            this.groupBox1.Controls.Add(this.btnAddRunebook);
            this.groupBox1.Controls.Add(this.lblRunebooks);
            this.groupBox1.Controls.Add(this.listRunebooks);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 622);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rail Settings";
            // 
            // btnCreateNewRail
            // 
            this.btnCreateNewRail.Location = new System.Drawing.Point(8, 385);
            this.btnCreateNewRail.Name = "btnCreateNewRail";
            this.btnCreateNewRail.Size = new System.Drawing.Size(182, 136);
            this.btnCreateNewRail.TabIndex = 15;
            this.btnCreateNewRail.Text = "Create New Rail File";
            this.btnCreateNewRail.UseVisualStyleBackColor = true;
            this.btnCreateNewRail.Click += new System.EventHandler(this.btnCreateNewRail_Click);
            // 
            // lblRailFile
            // 
            this.lblRailFile.AutoSize = true;
            this.lblRailFile.Location = new System.Drawing.Point(6, 22);
            this.lblRailFile.Name = "lblRailFile";
            this.lblRailFile.Size = new System.Drawing.Size(133, 20);
            this.lblRailFile.TabIndex = 14;
            this.lblRailFile.Text = "No rail file chosen";
            // 
            // btnRailFile
            // 
            this.btnRailFile.Location = new System.Drawing.Point(7, 45);
            this.btnRailFile.Name = "btnRailFile";
            this.btnRailFile.Size = new System.Drawing.Size(378, 31);
            this.btnRailFile.TabIndex = 13;
            this.btnRailFile.Text = "Rail File";
            this.btnRailFile.UseVisualStyleBackColor = true;
            this.btnRailFile.Click += new System.EventHandler(this.btnRailFile_Click);
            // 
            // btnContinueBuildRail
            // 
            this.btnContinueBuildRail.Location = new System.Drawing.Point(206, 493);
            this.btnContinueBuildRail.Name = "btnContinueBuildRail";
            this.btnContinueBuildRail.Size = new System.Drawing.Size(179, 28);
            this.btnContinueBuildRail.TabIndex = 12;
            this.btnContinueBuildRail.Text = "Continue";
            this.btnContinueBuildRail.UseVisualStyleBackColor = true;
            this.btnContinueBuildRail.Click += new System.EventHandler(this.btnContinueBuildRail_Click);
            // 
            // btnPauseBuildRail
            // 
            this.btnPauseBuildRail.Location = new System.Drawing.Point(206, 459);
            this.btnPauseBuildRail.Name = "btnPauseBuildRail";
            this.btnPauseBuildRail.Size = new System.Drawing.Size(179, 28);
            this.btnPauseBuildRail.TabIndex = 11;
            this.btnPauseBuildRail.Text = "Pause";
            this.btnPauseBuildRail.UseVisualStyleBackColor = true;
            this.btnPauseBuildRail.Click += new System.EventHandler(this.btnPauseBuildRail_Click);
            // 
            // lblRailName
            // 
            this.lblRailName.AutoSize = true;
            this.lblRailName.Location = new System.Drawing.Point(209, 352);
            this.lblRailName.Name = "lblRailName";
            this.lblRailName.Size = new System.Drawing.Size(86, 20);
            this.lblRailName.TabIndex = 10;
            this.lblRailName.Text = "Rail Name:";
            // 
            // btnResetRails
            // 
            this.btnResetRails.Enabled = false;
            this.btnResetRails.Location = new System.Drawing.Point(5, 591);
            this.btnResetRails.Name = "btnResetRails";
            this.btnResetRails.Size = new System.Drawing.Size(384, 26);
            this.btnResetRails.TabIndex = 1;
            this.btnResetRails.Text = "Reset Rails";
            this.btnResetRails.UseVisualStyleBackColor = true;
            this.btnResetRails.Click += new System.EventHandler(this.btnResetRails_Click);
            // 
            // btnLoadRails
            // 
            this.btnLoadRails.Location = new System.Drawing.Point(5, 559);
            this.btnLoadRails.Name = "btnLoadRails";
            this.btnLoadRails.Size = new System.Drawing.Size(384, 26);
            this.btnLoadRails.TabIndex = 1;
            this.btnLoadRails.Text = "Load Rails";
            this.btnLoadRails.UseVisualStyleBackColor = true;
            this.btnLoadRails.Click += new System.EventHandler(this.btnLoadRails_Click);
            // 
            // lblRuneNumber
            // 
            this.lblRuneNumber.AutoSize = true;
            this.lblRuneNumber.Location = new System.Drawing.Point(230, 320);
            this.lblRuneNumber.Name = "lblRuneNumber";
            this.lblRuneNumber.Size = new System.Drawing.Size(65, 20);
            this.lblRuneNumber.TabIndex = 10;
            this.lblRuneNumber.Text = "Rune #:";
            // 
            // txtRailName
            // 
            this.txtRailName.Location = new System.Drawing.Point(301, 349);
            this.txtRailName.Name = "txtRailName";
            this.txtRailName.Size = new System.Drawing.Size(88, 26);
            this.txtRailName.TabIndex = 1;
            // 
            // txtRuneNumber
            // 
            this.txtRuneNumber.Location = new System.Drawing.Point(301, 317);
            this.txtRuneNumber.Name = "txtRuneNumber";
            this.txtRuneNumber.Size = new System.Drawing.Size(88, 26);
            this.txtRuneNumber.TabIndex = 1;
            // 
            // btnSaveRails
            // 
            this.btnSaveRails.Location = new System.Drawing.Point(5, 527);
            this.btnSaveRails.Name = "btnSaveRails";
            this.btnSaveRails.Size = new System.Drawing.Size(384, 26);
            this.btnSaveRails.TabIndex = 1;
            this.btnSaveRails.Text = "Save Rails";
            this.btnSaveRails.UseVisualStyleBackColor = true;
            this.btnSaveRails.Click += new System.EventHandler(this.btnSaveRails_Click);
            // 
            // btnStopRail
            // 
            this.btnStopRail.Location = new System.Drawing.Point(302, 422);
            this.btnStopRail.Name = "btnStopRail";
            this.btnStopRail.Size = new System.Drawing.Size(83, 31);
            this.btnStopRail.TabIndex = 9;
            this.btnStopRail.Text = "Stop";
            this.btnStopRail.UseVisualStyleBackColor = true;
            this.btnStopRail.Click += new System.EventHandler(this.btnStopRail_Click);
            // 
            // btnStartRail
            // 
            this.btnStartRail.Location = new System.Drawing.Point(208, 422);
            this.btnStartRail.Name = "btnStartRail";
            this.btnStartRail.Size = new System.Drawing.Size(88, 31);
            this.btnStartRail.TabIndex = 8;
            this.btnStartRail.Text = "Start";
            this.btnStartRail.UseVisualStyleBackColor = true;
            this.btnStartRail.Click += new System.EventHandler(this.btnStartRail_Click);
            // 
            // btnRemoveRail
            // 
            this.btnRemoveRail.Location = new System.Drawing.Point(302, 385);
            this.btnRemoveRail.Name = "btnRemoveRail";
            this.btnRemoveRail.Size = new System.Drawing.Size(83, 31);
            this.btnRemoveRail.TabIndex = 7;
            this.btnRemoveRail.Text = "Remove";
            this.btnRemoveRail.UseVisualStyleBackColor = true;
            this.btnRemoveRail.Click += new System.EventHandler(this.btnRemoveRail_Click);
            // 
            // btnAddRail
            // 
            this.btnAddRail.Location = new System.Drawing.Point(208, 385);
            this.btnAddRail.Name = "btnAddRail";
            this.btnAddRail.Size = new System.Drawing.Size(88, 31);
            this.btnAddRail.TabIndex = 6;
            this.btnAddRail.Text = "Add";
            this.btnAddRail.UseVisualStyleBackColor = true;
            this.btnAddRail.Click += new System.EventHandler(this.btnAddRail_Click);
            // 
            // lblRails
            // 
            this.lblRails.AutoSize = true;
            this.lblRails.Location = new System.Drawing.Point(203, 84);
            this.lblRails.Name = "lblRails";
            this.lblRails.Size = new System.Drawing.Size(44, 20);
            this.lblRails.TabIndex = 5;
            this.lblRails.Text = "Rails";
            // 
            // listRails
            // 
            this.listRails.FormattingEnabled = true;
            this.listRails.ItemHeight = 20;
            this.listRails.Location = new System.Drawing.Point(205, 107);
            this.listRails.Name = "listRails";
            this.listRails.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listRails.Size = new System.Drawing.Size(184, 204);
            this.listRails.TabIndex = 4;
            // 
            // btnRemoveRunebook
            // 
            this.btnRemoveRunebook.Location = new System.Drawing.Point(101, 317);
            this.btnRemoveRunebook.Name = "btnRemoveRunebook";
            this.btnRemoveRunebook.Size = new System.Drawing.Size(88, 31);
            this.btnRemoveRunebook.TabIndex = 3;
            this.btnRemoveRunebook.Text = "Remove";
            this.btnRemoveRunebook.UseVisualStyleBackColor = true;
            this.btnRemoveRunebook.Click += new System.EventHandler(this.btnRemoveRunebook_Click);
            // 
            // btnAddRunebook
            // 
            this.btnAddRunebook.Location = new System.Drawing.Point(5, 317);
            this.btnAddRunebook.Name = "btnAddRunebook";
            this.btnAddRunebook.Size = new System.Drawing.Size(88, 31);
            this.btnAddRunebook.TabIndex = 2;
            this.btnAddRunebook.Text = "Add";
            this.btnAddRunebook.UseVisualStyleBackColor = true;
            this.btnAddRunebook.Click += new System.EventHandler(this.btnAddRunebook_Click);
            // 
            // lblRunebooks
            // 
            this.lblRunebooks.AutoSize = true;
            this.lblRunebooks.Location = new System.Drawing.Point(3, 84);
            this.lblRunebooks.Name = "lblRunebooks";
            this.lblRunebooks.Size = new System.Drawing.Size(91, 20);
            this.lblRunebooks.TabIndex = 1;
            this.lblRunebooks.Text = "Runebooks";
            // 
            // listRunebooks
            // 
            this.listRunebooks.FormattingEnabled = true;
            this.listRunebooks.ItemHeight = 20;
            this.listRunebooks.Location = new System.Drawing.Point(5, 107);
            this.listRunebooks.Name = "listRunebooks";
            this.listRunebooks.Size = new System.Drawing.Size(184, 204);
            this.listRunebooks.TabIndex = 0;
            // 
            // tabWatch
            // 
            this.tabWatch.Controls.Add(this.cboxStealthLoot);
            this.tabWatch.Controls.Add(this.btnStopWatching);
            this.tabWatch.Controls.Add(this.btnStartWatching);
            this.tabWatch.Controls.Add(this.txtWatchStatus);
            this.tabWatch.Location = new System.Drawing.Point(4, 29);
            this.tabWatch.Name = "tabWatch";
            this.tabWatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabWatch.Size = new System.Drawing.Size(879, 636);
            this.tabWatch.TabIndex = 1;
            this.tabWatch.Text = "Watch";
            this.tabWatch.UseVisualStyleBackColor = true;
            // 
            // cboxStealthLoot
            // 
            this.cboxStealthLoot.AutoSize = true;
            this.cboxStealthLoot.Location = new System.Drawing.Point(33, 602);
            this.cboxStealthLoot.Name = "cboxStealthLoot";
            this.cboxStealthLoot.Size = new System.Drawing.Size(172, 24);
            this.cboxStealthLoot.TabIndex = 2;
            this.cboxStealthLoot.Text = "Loot while Stealthed";
            this.cboxStealthLoot.UseVisualStyleBackColor = true;
            // 
            // btnStopWatching
            // 
            this.btnStopWatching.Location = new System.Drawing.Point(416, 596);
            this.btnStopWatching.Name = "btnStopWatching";
            this.btnStopWatching.Size = new System.Drawing.Size(149, 34);
            this.btnStopWatching.TabIndex = 1;
            this.btnStopWatching.Text = "Stop Watching";
            this.btnStopWatching.UseVisualStyleBackColor = true;
            // 
            // btnStartWatching
            // 
            this.btnStartWatching.Location = new System.Drawing.Point(261, 596);
            this.btnStartWatching.Name = "btnStartWatching";
            this.btnStartWatching.Size = new System.Drawing.Size(149, 34);
            this.btnStartWatching.TabIndex = 1;
            this.btnStartWatching.Text = "Start Watching";
            this.btnStartWatching.UseVisualStyleBackColor = true;
            this.btnStartWatching.Click += new System.EventHandler(this.btnStartWatching_Click);
            // 
            // txtWatchStatus
            // 
            this.txtWatchStatus.Location = new System.Drawing.Point(8, 6);
            this.txtWatchStatus.Multiline = true;
            this.txtWatchStatus.Name = "txtWatchStatus";
            this.txtWatchStatus.Size = new System.Drawing.Size(865, 584);
            this.txtWatchStatus.TabIndex = 0;
            // 
            // tabLoot
            // 
            this.tabLoot.Controls.Add(this.btnLootTest);
            this.tabLoot.Controls.Add(this.btnSaveLootList);
            this.tabLoot.Controls.Add(this.dataLootList);
            this.tabLoot.Controls.Add(this.gboxAddLoot);
            this.tabLoot.Location = new System.Drawing.Point(4, 29);
            this.tabLoot.Name = "tabLoot";
            this.tabLoot.Size = new System.Drawing.Size(879, 636);
            this.tabLoot.TabIndex = 2;
            this.tabLoot.Text = "Loot";
            this.tabLoot.UseVisualStyleBackColor = true;
            // 
            // btnSaveLootList
            // 
            this.btnSaveLootList.Location = new System.Drawing.Point(470, 583);
            this.btnSaveLootList.Name = "btnSaveLootList";
            this.btnSaveLootList.Size = new System.Drawing.Size(205, 50);
            this.btnSaveLootList.TabIndex = 4;
            this.btnSaveLootList.Text = "Save Loot List";
            this.btnSaveLootList.UseVisualStyleBackColor = true;
            this.btnSaveLootList.Click += new System.EventHandler(this.btnSaveLootList_Click);
            // 
            // dataLootList
            // 
            this.dataLootList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLootList.Location = new System.Drawing.Point(470, 3);
            this.dataLootList.Name = "dataLootList";
            this.dataLootList.Size = new System.Drawing.Size(409, 574);
            this.dataLootList.TabIndex = 3;
            // 
            // gboxAddLoot
            // 
            this.gboxAddLoot.Controls.Add(this.btnAddLootType);
            this.gboxAddLoot.Controls.Add(this.btnAddLootName);
            this.gboxAddLoot.Controls.Add(this.lblAddLootType);
            this.gboxAddLoot.Controls.Add(this.lblAddLootName);
            this.gboxAddLoot.Controls.Add(this.txtAddlootType);
            this.gboxAddLoot.Controls.Add(this.txtAddLootName);
            this.gboxAddLoot.Controls.Add(this.btnAddLootTarget);
            this.gboxAddLoot.Location = new System.Drawing.Point(3, 3);
            this.gboxAddLoot.Name = "gboxAddLoot";
            this.gboxAddLoot.Size = new System.Drawing.Size(461, 96);
            this.gboxAddLoot.TabIndex = 1;
            this.gboxAddLoot.TabStop = false;
            this.gboxAddLoot.Text = "Add Loot Methods";
            // 
            // btnAddLootType
            // 
            this.btnAddLootType.Location = new System.Drawing.Point(251, 25);
            this.btnAddLootType.Name = "btnAddLootType";
            this.btnAddLootType.Size = new System.Drawing.Size(98, 26);
            this.btnAddLootType.TabIndex = 2;
            this.btnAddLootType.Text = "Add";
            this.btnAddLootType.UseVisualStyleBackColor = true;
            this.btnAddLootType.Click += new System.EventHandler(this.btnAddLootType_Click);
            // 
            // btnAddLootName
            // 
            this.btnAddLootName.Location = new System.Drawing.Point(251, 57);
            this.btnAddLootName.Name = "btnAddLootName";
            this.btnAddLootName.Size = new System.Drawing.Size(98, 26);
            this.btnAddLootName.TabIndex = 2;
            this.btnAddLootName.Text = "Add";
            this.btnAddLootName.UseVisualStyleBackColor = true;
            this.btnAddLootName.Click += new System.EventHandler(this.btnAddLootName_Click);
            // 
            // lblAddLootType
            // 
            this.lblAddLootType.AutoSize = true;
            this.lblAddLootType.Location = new System.Drawing.Point(14, 28);
            this.lblAddLootType.Name = "lblAddLootType";
            this.lblAddLootType.Size = new System.Drawing.Size(47, 20);
            this.lblAddLootType.TabIndex = 2;
            this.lblAddLootType.Text = "Type:";
            // 
            // lblAddLootName
            // 
            this.lblAddLootName.AutoSize = true;
            this.lblAddLootName.Location = new System.Drawing.Point(6, 60);
            this.lblAddLootName.Name = "lblAddLootName";
            this.lblAddLootName.Size = new System.Drawing.Size(55, 20);
            this.lblAddLootName.TabIndex = 2;
            this.lblAddLootName.Text = "Name:";
            // 
            // txtAddlootType
            // 
            this.txtAddlootType.Location = new System.Drawing.Point(67, 25);
            this.txtAddlootType.Name = "txtAddlootType";
            this.txtAddlootType.Size = new System.Drawing.Size(178, 26);
            this.txtAddlootType.TabIndex = 1;
            // 
            // txtAddLootName
            // 
            this.txtAddLootName.Location = new System.Drawing.Point(67, 57);
            this.txtAddLootName.Name = "txtAddLootName";
            this.txtAddLootName.Size = new System.Drawing.Size(178, 26);
            this.txtAddLootName.TabIndex = 1;
            // 
            // btnAddLootTarget
            // 
            this.btnAddLootTarget.Location = new System.Drawing.Point(355, 25);
            this.btnAddLootTarget.Name = "btnAddLootTarget";
            this.btnAddLootTarget.Size = new System.Drawing.Size(100, 58);
            this.btnAddLootTarget.TabIndex = 0;
            this.btnAddLootTarget.Text = "Target";
            this.btnAddLootTarget.UseVisualStyleBackColor = true;
            this.btnAddLootTarget.Click += new System.EventHandler(this.btnAddLootTarget_Click);
            // 
            // tabHouses
            // 
            this.tabHouses.Controls.Add(this.cboxShardDisplay);
            this.tabHouses.Controls.Add(this.btnRefreshDataGrid);
            this.tabHouses.Controls.Add(this.dataGridView1);
            this.tabHouses.Location = new System.Drawing.Point(4, 29);
            this.tabHouses.Name = "tabHouses";
            this.tabHouses.Padding = new System.Windows.Forms.Padding(3);
            this.tabHouses.Size = new System.Drawing.Size(879, 636);
            this.tabHouses.TabIndex = 4;
            this.tabHouses.Text = "Houses";
            this.tabHouses.UseVisualStyleBackColor = true;
            // 
            // cboxShardDisplay
            // 
            this.cboxShardDisplay.FormattingEnabled = true;
            this.cboxShardDisplay.Items.AddRange(new object[] {
            "ALL",
            "Great Lakes",
            "Lake Superior",
            "Napa Valley"});
            this.cboxShardDisplay.Location = new System.Drawing.Point(8, 6);
            this.cboxShardDisplay.Name = "cboxShardDisplay";
            this.cboxShardDisplay.Size = new System.Drawing.Size(190, 28);
            this.cboxShardDisplay.TabIndex = 3;
            this.cboxShardDisplay.Text = "Select Shard";
            this.cboxShardDisplay.SelectedIndexChanged += new System.EventHandler(this.cboxShardDisplay_SelectedIndexChanged);
            // 
            // btnRefreshDataGrid
            // 
            this.btnRefreshDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshDataGrid.Location = new System.Drawing.Point(8, 600);
            this.btnRefreshDataGrid.Name = "btnRefreshDataGrid";
            this.btnRefreshDataGrid.Size = new System.Drawing.Size(84, 30);
            this.btnRefreshDataGrid.TabIndex = 1;
            this.btnRefreshDataGrid.Text = "Refresh";
            this.btnRefreshDataGrid.UseVisualStyleBackColor = true;
            this.btnRefreshDataGrid.Click += new System.EventHandler(this.btnRefreshDataGrid_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(865, 554);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabDebug
            // 
            this.tabDebug.Controls.Add(this.button1);
            this.tabDebug.Controls.Add(this.btnDebugSearchItems);
            this.tabDebug.Controls.Add(this.txtDebugStatus);
            this.tabDebug.Controls.Add(this.btnDebugGetID);
            this.tabDebug.Location = new System.Drawing.Point(4, 29);
            this.tabDebug.Name = "tabDebug";
            this.tabDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tabDebug.Size = new System.Drawing.Size(879, 636);
            this.tabDebug.TabIndex = 3;
            this.tabDebug.Text = "Debug";
            this.tabDebug.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDebugSearchItems
            // 
            this.btnDebugSearchItems.Location = new System.Drawing.Point(273, 82);
            this.btnDebugSearchItems.Name = "btnDebugSearchItems";
            this.btnDebugSearchItems.Size = new System.Drawing.Size(103, 50);
            this.btnDebugSearchItems.TabIndex = 2;
            this.btnDebugSearchItems.Text = "Search Items";
            this.btnDebugSearchItems.UseVisualStyleBackColor = true;
            this.btnDebugSearchItems.Click += new System.EventHandler(this.btnDebugSearchItems_Click);
            // 
            // txtDebugStatus
            // 
            this.txtDebugStatus.Location = new System.Drawing.Point(125, 218);
            this.txtDebugStatus.Multiline = true;
            this.txtDebugStatus.Name = "txtDebugStatus";
            this.txtDebugStatus.Size = new System.Drawing.Size(527, 350);
            this.txtDebugStatus.TabIndex = 1;
            // 
            // btnDebugGetID
            // 
            this.btnDebugGetID.Location = new System.Drawing.Point(86, 82);
            this.btnDebugGetID.Name = "btnDebugGetID";
            this.btnDebugGetID.Size = new System.Drawing.Size(75, 50);
            this.btnDebugGetID.TabIndex = 0;
            this.btnDebugGetID.Text = "Get ID";
            this.btnDebugGetID.UseVisualStyleBackColor = true;
            this.btnDebugGetID.Click += new System.EventHandler(this.btnDebugGetID_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.cboxSettingShard);
            this.tabSettings.Controls.Add(this.cboxStealthSearch);
            this.tabSettings.Controls.Add(this.btnLoadSettings);
            this.tabSettings.Controls.Add(this.btnSaveSettings);
            this.tabSettings.Controls.Add(this.lblSafeRuneNumber);
            this.tabSettings.Controls.Add(this.txtSafeRuneNumber);
            this.tabSettings.Controls.Add(this.btnSetSafeRunebook);
            this.tabSettings.Location = new System.Drawing.Point(4, 29);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(879, 636);
            this.tabSettings.TabIndex = 5;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // cboxSettingShard
            // 
            this.cboxSettingShard.FormattingEnabled = true;
            this.cboxSettingShard.Items.AddRange(new object[] {
            "Great Lakes",
            "Lake Superior"});
            this.cboxSettingShard.Location = new System.Drawing.Point(8, 58);
            this.cboxSettingShard.Name = "cboxSettingShard";
            this.cboxSettingShard.Size = new System.Drawing.Size(154, 28);
            this.cboxSettingShard.TabIndex = 6;
            this.cboxSettingShard.Text = "Select Shard";
            // 
            // cboxStealthSearch
            // 
            this.cboxStealthSearch.AutoSize = true;
            this.cboxStealthSearch.Location = new System.Drawing.Point(514, 60);
            this.cboxStealthSearch.Name = "cboxStealthSearch";
            this.cboxStealthSearch.Size = new System.Drawing.Size(191, 24);
            this.cboxStealthSearch.TabIndex = 5;
            this.cboxStealthSearch.Text = "Stealth while searching";
            this.cboxStealthSearch.UseVisualStyleBackColor = true;
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Location = new System.Drawing.Point(753, 593);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(123, 40);
            this.btnLoadSettings.TabIndex = 4;
            this.btnLoadSettings.Text = "Load Settings";
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(624, 593);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(123, 40);
            this.btnSaveSettings.TabIndex = 3;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // lblSafeRuneNumber
            // 
            this.lblSafeRuneNumber.AutoSize = true;
            this.lblSafeRuneNumber.Location = new System.Drawing.Point(203, 38);
            this.lblSafeRuneNumber.Name = "lblSafeRuneNumber";
            this.lblSafeRuneNumber.Size = new System.Drawing.Size(108, 20);
            this.lblSafeRuneNumber.TabIndex = 2;
            this.lblSafeRuneNumber.Text = "Rune Number";
            // 
            // txtSafeRuneNumber
            // 
            this.txtSafeRuneNumber.Location = new System.Drawing.Point(207, 62);
            this.txtSafeRuneNumber.Name = "txtSafeRuneNumber";
            this.txtSafeRuneNumber.Size = new System.Drawing.Size(100, 26);
            this.txtSafeRuneNumber.TabIndex = 1;
            // 
            // btnSetSafeRunebook
            // 
            this.btnSetSafeRunebook.Location = new System.Drawing.Point(335, 36);
            this.btnSetSafeRunebook.Name = "btnSetSafeRunebook";
            this.btnSetSafeRunebook.Size = new System.Drawing.Size(95, 50);
            this.btnSetSafeRunebook.TabIndex = 0;
            this.btnSetSafeRunebook.Text = "Set Safe Runebook";
            this.btnSetSafeRunebook.UseVisualStyleBackColor = true;
            this.btnSetSafeRunebook.Click += new System.EventHandler(this.btnSetSafeRunebook_Click);
            // 
            // tabCalendar
            // 
            this.tabCalendar.Controls.Add(this.txtCalendarOutput);
            this.tabCalendar.Controls.Add(this.btnCalendarConnect);
            this.tabCalendar.Location = new System.Drawing.Point(4, 29);
            this.tabCalendar.Name = "tabCalendar";
            this.tabCalendar.Size = new System.Drawing.Size(879, 636);
            this.tabCalendar.TabIndex = 6;
            this.tabCalendar.Text = "Calendar";
            this.tabCalendar.UseVisualStyleBackColor = true;
            // 
            // txtCalendarOutput
            // 
            this.txtCalendarOutput.Location = new System.Drawing.Point(8, 3);
            this.txtCalendarOutput.Multiline = true;
            this.txtCalendarOutput.Name = "txtCalendarOutput";
            this.txtCalendarOutput.Size = new System.Drawing.Size(410, 452);
            this.txtCalendarOutput.TabIndex = 1;
            // 
            // btnCalendarConnect
            // 
            this.btnCalendarConnect.Location = new System.Drawing.Point(779, 601);
            this.btnCalendarConnect.Name = "btnCalendarConnect";
            this.btnCalendarConnect.Size = new System.Drawing.Size(97, 32);
            this.btnCalendarConnect.TabIndex = 0;
            this.btnCalendarConnect.Text = "Connect";
            this.btnCalendarConnect.UseVisualStyleBackColor = true;
            this.btnCalendarConnect.Click += new System.EventHandler(this.btnCalendarConnect_Click);
            // 
            // workerBuildRail
            // 
            this.workerBuildRail.WorkerReportsProgress = true;
            this.workerBuildRail.WorkerSupportsCancellation = true;
            this.workerBuildRail.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerBuildRail_DoWork);
            this.workerBuildRail.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerBuildRail_ProgressChanged);
            this.workerBuildRail.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerBuildRail_RunWorkerCompleted);
            // 
            // workerSearch
            // 
            this.workerSearch.WorkerReportsProgress = true;
            this.workerSearch.WorkerSupportsCancellation = true;
            this.workerSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerSearch_DoWork);
            this.workerSearch.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerSearch_ProgressChanged);
            this.workerSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerSearch_RunWorkerCompleted);
            // 
            // workerCheckHouses
            // 
            this.workerCheckHouses.WorkerReportsProgress = true;
            this.workerCheckHouses.WorkerSupportsCancellation = true;
            this.workerCheckHouses.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerCheckHouses_DoWork);
            this.workerCheckHouses.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerCheckHouses_ProgressChanged);
            this.workerCheckHouses.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerCheckHouses_RunWorkerCompleted);
            // 
            // workerWatch
            // 
            this.workerWatch.WorkerReportsProgress = true;
            this.workerWatch.WorkerSupportsCancellation = true;
            this.workerWatch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerWatch_DoWork);
            this.workerWatch.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerWatch_ProgressChanged);
            this.workerWatch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerWatch_RunWorkerCompleted);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + \"\\\\Stealth\\\\FA" +
    "IL\"";
            // 
            // btnLootTest
            // 
            this.btnLootTest.Location = new System.Drawing.Point(3, 558);
            this.btnLootTest.Name = "btnLootTest";
            this.btnLootTest.Size = new System.Drawing.Size(136, 75);
            this.btnLootTest.TabIndex = 5;
            this.btnLootTest.Text = "Test";
            this.btnLootTest.UseVisualStyleBackColor = true;
            this.btnLootTest.Click += new System.EventHandler(this.btnLootTest_Click);
            // 
            // FAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 681);
            this.Controls.Add(this.tabFailTabs);
            this.Name = "FAIL";
            this.Text = "FAIL - Fully Automated IDOC Looter - v.0.0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FAIL_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FAIL_FormClosed);
            this.Load += new System.EventHandler(this.FAIL_Load);
            this.tabFailTabs.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabWatch.ResumeLayout(false);
            this.tabWatch.PerformLayout();
            this.tabLoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLootList)).EndInit();
            this.gboxAddLoot.ResumeLayout(false);
            this.gboxAddLoot.PerformLayout();
            this.tabHouses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabDebug.ResumeLayout(false);
            this.tabDebug.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabCalendar.ResumeLayout(false);
            this.tabCalendar.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tabFailTabs;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveRail;
        private System.Windows.Forms.Button btnAddRail;
        private System.Windows.Forms.Label lblRails;
        private System.Windows.Forms.ListBox listRails;
        private System.Windows.Forms.Button btnRemoveRunebook;
        private System.Windows.Forms.Button btnAddRunebook;
        private System.Windows.Forms.Label lblRunebooks;
        private System.Windows.Forms.ListBox listRunebooks;
        private System.Windows.Forms.TabPage tabWatch;
        private System.Windows.Forms.TabPage tabLoot;
        private System.Windows.Forms.Button btnStopRail;
        private System.Windows.Forms.Button btnStartRail;
        private System.Windows.Forms.Button btnResetRails;
        private System.Windows.Forms.Button btnLoadRails;
        private System.Windows.Forms.Button btnSaveRails;
        private System.Windows.Forms.Label lblRuneNumber;
        private System.Windows.Forms.TextBox txtRuneNumber;
        private System.Windows.Forms.Label lblRailName;
        private System.Windows.Forms.TextBox txtRailName;
        private System.ComponentModel.BackgroundWorker workerBuildRail;
        private System.Windows.Forms.Button btnStopSearch;
        private System.Windows.Forms.Button btnStartSearch;
        private System.ComponentModel.BackgroundWorker workerSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.ComponentModel.BackgroundWorker workerCheckHouses;
        private System.Windows.Forms.TabPage tabDebug;
        private System.Windows.Forms.Button btnDebugGetID;
        private System.Windows.Forms.TextBox txtDebugStatus;
        private System.Windows.Forms.Button btnDebugSearchItems;
        private System.Windows.Forms.TextBox txtHouseStatus;
        private System.Windows.Forms.Button btnSaveHouses;
        private System.Windows.Forms.Button btnLoadHouses;
        private System.Windows.Forms.TabPage tabHouses;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblSafeRuneNumber;
        private System.Windows.Forms.TextBox txtSafeRuneNumber;
        private System.Windows.Forms.Button btnSetSafeRunebook;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefreshDataGrid;
        private System.Windows.Forms.Button btnContinueBuildRail;
        private System.Windows.Forms.Button btnPauseBuildRail;
        private System.Windows.Forms.CheckBox cboxStealthSearch;
        private System.Windows.Forms.Button btnPauseSearch;
        private System.Windows.Forms.Button btnStopWatching;
        private System.Windows.Forms.Button btnStartWatching;
        private System.Windows.Forms.TextBox txtWatchStatus;
        private System.ComponentModel.BackgroundWorker workerWatch;
        private System.Windows.Forms.TextBox txtStartLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabCalendar;
        private System.Windows.Forms.Button btnCalendarConnect;
        private System.Windows.Forms.TextBox txtCalendarOutput;
        private System.Windows.Forms.ComboBox cboxShardSelect;
        private System.Windows.Forms.ComboBox cboxShardDisplay;
        private System.Windows.Forms.Label lblRailFile;
        private System.Windows.Forms.Button btnRailFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCreateNewRail;
        private System.Windows.Forms.ComboBox cboxSettingShard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gboxAddLoot;
        private System.Windows.Forms.Button btnAddLootType;
        private System.Windows.Forms.Button btnAddLootName;
        private System.Windows.Forms.Label lblAddLootType;
        private System.Windows.Forms.Label lblAddLootName;
        private System.Windows.Forms.TextBox txtAddlootType;
        private System.Windows.Forms.TextBox txtAddLootName;
        private System.Windows.Forms.Button btnAddLootTarget;
        private System.Windows.Forms.DataGridView dataLootList;
        private System.Windows.Forms.Button btnSaveLootList;
        private System.Windows.Forms.CheckBox cboxStealthLoot;
        private System.Windows.Forms.Button btnLootTest;
    }
}

