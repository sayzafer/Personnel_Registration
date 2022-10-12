using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personnel_Registration
{
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-UMTLPQ5;Initial Catalog=PersonnelDB;Integrated Security=True");

        private void Frmistatistik_Load(object sender, EventArgs e)
        {
            //Toplam Personel Sayisi
            connect.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from Tbl_Personnel", connect);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblToplamPersSayisi.Text = dr1[0].ToString();
            }
            connect.Close();

            //Evli Personel Sayisi
            connect.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) from Tbl_Personnel where PDurum=1", connect);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblEvliPersSayisi.Text = dr2[0].ToString(); 
            }
            connect.Close();

            //Bekar Personel Sayisi
            connect.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) from Tbl_Personnel where PDurum=0", connect);
            SqlDataReader d3 = komut3.ExecuteReader();
            while (d3.Read())
            {
                lblBekarPersSayisi.Text = d3[0].ToString();
            }
            connect.Close();

            //Sehir Sayisi
            connect.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct(PCity)) from Tbl_Personnel", connect);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblSehirSayisi.Text=dr4[0].ToString();
            }
            connect.Close();

            //Toplam Maas
            connect.Open();
            SqlCommand komut5 = new SqlCommand("select sum(PSalary) from Tbl_Personnel", connect);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblToplamMaas.Text=dr5[0].ToString();
            }
            connect.Close();

            //Ortalama Maas
            connect.Open();
            SqlCommand komut6 = new SqlCommand("select avg(PSalary) from Tbl_Personnel", connect);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblOrtMaas.Text=dr6[0].ToString();
            }
            connect.Close();
        }
    }
}
