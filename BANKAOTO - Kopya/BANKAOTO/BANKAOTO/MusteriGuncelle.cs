﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BANKAOTO
{
    public partial class MusteriGuncelle : Form
    {
        public MusteriGuncelle()
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
            SqlCommand komut = new SqlCommand("update musteriler set adSoyad= @p1,  adres= @p2, telefon= @p3 where ID=@p4 or tcNo=@p5 ", con);
            komut.Parameters.AddWithValue("@p4", txtAra.Text);
            komut.Parameters.AddWithValue("@p5", txtAra.Text);
            komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", txtAdres.Text);
            komut.Parameters.AddWithValue("@p3", txtTel.Text);
            con.Open();



            {
            int sonuc= komut.ExecuteNonQuery();
                if (sonuc ==1)
                {

                    MessageBox.Show("Güncelleme Yapildi!", "Güncelleme İslemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else
                {
                    MessageBox.Show("Güncelleme Yapilamadi!", "Güncelleme İslemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtBakiye_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTcNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}   
