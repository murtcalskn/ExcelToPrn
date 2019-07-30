using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace ExcelToPrn
{
    //murtcalskn@hotmail.com
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        
        private void btnDosyaYolu_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                btnDosyaYolu.Text = openFileDialog1.FileName.ToString();
            }
        }
        private void btnDosyaOku_Click(object sender, EventArgs e)
        {
            try
            {
                string dosyaYolu = btnDosyaYolu.Text.ToString();
                string tablo = txtTablo.Text.ToString();

                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dosyaYolu + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1;\"";
                conn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * From [" + tablo + "$] ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataDosya.DataSource = dt.DefaultView;
               
                comboDoldur();
                MessageBox.Show("Dosya okuma işlemi başarı ile gerçekleşti.","Dosya Okuma",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen dosyanın excel dosyası olduğunu kontrol edin ! \nTablo adının doğru girildiğinden emin olun !", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            conn.Close();

        }
        private void comboDoldur()
        {
            string dosyaYolu = btnDosyaYolu.Text.ToString();
            string tablo = txtTablo.Text.ToString();
            cmbMagaza.Items.Clear();
            cmd.CommandText = "Select MAGAZA From [" + tablo + "$] GROUP BY MAGAZA";
            cmd.Connection = conn;
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(dt);
            cmbMagaza.DataSource = dt;
            cmbMagaza.DisplayMember = "MAGAZA"; 
        }
        private void btnAktar_Click(object sender, EventArgs e)
        {

            string dosyaYolu = btnDosyaYolu.Text.ToString();
            string tablo = txtTablo.Text.ToString();
            cmd.Connection = conn;
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dosyaYolu + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1;\"";
            conn.Open();
            string sql="",birim="";
            if (radioTL.Checked == true)
            {
                sql = "Select [UPC-EAN BARCODE],VAN,[Ürün Tipi],[Tavsiye Edilen PSF KDV Dahil-TR],[PSF Uygulama Tarihi],[Kaynak Ülke],MAGAZA From [" + tablo + "$] Where MAGAZA=@MAGAZA";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@MAGAZA", cmbMagaza.Text);
                birim = "TL";
            }
            else if (radioEuro.Checked == true)
            {
                sql = "Select [UPC-EAN BARCODE],VAN,[Ürün Tipi],[Tavsiye Edilen PSF KDV Dahil-EUR],[PSF Uygulama Tarihi],[Kaynak Ülke],MAGAZA From [" + tablo + "$] Where MAGAZA=@MAGAZA";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@MAGAZA", cmbMagaza.Text);
                birim = "Euro";
            }
            
            cmd.CommandText = sql;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataDosya.DataSource = dt.DefaultView;
            conn.Close();

            DialogResult cevap = MessageBox.Show(cmbMagaza.Text.ToString() + " mağazamızda toplamda " + (dataDosya.RowCount - 1).ToString() + " adet kayıt var \n Dosyayı yazdırmak istediğinize emin misiniz ?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap==DialogResult.Yes)
            {
                string prnYol = btnGoruntule.Text;
                StreamWriter yaz = File.AppendText(prnYol);
                for (int i = 0; i < dataDosya.RowCount; i++)
                {
                    var q = dataDosya.Rows[i].Cells[5].Value;
                    string ulke = q != null ? q.ToString() : "";
                    var q1 = dataDosya.Rows[i].Cells[1].Value;
                    string van = q != null ? q.ToString() : "";
                    var q2 = dataDosya.Rows[i].Cells[3].Value;
                    string fiyat = q != null ? q.ToString() : "";
                    var q3 = dataDosya.Rows[i].Cells[0].Value;
                    string barkod = q != null ? q.ToString() : "";

                    
                    yaz.WriteLine(@"^XA");
                    yaz.WriteLine(@"^MMT");
                    yaz.WriteLine(@"^PW320");
                    yaz.WriteLine(@"^LL0160");
                    yaz.WriteLine(@"^LS0");
                    yaz.WriteLine(@"^FT106,22^A@I,17,18,TT0003M_^FH\^CI35^F8^FD"+ ulke +"^FS^CI0"); // Menşei Ülke
                    yaz.WriteLine(@"^FT121,51^A@I,23,22,TT0003M_^FH\^CI35^F8^FDÜretim Yeri^FS^CI0");
                    yaz.WriteLine(@"^FT298,86^A@I,17,18,TT0003M_^FH\^CI35^F8^FD"+ van + "^FS^CI0"); // VAN bilgisi
                    yaz.WriteLine(@"^FT290,107^A@I,16,15,TT0003M_^FH\^CI35^F8^FD10.09.2018 tarihinden itibaren geçerlidir^FS^CI0");
                    yaz.WriteLine(@"^FT141,129^A@I,17,18,TT0003M_^FH\^CI35^F8^FDGüneş Gözlüğü^FS^CI0");
                    yaz.WriteLine(@"^FT211,129^A@I,17,18,TT0003M_^FH\^CI35^F8^FD"+ birim +"^FS^CI0"); // TL yada Euro
                    yaz.WriteLine(@"^FT298,129^A@I,23,22,TT0003M_^FH\^CI35^F8^FD"+ fiyat+"^FS^CI0"); // Fiyat
                    yaz.WriteLine(@"^BY1,3,43^FT284,34^BCI,,N,N");
                    yaz.WriteLine(@"^FD>;"+barkod+"^FS"); // Barkodu küçük yazdırıyor
                    yaz.WriteLine(@"^FT297,18^A@I,17,18,TT0003M_^FH\^CI35^F8^FD"+ barkod + "^FS^CI0"); // Barkodu buyuk yazdırıyor
                    yaz.WriteLine(@"^PQ1,0,1,Y^XZ");
                    yaz.WriteLine("");
                }
                yaz.Close();
                MessageBox.Show("Dosya yazma işlemi tamamlandı.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //pencerede bir dosya sececeğimiz için kullanılır
            {
                btnGoruntule.Text = openFileDialog1.FileName.ToString();
            }
            string prnYol = btnGoruntule.Text;
        }
    }
}
