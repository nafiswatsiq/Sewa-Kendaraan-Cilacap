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
    using print;

    public partial class SewaKendaraan : Form
    {
        SewaCls sewa = new SewaCls();
        PelangganCls pelanggan = new PelangganCls();

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
            if(cariInputTxt.Text != "")
            {
                tabelSewa.DataSource = pelanggan.search(cariInputTxt.Text);
            } else
            {
                tabelSewa.DataSource = pelanggan.getAllData();
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

                EditSewa_Frm editSewa = new EditSewa_Frm(this);
                editSewa.code_pelanggan = row.Cells[0].Value.ToString();
                editSewa.nama = row.Cells[1].Value.ToString();
                editSewa.alamat = row.Cells[2].Value.ToString();
                editSewa.no_tlp = row.Cells[3].Value.ToString();
                editSewa.total_bayar = row.Cells[4].Value.ToString();
                editSewa.ShowDialog();
            }   
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            ListSewa();
        }

    }
}
