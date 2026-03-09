using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main.ActiveForm.Hide();
            customer cam = new customer();
            cam.Show();
        }

        private void existingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main.ActiveForm.Hide();
            customer cam = new customer();
            cam.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main.ActiveForm.Hide();
            Category cam = new Category();
            cam.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main.ActiveForm.Hide();
            Stock s1 = new Stock();
            s1.Show();

        }

        private void foodItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main.ActiveForm.Hide();
            FoodItems f1 = new FoodItems();
            f1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bill b1 = new bill();
            b1.Show();
            this.Hide();
        }
    }
}
