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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q1F2SU9;Initial Catalog=Ayubo;Integrated Security=True");

        
        public Form4()
        {
            InitializeComponent();
        }
        private void combo_four()
        {
            SqlDataAdapter da = new SqlDataAdapter("select p_Id from Pkg_Table", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbPackageId.DataSource = dt;
            cmbPackageId.DisplayMember = "p_Id";
            cmbPackageId.ValueMember = "p_Id";

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void buttonKM_Click(object sender, EventArgs e)
        {
            int st_km, end_km,totkm;
            
            

            st_km = int.Parse(tbxStartKm.Text);
            end_km = int.Parse(tbxEndKm.Text);
            totkm = end_km - st_km;
            

            tbxNumberofKm.Text = totkm.ToString();

            int maxkm = int.Parse(tbxMaxKm.Text);
            
            double extrakm;


            if (totkm>maxkm)
            {
                extrakm = totkm - maxkm;
            }
            else
            {
                extrakm = 0;
            }
            tbxExtraKm.Text = extrakm.ToString();


            double exkmrate = double.Parse(tbxExtraKmRate.Text);
            double exkmchrg;

            exkmchrg = exkmrate * extrakm;
            tbxExtraKmcharge.Text = exkmchrg.ToString();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            combo_four();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tbxExtraHRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHours_Click(object sender, EventArgs e)
        {
           
            DateTime st_time, end_time;
            TimeSpan ts;
            int tothours,extrahrs;

            st_time = DateTime.Parse(dtpStartTime.Text);
            end_time = DateTime.Parse(dtpEndTime.Text);
            ts = end_time - st_time  ;
            //tbxTotalDate.Text = ts.ToString();
            tothours = ts.Hours; //convert

            tbxNumberofHours.Text = tothours.ToString();

            int maxhrs = int.Parse(tbxMaxHrs.Text);

            

            if (tothours > maxhrs)
            {
                extrahrs = tothours - maxhrs;
            }
            else
            {
                extrahrs = 0;
            }
            tbxExtraHourse.Text = extrahrs.ToString();

            double exhrsrate= double.Parse(tbxExtraHRate.Text);
            double exHrschrg;

            exHrschrg = exhrsrate * extrahrs;
            tbxExtraCharge.Text = exHrschrg.ToString();









            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string SqlSearch;
            SqlSearch = "select * from Pkg_Table  where p_Id ='" + cmbPackageId.Text+"'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            double pkgrate = double.Parse(tbxPackageRate.Text);
            double exhrschrg = double.Parse(tbxExtraCharge.Text);
            double exkmchrg = double.Parse(tbxExtraKmcharge.Text);
            double tot;
            tot = pkgrate + exhrschrg + exkmchrg;
            tbxTotalCost.Text = tot.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
