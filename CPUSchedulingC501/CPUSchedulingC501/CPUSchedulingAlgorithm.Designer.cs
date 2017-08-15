namespace CPUSchedulingC501
{
    partial class CPUSchedulingAlgorithm
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
            this.mainP = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.preemptiveP = new System.Windows.Forms.Label();
            this.pNPEB = new System.Windows.Forms.Button();
            this.srtfB = new System.Windows.Forms.Button();
            this.rrB = new System.Windows.Forms.Button();
            this.nonpreemptiveP = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pPEB = new System.Windows.Forms.Button();
            this.spfB = new System.Windows.Forms.Button();
            this.fcfsB = new System.Windows.Forms.Button();
            this.mainP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.nonpreemptiveP.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainP
            // 
            this.mainP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainP.Controls.Add(this.panel1);
            this.mainP.Controls.Add(this.nonpreemptiveP);
            this.mainP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainP.Location = new System.Drawing.Point(0, 0);
            this.mainP.Name = "mainP";
            this.mainP.Size = new System.Drawing.Size(792, 428);
            this.mainP.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.preemptiveP);
            this.panel1.Controls.Add(this.pNPEB);
            this.panel1.Controls.Add(this.srtfB);
            this.panel1.Controls.Add(this.rrB);
            this.panel1.Location = new System.Drawing.Point(405, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 385);
            this.panel1.TabIndex = 4;
            // 
            // preemptiveP
            // 
            this.preemptiveP.AutoSize = true;
            this.preemptiveP.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preemptiveP.ForeColor = System.Drawing.Color.Gold;
            this.preemptiveP.Location = new System.Drawing.Point(77, -1);
            this.preemptiveP.Name = "preemptiveP";
            this.preemptiveP.Size = new System.Drawing.Size(229, 42);
            this.preemptiveP.TabIndex = 3;
            this.preemptiveP.Text = "Pre-emptive";
            // 
            // pNPEB
            // 
            this.pNPEB.BackColor = System.Drawing.Color.Teal;
            this.pNPEB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pNPEB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNPEB.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.pNPEB.Location = new System.Drawing.Point(26, 287);
            this.pNPEB.Name = "pNPEB";
            this.pNPEB.Size = new System.Drawing.Size(320, 62);
            this.pNPEB.TabIndex = 2;
            this.pNPEB.Text = "Priority (Pre-emptive)";
            this.pNPEB.UseVisualStyleBackColor = false;
            this.pNPEB.Click += new System.EventHandler(this.chooseAlgo);
            // 
            // srtfB
            // 
            this.srtfB.BackColor = System.Drawing.Color.Teal;
            this.srtfB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srtfB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srtfB.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.srtfB.Location = new System.Drawing.Point(26, 171);
            this.srtfB.Name = "srtfB";
            this.srtfB.Size = new System.Drawing.Size(320, 62);
            this.srtfB.TabIndex = 1;
            this.srtfB.Text = "Shortest Remaining Time First";
            this.srtfB.UseVisualStyleBackColor = false;
            this.srtfB.Click += new System.EventHandler(this.chooseAlgo);
            // 
            // rrB
            // 
            this.rrB.BackColor = System.Drawing.Color.Teal;
            this.rrB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rrB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rrB.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.rrB.Location = new System.Drawing.Point(26, 56);
            this.rrB.Name = "rrB";
            this.rrB.Size = new System.Drawing.Size(320, 62);
            this.rrB.TabIndex = 0;
            this.rrB.Text = "Round Robin";
            this.rrB.UseVisualStyleBackColor = false;
            this.rrB.Click += new System.EventHandler(this.chooseAlgo);
            // 
            // nonpreemptiveP
            // 
            this.nonpreemptiveP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nonpreemptiveP.Controls.Add(this.label1);
            this.nonpreemptiveP.Controls.Add(this.pPEB);
            this.nonpreemptiveP.Controls.Add(this.spfB);
            this.nonpreemptiveP.Controls.Add(this.fcfsB);
            this.nonpreemptiveP.Location = new System.Drawing.Point(22, 22);
            this.nonpreemptiveP.Name = "nonpreemptiveP";
            this.nonpreemptiveP.Size = new System.Drawing.Size(366, 385);
            this.nonpreemptiveP.TabIndex = 0;
            this.nonpreemptiveP.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(23, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Non - Pre-emptive";
            // 
            // pPEB
            // 
            this.pPEB.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pPEB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pPEB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPEB.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.pPEB.Location = new System.Drawing.Point(26, 287);
            this.pPEB.Name = "pPEB";
            this.pPEB.Size = new System.Drawing.Size(320, 62);
            this.pPEB.TabIndex = 2;
            this.pPEB.Text = "Priority (Non - Pre-emptive)";
            this.pPEB.UseVisualStyleBackColor = false;
            this.pPEB.Click += new System.EventHandler(this.chooseAlgo);
            // 
            // spfB
            // 
            this.spfB.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.spfB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spfB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spfB.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.spfB.Location = new System.Drawing.Point(26, 171);
            this.spfB.Name = "spfB";
            this.spfB.Size = new System.Drawing.Size(320, 62);
            this.spfB.TabIndex = 1;
            this.spfB.Text = "Shortest Process First";
            this.spfB.UseVisualStyleBackColor = false;
            this.spfB.Click += new System.EventHandler(this.chooseAlgo);
            // 
            // fcfsB
            // 
            this.fcfsB.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.fcfsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fcfsB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fcfsB.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.fcfsB.Location = new System.Drawing.Point(26, 56);
            this.fcfsB.Name = "fcfsB";
            this.fcfsB.Size = new System.Drawing.Size(320, 62);
            this.fcfsB.TabIndex = 0;
            this.fcfsB.Text = "First Come, First Served";
            this.fcfsB.UseVisualStyleBackColor = false;
            this.fcfsB.Click += new System.EventHandler(this.chooseAlgo);
            // 
            // CPUSchedulingAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 428);
            this.Controls.Add(this.mainP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CPUSchedulingAlgorithm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU Scheduling Algorithms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CPUSchedulingAlgorithm_FormClosing);
            this.mainP.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.nonpreemptiveP.ResumeLayout(false);
            this.nonpreemptiveP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainP;
        private System.Windows.Forms.Panel nonpreemptiveP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pPEB;
        private System.Windows.Forms.Button spfB;
        private System.Windows.Forms.Button fcfsB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label preemptiveP;
        private System.Windows.Forms.Button pNPEB;
        private System.Windows.Forms.Button srtfB;
        private System.Windows.Forms.Button rrB;
    }
}

