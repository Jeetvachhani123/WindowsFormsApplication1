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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\jeet_project\WindowsFormsApplication1\WindowsFormsApplication1\Database2.mdf;Integrated Security=True;User Instance=True");
        private void btn_submit_Click(object sender, EventArgs e)
        {
          
            con.Open();
            SqlCommand cm = new SqlCommand("insert into customer values('" + txtcusid.Text + "','" + txtcusnm.Text + "','" + txtcity.Text + "','" + txtaddr.Text + "','" + txtmono.Text + "')", con);
            cm.ExecuteNonQuery();
            MessageBox.Show("Successfully submitted");


            SqlCommand cmd = new SqlCommand("select * from customer", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void customer_Load(object sender, EventArgs e)
        {
            
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from customer", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Customer set c_name='" + txtcusnm.Text + "',c_city='" + txtcity.Text + "',c_address='" + txtaddr.Text + "',c_mono='" + txtmono.Text + "' where c_id='" + txtcusid.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record updated", "MessageBoxButtons.OK");

            SqlCommand cm = new SqlCommand("select * from Customer", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from customer where c_id='" + txtcusid.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record deleted", "MessageBoxButtons.OK");

            SqlCommand cmda = new SqlCommand("select * from customer", con);
            SqlDataAdapter da = new SqlDataAdapter(cmda);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            customer.ActiveForm.Hide();
            main m1 = new main();
            m1.Show();
        }
    }
}
