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
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-UMTLPQ5;Initial Catalog=PersonnelDB;Integrated Security=True");

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void FrmGrafik_Load(object sender, EventArgs e)
        {
            //Sehirler
            connect.Open();
            SqlCommand komutg1 = new SqlCommand("select PCity,count(*) from Tbl_Personnel group by PCity", connect);
            SqlDataReader dr1=komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            connect.Close();

            //Meslek-Maas
            connect.Open();
            SqlCommand komutg2 = new SqlCommand("select PJob,avg(PSalary) from Tbl_Personnel group by PJob", connect);
            SqlDataReader dr2 =komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }
            connect.Close();
        }
    }
}
