using OracleScriptBuilder.Source.BO;
using OracleScriptBuilder.Source.Constants;
using OracleScriptBuilder.Source.Enumerations;
using OracleScriptBuilder.Source.Management;
using OracleScriptBuilder.Source.QO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace OracleScriptBuilder.Source.View
{

    public partial class FrmIdentityScriptBuilder : Form
    {

        #region [ Private Fields ]

        private SaveTypes saveType = SaveTypes.OneFile;
        private ScriptTypes scriptType = ScriptTypes.IdentityInsert;
        private DbObject dbObj = new DbObject();

        private FileInfo fInfoSave;
        private SqlManager sqlMan;
        private string strFullSavePath = string.Empty;
        private string strSavePath = string.Empty;
        private List<TableObject> tableNames = new List<TableObject>();

        private Thread saveThread = null;


        private string sqlAuth = "Sql";
        private string winAuth = "Windows";
        private bool isSqlMode = false;
        private SqlConnectionStringBuilder conStrBuilder = null;

        #endregion

        //Server=.\SQLEXPRESS
        //Server=KRK\SQLEXPRESS

        //Initial Catalog=Northwind
        //Initial Catalog=AdventureWorks2012
        //Initial Catalog=BuroTestDB

        //Integrated Security=SSPI

        //User Id=sa;
        //Password=test*sql.11

        //Server=.\SQLEXPRESS;Initial Catalog=AdventureWorks2012;Integrated Security=SSPI;


        #region [ LoadScriptTypes method ]

        void LoadScriptTypes()
        {
            try
            {
                cmbxScriptType.Items.Clear();

                foreach (var item in Enum.GetValues(typeof(ScriptTypes)))
                {
                    cmbxScriptType.Items.Add(item);
                }

                cmbxScriptType.Refresh();

                if (cmbxScriptType.Items.Count > 0)
                    cmbxScriptType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        #endregion


        #region [ LoadSaveTypes method ]

        void LoadSaveTypes()
        {
            try
            {
                cmbxSaveType.Items.Clear();

                foreach (var item in Enum.GetValues(typeof(SaveTypes)))
                {
                    cmbxSaveType.Items.Add(item);
                }

                cmbxSaveType.Refresh();
                if (cmbxSaveType.Items.Count > 0)
                    cmbxSaveType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        #endregion


        #region [ FrmIdentityScriptBuilder Ctor ]

        public FrmIdentityScriptBuilder()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            sqlMan = new SqlManager();
            cmbxAuth.Items.AddRange(new object[] { winAuth, sqlAuth });
            cmbxAuth.SelectedIndex = 0;
        }

        #endregion


        #region [ Form_Load method ]

        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                LoadScriptTypes();
                LoadSaveTypes();
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        #endregion


        #region [ btnTestConnection_Click method ]

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtConnStr.Text))
                {
                    MessageBox.Show("Connection String can not be empty.", "Warning");
                    return;
                }

                bool mTested = sqlMan.TestConnection(txtConnStr.Text);
                if (mTested)
                {
                    MessageBox.Show("Test Successed.", "Result");
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Connection failed, check log.", "Warning");
                return;
            }
        }

        #endregion [ btnTestConnection_Click method ]


        #region [ LogError method ]

        private void LogError(Exception ex)
        {
            try
            {
                txtLog.Text = string.Format("{0}Date: {1},{2}Message: {3},{2}Stack Trace : {4}{2}****************{2}",
                    txtLog.Text,
                    DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss fff"),
                    Environment.NewLine,
                    ex.Message,
                    ex.StackTrace);
            }
            catch (Exception)
            {
            }
        }

        #endregion [ LogError method ]


        #region [ btnDown_Click method ]

        private void btnDown_Click(object sender, EventArgs e)
        {
            this.Up();
        }

        #endregion [ btnDown_Click method ]


        #region [ btnRemove_Click method ]

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.Remove();
        }

        #endregion [ btnRemove_Click method ]


        #region [ btnUp_Click method ]

        private void btnUp_Click(object sender, EventArgs e)
        {
            this.Down();
        }

        #endregion [ btnUp_Click method ]


        #region [ btnAddTablesToList_Click method ]

        private void btnAddTablesToList_Click(object sender, EventArgs e)
        {
            this.AddTablesToList();
        }

        #endregion [ btnAddTablesToList_Click method ]


        #region [ AddTablesToList method ]

        private void AddTablesToList()
        {
            try
            {
                AddTablesToInnerList();
                LoadTablesToList();
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        #endregion [ AddTablesToList method ]


        #region [ AddTablesToInnerList method ]

        private void AddTablesToInnerList()
        {
            try
            {
                tableNames = new List<TableObject>();
                foreach (int item in lstTables.CheckedIndices)
                {
                    tableNames.Add(dbObj.Tables[item]);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion


        #region [ Down method ]

        private void Down()
        {
            try
            {
                if (lstMainTables.Items.Count > 1)
                {
                    if (lstMainTables.SelectedIndex > 0)
                    {
                        int indx = lstMainTables.SelectedIndex;
                        TableObject tbl = tableNames[lstMainTables.SelectedIndex];
                        tableNames[lstMainTables.SelectedIndex] = tableNames[lstMainTables.SelectedIndex - 1];
                        tableNames[lstMainTables.SelectedIndex - 1] = tbl;
                        LoadTablesToList();
                        lstMainTables.SelectedIndex = indx - 1;
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        #endregion [ Down method ]


        #region [ Up method ]

        private void Up()
        {
            try
            {
                if (lstMainTables.Items.Count > 1)
                {
                    if (lstMainTables.SelectedIndex < lstMainTables.Items.Count - 1)
                    {
                        int indx = lstMainTables.SelectedIndex;
                        TableObject tbl = tableNames[lstMainTables.SelectedIndex];
                        tableNames[lstMainTables.SelectedIndex] = tableNames[lstMainTables.SelectedIndex + 1];
                        tableNames[lstMainTables.SelectedIndex + 1] = tbl;
                        LoadTablesToList();
                        lstMainTables.SelectedIndex = indx + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        #endregion [ Up method ]


        #region [ Remove method ]

        private void Remove()
        {
            try
            {
                if (lstTables.Items.Count > 0)
                {
                    if (lstTables.SelectedIndex > -1)
                    {
                        tableNames.RemoveAt(lstMainTables.SelectedIndex);
                        LoadTablesToList();
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        #endregion [ Remove method ]


        #region [ LoadTablesToList method ]

        private void LoadTablesToList()
        {
            try
            {
                lstMainTables.Items.Clear();
                foreach (var tbl in tableNames)
                {
                    lstMainTables.Items.Add(tbl.ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion [ LoadTablesToList method ]


        #region [ btnGetTables_Click method ]

        private void btnGetTables_Click(object sender, EventArgs e)
        {
            this.GetTables();
        }

        #endregion [ btnGetTables_Click method ]


        #region [ GetTables  method ]

        private void GetTables()
        {
            try
            {
                dbObj = sqlMan.BuildDbObject(txtConnStr.Text);
                tableNames = new List<TableObject>();
                lstTables.Items.Clear();
                foreach (var item in dbObj.Tables)
                {
                    lstTables.Items.Add(item.ToString());
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        #endregion [ GetTables  method ]


        #region [ btnBrowse_Click method ]

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Browse();
        }

        #endregion


        #region [ Browse method ]

        private void Browse()
        {
            try
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    fbd.RootFolder = Environment.SpecialFolder.DesktopDirectory;
                    System.Windows.Forms.DialogResult dr = fbd.ShowDialog();
                    if (dr == System.Windows.Forms.DialogResult.Yes || dr == System.Windows.Forms.DialogResult.OK)
                        strSavePath = fbd.SelectedPath;
                }

                txtSavePath.Text = strSavePath;
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("An Error occured. Please check out the log.", "Error");
            }
        }

        #endregion


        #region [ btnSave_Click method ]

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        #endregion


        #region [ Save method ]

        private void Save()
        {
            try
            {
                if (lstMainTables.Items == null)
                {
                    MessageBox.Show("No Tables selected to get script.", "Warning");
                    return;
                }

                if (lstMainTables.Items.Count < 1)
                {
                    MessageBox.Show("No Tables selected to get script.", "Warning");
                    return;
                }

                if (saveType != SaveTypes.Clipboard)
                {
                    if (string.IsNullOrWhiteSpace(strSavePath))
                    {
                        MessageBox.Show("Please Define Save Folder.");
                        return;
                    }
                }

                tbPgScript.Select();
                tbCtrlTables.SelectedIndex = 2;
                RunSaveThread();
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Save Process failed. Look at Log.");
            }
        }

        #endregion


        #region [ RunSaveThread method ]

        private void RunSaveThread()
        {
            try
            {
                saveThread = new Thread(new ThreadStart(this.SaveInThread));
                saveThread.Start();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion


        #region [ SaveInThread  method ]

        private void SaveInThread()
        {
            bool isExceptionThrowed = false;
            string exceptMessage = string.Empty;
            try
            {
                txtLog.Clear();
                txtScriptState.Clear();

                WriteToScriptLog("Script process has started.");

                LockButtons();

                if (saveType != SaveTypes.Clipboard)
                {
                    if (Directory.Exists(strSavePath) == false)
                    {
                        Directory.CreateDirectory(strSavePath);

                        WriteToScriptLog(string.Format("Main Save Path has been created; {0}.", strSavePath));
                    }
                }

                if (saveType == SaveTypes.OneFile || saveType == SaveTypes.FileForPerTable)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(strSavePath);
                    DateTime dt = DateTime.Now;
                    string strSvPth = string.Format(ScriptConstants.SaveFolderFormat, dt.ToString("yyyy_MM_dd_HH_mm_ss"));
                    strFullSavePath = dirInfo.CreateSubdirectory(strSvPth).FullName;

                    WriteToScriptLog(string.Format("Lower Save Path has been created; {0}.", strFullSavePath));

                    dirInfo = null;
                }

                List<string> scriptList = new List<string>();
                switch (saveType)
                {
                    case SaveTypes.OneFile:
                    case SaveTypes.Clipboard:
                        //string script = this.GetOneFileScript();
                        scriptList = this.GetOneFileScript();
                        if (saveType == SaveTypes.Clipboard)
                        {
                            StringBuilder strBuilder = new StringBuilder();
                            foreach (var item in scriptList)
                            {
                                strBuilder.AppendLine(item);
                                strBuilder.AppendLine(Crud.Go);
                            }
                            WriteToScriptLog("Clipboard script is preparing.");
                            Clipboard.SetText(strBuilder.ToString());
                            WriteToScriptLog("Script is copied to Clipboard.");
                        }
                        else
                        {
                            this.SaveOneFile(scriptList, string.Empty);
                        }
                        break;

                    case SaveTypes.FileForPerTable:
                        this.SaveFilesPerTable();
                        break;

                    default:
                        break;
                }

                WriteToScriptLog("Save process has ended.");
                MessageBox.Show("Save Process Successed.");
            }
            catch (OutOfMemoryException outOfEx)
            {
                isExceptionThrowed = true;
                exceptMessage = "Script length exceed the string length.";
                WriteToScriptLog(exceptMessage);
                LogError(outOfEx);
            }
            catch (Exception ex)
            {
                isExceptionThrowed = true;
                exceptMessage = "Save Process failed. Look at Log.";
                WriteToScriptLog(exceptMessage);
                LogError(ex);
            }
            finally
            {
                try
                {
                    saveThread = null;
                }
                catch (Exception exT)
                {
                    LogError(exT);
                }

                UnLockButtons();

                if (isExceptionThrowed)
                {
                    MessageBox.Show(exceptMessage);
                }
            }
        }

        #endregion


        #region [ WriteToScriptLog method ]

        void WriteToScriptLog(string messsage)
        {
            txtScriptState.Text = string.Format("{0}{1}: {2}{3}", txtScriptState.Text, DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss fff"), messsage, Environment.NewLine);
        }

        #endregion


        #region [ SaveOneFile method ]

        private void SaveOneFile(List<string> queryList, string tableName)
        {
            try
            {
                string fileString = string.Empty;
                if (string.IsNullOrWhiteSpace(tableName))
                {
                    fileString = string.Format(@"{0}\{1}.sql", strFullSavePath,
                         string.Format(ScriptConstants.SaveOneFileFormat,
                         DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")));

                    fInfoSave = new FileInfo(fileString);

                    WriteToScriptLog(string.Format("{0} file has created for script of {1} table.", fInfoSave.Name, tableName));

                    using (StreamWriter outfile = new StreamWriter(fInfoSave.FullName, false) { AutoFlush = true })
                    {
                        if (queryList != null)
                        {
                            foreach (var query in queryList)
                            {
                                outfile.WriteLine(query);
                                outfile.WriteLine(Crud.Go);
                            }

                        }
                        outfile.Close();
                    }

                    WriteToScriptLog(string.Format("Script of {0} table has been written to {1} file.", tableName, fInfoSave.Name));

                    fInfoSave = null;
                }
                else
                {
                    fileString = string.Format(@"{0}\{1}.sql", strFullSavePath,
                                            string.Format(ScriptConstants.SaveMultipleFiles, tableName,
                                            DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")));

                    fInfoSave = new FileInfo(fileString);

                    WriteToScriptLog(string.Format("{0} file has created for script of {1} table.", fInfoSave.Name, tableName));

                    using (StreamWriter outfile = new StreamWriter(fInfoSave.FullName, false) { AutoFlush = true })
                    {
                        if (queryList != null)
                        {
                            foreach (var query in queryList)
                            {
                                outfile.WriteLine(query);
                                outfile.WriteLine(Crud.Go);
                            }

                        }
                        outfile.Close();
                    }

                    WriteToScriptLog(string.Format("Script of {0} table has been written to {1} file.", tableName, fInfoSave.Name));

                    fInfoSave = null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion


        #region [ GetOneFileScript method ]

        private List<string> GetOneFileScript()
        {
            try
            {
                StringBuilder strBuilder = new StringBuilder();
                DataTable dt = new DataTable();
                List<string> scriptList = new List<string>();
                List<string> tableScript = new List<string>();
                string selectScript = string.Empty;

                if (chkTruncate.Checked)
                {
                    for (int tableCounter = 0; tableCounter < tableNames.Count; tableCounter++)
                    {
                        tableNames[tableCounter].AddTruncate = true;
                    }
                }

                foreach (var tblName in tableNames)
                {
                    dt = new DataTable();
                    dt = sqlMan.GetTable(txtConnStr.Text, tblName.SelectScript);
                    tblName.Records = dt;
                    tableScript = new List<string>();
                    tableScript = tblName.GetScriptByScriptType(scriptType);

                    if (tableScript != null)
                    {
                        foreach (var query in tableScript)
                        {
                            scriptList.Add(query);
                        }
                    }
                }
                return scriptList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion


        #region [ SaveFilesPerTable method ]

        private void SaveFilesPerTable()
        {
            try
            {
                DataTable dt = new DataTable();
                List<string> scriptList = new List<string>();
                int tableCounter = 1;

                if (chkTruncate.Checked)
                {
                    for (int tblCounter = 0; tblCounter < tableNames.Count; tblCounter++)
                    {
                        tableNames[tblCounter].AddTruncate = true;
                    }
                }

                string strScriptFile = string.Empty;
                foreach (var tblName in tableNames)
                {
                    dt = new DataTable();
                    dt = sqlMan.GetTable(txtConnStr.Text, tblName.SelectScript);
                    tblName.Records = dt;
                    if (dt.Rows.Count > 0 || tblName.AddTruncate)
                    {
                        scriptList = new List<string>();
                        WriteToScriptLog(string.Format("{0} table script is being created.", tblName.ToString()));
                        scriptList = tblName.GetScriptByScriptType(scriptType);
                        WriteToScriptLog(string.Format("{0} table script is created.", tblName.ToString()));
                        strScriptFile = tableCounter < 10 ? string.Format("0{0}_{1}", tableCounter, tblName.Name) : string.Format("{0}_{1}", tableCounter, tblName.Name);
                        SaveOneFile(scriptList, strScriptFile);
                    }
                    else
                    {
                        WriteToScriptLog("****************************************************");
                        WriteToScriptLog(string.Format("{0} table has no rows.", tblName.ToString()));
                        WriteToScriptLog("****************************************************");
                    }
                    tableCounter++;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion


        #region [ chkSelectAll_CheckedChanged method ]

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                chkSelectAll.Text = chkSelectAll.Checked ? "Deselect All" : "Select All";
                if (lstTables.Items != null)
                {
                    for (int itemCounter = 0; itemCounter < lstTables.Items.Count; itemCounter++)
                    {
                        lstTables.SetItemChecked(itemCounter, chkSelectAll.Checked);
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        #endregion


        #region [ btnAdd_Click method ]

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        #endregion


        #region [ Add method ]

        void Add()
        {
            try
            {
                if (lstTables.Items.Count < 1)
                {
                    MessageBox.Show("There is no item to add.");
                    return;
                }

                if (lstTables.SelectedIndex == -1)
                {
                    MessageBox.Show("Any item has not selected to add.");
                    return;
                }
                /*
                string item = lstTables.GetItemText(lstTables.SelectedItem);

                if (lstMainTables.Items.Contains(item))
                {
                    MessageBox.Show("Item has already added.");
                    return;
                }
                */
                if (tableNames.Contains(dbObj.Tables[lstTables.SelectedIndex]))
                {
                    MessageBox.Show("Item has already added.");
                    return;
                }
                tableNames.Add(dbObj.Tables[lstTables.SelectedIndex]);
                LoadTablesToList();
                lstTables.SetItemChecked(lstTables.SelectedIndex, true);
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Add Process failed. Look at Log.");
            }
        }

        #endregion


        #region [ cmbxScriptType_SelectedIndexChanged method ]

        private void cmbxScriptType_SelectedIndexChanged(object sender, EventArgs e)
        {
            setScriptTypeFromCombo();
        }

        #endregion


        #region [ setScriptTypeFromCombo method ]

        void setScriptTypeFromCombo()
        {
            try
            {
                if (cmbxScriptType.SelectedItem == null)
                {
                    scriptType = ScriptTypes.IdentityInsert;
                    return;
                }

                scriptType = (ScriptTypes)cmbxScriptType.SelectedItem;
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        #endregion


        #region [ cmbxSaveType_SelectedIndexChanged method ]

        private void cmbxSaveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            setSaveTypeFromCombo();
        }

        #endregion


        #region [ setSaveTypeFromCombo method ]

        void setSaveTypeFromCombo()
        {
            try
            {
                if (cmbxSaveType.SelectedItem == null)
                {
                    saveType = SaveTypes.OneFile;
                    return;
                }

                saveType = (SaveTypes)cmbxSaveType.SelectedItem;
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        #endregion


        #region [ LockButtons method ]

        void LockButtons()
        { LockUnLockButtons(false); }

        #endregion


        #region [ UnLockButtons method ]

        void UnLockButtons()
        { LockUnLockButtons(true); }

        #endregion


        #region [ LockUnLockButtons method ]

        void LockUnLockButtons(bool enableSate)
        {
            this.btnTestConnection.Enabled = enableSate;
            this.btnGetTables.Enabled = enableSate;
            this.btnAddTablesToList.Enabled = enableSate;
            this.btnAdd.Enabled = enableSate;
            this.btnUp.Enabled = enableSate;
            this.btnRemove.Enabled = enableSate;
            this.btnDown.Enabled = enableSate;
            this.btnBrowse.Enabled = enableSate;
            this.btnSave.Enabled = enableSate;
            this.btnBuildConnString.Enabled = enableSate;
        }

        #endregion


        #region [ cmbxAuth_SelectedIndexChanged method ]

        private void cmbxAuth_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                isSqlMode = string.Equals(cmbxAuth.GetItemText(cmbxAuth.SelectedItem), sqlAuth);
            }
            catch (Exception)
            {
                isSqlMode = false;
            }
            txtUser.Enabled = isSqlMode;
            txtPassword.Enabled = isSqlMode;
        }

        #endregion


        #region [ btnBuildConnString_Click method ]

        private void btnBuildConnString_Click(object sender, EventArgs e)
        {
            BuildConnString();
        }

        #endregion


        #region [ BuildConnString method ]

        void BuildConnString()
        {
            try
            {
                txtConnStr.Text = string.Empty;
                if (txtServer.Text.Length == 0)
                {
                    MessageBox.Show("You should define Server name.");
                    return;
                }

                if (txtDb.Text.Length == 0)
                {
                    MessageBox.Show("You should define Database name.");
                    return;
                }

                if (isSqlMode)
                {
                    if (txtUser.Text.Length == 0)
                    {
                        MessageBox.Show("You should define User name.");
                        return;
                    }

                }


                conStrBuilder = new SqlConnectionStringBuilder();
                conStrBuilder.DataSource = txtServer.Text;
                conStrBuilder.InitialCatalog = txtDb.Text;
                if (isSqlMode == false)
                {
                    conStrBuilder.IntegratedSecurity = true;
                }
                else
                {
                    conStrBuilder.UserID = txtUser.Text;
                    conStrBuilder.Password = txtPassword.Text;
                }

                txtConnStr.Text = conStrBuilder.ConnectionString;
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("ConnectionString could not built. Please check out the Log.");
            }
        }

        #endregion


        #region [ btnFastSave_Click method ]

        private void btnFastSave_Click(object sender, EventArgs e)
        {
            FastSave();
        }

        #endregion


        #region [ FastSave method ]

        private void FastSave()
        {
            try
            {
                if (lstTables.CheckedItems == null)
                {
                    MessageBox.Show("No Tables selected to get script.", "Warning");
                    return;
                }

                if (lstTables.CheckedItems.Count < 1)
                {
                    MessageBox.Show("No Tables selected to get script.", "Warning");
                    return;
                }

                AddTablesToInnerList();

                bool isConfirmed = true;
                if (saveType != SaveTypes.Clipboard)
                {
                    using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                    {
                        fbd.RootFolder = Environment.SpecialFolder.DesktopDirectory;
                        System.Windows.Forms.DialogResult dr = fbd.ShowDialog();
                        isConfirmed = (dr == System.Windows.Forms.DialogResult.Yes || dr == System.Windows.Forms.DialogResult.OK);
                        if (isConfirmed)
                        {
                            strSavePath = fbd.SelectedPath;
                        }
                    }

                    txtSavePath.Text = strSavePath;
                }

                if (isConfirmed)
                {
                    tbCtrlTables.SelectedIndex = 2;
                    RunSaveThread();
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Fast Save failed. Please check out the Log.");
            }
        }

        #endregion

    }
}