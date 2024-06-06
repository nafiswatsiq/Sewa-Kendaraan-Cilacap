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
        PelangganCls pelanggan = new PelangganCls();

        DataTable dataTable = new DataTable();

        string jenis;
        string namaKendaraan;
        string plat_nomor;
        int harga;
        string total;
        int total_bayar;
        string selectedValueKendaraan;
        int pelanggan_id;

        private SewaKendaraan sewaKendaraanForm;

        public TambahSewa_Frm(SewaKendaraan sewaKendaraanForm)
        {
            InitializeComponent();
            this.sewaKendaraanForm = sewaKendaraanForm;
        }

        private void totalHariTxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Tidak memperbolehkan nilai kurang dari 1
            if (e.KeyChar == '0' && totalHariTxt.Text.Length == 0)
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
            dataTable.Columns.Add("Total Hari");
            dataTable.Columns.Add("Tgl Mulai");
            dataTable.Columns.Add("Tgl Selesai");
            dataTable.Columns.Add("Nama Kendaraan");
            dataTable.Columns.Add("Plat Nomor");
            dataTable.Columns.Add("Harga");
            dataTable.Columns.Add("Total");

            SewaGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SewaGridView.DataSource = dataTable;
        }

        void ClearDataKendaraan()
        {
            totalHariTxt.Text = "1";
            tanggalMulaiDate.Value = DateTime.Now;
            tanggalSelesaiDate.Value = DateTime.Now;
            totalLbl.Text = "Rp. 0";
        }

        private void tambahBtn_Click(object sender, EventArgs e)
        {
            total_bayar = total_bayar += Convert.ToInt32(total);
            totalBayarLbl.Text = "Rp. " + total_bayar;

            dataTable.Rows.Add(
                selectedValueKendaraan,
                totalHariTxt.Text,
                tanggalMulaiDate.Value.ToString("yyyy-MM-dd"),
                tanggalSelesaiDate.Value.ToString("yyyy-MM-dd"),
                namaKendaraan,
                plat_nomor,
                harga,
                total
             );

            ClearDataKendaraan();
        }

        int selectedRowIndex;
        private void SewaGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                hapusBtn.Visible = true;
                //DataGridViewRow row = this.SewaGridView.Rows[e.RowIndex];
                selectedRowIndex = e.RowIndex;
            }
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Dapatkan indeks baris yang dipilih dalam DataGridView
                //selectedRowIndex = SewaGridView.SelectedRows[0].Index;
                MessageBox.Show(selectedRowIndex.ToString());
                int selectedTotal = Convert.ToInt32(SewaGridView.Rows[selectedRowIndex].Cells["Total"].Value.ToString());

                total_bayar = total_bayar - selectedTotal;
                totalBayarLbl.Text = "Rp. " + total_bayar;
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

            pelanggan.nama = namaPelangganTxt.Text;
            pelanggan.alamat = alamatPelangganTxt.Text;
            pelanggan.no_tlp = noTlpTxt.Text;
            pelanggan.total_bayar = total_bayar;

            string code = pelanggan.insert();
            if(code != "")
            {
                pelanggan_id = pelanggan.getPelangganId(code);

                foreach (DataRow item in dataTable.Rows)
                {
                    sewa.code = sewa.buatKode();
                    sewa.pelanggan_id = pelanggan_id;
                    sewa.kendaraan_id = Convert.ToInt32(item["Id"]);
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

                MessageBox.Show(data + " Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    pelanggan.deleteById(pelanggan_id);
                }
                catch (Exception ex)
                {
                       Console.WriteLine(ex.Message);
                }

                MessageBox.Show(data + " Data Gagal disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sewaKendaraanForm.ListSewa();

            this.Close();
        }

        void cetak()
        {
            
        }

        private void totalHariTxt_TextChanged(object sender, EventArgs e)
        {
            foreach (DataRow item in sewa.getKendaraanById(selectedValueKendaraan).Rows)
            {
                harga = Convert.ToInt32(item["harga"].ToString());
            }

            if (totalHariTxt.Text != "")
            {
                total = Convert.ToString(harga * Convert.ToInt32(totalHariTxt.Text));
                totalLbl.Text = "Rp. " + total;
            }

        }

        private void noTlpTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Hanya menerima angka dan tombol backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Tidak memperbolehkan nilai kurang dari 1
            if (e.KeyChar == '0' && noTlpTxt.Text.Length == 0)
            {
                e.Handled = true;
            }

            // Membatasi panjang teks maksimal 16 karakter
            if (noTlpTxt.Text.Length >= 16 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
