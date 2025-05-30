using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANKAOTO
{
    public partial class SifreDegistirme : Form
    {
        public SifreDegistirme()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(" server= DESKTOP-IJ48998\\SQLEXPRESS ; initial catalog = bankamatik; integrated security = sspi ");  
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtEski.Text ==""|| txtYeni.Text=="" )
            {
                MessageBox.Show("Lütfen Alanları Giriniz", "Şifre Değiştirme işlemi");
            }
            else if( txtYeni.Text.Length < 5 )
            {
                MessageBox.Show("En az 5 karakter uzunluğu şifre belirleyiniz", "Şifre Değiştirme işlemi");
            }
            else
            {
                SqlCommand komut = new SqlCommand("update musteriler set sifre = @p1 where sifre= @p2 ", con);
                komut.Parameters.AddWithValue("@p1", txtYeni.Text);
                komut.Parameters.AddWithValue("@p2 ", txtEski.Text);
                con.Open();



                int sonuc = komut.ExecuteNonQuery();
                if (sonuc == 1)
                {
                    MessageBox.Show("Şifre Değiştirme işlemi yapıldı", "Şifre Değiştirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    MessageBox.Show("Şifre Değiştirme işlemi başarısız!", "Şifre Değiştirme işlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);



                }
            }

            con.Close();
            txtEski.Text = "";
            txtYeni.Text = "";
        }

        private void SifreDegistirme_Load(object sender, EventArgs e)
        {

        }
    }
    }

