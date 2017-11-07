using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SunMoon_Azimuth_RightAscension
{
    public partial class FormSun : Form
    {
        public FormSun()
        {
            InitializeComponent();
        }

        private void FormSun_Load(object sender, EventArgs e)
        {
            //DateTime mydate = DateTime.Today;
            //Math_Formulae today = new Math_Formulae(mydate);
            //txtboxRAS.Text = today.ToString();

        }

        private void btnMoon_Click(object sender, EventArgs e)
        {


            FormMoon formmoon = new FormMoon();
            formmoon.Show();


            this.Hide();
        }

        private void SunPos()
        {

            //var position = new Math_Formulae(DateTime.Now);
            //txtboxAzimuthS = position.ToString();
            var position = New_Formula.CalculateSunPosition(DateTime.Now, -25.684044, 28.131091);

            //double RAH = position.Altitude;
            //RAH = RAH / 24;
            //double RAM = position.Altitude - RAH / 60;
            //double RAS = position.Altitude - RAH - RAM / 60;
            //string RA = RAH.ToString() + "h" + RAM.ToString() + "m" + RAS + "s";
            //txtboxRAS.Text = RA;
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine(position.Altitude.ToString());
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Right Ascension");
            //dt.Rows.Add(sb);
            //dgvSun.DataSource = dt;

            txtboxAzimuthS.Text = position.Azimuth.ToString();
            txtboxRAS.Text = position.Altitude.ToString();

            if (position.Altitude < 0)
            {
                double alt = -(position.Altitude) + 2;
                txtboxRAS.Text = alt.ToString();
            }
            else
            {
                txtboxRAS.Text = position.Altitude.ToString();
            }
            if (position.Azimuth > 90)
            {
                double alt = position.Altitude - 90;
                txtboxAzimuthS.Text = alt.ToString();
            }
            else
                if (position.Azimuth < 0)
            {
                double alt = position.Altitude + 90;
                txtboxAzimuthS.Text = alt.ToString();
            }
            else
            {

                txtboxAzimuthS.Text = position.Azimuth.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SunPos();
        }

        private void txtboxAzimuthS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
