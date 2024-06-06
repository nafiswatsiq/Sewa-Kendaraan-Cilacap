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
    public partial class EditSewa_Frm : Form
    {
        private string _code_pelanggan;
        private string _nama;
        private string _alamat;
        private string _no_tlp;
        private string _total_bayar;

        int pelanggan_id;
        int total_hari;
        private string nama_kendaraan;
        string tanggal_mulai;
        string tanggal_selesai;
        int total_harga;
        int harga;
        string sewa_code;
        string total;
        string selectedValueKendaraan;

        public string code_pelanggan
        {
            set { _code_pelanggan = value; }
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

        public string total_bayar
        {
            set { _total_bayar = value; }
        }

        SewaCls sewa = new SewaCls();
        PelangganCls pelanggan = new PelangganCls();

        private SewaKendaraan sewaKendaraanForm;

        public EditSewa_Frm(SewaKendaraan sewaKendaraanForm)
        {
            InitializeComponent();
            this.sewaKendaraanForm = sewaKendaraanForm;
        }

        private void EditSewa_Frm_Load(object sender, EventArgs e)
        {
            totalHariTxt.Text = "1";

            LoadKendaraan();
            SetData();
            setDataSewa();

        }

        Dictionary<string, string> comboBoxItems = new Dictionary<string, string>();

        void LoadKendaraan()
        {
            kendaraanCmb.Items.Clear();
            foreach (DataRow item in sewa.getKendaraan().Rows)
            {
                string label = item["nama"].ToString();
                string value = item["id"].ToString();

                kendaraanCmb.Items.Add(label);

                comboBoxItems[label] = value;
            }

            //kendaraanCmb.SelectedIndex = kendaraanCmb.FindStringExact(_nama_kendaraan);
        }

        private void kendaraanCmb_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedValueKendaraan = comboBoxItems[kendaraanCmb.SelectedItem.ToString()];
            foreach (DataRow item in sewa.getKendaraanById(selectedValueKendaraan).Rows)
            {
                harga = Convert.ToInt32(item["harga"].ToString());
            }

            total = Convert.ToString(harga * Convert.ToInt32(totalHariTxt.Text));
            totalLbl.Text = "Rp. " + total;
        }

        void SetData()
        {
            namaPelangganTxt.Text = _nama;
            alamatPelangganTxt.Text = _alamat;
            noTlpTxt.Text = _no_tlp;
            totalBayarLbl.Text = "Rp. " + _total_bayar;

            pelanggan_id = pelanggan.getPelangganId(_code_pelanggan);
        }

        void setDataSewa()
        {
            DataGridSewa.DataSource = sewa.getDataByPelanggan(pelanggan_id);
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                pelanggan.deleteById(pelanggan_id);
                MessageBox.Show("Data berhasil dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sewaKendaraanForm.ListSewa();

                this.Close();
            }
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {

            pelanggan.id = pelanggan_id;
            pelanggan.nama = namaPelangganTxt.Text;
            pelanggan.alamat = alamatPelangganTxt.Text;
            pelanggan.no_tlp = noTlpTxt.Text;
            pelanggan.total_bayar = Convert.ToInt32(_total_bayar);

            if (pelanggan.updateData() > 0)
            {
                MessageBox.Show("Data berhasil diubah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sewaKendaraanForm.ListSewa();

                this.Close();
            }
            else
            {
                MessageBox.Show("Data gagal diubah", "gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridSewa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataGridSewa.Rows[e.RowIndex];
                sewa_code = row.Cells[2].Value.ToString();
                totalHariTxt.Text = row.Cells[3].Value.ToString();
                tanggalMulaiDate.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());
                tanggalSelesaiDate.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());

                kendaraanCmb.SelectedIndex = kendaraanCmb.FindStringExact(row.Cells[0].Value.ToString());

            }
        }

        private void UbahKendaraanBtn_Click(object sender, EventArgs e)
        {
            sewa.code = sewa_code;
            sewa.kendaraan_id = Convert.ToInt32(selectedValueKendaraan);
            sewa.total_hari = Convert.ToInt32(totalHariTxt.Text);
            sewa.mulai = tanggalMulaiDate.Value.ToString("yyyy-MM-dd");
            sewa.selesai = tanggalSelesaiDate.Value.ToString("yyyy-MM-dd");
            sewa.total_harga = Convert.ToInt32(total);

            if (sewa.updateData() > 0)
            {
                _total_bayar = Convert.ToString(sewa.getTotalBayar(pelanggan_id));
                totalBayarLbl.Text = "Rp. " + _total_bayar;

                setDataSewa();
            }
            else
            {
                MessageBox.Show("Data gagal diubah", "gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearDataKendaraan();
        }

        private void totalHariTxt_TextChanged(object sender, EventArgs e)
        {
            foreach (DataRow item in sewa.getKendaraanById(selectedValueKendaraan).Rows)
            {
                harga = Convert.ToInt32(item["harga"].ToString());
            }

            total = Convert.ToString(harga * Convert.ToInt32(totalHariTxt.Text));
            totalLbl.Text = "Rp. " + total;
        }

        void ClearDataKendaraan()
        {
            totalHariTxt.Text = "1";
            tanggalMulaiDate.Value = DateTime.Now;
            tanggalSelesaiDate.Value = DateTime.Now;
            totalLbl.Text = "0";
        }
        private void tambahKendaraanBtn_Click(object sender, EventArgs e)
        {
            sewa.code = sewa.buatKode();
            sewa.pelanggan_id = pelanggan_id;
            sewa.kendaraan_id = Convert.ToInt32(selectedValueKendaraan);
            sewa.total_hari = Convert.ToInt32(totalHariTxt.Text);
            sewa.mulai = tanggalMulaiDate.Value.ToString("yyyy-MM-dd");
            sewa.selesai = tanggalSelesaiDate.Value.ToString("yyyy-MM-dd");
            sewa.total_harga = Convert.ToInt32(total);

            if (sewa.simpanData() > 0)
            {
                _total_bayar = Convert.ToString(sewa.getTotalBayar(pelanggan_id));
                totalBayarLbl.Text = "Rp. " + _total_bayar;

                setDataSewa();
            }
            else
            {
                MessageBox.Show("Data gagal disimpan", "gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearDataKendaraan();
        }

        private void hapusKendaraanBtn_Click(object sender, EventArgs e)
        {
            if (sewa.deleteData(sewa_code) > 0)
            {
                _total_bayar = Convert.ToString(sewa.getTotalBayar(pelanggan_id));
                totalBayarLbl.Text = "Rp. " + _total_bayar;

                setDataSewa();
            }
            else
            {
                MessageBox.Show("Data gagal dihapus", "gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearDataKendaraan();
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
