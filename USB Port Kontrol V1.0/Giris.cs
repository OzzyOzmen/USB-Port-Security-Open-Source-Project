using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;

namespace USB_Port_Kontrol_V1._0
{
    public partial class Giris : DevExpress.XtraEditors.XtraForm
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PortKontrol.accdb");
        public Giris()
        {
            InitializeComponent();
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from  kullanicilar where kadi='" + txtkullaniciadi.Text + "'and ksifre='" + txtkullanicisifre.Text + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                Form1 yeni = new Form1();
                yeni.Show();
                this.Hide();
            }

            else if (txtkullaniciadi.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı Alanı Boş Bırakılamaz", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtkullanicisifre.Text == "")
            {
                MessageBox.Show("Parola Alanı Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtkullaniciadi.Text = "";
            txtkullanicisifre.Text = "";
        }
    }
}