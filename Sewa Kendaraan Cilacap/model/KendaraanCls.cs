using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sewa_Kendaraan_Cilacap.model
{
    using config;
    using System.Data;
    using System.Xml.Linq;

    internal class KendaraanCls
    {
        private string _id, _jenis_id, _harga;
        private string _nama, _plat_nomor;
        Connection koneksi;
        string query;

        public KendaraanCls()
        {
            _id = "";
            _jenis_id = "";
            _nama = "";
            _plat_nomor = "";
            _harga = "";

            koneksi = new Connection();
            query = "";
        }
        public string id
        {
            set { _id = value; }
        }


        public string nama
        {
            set { _nama = value; }
            //get { return _nama; }
        }
        public string plat_nomor
        {
            set { _plat_nomor = value; }
            //get { return _nama; }
        }
        public string harga
        {
            set { _harga = value; }
        }
        public string jenis_id
        {
            set { _jenis_id = value; }
        }
        public DataTable getKendaraan()
        {
            query = "SELECT k.id as id, k.nama as nama, j.nama as jenis_id,k.harga as harga,k.plat_nomor as plat_nomor from kendaraan k join jenis j on k.jenis_id = j.id";

            return koneksi.eksekusiQuery(query);
        }
        public DataTable search(string nama)
        {
            query = "SELECT k.id as id, k.nama as nama, j.nama as jenis_id,k.harga as harga,k.plat_nomor as plat_nomor from kendaraan k join jenis j on k.jenis_id = j.id where k.nama LIKE '%" + nama + "%' OR j.nama LIKE '%" + nama + "%'";

            return koneksi.eksekusiQuery(query);
        }
        public DataTable getJenis()
        {
            query = "SELECT * FROM jenis";

            return koneksi.eksekusiQuery(query);
        }
        public bool isExist(string id)
        {
            bool cek = false;

            query = "SELECT * FROM kendaraan WHERE id = '" + id + "'";
            if (koneksi.eksekusiQuery(query).Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }
        public string ambilKodeJenisByNama(string nama)
        {
            string kode = "";
            DataTable dt = new DataTable();
            query = "SELECT * FROM jenis WHERE nama = '" + nama + "'";
            dt = koneksi.eksekusiQuery(query);

            if (dt.Rows.Count > 0)
            {
                kode = dt.Rows[0]["id"].ToString();
            }

            return kode;
        }
        public int insert()
        {
            int hasil = -1;

            query = "INSERT INTO kendaraan VALUES('" + _id + "','" + _jenis_id + "','" + _nama + "','" + _plat_nomor + "','" + _harga + "', 'gambar')";
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
                hasil = -1;
            }

            return hasil;
        }
        public int update(string id)
        {
            int hasil = -1;

            query = $"UPDATE kendaraan SET nama = '{_nama}', jenis_id = '{_jenis_id}', plat_nomor = '{_plat_nomor}', harga = '{_harga}' WHERE id = '{id}'";

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

            query = "DELETE FROM kendaraan WHERE id ='" + id + "'";

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

        public string buatKode()
        {
            string kode = "";
            int index = 0;
            DataTable dt = new DataTable();

            query = "SELECT IFNULL(MAX(id), 0 ) + 1  as kode from kendaraan";
            dt = koneksi.eksekusiQuery(query);

            if (dt.Rows.Count > 0)
            {
                kode = dt.Rows[0]["kode"].ToString();
                index = Convert.ToInt32(kode);

                if (index > 0 && index < 10)
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
