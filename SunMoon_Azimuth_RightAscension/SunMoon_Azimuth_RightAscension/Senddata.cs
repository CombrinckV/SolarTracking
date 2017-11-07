using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace SunMoon_Azimuth_RightAscension
{
    class Senddata
    {
        SerialPort myport = new SerialPort("Comm1", 9600, Parity.None, 8, StopBits.One);

        private int x;
        private int y;
        private int z;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public Senddata(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void SendVec()
        {
            myport.Open();
            myport.WriteLine(this.x.ToString() +" "+ this.y.ToString() +" "+this.z.ToString());

        }

        public int[] RecceiveVec(int[] vecs)
        {
            int[] myvecs = vecs;
            return myvecs;
            
           

        }

        public void GetVec()
        {
            myport.Open();
            string values = myport.ReadLine();
            int length = values.Length;
            int split = length / 2;
            x = int.Parse(values.Substring(0,split));

        }
    }
}
