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
    public partial class register : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q1F2SU9;Initial Catalog=Ayubo;Integrated Security=True");
        public register()
        {
            InitializeComponent();
        }
        private void clear_al()
        {
            tbxIdNumber.Clear();
            
            tbxUname.Clear();
            tbxEmail.Clear();
            tbxPwd.Clear();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlinsert;
            sqlinsert = "insert into Log_Table (usr_id,usr_name,pwd,email) values('" +tbxIdNumber.Text+ "','" +tbxUname + "','" + tbxPwd.Text + "','" + tbxEmail.Text +  "')";
            SqlCommand cmd = new SqlCommand(sqlinsert, con);
            con.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Registerd");
            clear_al();
            con.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            log lg1 = new log();
            lg1.Show();
            this.Hide();
        }
    
    }
}
