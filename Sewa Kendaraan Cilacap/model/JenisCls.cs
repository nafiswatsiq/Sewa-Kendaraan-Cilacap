using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sewa_Kendaraan_Cilacap.model
{
    using config;
    using System.Data;
    

    internal class JenisCls
    {
        private string _id;
        private string _nama;

        Connection koneksi;
        string query;

        public JenisCls()
        {
            _id = "";
            _nama = "";

            koneksi = new Connection();
            query = "";
        }

        public string id
        {
            set { _id = value; }
            //get { return _id; }
        }

        public string nama
        {
            set { _nama = value; }
            //get { return _nama; }
        }

        public bool isExist(string id)
        {
            bool cek = false;

            query = "SELECT * FROM jenis WHERE id = '" + id + "'";
            if (koneksi.eksekusiQuery(query).Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public int insert()
        {
            int hasil = -1;

            query = "INSERT INTO jenis VALUES('" + _id + "','" + _nama + "')";
            try
            {
                hasil = koneksi.eksekusiBukanQuery(query);
                if(hasil < 0)
                {
                    throw new Exception("Gagal menambahkan data");
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                hasil = -1;
            }

            return hasil;
        }

        public int update(string id)
        {
            int hasil = -1;

            query = "UPDATE jenis SET nama = '" + _nama + "' WHERE id = '" + id + "'";

            try
            {
                hasil = koneksi.eksekusiBukanQuery(query);
                if (hasil < 0)
                {
                    throw new Exception("Gagal menambahkan data");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return hasil;
        }

        public int delete(string id)
        {
            int hasil = -1;

            query = "DELETE FROM jenis WHERE id ='"+ id + "'";

            try
            {
                hasil = koneksi.eksekusiBukanQuery(query);
                if (hasil < 0)
                {
                    throw new Exception("Gagal menambahkan data");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return hasil;
        }

        public DataTable getJenis()
        {
            query = "SELECT * FROM jenis";

            return koneksi.eksekusiQuery(query);
        }

        public DataTable search(string nama)
        {
            query = "select * from jenis where nama LIKE '%"+nama+"%'";
            
            return koneksi.eksekusiQuery(query);
        }

        public string ambilKodeByNama(string nama)
        {
            string kode = "";
            DataTable dt = new DataTable();
            query = "SELECT * FROM jenis WHERE nama = '"+nama+"'";
            dt = koneksi.eksekusiQuery(query);

            if(dt.Rows.Count > 0)
            {
                kode = dt.Rows[0]["id"].ToString();
            }

            return kode;
        }

        public string buatKode()
        {
            string kode = "";
            int index = 0;
            DataTable dt = new DataTable();

            query = "SELECT IFNULL(MAX(id), 0 ) + 1  as kode from jenis";
            dt = koneksi.eksekusiQuery(query);

            if(dt.Rows.Count > 0)
            {
                kode = dt.Rows[0]["kode"].ToString();
                index = Convert.ToInt32(kode);

                if(index > 0 && index < 10)
                {
                    kode = "0" + index;
                }
                else
                {
                    kode = index.ToString();
                }
            }

            return kode;

        }
    }
}
