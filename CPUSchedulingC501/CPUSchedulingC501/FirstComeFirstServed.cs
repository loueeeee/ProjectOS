using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CPUSchedulingC501
{
    public partial class FirstComeFirstServed : Form
    {
        int[] processListArr;

        public FirstComeFirstServed()
        {
            InitializeComponent();
        }

        private void insertB_Click(object sender, EventArgs e)
        {
            if (hasSameArrivalOrProcessID(processIDTxt.Text, Convert.ToInt32(arrivalTimeTxt.Value)))
            {
                MessageBox.Show("Error: Your process has the same processes ID or arrival time with the other process!");
            }
            else
            {
                processListDGV.Rows.Add(processIDTxt.Text, arrivalTimeTxt.Value, burstTimeTxt.Value);
            }
        }

        private void removeB_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in processListDGV.SelectedRows)
            {
                processListDGV.Rows.Remove(row);
            }
        }

        private void runB_Click(object sender, EventArgs e)
        {
            if (hasBeginning())
            {
                processListArr = new int[processListDGV.RowCount];
                for (int ctr = 0; ctr < processListArr.Length; ctr++)
                {
                    processListArr[ctr] = ctr;
                }

                processListArr = sortAscending(processListArr);
                makeGanttChart();
            }
            else
            {
                MessageBox.Show("Error: Please have 0 arrival time!");
            }
        }

        public bool hasBeginning()
        {
            bool yes = false;
            foreach (DataGridViewRow row in processListDGV.Rows)
            {
                if (Convert.ToInt32(row.Cells[1].Value) == 0)
                {
                    yes = true;
                }
            }
            return yes;
        }

        public int[] sortAscending(int[] arr)
        {
            for (int x = arr.Length - 1; x >= 0; x--)
            {
                for (int y = 0; y < x; y++)
                {
                    if (Convert.ToInt32(processListDGV.Rows[arr[y]].Cells[1].Value) > Convert.ToInt32(processListDGV.Rows[arr[y+1]].Cells[1].Value))
                    {
                        int temp = arr[y];
                        arr[y] = arr[y + 1];
                        arr[y + 1] = temp;
                    }
                }
            }
            return arr;

        }

        public bool hasSameArrivalOrProcessID(string id, int at)
        {
            bool yes = false;

            foreach(DataGridViewRow row in processListDGV.Rows)
            {
                if (row.Cells[0].Value.ToString() == id || Convert.ToInt32(row.Cells[1].Value.ToString()) == at)
                {
                    yes = true;
                    break;
                }
            }
            return yes;
        }

        public void makeGanttChart()
        {
            ganttChartP.Controls.Clear();

            int time = 0;
            double awt = 0;
            double ata = 0;
            int currentX = 2;


            time += Convert.ToInt32(processListDGV.Rows[processListArr[0]].Cells[1].Value);

            for (int ctr = 0; ctr < processListArr.Length; ctr++)
            {
                Button b = new Button();
                b.BackColor = Color.DarkGoldenrod;
                b.Width = 50 * Convert.ToInt32(processListDGV.Rows[processListArr[ctr]].Cells[2].Value.ToString());
                b.Height = ganttChartP.Height - 40;
                b.Location = new Point(currentX, 0);
                b.Text = processListDGV.Rows[processListArr[ctr]].Cells[0].Value.ToString();
                b.FlatStyle = FlatStyle.Popup;
                b.Enabled = false;
                Label l = new Label();
                l.Text = time.ToString();
                l.ForeColor = Color.SeaGreen;
                l.Location = new Point(currentX - 5, ganttChartP.Height - 40);
                currentX += b.Width;
                l.BringToFront();
                processListDGV.Rows[processListArr[ctr]].Cells[3].Value = time - Convert.ToInt32(processListDGV.Rows[processListArr[ctr]].Cells[1].Value);
                awt += Convert.ToInt32(processListDGV.Rows[processListArr[ctr]].Cells[3].Value);
                time += Convert.ToInt32(processListDGV.Rows[processListArr[ctr]].Cells[2].Value);
                processListDGV.Rows[processListArr[ctr]].Cells[4].Value = time - Convert.ToInt32(processListDGV.Rows[processListArr[ctr]].Cells[1].Value);
                ata += Convert.ToInt32(processListDGV.Rows[processListArr[ctr]].Cells[4].Value);

                ganttChartP.Controls.Add(b);
                ganttChartP.Controls.Add(l);
            }

            awt /= processListDGV.Rows.Count;
            ata /= processListDGV.Rows.Count;

            Label ll = new Label();
            ll.Text = time.ToString();
            ll.ForeColor = Color.SeaGreen;
            ll.Location = new Point(currentX, ganttChartP.Height - 40);
            ll.BringToFront();
            ganttChartP.Controls.Add(ll);

            awtTxt.Text = String.Format("{0:0.00}", awt) + " ms";
            ataTxt.Text = String.Format("{0:0.00}", ata) + " ms"; 
        }

        private void ganttChartP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FirstComeFirstServed_FormClosing(object sender, FormClosingEventArgs e)
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

        private void processListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
