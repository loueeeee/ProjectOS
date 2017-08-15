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
    public partial class CPUSchedulingAlgorithm : Form
    {
        public CPUSchedulingAlgorithm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chooseAlgo(object sender, EventArgs e)
        {
            Button b = (Button)sender; 

            switch (b.Text)
            {
                case "First Come, First Served": this.Hide(); FirstComeFirstServed fcfs = new FirstComeFirstServed(); fcfs.ShowDialog(); break;
                case "Shortest Process First": this.Hide(); ShortestProcessFirst spf = new ShortestProcessFirst(); spf.ShowDialog(); break; 
                case "Priority (Non - Pre-emptive)": break;

                case "Round Robin": this.Hide(); RoundRobin rr = new RoundRobin(); rr.ShowDialog(); break;
                case "Shortest Remaining Time First": break;
                case "Priority (Pre-emptive)": break;
            }
        }

        private void CPUSchedulingAlgorithm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
