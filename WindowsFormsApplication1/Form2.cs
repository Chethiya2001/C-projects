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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q1F2SU9;Initial Catalog=Ayubo;Integrated Security=True");
        int  months, weeks, days,tt, reminder;
        public Form2()
        {
            InitializeComponent();
        }
        private void regcombo()
        {
            SqlDataAdapter da = new SqlDataAdapter("select vehicleNo from vehicle_Table", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbVehicalNumber.DataSource = dt;
            cmbVehicalNumber.DisplayMember = "vehicleNo";
            cmbVehicalNumber.ValueMember= "vehicleNo";

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            regcombo();
        }

        private void cmbVehicalNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            regcombo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void tbxVehicalType_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime rented_D, return_D;
            TimeSpan ts;
            double totdays;
            








            rented_D =DateTime.Parse  (dtRented.Text);
            return_D =DateTime.Parse (dtReturn.Text);
            ts = rented_D-return_D;
            //tbxTotalDate.Text = ts.ToString();
            totdays = ts.Days; //convert

            tbxTotalDate.Text = totdays.ToString();

            tt = int.Parse(tbxTotalDate.Text);
            months = tt / 30;
            reminder = tt % 30;
            weeks = reminder / 7;
            days = reminder % 7;

            tbxMonth.Text = months.ToString();
            tbxWeek.Text = weeks.ToString();
            tbxDay.Text = days.ToString();

             




        }

        private void tbxDailyDriverRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string SqlSearch;
            SqlSearch = "select * from  vehicle_Table where vehicleNo ='" + cmbVehicalNumber.Text + "' ";
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

        private void btnClaculateTotal_Click(object sender, EventArgs e)
        {
            Double m_rate=double.Parse(tbxMonthlyRate.Text);
            Double w_rate = double.Parse(tbxWekklyRate.Text);
            Double d_rate = double.Parse(tbxDailyRate.Text);
            Double dd_rate = double.Parse(tbxDailyDriverRate.Text);
            Double tot_cost;
            tot_cost = (m_rate * months) + (w_rate * weeks) + (d_rate * days) + (dd_rate * tt);
            if (chbxWithDriver.Checked == true)
            {
                tot_cost= tot_cost+ (dd_rate * tt);


            }
            tbxTotalCost.Text = Convert.ToString(tot_cost);






            
                
            
        }

    }
    
}
