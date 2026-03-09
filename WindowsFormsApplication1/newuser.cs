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
    public partial class newuser : Form
    {
        public newuser()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\jeet_project\WindowsFormsApplication1\WindowsFormsApplication1\Database2.mdf;Integrated Security=True;User Instance=True");
        private void newuser_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(75, 0, 0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into newuser values(@u_id,@u_name,@email,@password,@city,@address,@pincode,@mno)",con);
            cmd.Parameters.AddWithValue("@u_id", txt_uid.Text);
            cmd.Parameters.AddWithValue("@u_name", txt_unm.Text);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            cmd.Parameters.AddWithValue("@password", txt_pw.Text);
            cmd.Parameters.AddWithValue("@city", txt_city.Text);
            cmd.Parameters.AddWithValue("@address", txt_add.Text);
            cmd.Parameters.AddWithValue("@pincode", txt_pin.Text);
            cmd.Parameters.AddWithValue("@mno", txt_mno.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("You are successfully registered ","result",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login l1 = new login();
            this.Hide();
            l1.Show();
        }
    }
}
