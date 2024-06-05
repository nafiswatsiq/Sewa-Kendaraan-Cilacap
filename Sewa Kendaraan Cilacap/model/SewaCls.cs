﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sewa_Kendaraan_Cilacap.model
{
    using config;
    using System.Data;
    using System.Security.Policy;

    internal class SewaCls
    {
        private int _id;
        private string _code;
        private int _kendaraan_id;
        private string _nama_pelanggan;
        private string _alamat_pelanggan;
        private int _total_hari;
        private string _mulai;
        private string _selesai;
        private int _total_harga;

        Connection koneksi;
        string query;

        public SewaCls()
        {
            _id = 0;
            _code = "";
            _kendaraan_id = 0;
            _nama_pelanggan = "";
            _alamat_pelanggan = "";
            _total_hari = 0;
            _mulai = "";
            _selesai = "";
            _total_harga = 0;

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

        public int kendaraan_id
        {
            set { _kendaraan_id = value; }
        }

        public string nama_pelanggan
        {
            set { _nama_pelanggan = value; }
        }

        public string alamat_pelanggan
        {
            set { _alamat_pelanggan = value; }
        }

        public int total_hari
        {
            set { _total_hari = value; }
        }

        public string mulai
        {
            set { _mulai = value; }
        }

        public string selesai
        {
            set { _selesai=value; }
        }

        public int total_harga
        {
            set { _total_harga = value; }
        }

        public DataTable getKendaraan()
        {
            query = "SELECT * FROM kendaraan";

            return koneksi.eksekusiQuery(query);
        }

        public DataTable getKendaraanById(string id_kendaraan)
        {
            query = "SELECT j.nama AS jenis, k.* FROM kendaraan k JOIN jenis j ON k.jenis_id = j.id WHERE k.id = '"+ id_kendaraan +"'";

            return koneksi.eksekusiQuery(query);
        }

        public int simpanData()
        {
            int hasil = -1;

            try
            {
                query = "INSERT INTO sewa " +
                            "(code, kendaraan_id, nama_pelanggan, alamat_pelanggan, total_hari, mulai, selesai, total_harga)" +
                            " VALUES " +
                            "('"+ _code +"', '" + _kendaraan_id + "', '" + _nama_pelanggan + "', '" + _alamat_pelanggan + "', '" + _total_hari + "', '" + _mulai + "', '" + _selesai + "', '" + _total_harga + "')";

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

        public DataTable getAllData()
        {
            query = "SELECT j.nama AS jenis_kendaraan, " +
                "k.nama AS nama_kendaraan, " +
                "k.plat_nomor, " +
                "s.code, " +
                "s.nama_pelanggan, " +
                "s.alamat_pelanggan, " +
                "s.total_hari, " +
                "s.mulai, " +
                "s.selesai, " +
                "s.total_harga " +
                "FROM sewa s JOIN kendaraan k " +
                "ON s.kendaraan_id = k.id " +
                "JOIN jenis j ON j.id = k.jenis_id " +
                "ORDER BY s.id DESC";

            return koneksi.eksekusiQuery(query);
        }

        public DataTable search(string keyword)
        {
            query = "SELECT j.nama AS jenis_kendaraan, " +
                "k.nama AS nama_kendaraan, " +
                "k.plat_nomor, s.code, " +
                "s.nama_pelanggan, " +
                "s.alamat_pelanggan, " +
                "s.total_hari, " +
                "s.mulai, " +
                "s.selesai, " +
                "s.total_harga " +
                "FROM sewa s " +
                "JOIN kendaraan k ON s.kendaraan_id = k.id " +
                "JOIN jenis j ON j.id = k.jenis_id " +
                "WHERE k.nama LIKE '%" + keyword + "%' " +
                "OR k.plat_nomor LIKE '%" + keyword + "%' " +
                "OR s.code LIKE '%" + keyword + "%' " +
                "OR s.nama_pelanggan LIKE '%" + keyword + "%' " +
                "OR s.alamat_pelanggan LIKE '%" + keyword + "%'";

            return koneksi.eksekusiQuery(query);
        }

        public int deleteData(string code)
        {
            int hasil = -1;

            try
            {
                query = "DELETE FROM sewa WHERE code = '" + code + "'";

                hasil = koneksi.eksekusiBukanQuery(query);

                if (hasil < 0)
                {
                    throw new Exception("Gagal menghapus data");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                hasil = -1;
            }

            return hasil;
        }

        public string buatKode()
        {
            string kode = "";
            int index = 0;
            DataTable dt = new DataTable();

            query = "SELECT IFNULL(MAX(id), 0 ) + 1  AS code FROM sewa";
            dt = koneksi.eksekusiQuery(query);

            if (dt.Rows.Count > 0)
            {
                kode = dt.Rows[0]["code"].ToString();
                index = Convert.ToInt32(kode);

                if (index > 0 && index < 10)
                {
                    kode = "S" + index;
                }
                else
                {
                    kode = "S" + index.ToString();
                }
            }

            return kode;

        }

        public DataTable getDataByCode(string code)
        {
            query = "SELECT j.nama AS jenis_kendaraan, " +
                "k.nama AS nama_kendaraan, " +
                "k.plat_nomor, s.code, s.kendaraan_id" +
                "s.nama_pelanggan, " +
                "s.alamat_pelanggan, " +
                "s.total_hari, " +
                "s.mulai, s.selesai, s.total_harga " +
                "FROM sewa s JOIN kendaraan k " +
                "ON s.kendaraan_id = k.id " +
                "JOIN jenis j ON j.id = k.jenis_id " +
                "WHERE s.code = '" + code + "'";

            return koneksi.eksekusiQuery(query);
        }

        public int updateData()
        {
            int hasil = -1;

            try
            {
                query = "UPDATE sewa SET " +
                    "kendaraan_id='"+ _kendaraan_id +"'," +
                    "nama_pelanggan='"+_nama_pelanggan+"'," +
                    "alamat_pelanggan='"+_alamat_pelanggan+"'," +
                    "total_hari='"+_total_hari+"'," +
                    "mulai='"+_mulai+"'," +
                    "selesai='"+_selesai+"'," +
                    "total_harga='"+_total_harga+"' " +
                    "WHERE code='"+_code+"'";


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
    }
}
