using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiBook.Data
{
    public class SqlServerConfiguration
    {
        public SqlServerConfiguration(string connectionString) => ConnectionString = connectionString;
        public string ConnectionString { get; set; }
    }
}
