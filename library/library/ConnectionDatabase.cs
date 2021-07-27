using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace library
{
    class ConnectionDatabase
    {
        public static string getConnectionstring
        {
            get
            { 
            return "datasource=127.0.0.1;port=3306;username=root;password=;database=library;";
            }
        }
       
    }
}
