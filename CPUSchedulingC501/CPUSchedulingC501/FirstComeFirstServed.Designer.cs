namespace CPUSchedulingC501
{
    partial class FirstComeFirstServed
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.allP = new System.Windows.Forms.Panel();
            this.ataTxt = new System.Windows.Forms.Label();
            this.ataL = new System.Windows.Forms.Label();
            this.awtTxt = new System.Windows.Forms.Label();
            this.awtL = new System.Windows.Forms.Label();
            this.ganttChartL = new System.Windows.Forms.Label();
            this.runB = new System.Windows.Forms.Button();
            this.ganttChartP = new System.Windows.Forms.Panel();
            this.removeB = new System.Windows.Forms.Button();
            this.burstTimeTxt = new System.Windows.Forms.NumericUpDown();
            this.arrivalTimeTxt = new System.Windows.Forms.NumericUpDown();
            this.insertB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.processIDTxt = new System.Windows.Forms.TextBox();
            this.processListDGV = new System.Windows.Forms.DataGridView();
            this.processID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.burstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waitingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnAroundTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backB = new System.Windows.Forms.Button();
            this.allP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.burstTimeTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalTimeTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processListDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // allP
            // 
            this.allP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.allP.Controls.Add(this.backB);
            this.allP.Controls.Add(this.ataTxt);
            this.allP.Controls.Add(this.ataL);
            this.allP.Controls.Add(this.awtTxt);
            this.allP.Controls.Add(this.awtL);
            this.allP.Controls.Add(this.ganttChartL);
            this.allP.Controls.Add(this.runB);
            this.allP.Controls.Add(this.ganttChartP);
            this.allP.Controls.Add(this.removeB);
            this.allP.Controls.Add(this.burstTimeTxt);
            this.allP.Controls.Add(this.arrivalTimeTxt);
            this.allP.Controls.Add(this.insertB);
            this.allP.Controls.Add(this.label3);
            this.allP.Controls.Add(this.label2);
            this.allP.Controls.Add(this.label1);
            this.allP.Controls.Add(this.processIDTxt);
            this.allP.Controls.Add(this.processListDGV);
            this.allP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allP.Location = new System.Drawing.Point(0, 0);
            this.allP.Name = "allP";
            this.allP.Size = new System.Drawing.Size(734, 634);
            this.allP.TabIndex = 0;
            // 
            // ataTxt
            // 
            this.ataTxt.AutoSize = true;
            this.ataTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ataTxt.ForeColor = System.Drawing.Color.Goldenrod;
            this.ataTxt.Location = new System.Drawing.Point(646, 568);
            this.ataTxt.Name = "ataTxt";
            this.ataTxt.Size = new System.Drawing.Size(62, 25);
            this.ataTxt.TabIndex = 19;
            this.ataTxt.Text = "0 ms";
            // 
            // ataL
            // 
            this.ataL.AutoSize = true;
            this.ataL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ataL.ForeColor = System.Drawing.Color.LightGreen;
            this.ataL.Location = new System.Drawing.Point(354, 568);
            this.ataL.Name = "ataL";
            this.ataL.Size = new System.Drawing.Size(300, 25);
            this.ataL.TabIndex = 18;
            this.ataL.Text = "Average Turn-around Time:";
            // 
            // awtTxt
            // 
            this.awtTxt.AutoSize = true;
            this.awtTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awtTxt.ForeColor = System.Drawing.Color.Goldenrod;
            this.awtTxt.Location = new System.Drawing.Point(257, 568);
            this.awtTxt.Name = "awtTxt";
            this.awtTxt.Size = new System.Drawing.Size(62, 25);
            this.awtTxt.TabIndex = 15;
            this.awtTxt.Text = "0 ms";
            // 
            // awtL
            // 
            this.awtL.AutoSize = true;
            this.awtL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awtL.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.awtL.Location = new System.Drawing.Point(12, 568);
            this.awtL.Name = "awtL";
            this.awtL.Size = new System.Drawing.Size(250, 25);
            this.awtL.TabIndex = 14;
            this.awtL.Text = "Average Waiting Time:";
            // 
            // ganttChartL
            // 
            this.ganttChartL.AutoSize = true;
            this.ganttChartL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ganttChartL.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ganttChartL.Location = new System.Drawing.Point(12, 440);
            this.ganttChartL.Name = "ganttChartL";
            this.ganttChartL.Size = new System.Drawing.Size(150, 29);
            this.ganttChartL.TabIndex = 13;
            this.ganttChartL.Text = "Gantt Chart:";
            // 
            // runB
            // 
            this.runB.BackColor = System.Drawing.Color.SeaGreen;
            this.runB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.runB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runB.ForeColor = System.Drawing.Color.Yellow;
            this.runB.Location = new System.Drawing.Point(51, 389);
            this.runB.Name = "runB";
            this.runB.Size = new System.Drawing.Size(326, 38);
            this.runB.TabIndex = 12;
            this.runB.Text = "RUN";
            this.runB.UseVisualStyleBackColor = false;
            this.runB.Click += new System.EventHandler(this.runB_Click);
            // 
            // ganttChartP
            // 
            this.ganttChartP.AutoScroll = true;
            this.ganttChartP.Location = new System.Drawing.Point(13, 472);
            this.ganttChartP.Name = "ganttChartP";
            this.ganttChartP.Size = new System.Drawing.Size(712, 81);
            this.ganttChartP.TabIndex = 11;
            this.ganttChartP.Paint += new System.Windows.Forms.PaintEventHandler(this.ganttChartP_Paint);
            // 
            // removeB
            // 
            this.removeB.BackColor = System.Drawing.Color.Firebrick;
            this.removeB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeB.ForeColor = System.Drawing.Color.Yellow;
            this.removeB.Location = new System.Drawing.Point(431, 389);
            this.removeB.Name = "removeB";
            this.removeB.Size = new System.Drawing.Size(247, 38);
            this.removeB.TabIndex = 10;
            this.removeB.Text = "REMOVE SELECTED PROCESS";
            this.removeB.UseVisualStyleBackColor = false;
            this.removeB.Click += new System.EventHandler(this.removeB_Click);
            // 
            // burstTimeTxt
            // 
            this.burstTimeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burstTimeTxt.Location = new System.Drawing.Point(407, 47);
            this.burstTimeTxt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.burstTimeTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.burstTimeTxt.Name = "burstTimeTxt";
            this.burstTimeTxt.Size = new System.Drawing.Size(187, 38);
            this.burstTimeTxt.TabIndex = 9;
            this.burstTimeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.burstTimeTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // arrivalTimeTxt
            // 
            this.arrivalTimeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalTimeTxt.Location = new System.Drawing.Point(211, 47);
            this.arrivalTimeTxt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.arrivalTimeTxt.Name = "arrivalTimeTxt";
            this.arrivalTimeTxt.Size = new System.Drawing.Size(187, 38);
            this.arrivalTimeTxt.TabIndex = 8;
            this.arrivalTimeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // insertB
            // 
            this.insertB.BackColor = System.Drawing.Color.RoyalBlue;
            this.insertB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insertB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertB.ForeColor = System.Drawing.Color.Yellow;
            this.insertB.Location = new System.Drawing.Point(600, 47);
            this.insertB.Name = "insertB";
            this.insertB.Size = new System.Drawing.Size(125, 38);
            this.insertB.TabIndex = 7;
            this.insertB.Text = "INSERT";
            this.insertB.UseVisualStyleBackColor = false;
            this.insertB.Click += new System.EventHandler(this.insertB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(416, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Burst Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(219, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arrival Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Process ID:";
            // 
            // processIDTxt
            // 
            this.processIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processIDTxt.Location = new System.Drawing.Point(13, 47);
            this.processIDTxt.Name = "processIDTxt";
            this.processIDTxt.Size = new System.Drawing.Size(189, 38);
            this.processIDTxt.TabIndex = 1;
            this.processIDTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // processListDGV
            // 
            this.processListDGV.AllowUserToAddRows = false;
            this.processListDGV.AllowUserToDeleteRows = false;
            this.processListDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processListDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processListDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.processListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processListDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processID,
            this.arrivalTime,
            this.burstTime,
            this.waitingTime,
            this.turnAroundTime});
            this.processListDGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processListDGV.Location = new System.Drawing.Point(12, 102);
            this.processListDGV.Name = "processListDGV";
            this.processListDGV.RowHeadersWidth = 200;
            this.processListDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.processListDGV.Size = new System.Drawing.Size(713, 272);
            this.processListDGV.TabIndex = 0;
            this.processListDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.processListDGV_CellContentClick);
            // 
            // processID
            // 
            this.processID.HeaderText = "Process ID";
            this.processID.Name = "processID";
            this.processID.ReadOnly = true;
            // 
            // arrivalTime
            // 
            this.arrivalTime.HeaderText = "Arrival Time";
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.ReadOnly = true;
            // 
            // burstTime
            // 
            this.burstTime.HeaderText = "Burst Time";
            this.burstTime.Name = "burstTime";
            this.burstTime.ReadOnly = true;
            // 
            // waitingTime
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.waitingTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.waitingTime.HeaderText = "Waiting Time";
            this.waitingTime.Name = "waitingTime";
            this.waitingTime.ReadOnly = true;
            // 
            // turnAroundTime
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGreen;
            this.turnAroundTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.turnAroundTime.HeaderText = "Turn-around Time";
            this.turnAroundTime.Name = "turnAroundTime";
            this.turnAroundTime.ReadOnly = true;
            this.turnAroundTime.Width = 120;
            // 
            // backB
            // 
            this.backB.BackColor = System.Drawing.Color.Maroon;
            this.backB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backB.ForeColor = System.Drawing.Color.Goldenrod;
            this.backB.Location = new System.Drawing.Point(606, 596);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(119, 32);
            this.backB.TabIndex = 20;
            this.backB.Text = "Back";
            this.backB.UseVisualStyleBackColor = false;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // FirstComeFirstServed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 634);
            this.Controls.Add(this.allP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FirstComeFirstServed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First - Come, First - Served";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstComeFirstServed_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.allP.ResumeLayout(false);
            this.allP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.burstTimeTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalTimeTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processListDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel allP;
        private System.Windows.Forms.Button insertB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox processIDTxt;
        private System.Windows.Forms.DataGridView processListDGV;
        private System.Windows.Forms.NumericUpDown burstTimeTxt;
        private System.Windows.Forms.NumericUpDown arrivalTimeTxt;
        private System.Windows.Forms.Button removeB;
        private System.Windows.Forms.Button runB;
        private System.Windows.Forms.Panel ganttChartP;
        private System.Windows.Forms.Label ganttChartL;
        private System.Windows.Forms.DataGridViewTextBoxColumn processID;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn burstTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn waitingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnAroundTime;
        private System.Windows.Forms.Label ataTxt;
        private System.Windows.Forms.Label ataL;
        private System.Windows.Forms.Label awtTxt;
        private System.Windows.Forms.Label awtL;
        private System.Windows.Forms.Button backB;
    }
}

