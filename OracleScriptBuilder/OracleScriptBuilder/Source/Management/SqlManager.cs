using OracleScriptBuilder.Source.BO;
using OracleScriptBuilder.Source.QO;
using OracleScriptBuilder.Source.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace OracleScriptBuilder.Source.Management
{
    internal class SqlManager
    {

        #region [ Private Fields ]

        private List<string> dateTypes = new List<string>() { "date", "datetime2", "datetime", "datetimeoffset", "smalldatetime", "timestamp" };

        #endregion


        #region [ TestConnection method ]

        internal bool TestConnection(string connStr)
        {
            try
            {
                bool isTested = false;
                using (SqlConnection sqlConn = new SqlConnection(connStr))
                {
                    sqlConn.Open();
                    sqlConn.Close();
                    isTested = true;
                }
                return isTested;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion [ TestConnection method ]


        #region [ BuildDbObject method ]

        public DbObject BuildDbObject(string connectionString)
        {
            DbObject dbObj = new DbObject();
            try
            {
                List<TableObject> tables = new List<TableObject>();
                DataTable dtAllObjects = GetTable(connectionString, Crud.GetSchema_Table_Columns_DataTypes_IdentityCol());
                TableObject tblObj = null;
                foreach (DataRow row in dtAllObjects.Rows)
                {
                    tblObj = null;
                    tblObj = new TableObject { Name = string.Format("{0}", row["TABLE_NAME"]), Schema = string.Format("{0}", row["TABLE_SCHEMA"]) };
                    if (tables.Contains(tblObj) == false)
                    {
                        tables.Add(tblObj);
                    }
                }
                tblObj = null;
                DataRow[] rows = null;
                ColumnObject colObj;
                List<ColumnObject> Columns = null;

                for (int tableCounter = 0; tableCounter < tables.Count; tableCounter++)
                {
                    tblObj = null;
                    tblObj = tables[tableCounter];
                    Columns = new List<ColumnObject>();
                    rows = null;
                    rows = dtAllObjects.Select(string.Format("TABLE_NAME='{0}' AND TABLE_SCHEMA='{1}'", tblObj.Name, tblObj.Schema));

                    foreach (DataRow rw in rows)
                    {
                        colObj = new ColumnObject() { ColumnName = string.Format("{0}", rw["COLUMN_NAME"]), ColumnDataType = string.Format("{0}", rw["DATA_TYPE"]) };
                        if (Columns.Contains(colObj) == false)
                        {
                            Columns.Add(colObj);
                        }
                    }

                    tblObj.Columns = Columns;

                    rows = null;
                    rows = dtAllObjects.Select(string.Format("TABLE_NAME='{0}' AND TABLE_SCHEMA='{1}' AND IS_IDENTITY=1", tblObj.Name, tblObj.Schema));

                    foreach (DataRow rw in rows)
                    {
                        tblObj.IdColumn = string.Format("{0}", rw["COLUMN_NAME"]).Replace(" ", "");
                    }

                    tables[tableCounter] = tblObj;
                }
                dbObj.Tables = tables;
            }
            catch (Exception)
            {
                throw;
            }

            return dbObj;
        }

        #endregion [ BuildDbObject method ]


        #region [ GetTable method ]

        internal DataTable GetTable(string connStr, string query)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion [ GetTable method ]


        #region [ GetDataRowAsString method ]

        public string GetDataRowAsString(DataRow row, DataColumnCollection dataCols, Hashtable Columns)
        {
            try
            {
                StringBuilder rowBuilder = new StringBuilder();
                string strColDataType;

                foreach (DataColumn col in dataCols)
                {
                    if (row[col.ColumnName].IsNullOrDbNull())
                    {
                        rowBuilder.Append("NULL, ");
                        continue;
                    }
                    else
                    {
                        if (col.DataType.Name.Equals("Boolean") || col.DataType.Name.Equals("System.Boolean"))
                        {
                            rowBuilder.Append(string.Format("{0}, ", row[col.ColumnName].ToBool() ? 1 : 0));
                            continue;
                        }

                        if (col.DataType.Name.Equals("Double") || col.DataType.Name.Equals("System.Double"))
                        {
                            rowBuilder.Append(string.Format("{0}, ", row[col.ColumnName].ToDouble().ToString().Replace(',', '.')));
                            continue;
                        }

                        if (col.DataType.Name.Equals("Single") || col.DataType.Name.Equals("System.Single"))
                        {
                            rowBuilder.Append(string.Format("{0}, ", row[col.ColumnName].ToFloat()).Replace(',', '.'));
                            continue;
                        }

                        if (col.DataType.Name.Equals("Int32") || col.DataType.Name.Equals("System.Int32") ||
                            col.DataType.Name.Equals("Int16") || col.DataType.Name.Equals("System.Int16") ||
                            //col.DataType.Name.Equals("Int64") || col.DataType.Name.Equals("System.Int64") ||
                            col.DataType.Name.Equals("Byte") || col.DataType.Name.Equals("System.Byte"))
                        {
                            rowBuilder.Append(string.Format("{0}, ", row[col.ColumnName].ToInt()));
                            continue;
                        }

                        if (col.DataType.Name.Equals("Int64") || col.DataType.Name.Equals("System.Int64"))
                        {
                            rowBuilder.Append(string.Format("{0}, ", row[col.ColumnName].ToLong()));
                            continue;
                        }
                        if (col.DataType.Name.Equals("Byte[]") || col.DataType.Name.Equals("System.Byte[]"))
                        {
                            rowBuilder.Append(string.Format("0x{0}, ", BitConverter.ToString((byte[])row[col.ColumnName])).Replace("-", ""));
                            continue;
                        }
                        /*
                        if (col.DataType.Name.Equals("DateTime") || col.DataType.Name.Equals("System.DateTime"))
                        {
                            DateTime dt = ConvertUtil.ToDate(string.Format("{0}", row[col.ColumnName]));
                            rowBuilder.Append(string.Format("'{0}', ", ConvertUtil.DateToStr(dt)));
                            continue;
                        }
                        */
                        strColDataType = string.Format("{0}", Columns[col.ColumnName]).ToLower().Replace("ı", "i");
                        if (dateTypes.Contains(strColDataType))
                        {
                            rowBuilder.Append(string.Format("CAST(N'{0}' AS {1}), ", string.Format("{0}", row[col.ColumnName]), Columns[col.ColumnName]));
                            continue;
                        }

                        rowBuilder.Append(string.Format("N'{0}', ", string.Format("{0}", row[col.ColumnName]).Replace("'", "''")));
                    }
                }
                string rowStr = rowBuilder.ToString();
                rowStr = rowStr.TrimEnd().TrimEnd(',');
                return rowStr;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion [ GetDataRowAsString method ]
    }
}