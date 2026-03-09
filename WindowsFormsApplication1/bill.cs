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
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\jeet_project\WindowsFormsApplication1\WindowsFormsApplication1\Database2.mdf;Integrated Security=True;User Instance=True");
        private void bill_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Bill", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();


        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter all Details", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                con.Open();
                SqlCommand cm = new SqlCommand("insert into Bill values(" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + ",'" + dateTimePicker1.Text + "','" + textBox4.Text + "'," + textBox5.Text + ",'" + textBox6.Text + "')", con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Data Submitted Successfully");

                SqlCommand cmd = new SqlCommand("select * from Bill", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
        
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter all Details", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Bill set categoryid=" + textBox2.Text + ",itemid=" + textBox3.Text + ",date='" + dateTimePicker1.Text + "',customername='" + textBox4.Text + "',totalprice=" + textBox5.Text + ",itemname='" + textBox6.Text + "' where billid='" + textBox1.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record updated", "MessageBoxButtons.OK");

                SqlCommand cm = new SqlCommand("select * from Bill", con);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter all Details", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Bill where billid=" + textBox1.Text + "", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record deleted", "MessageBoxButtons.OK");

                SqlCommand cmda = new SqlCommand("select * from Bill", con);
                SqlDataAdapter da = new SqlDataAdapter(cmda);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BillReport b1 = new BillReport();
            b1.Show();
            this.Hide();
        }
    }
}
