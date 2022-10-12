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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-UMTLPQ5;Initial Catalog=PersonnelDB;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personnelDBDataSet.Tbl_Personnel' table. You can move, or remove it, as needed.
            this.tbl_PersonnelTableAdapter.Fill(this.personnelDBDataSet.Tbl_Personnel);

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.tbl_PersonnelTableAdapter.Fill(this.personnelDBDataSet.Tbl_Personnel);
        }

        //Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personnel (PName,PLastName,PCity,PSalary,PJob,PDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", connect);
            komut.Parameters.AddWithValue("@p1", PName.Text);
            komut.Parameters.AddWithValue("@p2", PLastName.Text);
            komut.Parameters.AddWithValue("@p3", PCity.Text);
            komut.Parameters.AddWithValue("@p4", PSalary.Text);
            komut.Parameters.AddWithValue("@p5", PJob.Text);
            komut.Parameters.AddWithValue("@p6", label8);
            komut.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Personel eklendi.");
        }

        private void PEvli_CheckedChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                PEvli.Checked = true;
            }
        }

        private void PBekar_CheckedChanged(object sender, EventArgs e)
        {
            if (label8.Text == "False")
            {
                PBekar.Checked = true;
            }
        }

        //Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            PID.Text = "";
            PName.Text = "";
            PLastName.Text = "";
            PCity.Text = "";
            PJob.Text = "";
            PSalary.Text = "";
            PEvli.Checked = false;
            PBekar.Checked = false;
            PName.Focus();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            PID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            PName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            PLastName.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            PCity.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            PJob.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            PSalary.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text=dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if(label8.Text == "True")
            {
                PEvli.Checked = true;
            }
            if(label8.Text == "False")
            {
                PBekar.Checked = true;
            }
        }

        //Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komutsil = new SqlCommand("delete from Tbl_Personnel where PID=@p1", connect);
            komutsil.Parameters.AddWithValue("@p1", PID.Text);
            komutsil.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Personel silindi.");
        }

        //Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komutguncelle = new SqlCommand("update Tbl_Personnel set PName=@p1,PLastName=@p2,PCity=@p3,PJob=@p4,PSalary=@p5,PDurum=@p6 where PID=@p7", connect);
            komutguncelle.Parameters.AddWithValue("@p1", PName.Text);
            komutguncelle.Parameters.AddWithValue("@p2", PLastName.Text);
            komutguncelle.Parameters.AddWithValue("@p3", PCity.Text);
            komutguncelle.Parameters.AddWithValue("@p4", PJob.Text);
            komutguncelle.Parameters.AddWithValue("@p5", PSalary.Text);
            komutguncelle.Parameters.AddWithValue("@p6", label8.Text);
            komutguncelle.Parameters.AddWithValue("@p7", PID.Text);
            komutguncelle.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Personel güncellendi");
        }

        //Statistic
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            Frmistatistik fr = new Frmistatistik();
            fr.Show();
        }

        private void btnGraphic_Click(object sender, EventArgs e)
        {
            FrmGrafik fr = new FrmGrafik();
            fr.Show();
        }
    }
}
