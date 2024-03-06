using DALTodo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLTodo
{
    public class BLSettings
    {
        public string SetConnectionString(string ConnectionString)
        {
            try
            {
                DLSettings dLsettings = new DLSettings();
                return dLsettings.SetConnectionString(ConnectionString);
            }
            catch
            {
                throw;
            }
        }
    }
}
