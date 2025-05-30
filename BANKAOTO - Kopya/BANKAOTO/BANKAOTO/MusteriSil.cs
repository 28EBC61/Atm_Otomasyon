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
    public partial class MusteriSil : Form
    {
        public MusteriSil()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(" server= DESKTOP-IJ48998\\SQLEXPRESS ; initial catalog = bankamatik; integrated security = sspi ");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from musteriler where ID= @p1 or tcNo= @p2 ", con);
            komut.Parameters.AddWithValue("@p1", txtAra.Text);
            komut.Parameters.AddWithValue("@p2", txtAra.Text);
            con.Open();



            {
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    txtID.Text = dr["ID"].ToString();
                    txtTcNo.Text = dr["tcNo"].ToString();
                    txtAdSoyad.Text = dr["adSoyad"].ToString();
                    txtAdres.Text = dr["adres"].ToString();
                    txtTel.Text = dr["telefon"].ToString();
                    txtBakiye.Text = dr["bakiye"].ToString();


                }

                else
                {
                    MessageBox.Show("Numarali Kayit Bulunamadi!", "Kayit Arama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Text = "";
                    txtTcNo.Text = "";
                    txtAdres.Text = "";
                    txtAdSoyad.Text = "";
                    txtBakiye.Text = "";
                    txtTel.Text = "";
                    txtID.Text = "";

                }
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete musteriler where ID= @p1 or tcNo= @p2 ", con);
            komut.Parameters.AddWithValue("@p1", txtAra.Text);
            komut.Parameters.AddWithValue("@p2", txtAra.Text);

            con.Open();



            {
                int sonuc = komut.ExecuteNonQuery(); 
                if (sonuc == 1)
                {

                    MessageBox.Show("Silme İslemi Yapildi!", "Silme İslemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else
                {
                    MessageBox.Show("Silme Yapilamadi!", "Silme İslemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Text = "";
                    txtTcNo.Text = "";
                    txtAdres.Text = "";
                    txtAdSoyad.Text = "";
                    txtBakiye.Text = "";
                    txtTel.Text = "";
                    txtID.Text = "";

                }
            }

            con.Close();
        }

        private void MusteriSil_Load(object sender, EventArgs e)
        {

        }
    }
}
