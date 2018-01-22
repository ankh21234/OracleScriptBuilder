namespace OracleScriptBuilder.Source.BO
{
    internal struct ColumnObject
    {
        public string ColumnName { get; set; }

        public string ColumnDataType { get; set; }

        public string ColumnFullName
        {
            get
            {
                string result = string.Empty;

                if (string.IsNullOrWhiteSpace(ColumnName) == false)
                {
                    result = string.Format("{0}{1}{2}", Prefix, ColumnName, Suffix);
                }

                return result;
            }
        }

        public string Suffix { get { return string.Empty; } }

        public string Prefix { get { return string.Empty; } }

        public override bool Equals(object obj)
        {
            if (obj is ColumnObject)
            {
                ColumnObject col = (ColumnObject)obj;
                return string.Equals(this.ColumnName, col.ColumnName);
            }

            return false;
        }
    }
}