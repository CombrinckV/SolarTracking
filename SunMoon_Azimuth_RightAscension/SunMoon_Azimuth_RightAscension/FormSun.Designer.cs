namespace SunMoon_Azimuth_RightAscension
{
    partial class FormSun
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxAzimuthS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxRAS = new System.Windows.Forms.TextBox();
            this.DateSelectionSun = new System.Windows.Forms.MonthCalendar();
            this.dgvSun = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMoon = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSun)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Azimuth";
            // 
            // txtboxAzimuthS
            // 
            this.txtboxAzimuthS.Location = new System.Drawing.Point(3, 29);
            this.txtboxAzimuthS.Name = "txtboxAzimuthS";
            this.txtboxAzimuthS.Size = new System.Drawing.Size(100, 20);
            this.txtboxAzimuthS.TabIndex = 1;
            this.txtboxAzimuthS.TextChanged += new System.EventHandler(this.txtboxAzimuthS_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Right Ascension";
            // 
            // txtboxRAS
            // 
            this.txtboxRAS.Location = new System.Drawing.Point(109, 29);
            this.txtboxRAS.Name = "txtboxRAS";
            this.txtboxRAS.Size = new System.Drawing.Size(118, 20);
            this.txtboxRAS.TabIndex = 3;
            // 
            // DateSelectionSun
            // 
            this.DateSelectionSun.Location = new System.Drawing.Point(4, 78);
            this.DateSelectionSun.Name = "DateSelectionSun";
            this.DateSelectionSun.TabIndex = 4;
            // 
            // dgvSun
            // 
            this.dgvSun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSun.Location = new System.Drawing.Point(238, 46);
            this.dgvSun.Name = "dgvSun";
            this.dgvSun.Size = new System.Drawing.Size(458, 397);
            this.dgvSun.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Projected Azimuth and Right Ascension";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Please select a date to see the projected values";
            // 
            // btnMoon
            // 
            this.btnMoon.Location = new System.Drawing.Point(62, 420);
            this.btnMoon.Name = "btnMoon";
            this.btnMoon.Size = new System.Drawing.Size(89, 23);
            this.btnMoon.TabIndex = 8;
            this.btnMoon.Text = "To the Moon!";
            this.btnMoon.UseVisualStyleBackColor = true;
            this.btnMoon.Click += new System.EventHandler(this.btnMoon_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormSun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 455);
            this.Controls.Add(this.btnMoon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvSun);
            this.Controls.Add(this.DateSelectionSun);
            this.Controls.Add(this.txtboxRAS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxAzimuthS);
            this.Controls.Add(this.label1);
            this.Name = "FormSun";
            this.Text = "Azimuth and Right Ascension for the Sun";
            this.Load += new System.EventHandler(this.FormSun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxAzimuthS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxRAS;
        private System.Windows.Forms.MonthCalendar DateSelectionSun;
        private System.Windows.Forms.DataGridView dgvSun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMoon;
        private System.Windows.Forms.Timer timer1;
    }
}

