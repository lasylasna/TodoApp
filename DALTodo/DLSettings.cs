using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTodo
{
    public class DLSettings
    {
        public static string DbConnectionString { get; set; }
        public string SetConnectionString(string connectionString)
        {
            try
            {
                DbConnectionString = connectionString;
                return DbConnectionString;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
