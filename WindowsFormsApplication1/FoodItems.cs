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
    public partial class FoodItems : Form
    {
        public FoodItems()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\jeet_project\WindowsFormsApplication1\WindowsFormsApplication1\Database2.mdf;Integrated Security=True;User Instance=True");
        private void FoodItems_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from item", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FoodItems.ActiveForm.Hide();
            main m1 = new main();
            m1.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into item values(@f_id,@f_name,@price)", con);
            cmd.Parameters.AddWithValue("@f_id", txt_id.Text);
            cmd.Parameters.AddWithValue("@f_name", txt_nm.Text);
            cmd.Parameters.AddWithValue("@price", txt_price.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Submitted Successfully");

            SqlCommand cm = new SqlCommand("select * from item", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cm = new SqlCommand("update item set f_name=@f_name,price=@price where f_id=@f_id",con);
        
            cm.Parameters.AddWithValue("@f_id", txt_id.Text);
            cm.Parameters.AddWithValue("@f_name", txt_nm.Text);
            cm.Parameters.AddWithValue("@price", txt_price.Text);
            cm.ExecuteNonQuery();
            MessageBox.Show("Record updated", "MessageBoxButtons.OK");

            SqlCommand cmd = new SqlCommand("select * from item", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from  item where f_id=@f_id", con);
            cmd.Parameters.AddWithValue("@f_id", txt_id.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record deleted", "MessageBoxButtons.OK");


            SqlCommand cm = new SqlCommand("select * from item", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }

       
    }
}
