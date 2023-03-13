using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Vectors2D
    {
        private double x;
        private double y;
        public Vectors2D() 
        {
            x = 0;
            y = 0;
        }
        public Vectors2D(double x, double y) 
        { 
            this.x = x;
            this.y = y;
        }
        public Vectors2D(Vectors2D v)
        {
            x = v.X;
            y = v.Y;
        }

        public double X
        {
            get
            {
                return x;
            }
            set 
            { 
                x=value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y=value;
            }
        }

        public string ToString()
        {
            return "X = "+x+" - Y = "+y;
        }

        public bool Equals(Vectors2D other)
        {
            if ((x == other.X) && (y == other.Y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Norm()
        {
            return Math.Sqrt(x*x+y*y);
        }
    }

    class Vectors3D : Vectors2D
    {
        private double z;
        public Vectors3D() :base()
        {
            z = 0;
        }
        public Vectors3D(double x, double y, double z) : base(x, y)
        {
            this.z = z;
        }
        public Vectors3D(Vectors3D v)
        {
            X = v.X;
            Y = v.Y;
            z = v.Z;
        }
        public double Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }

        public string ToString()
        {
            return "X = " + X + " - Y = " + Y+" - Z = "+z;
        }

        public bool Equals(Vectors3D other)
        {
            if ((X == other.X) && (Y == other.Y) && (Z == other.Z))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Norm()
        {
            return Math.Sqrt(X*X + Y*Y + z*z);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vectors2D v1= new Vectors2D(3,4);
            Vectors2D v2= new Vectors2D(v1);
            Vectors3D v3= new Vectors3D();
            Vectors3D v4 = new Vectors3D(3,4,5);

            Console.WriteLine("v1: "+v1.ToString());
            Console.WriteLine("v2: " + v2.ToString());
            Console.WriteLine("v3: " + v3.ToString());
            Console.WriteLine("v4: " + v4.ToString());

            Console.WriteLine("v1.Norm(): "+v1.Norm());
            Console.WriteLine("v2.Norm(): "+v2.Norm());
            Console.WriteLine("v3.Norm(): "+v3.Norm());
            Console.WriteLine("v4.Norm(): "+v4.Norm());

            Console.WriteLine("v1.Equals(v2): "+v1.Equals(v2));
            Console.WriteLine("v3.Equals(v4): "+v3.Equals(v4));

            Console.ReadKey();

        }
    }
}
