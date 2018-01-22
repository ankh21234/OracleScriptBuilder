namespace OracleScriptBuilder.Source.QO
{
    internal class Crud
    {
        internal static readonly string Go = "GO";

        internal static readonly string NoRecordsFormat = "-- No Records in {0} table.";

        internal static readonly string DeleteFromFormat = "DELETE FROM {0};";

        internal static string GetInsertBaseFormat()
        {
            return "INSERT INTO #tableName(#columns) VALUES({0})";
        }

        internal static string GetSelectColumnsFormat()
        {
            return "Select {0} From {1};";
        }

        internal static string GetTruncateFormat()
        {
            return "TRUNCATE TABLE {0};";
        }

        internal static string InsertFormat()
        {
            return "INSERT INTO {0} ({1}) VALUES ({2})";
        }

        internal static string IdentityInsertFormat()
        {
            return "SET IDENTITY_INSERT {0} {1}";
        }

        internal static string GetSchema_Table_Columns_DataTypes_IdentityCol()
        {
            return @"SELECT
                    ssc.name AS TABLE_SCHEMA, stb.name AS TABLE_NAME, scl.name AS COLUMN_NAME, types.name AS DATA_TYPE, CAST(scl.is_identity AS INT) AS IS_IDENTITY
                    FROM sys.columns scl
                    INNER JOIN sys.tables stb ON scl.object_id=stb.object_id
                    INNER JOIN sys.schemas ssc ON stb.schema_id=ssc.schema_id
                    INNER JOIN sys.types types ON scl.system_type_id=types.system_type_id
                    WHERE scl.is_computed <> 1
                     AND types.is_user_defined <> 1
                     AND types.name <> 'sysname'
                     Order By ssc.name, stb.name, scl.column_id;";
        }
    }
}