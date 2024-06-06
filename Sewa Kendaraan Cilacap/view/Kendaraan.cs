using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sewa_Kendaraan_Cilacap.view
{
    using model;
    public partial class Kendaraan : Form
    {
        KendaraanCls kendaraan = new KendaraanCls();
        public Kendaraan()
        {
            InitializeComponent();
        }

        private void Kendaraan_Load(object sender, EventArgs e)
        {
            getListKendaraan();
            IdTxt.Text = kendaraan.buatKode();
            ListJenis();
            NamaTxt.Focus();
        }
        void ListJenis()
        {
            JenisCmb.Items.Clear();
            foreach (DataRow item in kendaraan.getJenis().Rows)
            {
                JenisCmb.Items.Add(item["nama"]);
            }
        }
        void ClearForm()
        {
            IdTxt.Text = kendaraan.buatKode();
            NamaTxt.Text = "";
            PlatTxt.Text = "";
            HargaTxt.Text = "" ;
            JenisCmb.SelectedIndex = -1;
        }

        void getListKendaraan()
        {
            if (SearchBox.Text != "")
            {
                DataGridKendaraan.DataSource = kendaraan.search(SearchBox.Text);
            }
            else
            {
                DataGridKendaraan.DataSource = kendaraan.getKendaraan();
            }
        }

        private void SimpanBtn_Click(object sender, EventArgs e)
        {
            if (IdTxt.Text == "" && NamaTxt.Text == "" && JenisCmb.Text == "")
            {
                MessageBox.Show("Form Harus di isi", "gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!kendaraan.isExist(IdTxt.Text))
            {
                kendaraan.id = IdTxt.Text;

                kendaraan.jenis_id = kendaraan.ambilKodeJenisByNama(JenisCmb.Text);
                kendaraan.nama = NamaTxt.Text;
                kendaraan.plat_nomor = PlatTxt.Text;
                kendaraan.harga = HargaTxt.Text;


                if (kendaraan.insert() > 0)
                {
                    MessageBox.Show("Data berhasil disimpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();

                    getListKendaraan();
                }
                else
                {
                    MessageBox.Show("Data gagal disimpan", "gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Data dengan id " + IdTxt.Text + " sudah ada", "gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UbahBtn_Click(object sender, EventArgs e)
        {
            if (kendaraan.isExist(IdTxt.Text))
            {
                kendaraan.id= IdTxt.Text;
                kendaraan.nama = NamaTxt.Text;
                kendaraan.jenis_id = kendaraan.ambilKodeJenisByNama(JenisCmb.Text); 
                kendaraan.plat_nomor = PlatTxt.Text;
                kendaraan.harga = HargaTxt.Text;

                if (kendaraan.update(IdTxt.Text) > 0)
                {
                    MessageBox.Show("Data berhasil diubah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();

                    getListKendaraan();
                }
                else
                {
                    MessageBox.Show("Data gagal diubah", "gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Data dengan id " + IdTxt.Text + " tidak ditemukan", "gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HapusBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Data dengan id " + IdTxt.Text + " akan dihapus", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (kendaraan.isExist(IdTxt.Text))
                {
                    if (kendaraan.delete(IdTxt.Text) > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearForm();

                        getListKendaraan();
                    }
                    else
                    {
                        MessageBox.Show("Data gagal dihapus", "gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Data dengan id " + IdTxt.Text + " tidak ditemukan", "gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BatalBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            getListKendaraan();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            getListKendaraan();
        }

        private void DataGridKendaraan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = this.DataGridKendaraan.Rows[e.RowIndex];
                IdTxt.Text = row.Cells[0].Value.ToString();
                NamaTxt.Text = row.Cells[1].Value.ToString();
                JenisCmb.SelectedIndex = JenisCmb.FindStringExact(row.Cells[2].Value.ToString());
                PlatTxt.Text = row.Cells[4].Value.ToString();
                HargaTxt.Text = row.Cells[3].Value.ToString();

                NamaTxt.SelectAll();
                NamaTxt.Focus();
            }
        }
    }
}
