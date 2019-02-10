using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Management;
using System.IO.Ports;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace USB_Port_Kontrol_V1._0
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PortKontrol.accdb");


        public Form1()
        {
            
            InitializeComponent();
            HddBilgiGetir();
        }
        string folder;
        private void btnkullaniciadidegis_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblid.Text);
            string yenikullaniciadi = txtyenikullaniciadi.Text;
            baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand("update kullanicilar set kadi='"+ yenikullaniciadi +"' where id = "+ id +"",baglanti);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Kullanıcı adı başarı ile değiştirilmiştir.");
            baglanti.Close();
            txtyenikullaniciadi.Text = "";
            txtyenisifre.Text = "";
        }

       private void btnsifredeğistir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblid.Text);
            string yenisifre = txtyenisifre.Text;
            baglanti.Open();
            OleDbCommand komut3 = new OleDbCommand("update kullanicilar set ksifre='" + yenisifre + "' where id = " + id + "", baglanti);
            komut3.ExecuteNonQuery();
            MessageBox.Show("Şifre başarı ile değiştirilmiştir.");
            baglanti.Close();
            txtyenikullaniciadi.Text = "";
            txtyenisifre.Text = "";
        }
               
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from kullanicilar ", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblid.Text = (oku["id"].ToString());
                lblkullaniciadi.Text = (oku["kadi"].ToString());
                lblkullanicisifre.Text = (oku["ksifre"].ToString());
            }
            baglanti.Close();

          
                
        }

        private void btnportkilitle_Click(object sender, EventArgs e)
        {
            
            // Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 4, Microsoft.Win32.RegistryValueKind.DWord);
        
            try
            {
                string path = "SYSTEM\\CurrentControlSet\\services\\USBSTOR\\";
                RegistryKey RK = Registry.LocalMachine.OpenSubKey(path, true);
                RK.SetValue("Start", "4", RegistryValueKind.DWord);
                lbldurumbildirim.Text = "Portlar Kapatıldı";
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Yönetici olarak çalıştırmalısınız", "Durduruldu.");
            }


        }

            private void btnportkilitac_Click(object sender, EventArgs e)
        {
            lbldurumbildirim.Text = "Portlar Açıldı";
            //Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 3, Microsoft.Win32.RegistryValueKind.DWord);
           
            string path = "SYSTEM\\CurrentControlSet\\services\\USBSTOR\\";
            RegistryKey RK = Registry.LocalMachine.OpenSubKey(path, true);
            RK.SetValue("Start", "3", RegistryValueKind.DWord);
        }

        private void btncdromkilitle_Click(object sender, EventArgs e)
        {
            // Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 4, Microsoft.Win32.RegistryValueKind.DWord);
            try
            {
                string path = "SYSTEM\\CurrentControlSet\\Services\\cdrom\\";
                RegistryKey RK = Registry.LocalMachine.OpenSubKey(path, true);
                RK.SetValue("Start", "4", RegistryValueKind.DWord);
                lblcdromdurumbildirim.Text = "CDRom Kapatıldı";
            }
            catch (Exception)
            {
                MessageBox.Show(" Yönetici olarak çalıştırmalısınız", "Durduruldu.");
            }
        }

        private void btncdromkilitac_Click(object sender, EventArgs e)
        {
            lblcdromdurumbildirim.Text = "CDRom Açıldı";
            //Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 3, Microsoft.Win32.RegistryValueKind.DWord);

            string path = "SYSTEM\\CurrentControlSet\\Services\\cdrom\\";
            RegistryKey RK = Registry.LocalMachine.OpenSubKey(path, true);
            RK.SetValue("Start", "1", RegistryValueKind.DWord);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPUYuzde.NextValue();
            float fram = pRAMMB.NextValue();
            progressCPU.EditValue = (int)fcpu;
            progressRAM.EditValue = (double)fcpu;
            lblCPUyuzde.Text = string.Format("{0:0.00}%", fcpu);
            lblRamMB.Text = NewMethod(fram);

        }

        private static string NewMethod(float fram)
        {
            return $"{fram:0.00}MB";
        }


       
             
        private void BtnBosaltveTemizle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu işlem İşlemci ve Ram Optimizasyonu sağlayarak RAM kullanımınızı düşürür." + Environment.NewLine + "Devam etmek için TAMAM tuşuna tıklayınız...");



      
           // MessageBox.Show("Optimizasyon başarı ile tamamlanmış ve RAM kullanımınız optimize edilmiştir...");
        }

        private void BtnHddBosaltveTemizle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu işlem sadece Hardiskinizdeki gereksiz dosyaları temizliyecektir."+Environment.NewLine+"Devam etmek için TAMAM tuşuna tıklayınız...");
            Process.Start("C:\\Windows\\system32\\cleanmgr.exe");

        }

        static string ConvertToMegabytes(decimal bytes)
        {
            return ((decimal)bytes / 1024M / 1024M).ToString("F1") + "MB";
        }

        static string ConvertToGigabytes(decimal bytes)
        {
            return ((decimal)bytes / 1024M / 1024M / 1024M).ToString("F1") + "GB";
        }

        private void HddBilgiGetir()
        {
            string[] drive = Directory.GetLogicalDrives();
            foreach (string item in drive)
            {
                cmbHDDSecin.Items.Add(item.ToString());
            }
        }
        private void cmbHDDSecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string getinfo = cmbHDDSecin.SelectedItem.ToString();
            DriveInfo driveinfo = new DriveInfo(getinfo);
           Decimal Avaible_Space = Convert.ToDecimal(driveinfo.AvailableFreeSpace);
            Decimal Total_Space = Convert.ToDecimal(driveinfo.TotalFreeSpace);
            Decimal Drive_Type = Convert.ToDecimal(driveinfo.DriveType);
            lblhddAvaible_Space.Text = ConvertToGigabytes( Avaible_Space );
            lblhddTotal_Space.Text = ConvertToGigabytes(Total_Space);
            lblhddDrive_Type.Text = Drive_Type.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folder = folderBrowserDialog1.SelectedPath;
                label1.Text += folder;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (folder != null)
            {
                string[] filename = { ".htt", ".txt", ".docx" };
                string[] files = Directory.GetFiles(folder);
                progressBar1.Maximum = files.Count();
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file);
                    foreach (string filess in filename)
                    {
                        if (extension == filess)
                        {
                            string filename2 = Path.GetFileNameWithoutExtension(file);
                            listBox1.Items.Add(file);
                            listBox2.Items.Add(filename2 + "\t" + extension);
                        }
                    }
                    progressBar1.Increment(1);
                    label6.Text = "Dosya Aranıyor...";
                }



            }
            else
            {
                MessageBox.Show("Virüs taraması için dosya seçmelisiniz");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                foreach (string item in listBox1.Items)
                {
                    File.Delete(item);
                }
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                MessageBox.Show("Bütün virüsler temizlendi");
            }
            else
            {
                MessageBox.Show("Virüs Bulunamadı");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0)
            {

            }
            else
            {
                MessageBox.Show("Silmek için Seçili virüs yok, önce seçmelisiniz !..");
            }
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

