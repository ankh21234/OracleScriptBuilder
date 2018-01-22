using OracleScriptBuilder.Source.Enumerations;
using OracleScriptBuilder.Source.Management;
using OracleScriptBuilder.Source.QO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace OracleScriptBuilder.Source.BO
{
    internal class TableObject
    {
        #region [ Properties ]

        private string _Name = string.Empty;

        /// <summary>
        /// Gets, Sets Name.
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _Schema = string.Empty;

        /// <summary>
        /// Gets, Sets Schema.
        /// </summary>
        public string Schema
        {
            get { return _Schema; }
            set { _Schema = value; }
        }

        private string _IdColumn = string.Empty;

        /// <summary>
        /// Gets, Sets IdColumn.
        /// </summary>
        public string IdColumn
        {
            get { return _IdColumn; }
            set { _IdColumn = value; }
        }

        private List<ColumnObject> _Columns = new List<ColumnObject> { };

        /// <summary>
        /// Gets, Sets Columns Of TableObject
        /// </summary>
        internal List<ColumnObject> Columns
        {
            get { return _Columns; }
            set
            {
                _Columns = value;
                if (_Columns == null)
                {
                    _Columns = new List<ColumnObject>();
                }
                SetSelectScript();
            }
        }

        /// <summary>
        /// Gets, Sets Add Truncate Word;
        /// </summary>
        public bool AddTruncate { get; set; }

        /// <summary>
        /// Gets FullName.
        /// </summary>
        public string FullName { get { return string.Format("{0}{1}{2}", Prefix, _Name, Suffix); } }

        /// <summary>
        /// Gets FullNameWithSchema.
        /// </summary>
        public string FullNameWithSchema { get { return string.Format("{0}{1}{2}.{0}{3}{2}", Prefix, _Schema, Suffix, _Name); } }

        /// <summary>
        /// Gets Prefix.
        /// </summary>
        public string Prefix { get { return "["; } }

        /// <summary>
        /// Gets SchemaName.
        /// </summary>
        public string SchemaName { get { return string.Format("{0}{1}{2}", Prefix, Schema, Suffix); } }

        /// <summary>
        /// Gets Suffix.
        /// </summary>
        public string Suffix { get { return "]"; } }

        private DataTable records = new DataTable();

        /// <summary>
        /// Gets, Sets Records Of TableObject.
        /// </summary>
        public DataTable Records
        {
            get { return records; }
            set
            {
                records = value;
                if (records == null)
                    records = new DataTable();
            }
        }

        private string _selectScript = string.Empty;

        /// <summary>
        /// Gets SelectScript.
        /// </summary>
        public string SelectScript
        {
            get { return _selectScript; }
        }

        #endregion [ Properties ]


        #region [ GetScriptByScriptType2 method ]

        public List<string> GetScriptByScriptType(ScriptTypes scriptType)
        {
            List<string> queryList = new List<string>();

            //StringBuilder strBuilder = new StringBuilder();
            try
            {
                var dtScriptRecords = records;
                if (this.AddTruncate)
                {
                    if (string.Format("{0}", _IdColumn).Replace(" ", "").Length > 0)
                    {
                        queryList.Add(string.Format(Crud.GetTruncateFormat(), this.FullNameWithSchema));
                        //  strBuilder.AppendLine(Crud.Go);
                    }
                    else
                    {
                        queryList.Add(string.Format(Crud.DeleteFromFormat, this.FullNameWithSchema));
                        //strBuilder.AppendLine(Crud.Go);
                    }
                }
                if (records.Rows.Count > 0)
                {
                    switch (scriptType)
                    {
                        case ScriptTypes.IdentityInsert:
                            if (string.Format("{0}", _IdColumn).Replace(" ", "").Length > 0)
                            {
                                queryList.Add(String.Format(Crud.IdentityInsertFormat(), this.FullNameWithSchema, "ON"));
                                //strBuilder.AppendLine(Crud.Go);
                            }
                            break;

                        case ScriptTypes.Insert:
                            if (string.Format("{0}", _IdColumn).Replace(" ", "").Length > 0)
                            {
                                dtScriptRecords.Columns.Remove(_IdColumn);
                            }
                            break;

                        default:
                            break;
                    }
                    string strCols = string.Empty;
                    foreach (DataColumn col in dtScriptRecords.Columns)
                    {
                        strCols = string.Format("{0}, [{1}]", strCols, col.ColumnName);
                    }

                    if (strCols.Length > 0)
                        strCols = strCols.TrimStart(',').TrimStart();

                    SqlManager sqlMan = new SqlManager();

                    Hashtable h = new Hashtable();
                    foreach (var item in this.Columns)
                    {
                        h.Add(item.ColumnName, item.ColumnDataType);
                    }

                    foreach (DataRow row in dtScriptRecords.Rows)
                    {
                        queryList.Add(string.Format(Crud.InsertFormat(), this.FullNameWithSchema, strCols, sqlMan.GetDataRowAsString(row, dtScriptRecords.Columns, h)));
                        //strBuilder.AppendLine(string.Format(this.InsertFormat, sqlMan.GetDataRowAsString(row, dtScriptRecords.Columns, h)));
                        //strBuilder.AppendLine(Crud.Go);
                    }

                    if (scriptType == ScriptTypes.IdentityInsert)
                    {
                        if (string.Format("{0}", _IdColumn).Replace(" ", "").Length > 0)
                        {
                            queryList.Add(String.Format(Crud.IdentityInsertFormat(), this.FullNameWithSchema, "OFF"));
                            // strBuilder.AppendLine(Crud.Go);
                        }
                    }
                }
                else
                {
                    queryList.Add(string.Format(Crud.NoRecordsFormat, this.ToString()));
                }
            }
            catch (Exception)
            {
                throw;
            }
            return queryList;
        }

        #endregion [ GetScriptByScriptType2 method ]


        #region [ SetSelectScript method ]

        private void SetSelectScript()
        {
            try
            {
                StringBuilder colBuilder = new StringBuilder();
                string colType;

                foreach (var colObj in this.Columns)
                {
                    colType = string.Empty;
                    colType = string.Format("{0}", colObj.ColumnDataType);
                    colType = colType.ToLower().Replace('ı', 'i');
                    if (colType.Equals("datetime2") || colType.Equals("datetimeoffset") || colType.Equals("time"))
                    {
                        colBuilder.Append(string.Format("CAST([{0}] As VarChar) As [{0}], ", colObj.ColumnName));
                    }
                    else if (colType.Equals("datetime") || colType.Equals("date") || colType.Equals("smalldatetime"))
                    {
                        int formatInt = 121;//FOR DATETIME

                        if (colType.Equals("date"))
                        {
                            formatInt = 23;
                        }

                        if (colType.Equals("smalldatetime"))
                        {
                            formatInt = 20;
                        }

                        colBuilder.Append(string.Format("CONVERT(VarChar, [{0}], {1}) As [{0}], ", colObj.ColumnName, formatInt));
                    }
                    else
                    {
                        colBuilder.Append(string.Format("[{0}], ", colObj.ColumnName));
                    }
                }
                string cols = colBuilder.ToString();
                cols = cols.TrimEnd().TrimEnd(',');
                _selectScript = string.Format(Crud.GetSelectColumnsFormat(), cols, this.FullNameWithSchema);
            }
            catch (Exception)
            {
                _selectScript = string.Empty;
            }
        }

        #endregion [ SetSelectScript method ]


        public override string ToString()
        {
            return this.FullNameWithSchema;
        }


        public override bool Equals(object obj)
        {
            bool result = false;
            try
            {
                if (obj is TableObject)
                {
                    TableObject tblObj = obj as TableObject;
                    result = (string.Equals(tblObj.Name, this.Name) && string.Equals(tblObj.Schema, this.Schema));
                }
            }
            catch (Exception)
            {
            }

            return result;
        }
    }
}