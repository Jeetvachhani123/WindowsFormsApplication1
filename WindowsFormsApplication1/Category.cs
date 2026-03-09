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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\jeet_project\WindowsFormsApplication1\WindowsFormsApplication1\Database2.mdf;Integrated Security=True;User Instance=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cm = new SqlCommand("insert into category values('" + txtcatid.Text + "','" + txtcatnm.Text + "')", con);
            cm.ExecuteNonQuery();
            MessageBox.Show("Successfully submitted");

            SqlCommand cmd = new SqlCommand("select * from category", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update category set cat_name='" + txtcatnm.Text + "' where cat_id='" + txtcatid.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record updated", "MessageBoxButtons.OK");

            SqlCommand cm = new SqlCommand("select * from category", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Category.ActiveForm.Hide();
            main m1 = new main();
            m1.Show();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cm = new SqlCommand("select * from category", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from category where cat_id='" + txtcatid.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record deleted", "MessageBoxButtons.OK");

            SqlCommand cmda = new SqlCommand("select * from category", con);
            SqlDataAdapter da = new SqlDataAdapter(cmda);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
