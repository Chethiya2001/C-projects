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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q1F2SU9;Initial Catalog=Ayubo;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }
        private void combo_shrt()
        {
            SqlDataAdapter da = new SqlDataAdapter("select p_Id from Pkg_Table", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbPackageId.DataSource = dt;
            cmbPackageId.DisplayMember = "p_Id";
            cmbPackageId.ValueMember = "p_Id";

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string SqlSearch;
            SqlSearch = "select * from  Pkg_Table where p_Id  ='" + cmbPackageId.Text + "' ";
            SqlCommand cmd = new SqlCommand(SqlSearch, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                tbxPackageType.Text = dr["p_type"].ToString();
                tbxPackageRate.Text = dr["p_rate"].ToString();
                tbxVehicalType.Text = dr["v_type"].ToString();
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

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlinsert;
            sqlinsert = "insert into  Pkg_Table (p_Id,p_type,p_rate,v_type,max_km,max_hrs,ex_km_rate,ex_hr_rate,dr_night_rate,nightpark_rate) values('" + cmbPackageId.Text + "','" + tbxPackageType.Text + "','" + tbxPackageRate.Text + "','" + tbxVehicalType.Text + "','" + tbxMaxKm.Text + "','" + tbxMaxHrs.Text + "','" + tbxExtraKmRate.Text + "','" + tbxExtraHRate.Text + "','" + tbxDriverNightRate.Text + "','" + tbxNightParkRate.Text + "')";
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
            sqlupdate = "update Pkg_Table set p_type='" + tbxPackageType.Text + "',p_rate='" + tbxPackageRate.Text + "',v_type='" + tbxVehicalType.Text + "',max_km='" + tbxMaxKm.Text + "',max_hrs='" + tbxMaxHrs.Text + "',ex_hr_rate='" + tbxExtraHRate.Text + "',ex_km_rate='" + tbxExtraKmRate.Text + "',dr_night_rate='" + tbxDriverNightRate.Text + "',nightpark_rate='" + tbxNightParkRate.Text + "' where p_Id='" + cmbPackageId.Text + "' ";
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
                sqldelete = "delete from Pkg_Table  where p_Id='" + cmbPackageId.Text + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("deleted");
                clear_all();
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear_all();
        }

        private void cmbPackageId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
