using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sewa_Kendaraan_Cilacap.config
{
    abstract class Config
    {
        //public static string connectionString = "Server=localhost;Database=siperpus;Uid=root;Pwd=;";

        //eksekusi Insert, Update, Delete
        public abstract int eksekusiBukanQuery(string query);

        //eksekusi Select
        public abstract DataTable eksekusiQuery(string query);
    }
}
