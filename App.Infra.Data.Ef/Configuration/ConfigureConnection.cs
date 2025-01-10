using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Ef.Configuration
{
    public static class ConfigureConnection
    {
        public static string _connectionString { get; set; }

        static ConfigureConnection()
        {
            _connectionString = "Server=localhost\\SQLEXPRESS;Database=CW19Db;Trusted_Connection=True;Encrypt=False";
        }
    }
}
