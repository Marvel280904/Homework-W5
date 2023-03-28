using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_W5
{
    public partial class Form1 : Form
    {
        DataTable simpanproduk = new DataTable();
        DataTable kategori= new DataTable();
        DataTable tampilproduk = new DataTable();
        List<string> id = new List<string>() {"J001", "T001", "K001", "K002", "R001", "J002", "C001", "S001"};
        List<string> barang = new List<string>() { "Jas Hitam", "T-Shirt", "Kemeja Hitam", "Kemeja Putih", "Rok Mini", "Jeans Hitam", "Celana Pendek Hitam", "Sweater Hitam"};
        List<string> harga = new List<string>() {"1000000", "200000", "400000", "400000", "100000", "500000", "150000", "250000"};
        List<string> stock = new List<string>() {"10", "20", "10", "10", "7", "5", "10", "5"};
        List<string> ktgr = new List<string>() {"C1", "C2", "C3", "C3", "C4", "C5", "C6", "C7"};
        List<string> idktgr = new List<string>() {"C1", "C2", "C3", "C4", "C5", "C6", "C7"};
        List<string> namaktgr = new List<string>() {"Jas", "T-Shirt", "Kemeja", "Rok", "Jeans", "Celana", "Sweater"};
        int cek = 0;
        int c = 0;
        int nampung = 0;
        int n = 0;
        int edit = 0;
        string hapus = "";
        string idbaru = "";
        string idbarang = "";
        string idkategori = "";
        string simpenkategori = "";
        string simpenbarang = "";
        public Form1()
        {
            InitializeComponent();
        }

        public void updatekategori()
        {
            for(int x = 0; x < namaktgr.Count; x++)
            {
                kategori.Rows.Add(idktgr[x], namaktgr[x]);
            }
            datakategori.DataSource = kategori;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            simpanproduk.Columns.Add("Product ID"); 
            simpanproduk.Columns.Add("Product Name");
            simpanproduk.Columns.Add("Price"); 
            simpanproduk.Columns.Add("Stock");
            simpanproduk.Columns.Add("Category ID");
            databarang.DataSource = simpanproduk;
            for (int x = 0; x < barang.Count; x++)
            {
                simpanproduk.Rows.Add(id[x], barang[x], harga[x], stock[x], ktgr[x]);
            }
            databarang.DataSource = simpanproduk;

            kategori.Columns.Add("Category ID");
            kategori.Columns.Add("Category Name");
            datakategori.DataSource = kategori;
            updatekategori();

            foreach (string a in namaktgr)
            {
                listbarang.Items.Add(a);
                detailkategori.Items.Add(a);
            }

            tampilproduk = simpanproduk.Copy();
        }

        private void filter_Click(object sender, EventArgs e)
        {
            listbarang.Enabled = true;
        }

        private void all_Click(object sender, EventArgs e)
        {
            listbarang.Enabled = false;
            listbarang.Text = null;
            databarang.DataSource = simpanproduk;
        }

        private void listbarang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tampilproduk.Rows.Clear();
            foreach (DataRow a in kategori.Rows)
            {
                if (a[1] == listbarang.SelectedItem.ToString())
                {
                    foreach(DataRow b in simpanproduk.Rows)
                    {
                        if (a[0] == b[4])
                        {
                            tampilproduk.Rows.Add(b[0], b[1], b[2], b[3], b[4]);
                        }
                    }
                }
            }
            databarang.DataSource = tampilproduk;
        }

        private void addkategori_Click(object sender, EventArgs e)
        {
            cek = 0;
            if (namakategori.Text == "")
            {
                MessageBox.Show("Error please input category name first");
            }
            else
            {
                foreach (DataRow a in kategori.Rows)
                {
                    c = Convert.ToInt32(a[0].ToString().Substring(1));
                    if (c >= nampung)
                    {
                        nampung = c;
                    }
                }
                idbaru = "C" + (nampung + 1);
                foreach (DataRow b in kategori.Rows)
                {
                    if (namakategori.Text == b[1].ToString())
                    {
                        cek = 1;
                    }

                }
                if (cek == 1)
                {
                    MessageBox.Show("Error category name is already exist");
                }
                else
                {
                    kategori.Rows.Add(idbaru, namakategori.Text);
                    listbarang.Items.Add(namakategori.Text);
                    detailkategori.Items.Add(namakategori.Text);
                }
                namakategori.Text = null;
            }
        }

        private void detailharga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void detailstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void addbarang_Click(object sender, EventArgs e)
        {
            if (detailnama.Text == "" || detailkategori.SelectedItem.ToString() == "" || detailharga.Text == "" || detailstock.Text == "")
            {
                MessageBox.Show("Error please input the textbox");
            }
            else
            {
                foreach (DataRow a in simpanproduk.Rows)
                {
                    if (detailnama.Text[0].ToString().ToUpper() == a[0].ToString()[0].ToString())
                    {
                        c = Convert.ToInt32(a[0].ToString().Substring(1));
                        if (c >= n)
                        {
                            n = c;
                        }
                    }           
                }
                n += 1;
                idbarang = detailnama.Text[0].ToString().ToUpper();
                for (int i = n.ToString().Length; i < 3; i++)
                {
                    idbarang += "0";
                }
                idbarang += Convert.ToString(n);
                foreach(DataRow b in kategori.Rows)
                {
                    if (b[1].ToString() == detailkategori.SelectedItem.ToString())
                    {
                        idkategori = b[0].ToString();
                    }
                }
                simpanproduk.Rows.Add(idbarang, detailnama.Text, detailharga.Text, detailstock.Text, idkategori);
                detailnama.Text = null; detailharga.Text = null; detailstock.Text = null; detailkategori.Text = null;
            }    
        }

        private void hapuskategori_Click(object sender, EventArgs e)
        {
            listbarang.Items.Remove(datakategori.SelectedCells[1].Value.ToString());
            detailkategori.Items.Remove(datakategori.SelectedCells[1].Value.ToString());
            foreach (DataRow a in kategori.Rows)
            {
                if (a[0].ToString() == simpenkategori)
                {
                    kategori.Rows.Remove(a);
                    break;
                }
            }       
            namakategori.Text = null;
            for (int x = simpanproduk.Rows.Count - 1; x >= 0; x--)
            {
                if (simpanproduk.Rows[x][4].ToString() == simpenkategori)
                {
                    simpanproduk.Rows.RemoveAt(x);
                }
            }
        }

        private void datakategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            simpenkategori = datakategori.SelectedCells[0].Value.ToString();
            namakategori.Text = datakategori.SelectedCells[1].Value.ToString();
        }

        private void databarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hapus = databarang.SelectedCells[0].Value.ToString();
            detailnama.Text = databarang.SelectedCells[1].Value.ToString();
            simpenbarang = databarang.SelectedCells[4].Value.ToString();
            foreach (DataRow a in kategori.Rows)
            {
                if (a[0].ToString() == simpenbarang)
                {
                    detailkategori.Text = a[1].ToString();
                    break;
                }
            }
            detailharga.Text = databarang.SelectedCells[2].Value.ToString();
            detailstock.Text = databarang.SelectedCells[3].Value.ToString();

        }

        private void editbarang_Click(object sender, EventArgs e)
        {
            if (detailnama.Text == "" || detailkategori.SelectedItem.ToString() == "" || detailharga.Text == "" || detailstock.Text == "")
            {
                MessageBox.Show("Error please input the textbox");
            }
            else
            {
                edit = databarang.SelectedRows[0].Index;
                if (detailstock.Text == "0")
                {
                    simpanproduk.Rows.RemoveAt(edit);
                }
                else
                {     
                    simpanproduk.Rows[edit][1] = detailnama.Text;
                    simpanproduk.Rows[edit][2] = detailharga.Text;
                    simpanproduk.Rows[edit][3] = detailstock.Text;
                    foreach (DataRow a in kategori.Rows)
                    {
                        if (a[1].ToString() == detailkategori.Text)
                        {
                            simpanproduk.Rows[edit][4] = a[0].ToString();
                            break;
                        }
                    }
                }    
            }
            detailnama.Text = null; detailharga.Text = null; detailstock.Text = null; detailkategori.Text = null;
        }

        private void hapusbarang_Click(object sender, EventArgs e)
        {
            foreach (DataRow a in simpanproduk.Rows)
            {
                if (hapus == a[0])
                {
                    simpanproduk.Rows.Remove(a);
                    break;
                }
            }
            detailnama.Text = null; detailharga.Text = null; detailstock.Text = null; detailkategori.Text = null;
        }
    }
}
