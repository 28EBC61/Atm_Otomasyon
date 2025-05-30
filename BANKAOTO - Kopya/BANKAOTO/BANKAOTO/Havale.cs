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
    public partial class Havale : Form
    {
        public Havale()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(" server= DESKTOP-IJ48998\\SQLEXPRESS ; initial catalog = bankamatik; integrated security = sspi ");
        private void button1_Click(object sender, EventArgs e)
        {
            float sayi = float.Parse(txtMiktar.Text);
            int aliciNo = int.Parse(txtNo.Text);

            SqlCommand komut = new SqlCommand("select * from musteriler where ID= @p1 ", con);
            komut.Parameters.AddWithValue("@p1", txtNo.Text);
            bool sonuc = false;
            con.Open();



            {
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    sonuc = true;


                }
                else
                {
                    MessageBox.Show("Alıcı Hesap No Hatalı !", "Havale/EFT işlemi");
                }


            }
            con.Close();



            if (sayi > Form1.mBakiye && sonuc)
            {
                MessageBox.Show("Yetersiz Bakiye", "Para çekme işlemi");
            }
            else
            {
                SqlCommand komut2 = new SqlCommand("update musteriler set bakiye -= @p1 where ID= @p2 ", con);
                SqlCommand komut3 = new SqlCommand("update musteriler set bakiye += @p3 where ID= @p2 ", con);
                komut2.Parameters.AddWithValue("@p1", sayi);
                komut2.Parameters.AddWithValue("@p2 ", Form1.mID);
                komut3.Parameters.AddWithValue("@p3 ", sayi);
                komut3.Parameters.AddWithValue("@p2", aliciNo);

                con.Open();
                komut2.ExecuteNonQuery();
                komut3.ExecuteNonQuery();

                MessageBox.Show("Havale/EFT işlemi yapıldı", "Havale/EFT işlemi", MessageBoxButtons.OK);
                Form1.mBakiye -= sayi;





                con.Close();
                txtNo.Text = "";
                txtMiktar.Text = "";
            }
        }
    }
}
    
    

