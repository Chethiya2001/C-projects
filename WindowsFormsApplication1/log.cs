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
    public partial class log : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q1F2SU9;Initial Catalog=Ayubo;Integrated Security=True");
        public log()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUserName.Text == "" || tbxPwd.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }


            SqlCommand cmd = new SqlCommand("Select * from Log_Table where usr_name=@usr_name and pwd=@pwd", con);
            cmd.Parameters.AddWithValue("@usr_name", tbxUserName.Text);
            cmd.Parameters.AddWithValue("@pwd", tbxPwd.Text);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
                MDIParent1 fm = new MDIParent1();
                fm.Show();
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }



        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register rg1 = new register();
            rg1.Show();
            this.Hide();
        }
    }
}
