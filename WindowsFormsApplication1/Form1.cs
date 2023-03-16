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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q1F2SU9;Initial Catalog=Ayubo;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        private void clear_all()
        {
            
            tbxVehicalType.Clear();
            tbxVehicaModel.Clear();
            tbxMonthlyRate.Clear();
            tbxWekklyRate.Clear();
            tbxDailyRate.Clear();
            tbxDailyDriverRate.Clear();
            tbxFaulType.Clear();

            cmbVehicalNumber.Focus();

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string SqlSearch;
            SqlSearch = "select * from  vehicle_Table where vehicleNo ='" +cmbVehicalNumber.Text + "' ";
            SqlCommand cmd = new SqlCommand(SqlSearch, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                tbxVehicalType.Text = dr["VehicleType"].ToString();
                tbxVehicaModel.Text = dr["VehicleModel"].ToString();
                tbxMonthlyRate.Text = dr["monthlyRate"].ToString();
                tbxWekklyRate.Text = dr["weeklyRate"].ToString();
                tbxDailyRate.Text = dr["dailyRate"].ToString();
                tbxDailyDriverRate.Text = dr["dailyDriverRate"].ToString();
                tbxFaulType.Text = dr["FualType"].ToString();


            con.Close();
            }
            
            else
            {
                clear_all();
                MessageBox.Show("Not Found");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlinsert;
            sqlinsert = "insert into vehicle_Table (vehicleNo,VehicleType,VehicleModel,monthlyRate,weeklyRate,dailyRate,dailyDriverRate,FualType) values('" + cmbVehicalNumber.Text + "','" +tbxVehicalType.Text + "','" + tbxVehicaModel.Text + "','" + tbxMonthlyRate.Text + "','" + tbxWekklyRate.Text + "','" + tbxDailyRate.Text + "','" + tbxDailyDriverRate.Text + "','" + tbxFaulType.Text + "')";
            SqlCommand cmd = new SqlCommand(sqlinsert, con);
            con.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Inserted");
            clear_all();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlupdate;
            sqlupdate = "update vehicle_Table set VehicleType='" + tbxVehicalType.Text + "',VehicleModel='" + tbxVehicaModel.Text + "',monthlyRate='" +tbxMonthlyRate.Text+ "',weeklyRate='" + tbxWekklyRate.Text + "',dailyRate='" + tbxDailyRate.Text + "',dailyDriverRate='" + tbxDailyDriverRate.Text + "',FualType='" + tbxFaulType.Text + "' where vehicleNo='" + cmbVehicalNumber.Text+ "' ";
            SqlCommand cmd = new SqlCommand(sqlupdate, con);
            con.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show(" Succesfully Update... ");
            clear_all();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ans;
            ans = MessageBox.Show("Are you to Delete!", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (ans == DialogResult.Yes)
            {
                string sqldelete;
                sqldelete = "delete from vehicle_Table where vehicleNo ='" + cmbVehicalNumber + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("deleted");
                clear_all();
                con.Close();
            }
        }
    }
}
