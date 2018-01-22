namespace OracleScriptBuilder.Source.Enumerations
{
    enum ScriptTypes : byte
    {
        /// <summary>
        /// Identity Mode will be added.
        /// </summary>
        IdentityInsert = 1,

        /// <summary>
        /// Script Without Id Column
        /// </summary>
        Insert = 2,

        /// <summary>
        /// Script With Id Column.
        /// </summary>
        InsertWithIdColumn = 4
    };
}