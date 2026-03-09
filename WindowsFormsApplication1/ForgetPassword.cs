using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\jeet_project\WindowsFormsApplication1\WindowsFormsApplication1\Database2.mdf;Integrated Security=True;User Instance=True");

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(75, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from newuser where email='" + txt_email.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label1.Text = " your password is" + dr.GetValue(3).ToString();
                MessageBox.Show("your password is   " + dr.GetValue(3).ToString());
            }
            else
            {

                MessageBox.Show("not match");
            }
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login l1 = new login();
            l1.Show();
            this.Hide();
        }
    }
}
