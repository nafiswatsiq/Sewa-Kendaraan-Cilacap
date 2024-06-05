using Sewa_Kendaraan_Cilacap.model;
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
    public partial class SewaKendaraan : Form
    {
        SewaCls sewa = new SewaCls();

        public SewaKendaraan()
        {
            InitializeComponent();
        }

        private void SewaKendaraan_Load(object sender, EventArgs e)
        {
            ListSewa();
        }

        public void ListSewa()
        {
            if(searchTxt.Text != "")
            {
                tabelSewa.DataSource = sewa.search(searchTxt.Text);
            } else
            {
                tabelSewa.DataSource = sewa.getAllData();
            }
        }

        private void cariBtn_Click(object sender, EventArgs e)
        {
            ListSewa();
        }

        private void tambahSewaBtn_Click(object sender, EventArgs e)
        {
            TambahSewa_Frm tambahSewa = new TambahSewa_Frm(this);
            tambahSewa.ShowDialog();
        }

        private void tabelSewa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //buat dialog untuk edit atau hapus
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.tabelSewa.Rows[e.RowIndex];
                string code = row.Cells[3].Value.ToString();

                EditSewa_Frm editSewa = new EditSewa_Frm(this);
                editSewa.nama_kendaraan = row.Cells[1].Value.ToString();
                editSewa.code = code;
                editSewa.nama_pelanggan = row.Cells[4].Value.ToString();
                editSewa.alamat_pelanggan = row.Cells[5].Value.ToString();
                editSewa.total_hari = Convert.ToInt32(row.Cells[6].Value);
                editSewa.mulai = row.Cells[7].Value.ToString();
                editSewa.selesai = row.Cells[8].Value.ToString();
                editSewa.total_harga = Convert.ToInt32(row.Cells[9].Value);
                editSewa.ShowDialog();
            }   
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            ListSewa();
        }
    }
}
