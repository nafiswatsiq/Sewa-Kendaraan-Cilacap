using Sewa_Kendaraan_Cilacap.config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sewa_Kendaraan_Cilacap.model
{
    internal class LoginCls
    {

        private string _username;
        private string _password;

        Connection koneksi;
        string query;

        public LoginCls()
        {
            _username = "";
            _password = "";

            koneksi = new Connection();
            query = "";
        }

        public string username
        {
            set { _username = value;  }
        }

        public string password
        {
            set { _password = value; }
        }

        public bool isExist(string username, string password)
        {
            bool cek = false;

            query = "SELECT * FROM users WHERE username = '" + username + "' AND password = '" + password + "'";
            if (koneksi.eksekusiQuery(query).Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public string getUserName(string username)
        {
            string nama = "";
            DataTable dt = new DataTable();

            query = "SELECT * FROM users WHERE username = '" + username + "'";
            dt = koneksi.eksekusiQuery(query);

            if (dt.Rows.Count > 0)
            {
                nama = dt.Rows[0]["nama"].ToString();
            }

            return nama;
        }
    }
}
