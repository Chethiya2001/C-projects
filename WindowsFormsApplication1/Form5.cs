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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q1F2SU9;Initial Catalog=Ayubo;Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
        }

        
        private void clear_all()


        {

            tbxVehicalType.Clear();
            tbxPackageType.Clear();
            tbxPackageRate.Clear();
            tbxMaxKm.Clear();
            tbxMaxHrs.Clear();
            tbxExtraKmRate.Clear();
            tbxExtraHRate.Clear();
            tbxNightParkRate.Clear();
            tbxDriverNightRate.Clear();


            cmbPackageId.Focus();

        }

        private void combo_five()
        {
            SqlDataAdapter da = new SqlDataAdapter("select p_Id from Pkg_Table", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbPackageId.DataSource = dt;
            cmbPackageId.DisplayMember = "p_Id";
            cmbPackageId.ValueMember = "p_Id";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string SqlSearch;
            SqlSearch = "select * from Pkg_Table  where p_Id ='" + cmbPackageId.Text + "'";
            SqlCommand cmd = new SqlCommand(SqlSearch, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                tbxVehicalType.Text = dr["v_type"].ToString();
                tbxPackageType.Text = dr["p_type"].ToString();
                tbxPackageRate.Text = dr["p_rate"].ToString();
                tbxMaxKm.Text = dr["max_km"].ToString();
                tbxMaxHrs.Text = dr["max_hrs"].ToString();
                tbxExtraKmRate.Text = dr["ex_km_rate"].ToString();
                tbxExtraHRate.Text = dr["ex_hr_rate"].ToString();
                tbxDriverNightRate.Text = dr["dr_night_rate"].ToString();
                tbxNightParkRate.Text = dr["nightpark_rate"].ToString();



                con.Close();
            }

            else
            {
                clear_all();
                MessageBox.Show("Not Found");

            }
        }

        private void buttonKM_Click(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime rented, returned;
            TimeSpan ts;
            Double tot_days;

            rented = DateTime.Parse(dtRented.Text);
            returned = DateTime.Parse(dtReturn.Text);
            ts = rented- returned;

            tot_days = ts.Days;
            tbxTotalDate.Text = tot_days.ToString();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            combo_five(); 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbxBaseHireCharge_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxMaxKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            DateTime rented, returned;
            TimeSpan ts;
            Double tot_days;

            rented = DateTime.Parse(dtRented.Text);
            returned = DateTime.Parse(dtReturn.Text);
            ts = rented - returned;

            tot_days = ts.Days;
            tbxTotalDate.Text = tot_days.ToString();

            


            int st_km, end_km, totkm;

            st_km = int.Parse(tbxStartKm.Text);
            end_km = int.Parse(tbxEndKm.Text);
            totkm = end_km - st_km;


            TbxNo_of_Km.Text = totkm.ToString();

            int maxkm = int.Parse(tbxMaxKm.Text);

            double extrakm;


            if (totkm > maxkm)
            {
                extrakm = totkm - maxkm;
            }
            else
            {
                extrakm = 0;
            }
            TbxExtraKm.Text = extrakm.ToString();

           
            double exkmrate = double.Parse(tbxExtraKmRate.Text);
            double exkmchrg;

            exkmchrg = exkmrate * extrakm;
            tbxExtraKmcharge.Text = exkmchrg.ToString();

            






        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime rented, returned;
            TimeSpan ts;
            Double tot_days;

            rented = DateTime.Parse(dtRented.Text);
            returned = DateTime.Parse(dtReturn.Text);
            ts = rented - returned;

            tot_days = ts.Days;
            tbxTotalDate.Text = tot_days.ToString();



            double tot_cost = (double.Parse(tbxNightParkRate.Text)) + (int.Parse(tbxExtraKmcharge.Text)) + ((ts.Days - 1) * (double.Parse(tbxNightParkRate.Text))) + ((ts.Days - 1) * (double.Parse(tbxDriverNightRate.Text)));
            tbxLongTourTotal.Text = tot_cost.ToString();



        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Calculation_Enter(object sender, EventArgs e)
        {

        }
    }
}
