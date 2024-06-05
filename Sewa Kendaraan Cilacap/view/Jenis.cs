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
    public partial class Jenis : Form
    {
        JenisCls jenis = new JenisCls();

        public Jenis()
        {
            InitializeComponent();
        }

        private void Jenis_Load(object sender, EventArgs e)
        {
            tampilData();
            IdTxt.Text = jenis.buatKode();
            NamaTxt.Focus();
        }

        void tampilData()
        {
            if (SearchBox.Text != "")
            {
                DataGridJenis.DataSource = jenis.search(SearchBox.Text);
            }
            else
            {
                DataGridJenis.DataSource = jenis.getJenis();
            }
        }

        private void SimpanBtn_Click(object sender, EventArgs e)
        {
            if (IdTxt.Text == "" || NamaTxt.Text == "")
            //if (IdTxt.Text == "" && NamaTxt.Text == "")
            {
                MessageBox.Show("Form Harus di isi", "gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!jenis.isExist(IdTxt.Text))
            {
                jenis.id = IdTxt.Text;
                jenis.nama = NamaTxt.Text;

                if (jenis.insert() > 0)
                {
                    MessageBox.Show("Data berhasil disimpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();

                    tampilData();
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
            if (jenis.isExist(IdTxt.Text))
            {
                jenis.nama = NamaTxt.Text;

                if (jenis.update(IdTxt.Text) > 0)
                {
                    MessageBox.Show("Data berhasil diubah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();

                    tampilData();
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

        private void BatalBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void HapusBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Data dengan id " + IdTxt.Text + " akan dihapus", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if(result == DialogResult.OK)
            {
                if (jenis.isExist(IdTxt.Text))
                {
                    if (jenis.delete(IdTxt.Text) > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearForm();

                        tampilData();
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

        private void TutupBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                SimpanBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.U && e.Control)
            {
                UbahBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.H && e.Control)
            {
                HapusBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            tampilData();
        }

        void ClearForm()
        {
            IdTxt.Clear();
            NamaTxt.Clear();
            NamaTxt.Focus();

            IdTxt.Text = jenis.buatKode();
        }

        private void GetCode_Click(object sender, EventArgs e)
        {
            string kode = jenis.ambilKodeByNama(NamaTxt.Text);

            MessageBox.Show("kode nya " + kode);
        }

        private void DataGridJurusan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = this.DataGridJenis.Rows[e.RowIndex];
                IdTxt.Text = row.Cells[0].Value.ToString();
                NamaTxt.Text = row.Cells[1].Value.ToString();

                NamaTxt.SelectAll();
                NamaTxt.Focus();
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            tampilData();
        }

        private void IdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NamaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridJurusan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
