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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\jeet_project\WindowsFormsApplication1\WindowsFormsApplication1\Database2.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select  * from newuser where u_name='"+textBox1.Text +"' and password='"+textBox2.Text+"'",con);

            SqlDataReader dr;

            dr = cmd.ExecuteReader();

            if(dr.Read()){
                MessageBox.Show("login successfully","success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                main m1 = new main();
                m1.Show();
            }else{
                MessageBox.Show("check username and password","warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            con.Close();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login.ActiveForm.Hide();
            newuser n1 = new newuser();
            n1.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login.ActiveForm.Hide();
            ForgetPassword frm = new ForgetPassword();
            frm.Show();
        }
    }
}
