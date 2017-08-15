using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPUSchedulingC501
{
    public partial class RoundRobin : Form
    {
        public RoundRobin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
            DataTable dataGridView1 = new DataTable();
             dataGridView1.Rows.Add(CBprocessid.SelectedItem.ToString(),CBarrival.SelectedItem.ToString(),CBburst.SelectedItem.ToString());

            string tingin = CBburst.SelectedItem.ToString();
            MessageBox.Show(tingin);

        }

        private void BTNstart_Click(object sender, EventArgs e)
        {

        }

        private void RoundRobin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Back();
        }

        public void Back()
        {
            this.Hide();
            CPUSchedulingAlgorithm cpu = new CPUSchedulingAlgorithm();
            cpu.ShowDialog();
        }

        private void backB_Click(object sender, EventArgs e)
        {
            Back();
        }
    }
}
