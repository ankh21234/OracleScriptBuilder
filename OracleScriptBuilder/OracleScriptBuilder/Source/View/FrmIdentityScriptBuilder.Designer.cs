namespace OracleScriptBuilder.Source.View
{
    partial class FrmIdentityScriptBuilder
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
            this.tblLytMain = new System.Windows.Forms.TableLayoutPanel();
            this.tbCtrlTables = new System.Windows.Forms.TabControl();
            this.tbPgTables = new System.Windows.Forms.TabPage();
            this.tblLytTables = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytTableChoose = new System.Windows.Forms.TableLayoutPanel();
            this.lstTables = new System.Windows.Forms.CheckedListBox();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.lblDbTables = new System.Windows.Forms.Label();
            this.tblLytSaveAndAddList = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddTablesToList = new System.Windows.Forms.Button();
            this.btnFastSave = new System.Windows.Forms.Button();
            this.tblLytMainList = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.lstMainTables = new System.Windows.Forms.ListBox();
            this.lblScriptTables = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbPgLog = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.tbPgScript = new System.Windows.Forms.TabPage();
            this.txtScriptState = new System.Windows.Forms.RichTextBox();
            this.tblLytConnButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnGetTables = new System.Windows.Forms.Button();
            this.btnBuildConnString = new System.Windows.Forms.Button();
            this.tblLytSavePath = new System.Windows.Forms.TableLayoutPanel();
            this.lblSavePath = new System.Windows.Forms.Label();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblLytTruncateAndComboxes = new System.Windows.Forms.TableLayoutPanel();
            this.chkTruncate = new System.Windows.Forms.CheckBox();
            this.lblScriptType = new System.Windows.Forms.Label();
            this.lblSaveType = new System.Windows.Forms.Label();
            this.cmbxScriptType = new System.Windows.Forms.ComboBox();
            this.cmbxSaveType = new System.Windows.Forms.ComboBox();
            this.tblLytConnStr = new System.Windows.Forms.TableLayoutPanel();
            this.lblConnStr = new System.Windows.Forms.Label();
            this.txtConnStr = new System.Windows.Forms.TextBox();
            this.tblLytConnStrBuild = new System.Windows.Forms.TableLayoutPanel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblDb = new System.Windows.Forms.Label();
            this.txtDb = new System.Windows.Forms.TextBox();
            this.lblAuth = new System.Windows.Forms.Label();
            this.cmbxAuth = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.tblLytMain.SuspendLayout();
            this.tbCtrlTables.SuspendLayout();
            this.tbPgTables.SuspendLayout();
            this.tblLytTables.SuspendLayout();
            this.tblLytTableChoose.SuspendLayout();
            this.tblLytSaveAndAddList.SuspendLayout();
            this.tblLytMainList.SuspendLayout();
            this.tblLytButtons.SuspendLayout();
            this.tbPgLog.SuspendLayout();
            this.tbPgScript.SuspendLayout();
            this.tblLytConnButtons.SuspendLayout();
            this.tblLytSavePath.SuspendLayout();
            this.tblLytTruncateAndComboxes.SuspendLayout();
            this.tblLytConnStr.SuspendLayout();
            this.tblLytConnStrBuild.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLytMain
            // 
            this.tblLytMain.ColumnCount = 1;
            this.tblLytMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.Controls.Add(this.tbCtrlTables, 0, 4);
            this.tblLytMain.Controls.Add(this.tblLytConnButtons, 0, 2);
            this.tblLytMain.Controls.Add(this.tblLytSavePath, 0, 5);
            this.tblLytMain.Controls.Add(this.btnSave, 0, 6);
            this.tblLytMain.Controls.Add(this.tblLytTruncateAndComboxes, 0, 3);
            this.tblLytMain.Controls.Add(this.tblLytConnStr, 0, 1);
            this.tblLytMain.Controls.Add(this.tblLytConnStrBuild, 0, 0);
            this.tblLytMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytMain.Location = new System.Drawing.Point(0, 0);
            this.tblLytMain.Name = "tblLytMain";
            this.tblLytMain.RowCount = 7;
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytMain.Size = new System.Drawing.Size(834, 711);
            this.tblLytMain.TabIndex = 1;
            // 
            // tbCtrlTables
            // 
            this.tbCtrlTables.Controls.Add(this.tbPgTables);
            this.tbCtrlTables.Controls.Add(this.tbPgLog);
            this.tbCtrlTables.Controls.Add(this.tbPgScript);
            this.tbCtrlTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCtrlTables.Location = new System.Drawing.Point(3, 243);
            this.tbCtrlTables.Name = "tbCtrlTables";
            this.tbCtrlTables.SelectedIndex = 0;
            this.tbCtrlTables.Size = new System.Drawing.Size(828, 385);
            this.tbCtrlTables.TabIndex = 4;
            // 
            // tbPgTables
            // 
            this.tbPgTables.Controls.Add(this.tblLytTables);
            this.tbPgTables.Location = new System.Drawing.Point(4, 26);
            this.tbPgTables.Name = "tbPgTables";
            this.tbPgTables.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgTables.Size = new System.Drawing.Size(820, 355);
            this.tbPgTables.TabIndex = 0;
            this.tbPgTables.Text = "Tables";
            this.tbPgTables.UseVisualStyleBackColor = true;
            // 
            // tblLytTables
            // 
            this.tblLytTables.ColumnCount = 3;
            this.tblLytTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytTables.Controls.Add(this.tblLytTableChoose, 0, 0);
            this.tblLytTables.Controls.Add(this.tblLytMainList, 2, 0);
            this.tblLytTables.Controls.Add(this.btnAdd, 1, 0);
            this.tblLytTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytTables.Location = new System.Drawing.Point(3, 3);
            this.tblLytTables.Name = "tblLytTables";
            this.tblLytTables.RowCount = 1;
            this.tblLytTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytTables.Size = new System.Drawing.Size(814, 349);
            this.tblLytTables.TabIndex = 0;
            // 
            // tblLytTableChoose
            // 
            this.tblLytTableChoose.ColumnCount = 1;
            this.tblLytTableChoose.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytTableChoose.Controls.Add(this.lstTables, 0, 1);
            this.tblLytTableChoose.Controls.Add(this.chkSelectAll, 0, 2);
            this.tblLytTableChoose.Controls.Add(this.lblDbTables, 0, 0);
            this.tblLytTableChoose.Controls.Add(this.tblLytSaveAndAddList, 0, 3);
            this.tblLytTableChoose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytTableChoose.Location = new System.Drawing.Point(3, 3);
            this.tblLytTableChoose.Name = "tblLytTableChoose";
            this.tblLytTableChoose.RowCount = 4;
            this.tblLytTableChoose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLytTableChoose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytTableChoose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblLytTableChoose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytTableChoose.Size = new System.Drawing.Size(381, 343);
            this.tblLytTableChoose.TabIndex = 0;
            // 
            // lstTables
            // 
            this.lstTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTables.FormattingEnabled = true;
            this.lstTables.Location = new System.Drawing.Point(3, 33);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(375, 232);
            this.lstTables.TabIndex = 1;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(3, 275);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(85, 21);
            this.chkSelectAll.TabIndex = 2;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // lblDbTables
            // 
            this.lblDbTables.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDbTables.AutoSize = true;
            this.lblDbTables.Location = new System.Drawing.Point(3, 6);
            this.lblDbTables.Name = "lblDbTables";
            this.lblDbTables.Size = new System.Drawing.Size(124, 17);
            this.lblDbTables.TabIndex = 3;
            this.lblDbTables.Text = "Database Tables :";
            // 
            // tblLytSaveAndAddList
            // 
            this.tblLytSaveAndAddList.ColumnCount = 2;
            this.tblLytSaveAndAddList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytSaveAndAddList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytSaveAndAddList.Controls.Add(this.btnAddTablesToList, 1, 0);
            this.tblLytSaveAndAddList.Controls.Add(this.btnFastSave, 0, 0);
            this.tblLytSaveAndAddList.Location = new System.Drawing.Point(3, 306);
            this.tblLytSaveAndAddList.Name = "tblLytSaveAndAddList";
            this.tblLytSaveAndAddList.RowCount = 1;
            this.tblLytSaveAndAddList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytSaveAndAddList.Size = new System.Drawing.Size(375, 34);
            this.tblLytSaveAndAddList.TabIndex = 4;
            // 
            // btnAddTablesToList
            // 
            this.btnAddTablesToList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTablesToList.Location = new System.Drawing.Point(206, 3);
            this.btnAddTablesToList.Name = "btnAddTablesToList";
            this.btnAddTablesToList.Size = new System.Drawing.Size(150, 28);
            this.btnAddTablesToList.TabIndex = 0;
            this.btnAddTablesToList.Text = "Add Tables To List";
            this.btnAddTablesToList.UseVisualStyleBackColor = true;
            this.btnAddTablesToList.Click += new System.EventHandler(this.btnAddTablesToList_Click);
            // 
            // btnFastSave
            // 
            this.btnFastSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFastSave.Location = new System.Drawing.Point(39, 3);
            this.btnFastSave.Name = "btnFastSave";
            this.btnFastSave.Size = new System.Drawing.Size(108, 28);
            this.btnFastSave.TabIndex = 1;
            this.btnFastSave.Text = "Fast Save";
            this.btnFastSave.UseVisualStyleBackColor = true;
            this.btnFastSave.Click += new System.EventHandler(this.btnFastSave_Click);
            // 
            // tblLytMainList
            // 
            this.tblLytMainList.ColumnCount = 2;
            this.tblLytMainList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMainList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLytMainList.Controls.Add(this.tblLytButtons, 1, 1);
            this.tblLytMainList.Controls.Add(this.lstMainTables, 0, 1);
            this.tblLytMainList.Controls.Add(this.lblScriptTables, 0, 0);
            this.tblLytMainList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytMainList.Location = new System.Drawing.Point(430, 3);
            this.tblLytMainList.Name = "tblLytMainList";
            this.tblLytMainList.RowCount = 2;
            this.tblLytMainList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblLytMainList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMainList.Size = new System.Drawing.Size(381, 343);
            this.tblLytMainList.TabIndex = 1;
            // 
            // tblLytButtons
            // 
            this.tblLytButtons.ColumnCount = 1;
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytButtons.Controls.Add(this.btnUp, 0, 0);
            this.tblLytButtons.Controls.Add(this.btnRemove, 0, 1);
            this.tblLytButtons.Controls.Add(this.btnDown, 0, 2);
            this.tblLytButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytButtons.Location = new System.Drawing.Point(304, 33);
            this.tblLytButtons.Name = "tblLytButtons";
            this.tblLytButtons.RowCount = 4;
            this.tblLytButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytButtons.Size = new System.Drawing.Size(74, 307);
            this.tblLytButtons.TabIndex = 0;
            // 
            // btnUp
            // 
            this.btnUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUp.Location = new System.Drawing.Point(3, 3);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(68, 34);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.Location = new System.Drawing.Point(3, 43);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(68, 34);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDown
            // 
            this.btnDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDown.Location = new System.Drawing.Point(3, 83);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(68, 34);
            this.btnDown.TabIndex = 0;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // lstMainTables
            // 
            this.lstMainTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMainTables.FormattingEnabled = true;
            this.lstMainTables.ItemHeight = 17;
            this.lstMainTables.Location = new System.Drawing.Point(3, 33);
            this.lstMainTables.Name = "lstMainTables";
            this.lstMainTables.Size = new System.Drawing.Size(295, 307);
            this.lstMainTables.TabIndex = 1;
            // 
            // lblScriptTables
            // 
            this.lblScriptTables.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblScriptTables.AutoSize = true;
            this.lblScriptTables.Location = new System.Drawing.Point(3, 6);
            this.lblScriptTables.Name = "lblScriptTables";
            this.lblScriptTables.Size = new System.Drawing.Size(99, 17);
            this.lblScriptTables.TabIndex = 3;
            this.lblScriptTables.Text = "Script Tables :";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(390, 154);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "->";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbPgLog
            // 
            this.tbPgLog.Controls.Add(this.txtLog);
            this.tbPgLog.Location = new System.Drawing.Point(4, 26);
            this.tbPgLog.Name = "tbPgLog";
            this.tbPgLog.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgLog.Size = new System.Drawing.Size(820, 355);
            this.tbPgLog.TabIndex = 1;
            this.tbPgLog.Text = "Log";
            this.tbPgLog.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 3);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(814, 349);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // tbPgScript
            // 
            this.tbPgScript.Controls.Add(this.txtScriptState);
            this.tbPgScript.Location = new System.Drawing.Point(4, 26);
            this.tbPgScript.Name = "tbPgScript";
            this.tbPgScript.Size = new System.Drawing.Size(820, 355);
            this.tbPgScript.TabIndex = 2;
            this.tbPgScript.Text = "Script";
            this.tbPgScript.UseVisualStyleBackColor = true;
            // 
            // txtScriptState
            // 
            this.txtScriptState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScriptState.Location = new System.Drawing.Point(0, 0);
            this.txtScriptState.Name = "txtScriptState";
            this.txtScriptState.ReadOnly = true;
            this.txtScriptState.Size = new System.Drawing.Size(820, 355);
            this.txtScriptState.TabIndex = 0;
            this.txtScriptState.Text = "";
            this.txtScriptState.WordWrap = false;
            // 
            // tblLytConnButtons
            // 
            this.tblLytConnButtons.ColumnCount = 3;
            this.tblLytConnButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblLytConnButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblLytConnButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tblLytConnButtons.Controls.Add(this.btnTestConnection, 1, 0);
            this.tblLytConnButtons.Controls.Add(this.btnGetTables, 2, 0);
            this.tblLytConnButtons.Controls.Add(this.btnBuildConnString, 0, 0);
            this.tblLytConnButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytConnButtons.Location = new System.Drawing.Point(3, 163);
            this.tblLytConnButtons.Name = "tblLytConnButtons";
            this.tblLytConnButtons.RowCount = 1;
            this.tblLytConnButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytConnButtons.Size = new System.Drawing.Size(828, 34);
            this.tblLytConnButtons.TabIndex = 5;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTestConnection.Location = new System.Drawing.Point(326, 3);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(172, 28);
            this.btnTestConnection.TabIndex = 3;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnGetTables
            // 
            this.btnGetTables.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGetTables.Location = new System.Drawing.Point(589, 3);
            this.btnGetTables.Name = "btnGetTables";
            this.btnGetTables.Size = new System.Drawing.Size(200, 28);
            this.btnGetTables.TabIndex = 4;
            this.btnGetTables.Text = "Get Tables";
            this.btnGetTables.UseVisualStyleBackColor = true;
            this.btnGetTables.Click += new System.EventHandler(this.btnGetTables_Click);
            // 
            // btnBuildConnString
            // 
            this.btnBuildConnString.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuildConnString.Location = new System.Drawing.Point(54, 3);
            this.btnBuildConnString.Name = "btnBuildConnString";
            this.btnBuildConnString.Size = new System.Drawing.Size(167, 28);
            this.btnBuildConnString.TabIndex = 5;
            this.btnBuildConnString.Text = "Build Conn String";
            this.btnBuildConnString.UseVisualStyleBackColor = true;
            this.btnBuildConnString.Click += new System.EventHandler(this.btnBuildConnString_Click);
            // 
            // tblLytSavePath
            // 
            this.tblLytSavePath.ColumnCount = 3;
            this.tblLytSavePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLytSavePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytSavePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLytSavePath.Controls.Add(this.lblSavePath, 0, 0);
            this.tblLytSavePath.Controls.Add(this.txtSavePath, 1, 0);
            this.tblLytSavePath.Controls.Add(this.btnBrowse, 2, 0);
            this.tblLytSavePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytSavePath.Location = new System.Drawing.Point(3, 634);
            this.tblLytSavePath.Name = "tblLytSavePath";
            this.tblLytSavePath.RowCount = 1;
            this.tblLytSavePath.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytSavePath.Size = new System.Drawing.Size(828, 34);
            this.tblLytSavePath.TabIndex = 6;
            // 
            // lblSavePath
            // 
            this.lblSavePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSavePath.AutoSize = true;
            this.lblSavePath.Location = new System.Drawing.Point(3, 8);
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(81, 17);
            this.lblSavePath.TabIndex = 0;
            this.lblSavePath.Text = "Save Path :";
            // 
            // txtSavePath
            // 
            this.txtSavePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSavePath.Location = new System.Drawing.Point(123, 5);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.ReadOnly = true;
            this.txtSavePath.Size = new System.Drawing.Size(582, 23);
            this.txtSavePath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBrowse.Location = new System.Drawing.Point(715, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(110, 28);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(360, 675);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 31);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tblLytTruncateAndComboxes
            // 
            this.tblLytTruncateAndComboxes.ColumnCount = 5;
            this.tblLytTruncateAndComboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tblLytTruncateAndComboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytTruncateAndComboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLytTruncateAndComboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytTruncateAndComboxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLytTruncateAndComboxes.Controls.Add(this.chkTruncate, 0, 0);
            this.tblLytTruncateAndComboxes.Controls.Add(this.lblScriptType, 1, 0);
            this.tblLytTruncateAndComboxes.Controls.Add(this.lblSaveType, 3, 0);
            this.tblLytTruncateAndComboxes.Controls.Add(this.cmbxScriptType, 2, 0);
            this.tblLytTruncateAndComboxes.Controls.Add(this.cmbxSaveType, 4, 0);
            this.tblLytTruncateAndComboxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytTruncateAndComboxes.Location = new System.Drawing.Point(3, 203);
            this.tblLytTruncateAndComboxes.Name = "tblLytTruncateAndComboxes";
            this.tblLytTruncateAndComboxes.RowCount = 1;
            this.tblLytTruncateAndComboxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytTruncateAndComboxes.Size = new System.Drawing.Size(828, 34);
            this.tblLytTruncateAndComboxes.TabIndex = 10;
            // 
            // chkTruncate
            // 
            this.chkTruncate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkTruncate.Location = new System.Drawing.Point(10, 6);
            this.chkTruncate.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chkTruncate.Name = "chkTruncate";
            this.chkTruncate.Size = new System.Drawing.Size(125, 21);
            this.chkTruncate.TabIndex = 10;
            this.chkTruncate.Text = "Add Truncate Table";
            this.chkTruncate.UseVisualStyleBackColor = true;
            // 
            // lblScriptType
            // 
            this.lblScriptType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblScriptType.AutoSize = true;
            this.lblScriptType.Location = new System.Drawing.Point(150, 8);
            this.lblScriptType.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblScriptType.Name = "lblScriptType";
            this.lblScriptType.Size = new System.Drawing.Size(88, 17);
            this.lblScriptType.TabIndex = 11;
            this.lblScriptType.Text = "Script Type :";
            // 
            // lblSaveType
            // 
            this.lblSaveType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSaveType.AutoSize = true;
            this.lblSaveType.Location = new System.Drawing.Point(493, 8);
            this.lblSaveType.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblSaveType.Name = "lblSaveType";
            this.lblSaveType.Size = new System.Drawing.Size(84, 17);
            this.lblSaveType.TabIndex = 12;
            this.lblSaveType.Text = "Save Type :";
            // 
            // cmbxScriptType
            // 
            this.cmbxScriptType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbxScriptType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxScriptType.FormattingEnabled = true;
            this.cmbxScriptType.Location = new System.Drawing.Point(280, 6);
            this.cmbxScriptType.Name = "cmbxScriptType";
            this.cmbxScriptType.Size = new System.Drawing.Size(200, 25);
            this.cmbxScriptType.TabIndex = 13;
            this.cmbxScriptType.SelectedIndexChanged += new System.EventHandler(this.cmbxScriptType_SelectedIndexChanged);
            // 
            // cmbxSaveType
            // 
            this.cmbxSaveType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbxSaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSaveType.FormattingEnabled = true;
            this.cmbxSaveType.Location = new System.Drawing.Point(623, 4);
            this.cmbxSaveType.Name = "cmbxSaveType";
            this.cmbxSaveType.Size = new System.Drawing.Size(202, 25);
            this.cmbxSaveType.TabIndex = 13;
            this.cmbxSaveType.SelectedIndexChanged += new System.EventHandler(this.cmbxSaveType_SelectedIndexChanged);
            // 
            // tblLytConnStr
            // 
            this.tblLytConnStr.ColumnCount = 2;
            this.tblLytConnStr.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tblLytConnStr.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytConnStr.Controls.Add(this.lblConnStr, 0, 0);
            this.tblLytConnStr.Controls.Add(this.txtConnStr, 1, 0);
            this.tblLytConnStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytConnStr.Location = new System.Drawing.Point(3, 123);
            this.tblLytConnStr.Name = "tblLytConnStr";
            this.tblLytConnStr.RowCount = 1;
            this.tblLytConnStr.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytConnStr.Size = new System.Drawing.Size(828, 34);
            this.tblLytConnStr.TabIndex = 11;
            // 
            // lblConnStr
            // 
            this.lblConnStr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblConnStr.AutoSize = true;
            this.lblConnStr.Location = new System.Drawing.Point(10, 8);
            this.lblConnStr.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblConnStr.Name = "lblConnStr";
            this.lblConnStr.Size = new System.Drawing.Size(128, 17);
            this.lblConnStr.TabIndex = 1;
            this.lblConnStr.Text = "Connection String :";
            // 
            // txtConnStr
            // 
            this.txtConnStr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtConnStr.Location = new System.Drawing.Point(163, 5);
            this.txtConnStr.Name = "txtConnStr";
            this.txtConnStr.Size = new System.Drawing.Size(662, 23);
            this.txtConnStr.TabIndex = 2;
            // 
            // tblLytConnStrBuild
            // 
            this.tblLytConnStrBuild.ColumnCount = 4;
            this.tblLytConnStrBuild.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytConnStrBuild.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLytConnStrBuild.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytConnStrBuild.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLytConnStrBuild.Controls.Add(this.lblUser, 0, 2);
            this.tblLytConnStrBuild.Controls.Add(this.lblServer, 0, 0);
            this.tblLytConnStrBuild.Controls.Add(this.txtServer, 1, 0);
            this.tblLytConnStrBuild.Controls.Add(this.lblDb, 2, 0);
            this.tblLytConnStrBuild.Controls.Add(this.txtDb, 3, 0);
            this.tblLytConnStrBuild.Controls.Add(this.lblAuth, 0, 1);
            this.tblLytConnStrBuild.Controls.Add(this.cmbxAuth, 1, 1);
            this.tblLytConnStrBuild.Controls.Add(this.txtPassword, 3, 2);
            this.tblLytConnStrBuild.Controls.Add(this.lblPassword, 2, 2);
            this.tblLytConnStrBuild.Controls.Add(this.txtUser, 1, 2);
            this.tblLytConnStrBuild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytConnStrBuild.Location = new System.Drawing.Point(3, 3);
            this.tblLytConnStrBuild.Name = "tblLytConnStrBuild";
            this.tblLytConnStrBuild.RowCount = 3;
            this.tblLytConnStrBuild.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblLytConnStrBuild.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblLytConnStrBuild.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tblLytConnStrBuild.Size = new System.Drawing.Size(828, 114);
            this.tblLytConnStrBuild.TabIndex = 12;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(3, 85);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 17);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "User :";
            // 
            // lblServer
            // 
            this.lblServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(4, 10);
            this.lblServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(58, 17);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "Server :";
            // 
            // txtServer
            // 
            this.txtServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtServer.Location = new System.Drawing.Point(169, 7);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(240, 23);
            this.txtServer.TabIndex = 2;
            // 
            // lblDb
            // 
            this.lblDb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDb.AutoSize = true;
            this.lblDb.Location = new System.Drawing.Point(417, 10);
            this.lblDb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(77, 17);
            this.lblDb.TabIndex = 3;
            this.lblDb.Text = "Database :";
            // 
            // txtDb
            // 
            this.txtDb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDb.Location = new System.Drawing.Point(582, 7);
            this.txtDb.Margin = new System.Windows.Forms.Padding(4);
            this.txtDb.Name = "txtDb";
            this.txtDb.Size = new System.Drawing.Size(230, 23);
            this.txtDb.TabIndex = 4;
            // 
            // lblAuth
            // 
            this.lblAuth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAuth.AutoSize = true;
            this.lblAuth.Location = new System.Drawing.Point(3, 47);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(106, 17);
            this.lblAuth.TabIndex = 5;
            this.lblAuth.Text = "Authentication :";
            // 
            // cmbxAuth
            // 
            this.cmbxAuth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbxAuth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAuth.FormattingEnabled = true;
            this.cmbxAuth.Location = new System.Drawing.Point(168, 43);
            this.cmbxAuth.Name = "cmbxAuth";
            this.cmbxAuth.Size = new System.Drawing.Size(242, 25);
            this.cmbxAuth.TabIndex = 6;
            this.cmbxAuth.SelectedIndexChanged += new System.EventHandler(this.cmbxAuth_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(581, 82);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(229, 23);
            this.txtPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(416, 85);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 17);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password :";
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(168, 82);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(242, 23);
            this.txtUser.TabIndex = 9;
            // 
            // FrmIdentityScriptBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 711);
            this.Controls.Add(this.tblLytMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(850, 750);
            this.MinimumSize = new System.Drawing.Size(850, 726);
            this.Name = "FrmIdentityScriptBuilder";
            this.Text = "Identity Script Builder";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tblLytMain.ResumeLayout(false);
            this.tbCtrlTables.ResumeLayout(false);
            this.tbPgTables.ResumeLayout(false);
            this.tblLytTables.ResumeLayout(false);
            this.tblLytTableChoose.ResumeLayout(false);
            this.tblLytTableChoose.PerformLayout();
            this.tblLytSaveAndAddList.ResumeLayout(false);
            this.tblLytMainList.ResumeLayout(false);
            this.tblLytMainList.PerformLayout();
            this.tblLytButtons.ResumeLayout(false);
            this.tbPgLog.ResumeLayout(false);
            this.tbPgScript.ResumeLayout(false);
            this.tblLytConnButtons.ResumeLayout(false);
            this.tblLytSavePath.ResumeLayout(false);
            this.tblLytSavePath.PerformLayout();
            this.tblLytTruncateAndComboxes.ResumeLayout(false);
            this.tblLytTruncateAndComboxes.PerformLayout();
            this.tblLytConnStr.ResumeLayout(false);
            this.tblLytConnStr.PerformLayout();
            this.tblLytConnStrBuild.ResumeLayout(false);
            this.tblLytConnStrBuild.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLytMain;
        private System.Windows.Forms.Label lblConnStr;
        private System.Windows.Forms.TextBox txtConnStr;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.TabControl tbCtrlTables;
        private System.Windows.Forms.TabPage tbPgTables;
        private System.Windows.Forms.TableLayoutPanel tblLytTables;
        private System.Windows.Forms.TableLayoutPanel tblLytTableChoose;
        private System.Windows.Forms.TabPage tbPgLog;
        private System.Windows.Forms.Button btnAddTablesToList;
        private System.Windows.Forms.CheckedListBox lstTables;
        private System.Windows.Forms.TableLayoutPanel tblLytMainList;
        private System.Windows.Forms.TableLayoutPanel tblLytButtons;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.ListBox lstMainTables;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.TableLayoutPanel tblLytConnButtons;
        private System.Windows.Forms.Button btnGetTables;
        private System.Windows.Forms.TableLayoutPanel tblLytSavePath;
        private System.Windows.Forms.Label lblSavePath;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tbPgScript;
        private System.Windows.Forms.RichTextBox txtScriptState;
        private System.Windows.Forms.CheckBox chkTruncate;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Label lblDbTables;
        private System.Windows.Forms.Label lblScriptTables;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tblLytTruncateAndComboxes;
        private System.Windows.Forms.Label lblScriptType;
        private System.Windows.Forms.Label lblSaveType;
        private System.Windows.Forms.ComboBox cmbxScriptType;
        private System.Windows.Forms.ComboBox cmbxSaveType;
        private System.Windows.Forms.TableLayoutPanel tblLytConnStr;
        private System.Windows.Forms.TableLayoutPanel tblLytConnStrBuild;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblDb;
        private System.Windows.Forms.TextBox txtDb;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.ComboBox cmbxAuth;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnBuildConnString;
        private System.Windows.Forms.TableLayoutPanel tblLytSaveAndAddList;
        private System.Windows.Forms.Button btnFastSave;
    }
}