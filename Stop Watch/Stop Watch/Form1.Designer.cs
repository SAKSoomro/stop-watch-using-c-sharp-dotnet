namespace Stop_Watch
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mSeconds = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.playPic = new System.Windows.Forms.PictureBox();
            this.pausePic = new System.Windows.Forms.PictureBox();
            this.resetPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pausePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stop Watch";
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Font = new System.Drawing.Font("Segoe UI Semibold", 72.2F, System.Drawing.FontStyle.Bold);
            this.hours.ForeColor = System.Drawing.Color.White;
            this.hours.Location = new System.Drawing.Point(3, 84);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(202, 161);
            this.hours.TabIndex = 1;
            this.hours.Text = "00";
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.Font = new System.Drawing.Font("Segoe UI Semibold", 72.2F, System.Drawing.FontStyle.Bold);
            this.minutes.ForeColor = System.Drawing.Color.White;
            this.minutes.Location = new System.Drawing.Point(223, 84);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(202, 161);
            this.minutes.TabIndex = 2;
            this.minutes.Text = "00";
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.Font = new System.Drawing.Font("Segoe UI Semibold", 72.2F, System.Drawing.FontStyle.Bold);
            this.seconds.ForeColor = System.Drawing.Color.White;
            this.seconds.Location = new System.Drawing.Point(448, 84);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(202, 161);
            this.seconds.TabIndex = 3;
            this.seconds.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mSeconds
            // 
            this.mSeconds.AutoSize = true;
            this.mSeconds.Font = new System.Drawing.Font("Segoe UI Semibold", 58.2F, System.Drawing.FontStyle.Bold);
            this.mSeconds.ForeColor = System.Drawing.Color.White;
            this.mSeconds.Location = new System.Drawing.Point(677, 107);
            this.mSeconds.Name = "mSeconds";
            this.mSeconds.Size = new System.Drawing.Size(163, 130);
            this.mSeconds.TabIndex = 4;
            this.mSeconds.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 58.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(616, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 130);
            this.label2.TabIndex = 5;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 58.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(395, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 130);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 58.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(171, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 130);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(98, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "hour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(324, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(551, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "sec";
            // 
            // playPic
            // 
            this.playPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playPic.Image = ((System.Drawing.Image)(resources.GetObject("playPic.Image")));
            this.playPic.Location = new System.Drawing.Point(295, 308);
            this.playPic.Name = "playPic";
            this.playPic.Size = new System.Drawing.Size(100, 100);
            this.playPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playPic.TabIndex = 11;
            this.playPic.TabStop = false;
            this.playPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pausePic
            // 
            this.pausePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pausePic.Image = ((System.Drawing.Image)(resources.GetObject("pausePic.Image")));
            this.pausePic.Location = new System.Drawing.Point(295, 308);
            this.pausePic.Name = "pausePic";
            this.pausePic.Size = new System.Drawing.Size(100, 100);
            this.pausePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pausePic.TabIndex = 12;
            this.pausePic.TabStop = false;
            this.pausePic.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // resetPic
            // 
            this.resetPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetPic.Image = ((System.Drawing.Image)(resources.GetObject("resetPic.Image")));
            this.resetPic.Location = new System.Drawing.Point(449, 308);
            this.resetPic.Name = "resetPic";
            this.resetPic.Size = new System.Drawing.Size(100, 100);
            this.resetPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.resetPic.TabIndex = 13;
            this.resetPic.TabStop = false;
            this.resetPic.Click += new System.EventHandler(this.resetPic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.resetPic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mSeconds);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.playPic);
            this.Controls.Add(this.pausePic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pausePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label mSeconds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox playPic;
        private System.Windows.Forms.PictureBox pausePic;
        private System.Windows.Forms.PictureBox resetPic;
    }
}

