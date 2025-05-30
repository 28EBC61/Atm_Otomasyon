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
    public partial class ParaYatir : Form
    {
        public ParaYatir()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(" server= DESKTOP-IJ48998\\SQLEXPRESS ; initial catalog = bankamatik; integrated security = sspi ");

        private void button1_Click(object sender, EventArgs e)
        {
            float sayi = float.Parse(maskedTextBox1.Text);
            if (int.Parse(maskedTextBox1.Text)<= 10 )
            {
                MessageBox.Show("Lütfen En Az 10 Tl Yatırınız", "Para yatırma işlemi");
            }
            else
            {
                SqlCommand komut = new SqlCommand("update musteriler set bakiye += @p1 where ID= @p2 ", con);
                komut.Parameters.AddWithValue("@p1", sayi);
                komut.Parameters.AddWithValue("@p2 ", Form1.mID);
                con.Open();



                int sonuc = komut.ExecuteNonQuery();
                if (sonuc == 1)
                {
                    MessageBox.Show("Para yatırma işlemi yapıldı", "Para yatırma işlemi", MessageBoxButtons.OK);
                    Form1.mBakiye += sayi;

                    HareketKaydet.kaydet(Form1.mID, "Para Yatırıldı");
                }

                else
                {
                    MessageBox.Show("Para yatırma işlemi başarısız!", "para yatırma işlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);



                }
            }

            con.Close();
            maskedTextBox1.Text = "";
        }

        private void ParaYatir_Load(object sender, EventArgs e)
        {

        }
    }
    }

