using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SunMoon_Azimuth_RightAscension
{
    class Calculate_Vectors
    {
        private double x;
        private double y;
        private double z;

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public Calculate_Vectors(double x,double y,double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double Magnitude()
        {
            return Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)+Math.Pow(z,2));
        }
    }
}
