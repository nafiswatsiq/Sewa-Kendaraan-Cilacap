using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sewa_Kendaraan_Cilacap.config
{
    internal class Connection:Config
    {
        MySqlConnection _conn;
        MySqlCommand _command;
        MySqlDataAdapter _adapter;

        string url = "server=localhost;port=3306;database=sewa_kendaraan;uid=root;pwd=";

        public Connection()
        {
            _conn = new MySqlConnection(url);
            _command = new MySqlCommand();
            _adapter = new MySqlDataAdapter();
        }

        void bukaKoneksi()
        {
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
        }

        void tutupKoneksi()
        {
            if (_conn.State == ConnectionState.Open)
            {
                _conn.Close();
            }
        }

        public override int eksekusiBukanQuery(string query)
        {

            int kembalian = -1;

            try
            {
                bukaKoneksi();

                _command.Connection = _conn;
                _command.CommandText = query;

                kembalian = _command.ExecuteNonQuery();
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } finally
            {
                tutupKoneksi();
            }

            return kembalian;
        }

        public override DataTable eksekusiQuery(string query)
        {
            DataTable kembalian = new DataTable();

            try
            {
                bukaKoneksi();

                _command.Connection = _conn;
                _command.CommandText = query;
                _adapter.SelectCommand = _command;
                _adapter.Fill(kembalian);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                tutupKoneksi();
            }

            return kembalian;
        }
    }
}
