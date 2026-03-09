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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\jeet_project\WindowsFormsApplication1\WindowsFormsApplication1\Database2.mdf;Integrated Security=True;User Instance=True");

        private void Stock_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from stock", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cm = new SqlCommand("insert into stock values('" + txtstockid.Text + "','" + txtitemid.Text + "','" + txtitemnm.Text + "','" + txtqty.Text + "')", con);
            cm.ExecuteNonQuery();
            MessageBox.Show("Data Submitted Successfully");

            SqlCommand cmd = new SqlCommand("select * from stock", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update stock set i_id=" + txtitemid.Text + ",i_nm='" + txtitemnm.Text + "',qty=" + txtqty.Text + " where s_id=" + txtstockid.Text + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record updated", "MessageBoxButtons.OK");

            SqlCommand cmda = new SqlCommand("select * from stock", con);
            SqlDataAdapter da = new SqlDataAdapter(cmda);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from stock where s_id=" + txtstockid.Text + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record deleted", "MessageBoxButtons.OK");

            SqlCommand cm = new SqlCommand("select * from stock", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Stock.ActiveForm.Hide();
            main m1 = new main();
            m1.Show();
        }
    }
}
