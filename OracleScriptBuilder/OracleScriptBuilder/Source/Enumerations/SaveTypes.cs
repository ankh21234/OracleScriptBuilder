namespace OracleScriptBuilder.Source.Enumerations
{
    internal enum SaveTypes : byte
    {
        /// <summary>
        /// Script as One File
        /// </summary>
        OneFile = 1,

        /// <summary>
        /// Script as One File Per Object
        /// </summary>
        FileForPerTable = 2,

        /// <summary>
        /// Script is copied to Clipboard
        /// </summary>
        Clipboard = 4
    };
}