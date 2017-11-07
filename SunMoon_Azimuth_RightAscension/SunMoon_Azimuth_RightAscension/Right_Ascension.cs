using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SunMoon_Azimuth_RightAscension
{
    class Right_Ascension
    {
        private double lambda;
        private double epsilon;

        public double Epsilon
        {
            get { return epsilon; }
            set { epsilon = value; }
        }

        public double Lambda
        {
            get { return lambda; }
            set { lambda = value; }
        }

        public Right_Ascension(double Epsilon,double Lambda)
        {
            this.lambda = Lambda;
            this.epsilon = Epsilon;
        }

        public double RightAscension()
        {
            double delta = Math.Atan2(Math.Cos(this.epsilon),Math.Tan(this.lambda));
            return delta;
        }

        public double Declination()
        {
            double alpha = Math.Sinh(Math.Sin(this.epsilon) * Math.Sin(this.lambda));
            return alpha;
        }
    }
}
