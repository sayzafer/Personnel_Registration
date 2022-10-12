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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-UMTLPQ5;Initial Catalog=PersonnelDB;Integrated Security=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Admin where userName=@p1 and userPsw=@p2", connect);
            komut.Parameters.AddWithValue("@p1", txtUserName.Text);
            komut.Parameters.AddWithValue("@p2", txtUserPsw.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da sifre");
            }
            connect.Close();
        }
    }
}
