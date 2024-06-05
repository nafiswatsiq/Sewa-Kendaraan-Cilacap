using MySqlX.XDevAPI.Relational;
using Sewa_Kendaraan_Cilacap.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sewa_Kendaraan_Cilacap.view
{
    public partial class TambahSewa_Frm : Form
    {
        SewaCls sewa = new SewaCls();
        // Buat DataTable untuk menyimpan data sementara
        DataTable dataTable = new DataTable();

        string jenis;
        string namaKendaraan;
        string plat_nomor;
        int harga;
        string total;
        string selectedValueKendaraan;

        private SewaKendaraan sewaKendaraanForm;

        public TambahSewa_Frm(SewaKendaraan sewaKendaraanForm)
        {
            InitializeComponent();
            this.sewaKendaraanForm = sewaKendaraanForm;
        }

        private void totalHariTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            if(dataTable.Rows.Count > 0)
            {
                DialogResult result =  MessageBox.Show("Data belum tersimpan, ingin menutup?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            } else
            {
                this.Close();
            }
        }

        private void TambahSewa_Frm_Load(object sender, EventArgs e)
        {
            ListKendaraan();
            MakeDataTable();

            totalHariTxt.Text = "1";
            namaPelangganTxt.Focus();
        }

        Dictionary<string, string> comboBoxItems = new Dictionary<string, string>();
        
        void ListKendaraan()
        {

            kendaraanCmb.Items.Clear();

            foreach (DataRow item in sewa.getKendaraan().Rows)
            {
                string label = item["nama"].ToString();
                string value = item["id"].ToString();

                kendaraanCmb.Items.Add(label);

                comboBoxItems[label] = value;
            }
        }

        private void kendaraanCmb_SelectedValueChanged(object sender, EventArgs e)
        {

            selectedValueKendaraan = comboBoxItems[kendaraanCmb.SelectedItem.ToString()];
            foreach (DataRow item in sewa.getKendaraanById(selectedValueKendaraan).Rows)
            {
                jenis = item["jenis"].ToString();
                namaKendaraan = item["nama"].ToString();
                plat_nomor = item["plat_nomor"].ToString();
                harga = Convert.ToInt32(item["harga"].ToString());
            }

            total = Convert.ToString(harga * Convert.ToInt32(totalHariTxt.Text));
            totalLbl.Text = "Rp. " + total;
        }

        void MakeDataTable()
        {
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Nama Pelanggan");
            dataTable.Columns.Add("Alamat Pelanggan");
            dataTable.Columns.Add("Total Hari");
            dataTable.Columns.Add("Tgl Mulai");
            dataTable.Columns.Add("Tgl Selesai");
            dataTable.Columns.Add("Nama Kendaraan");
            dataTable.Columns.Add("Plat Nomor");
            dataTable.Columns.Add("Harga");
            dataTable.Columns.Add("Total");

            SewaGridView.DataSource = dataTable;
        }

        private void tambahBtn_Click(object sender, EventArgs e)
        {

            dataTable.Rows.Add(
                selectedValueKendaraan,
                namaPelangganTxt.Text,
                alamatPelangganTxt.Text,
                totalHariTxt.Text,
                tanggalMulaiDate.Value.ToString("yyyy-MM-dd"),
                tanggalSelesaiDate.Value.ToString("yyyy-MM-dd"),
                namaKendaraan,
                plat_nomor,
                harga,
                total
             );

            totalHariTxt.Text = "1";
            //totalHargaTxt.Text = "";
            tanggalMulaiDate.Value = DateTime.Now;
            tanggalSelesaiDate.Value = DateTime.Now;
        }

        private void SewaGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hapusBtn.Visible = true;
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Dapatkan indeks baris yang dipilih dalam DataGridView
                int selectedRowIndex = SewaGridView.SelectedRows[0].Index;

                // Hapus baris yang dipilih dari DataTable
                dataTable.Rows.RemoveAt(selectedRowIndex);

                // Perbarui DataGridView
                SewaGridView.Refresh();
            }catch (Exception ex)
            {
                MessageBox.Show("Pilih data yang akan dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            int data = 0;
            foreach (DataRow item in dataTable.Rows)
            {
                sewa.code = sewa.buatKode();
                sewa.kendaraan_id = Convert.ToInt32(item["Id"]);
                sewa.nama_pelanggan = item["Nama Pelanggan"].ToString();
                sewa.alamat_pelanggan = item["Alamat Pelanggan"].ToString();
                sewa.total_hari = Convert.ToInt32(item["Total Hari"]);
                sewa.mulai = item["Tgl Mulai"].ToString();
                sewa.selesai = item["Tgl Selesai"].ToString();
                sewa.total_harga = Convert.ToInt32(item["Total"]);

                int res = sewa.simpanData();
                if (res > 0)
                {
                    data += res;
                }
            }

            sewaKendaraanForm.ListSewa();

            MessageBox.Show(data + " Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Close();
        }
    }
}
