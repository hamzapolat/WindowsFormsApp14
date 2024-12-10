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

namespace WindowsFormsApp14
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baglanti = "server=172.20.112.108;" +
                "Database=nesneTabanliProgramlama;" +
                "User Id=ogr1;" +
                "Password=bgt2024";


            string sorgu =
                "INSERT INTO Ogrenciler" +
                "(OgrAd,OgrSoyad,OgrYas,OgrCins,developer)" +
                "VALUES" +
                "(@ad,@soyad,@yas,@cins,'HAMZA')";
            using (SqlConnection con = new SqlConnection(baglanti))
                using (SqlCommand komut = new SqlCommand(sorgu, con))
            {
                komut.Parameters.AddWithValue("@ad", textBox1.Text);
                komut.Parameters.AddWithValue("@soyad", textBox2.Text);
                komut.Parameters.AddWithValue("@yas",Convert.ToInt32(textBox3.Text));
                komut.Parameters.AddWithValue("@cins", "E");
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();
                this.Close();
                MessageBox.Show("Kayıt Eklendi");

                
            }
            {



       //        try
       //         {
       //            con.Open();
       //            MessageBox.Show("Bağlantı Başarılı");
       //         }
       //       catch (Exception ex)
       //        {
       //            MessageBox.Show("bağlantı başarısız"+ex.Message);
                }
            }
        }
    }
