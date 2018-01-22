using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleScriptBuilder.Source.BO
{
    internal class DbObject
    {
        private string _Catalog = string.Empty;

        private string _Schema = string.Empty;

        private List<TableObject> _Tables = new List<TableObject>();

        public string Catalog
        {
            get { return _Catalog; }
            set { _Catalog = value; }
        }

        public string Prefix { get { return "["; } }

        public string Schema
        {
            get { return _Schema; }
            set { _Schema = value; }
        }
        public string SchemaName { get { return string.Format("{0}{1}{2}", Prefix, Schema, Suffix); } }

        public string Suffix { get { return "]"; } }

        public List<TableObject> Tables
        {
            get { return _Tables; }
            set { _Tables = value; }
        }
        
    }
}