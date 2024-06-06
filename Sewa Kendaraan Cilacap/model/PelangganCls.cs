using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sewa_Kendaraan_Cilacap.model
{

    using config;
    using System.Data;
    using System.Windows.Forms;

    internal class PelangganCls
    {
        private int _id;
        private string _code;
        private string _nama;
        private string _alamat;
        private string _no_tlp;
        private int _total_bayar;

        Connection koneksi;
        string query;

        public PelangganCls()
        {
            _id = 0;
            _code = "";
            _nama = "";
            _alamat = "";
            _no_tlp = "";
            _total_bayar = 0;

            koneksi = new Connection();
            query = "";
        }

        public int id
        {
            set { _id = value; }
        }

        public string code
        {
            set { _code = value; }
        }

        public string nama
        {
            set { _nama = value; }
        }

        public string alamat
        {
            set { _alamat = value; }
        }

        public string no_tlp
        {
            set { _no_tlp = value; }
        }

        public int total_bayar
        {
            set { _total_bayar = value; }
        }

        public DataTable getAllData()
        {
            query = "SELECT code, nama, alamat, no_tlp, total_bayar FROM pelanggan";

            return koneksi.eksekusiQuery(query);
        }

        public DataTable search(string keyword)
        {
            query = "SELECT * FROM pelanggan WHERE code LIKE '%" + keyword + "%' OR nama LIKE '%" + keyword + "%' OR alamat LIKE '%" + keyword + "%' OR no_tlp LIKE '%" + keyword + "%' OR total_bayar LIKE '%" + keyword + "%'";

            return koneksi.eksekusiQuery(query);
        }

        public string buatKode()
        {
            string kode = "";
            int index = 0;
            DataTable dt = new DataTable();

            query = "SELECT IFNULL(MAX(id), 0 ) + 1  as kode from pelanggan";
            dt = koneksi.eksekusiQuery(query);

            if (dt.Rows.Count > 0)
            {
                kode = dt.Rows[0]["kode"].ToString();
                index = Convert.ToInt32(kode);

                if (index > 0 && index < 10)
                {
                    kode = "P" + index;
                }
                else
                {
                    kode = "P" + index.ToString();
                }
            }

            return kode;
        }

        public string insert()
        {
            string kode = buatKode();
            string hasil = "";

            query = "INSERT INTO pelanggan (code, nama, alamat, no_tlp, total_bayar) VALUES ('" + kode + "', '" + _nama + "', '" + _alamat + "', '" + _no_tlp + "', '" + _total_bayar + "')";

            try
            {
                koneksi.eksekusiBukanQuery(query);
                hasil = kode;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return hasil;
        }

        int pelanggan_id;
        public int getPelangganId(string code)
        {
            DataTable dt = new DataTable();

            query = "SELECT id FROM pelanggan WHERE code = '" + code + "'";

            dt = koneksi.eksekusiQuery(query);

            if (dt.Rows.Count > 0)
            {
                pelanggan_id = Convert.ToInt32(dt.Rows[0]["id"]);
            }

            return pelanggan_id;
        }

        public int deleteById(int id_pelangaan)
        {
            int hasil = -1;

            query = "DELETE FROM pelanggan WHERE id ='" + id_pelangaan + "'";

            try
            {
                hasil = koneksi.eksekusiBukanQuery(query);
                if (hasil < 0)
                {
                    throw new Exception("Gagal menghapus data");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return hasil;
        }

        public int updateData()
        {
            int hasil = -1;

            query = "UPDATE pelanggan SET nama = '" + _nama + "', alamat = '" + _alamat + "', no_tlp = '" + _no_tlp + "', total_bayar = '" + _total_bayar + "' WHERE id = '" + _id + "'";

            try
            {
                hasil = koneksi.eksekusiBukanQuery(query);
                if (hasil < 0)
                {
                    throw new Exception("Gagal mengupdate data");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return hasil;
        }
    }
}
