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
        private string _code;
        private int _kendaraan_id;
        private string _nama_kendaraan;
        private string _nama_pelanggan;
        private string _alamat_pelanggan;
        private int _total_hari;
        private string _mulai;
        private string _selesai;
        private int _total_harga;

        public string code
        {
            set { _code = value; }
        }

        public int kendaraan_id
        {
            set { _kendaraan_id = value; }
        }

        public string nama_kendaraan
        {
            set { _nama_kendaraan = value; }
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
            set { _selesai = value; }
        }

        public int total_harga
        {
            set { _total_harga = value; }
        }

        SewaCls sewa = new SewaCls();

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

            kendaraanCmb.SelectedIndex = kendaraanCmb.FindStringExact(_nama_kendaraan);
        }

        int harga;
        string total;
        string selectedValueKendaraan;

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
            namaPelangganTxt.Text = _nama_pelanggan;
            alamatPelangganTxt.Text = _alamat_pelanggan;
            totalHariTxt.Text = _total_hari.ToString();
            tanggalMulaiDate.Value = Convert.ToDateTime(_mulai);
            tanggalSelesaiDate.Value = Convert.ToDateTime(_selesai);
            totalLbl.Text = "Rp. "+_total_harga.ToString();
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sewa.deleteData(_code);
                MessageBox.Show("Data berhasil dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                sewaKendaraanForm.ListSewa();

                this.Close();
            }
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            sewa.code = _code;
            sewa.kendaraan_id = Convert.ToInt32(selectedValueKendaraan);
            sewa.nama_pelanggan = namaPelangganTxt.Text;
            sewa.alamat_pelanggan = alamatPelangganTxt.Text;
            sewa.total_hari = Convert.ToInt32(totalHariTxt.Text);
            sewa.mulai = tanggalMulaiDate.Value.ToString("yyyy-MM-dd");
            sewa.selesai = tanggalSelesaiDate.Value.ToString("yyyy-MM-dd");
            sewa.total_harga = Convert.ToInt32(total);

            if (sewa.updateData() > 0)
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
    }
}
