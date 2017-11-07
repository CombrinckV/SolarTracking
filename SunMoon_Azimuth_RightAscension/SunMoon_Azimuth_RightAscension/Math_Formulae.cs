using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SunMoon_Azimuth_RightAscension
{
    class Math_Formulae
    {
        const double mlSun = 280.460;
        const double Aberation = 0.9856474;
        const double mAnom = 357.528;
        const double AnomAb = 0.9856003;
        private DateTime enddate;

        public DateTime Enddate
        {
            get { return enddate; }
            set { enddate = value; }
        }
        public Math_Formulae(DateTime date)
        {
            this.enddate = date;
        }

        public double JulianDate()
        {
            DateTime startdate = new DateTime(2000, 1, 1);
            double Jdays = (this.enddate - startdate).TotalDays;
            return Jdays;        
        }

        public double MeanLongitude(double JDays)
        {
            double mLong;
            mLong = mlSun + (Aberation * JDays);
            return mLong;
        }

        public double MeanAnomaly(double JDays)
        {
            double meanAnomaly;
            meanAnomaly = mAnom + (AnomAb * JDays);
            return meanAnomaly;
        }

        public double EclipticLongitude(double L,double g)
        {
            double Lambda;
            Lambda = L + 1.915 * (Math.Sin(g)) + 0.020 * (Math.Sin(2 * g));
            return Lambda;
        }

        public double Obliquity(double JDays)
        {
            double Epsilon;
            Epsilon = 23.439 - (0.0000004 * JDays);
            return Epsilon;
        }

        public double RightAscension()
        {
            double days = JulianDate();
            double epsilon = Obliquity(days);
            double L = MeanLongitude(days);
            double g = MeanAnomaly(days);
            double lambda = EclipticLongitude(L, g);
            double delta = Math.Atan2(Math.Cos(epsilon), Math.Tan(lambda));
            return delta;
        }

        //public void SendData(DateTime date)
        //{
        //    double Lambda,Epsilon,Days,Long,Anom;
        //    Days = JulianDate();
        //    Long = MeanLongitude(Days);
        //    Anom = MeanAnomaly(Days);
        //    Lambda = EclipticLongitude(Long,Anom);
        //    Epsilon = Obliquity(Days);
        //}

        public override string ToString()
        {
            double Right = RightAscension();
         //   Right = (Right * Math.PI) / 360;
            return Right.ToString();
        }
    }
}
