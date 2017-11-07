namespace SunMoon_Azimuth_RightAscension
{
    partial class FormMoon
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
            this.btnSun = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMoon = new System.Windows.Forms.DataGridView();
            this.DateSelectionM = new System.Windows.Forms.MonthCalendar();
            this.txtboxRAM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxAzimuthM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSun
            // 
            this.btnSun.Location = new System.Drawing.Point(93, 437);
            this.btnSun.Name = "btnSun";
            this.btnSun.Size = new System.Drawing.Size(89, 23);
            this.btnSun.TabIndex = 17;
            this.btnSun.Text = "To the Sun!";
            this.btnSun.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Please select a date to see the projected values";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Projected Azimuth and Right Ascension";
            // 
            // dgvMoon
            // 
            this.dgvMoon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoon.Location = new System.Drawing.Point(269, 63);
            this.dgvMoon.Name = "dgvMoon";
            this.dgvMoon.Size = new System.Drawing.Size(458, 397);
            this.dgvMoon.TabIndex = 14;
            // 
            // DateSelectionM
            // 
            this.DateSelectionM.Location = new System.Drawing.Point(35, 95);
            this.DateSelectionM.Name = "DateSelectionM";
            this.DateSelectionM.TabIndex = 13;
            // 
            // txtboxRAM
            // 
            this.txtboxRAM.Location = new System.Drawing.Point(140, 46);
            this.txtboxRAM.Name = "txtboxRAM";
            this.txtboxRAM.Size = new System.Drawing.Size(118, 20);
            this.txtboxRAM.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current Right Ascension";
            // 
            // txtboxAzimuthM
            // 
            this.txtboxAzimuthM.Location = new System.Drawing.Point(34, 46);
            this.txtboxAzimuthM.Name = "txtboxAzimuthM";
            this.txtboxAzimuthM.Size = new System.Drawing.Size(100, 20);
            this.txtboxAzimuthM.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current Azimuth";
            // 
            // FormMoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 490);
            this.Controls.Add(this.btnSun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMoon);
            this.Controls.Add(this.DateSelectionM);
            this.Controls.Add(this.txtboxRAM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxAzimuthM);
            this.Controls.Add(this.label1);
            this.Name = "FormMoon";
            this.Text = "Azimuth and Right Ascension for the Moon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMoon;
        private System.Windows.Forms.MonthCalendar DateSelectionM;
        private System.Windows.Forms.TextBox txtboxRAM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxAzimuthM;
        private System.Windows.Forms.Label label1;
    }
}