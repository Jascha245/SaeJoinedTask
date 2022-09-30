using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektorMathematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vector3 = new Vector(0,0,0);

            Vector vector4 = new Vector(3,3,3);

            float x = Vector.Length(vector4);

            Console.WriteLine(x);

            Console.ReadLine();
        }
    }

    internal class Vector
    {
        public float X;
        public float Y;
        public float Z;

        public Vector()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public Vector(float X, float Y, float Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public static Vector Add(Vector vector1, Vector vector2)
        {
            Vector vector = new Vector();
            vector.X = vector1.X + vector2.X;
            vector.Y = vector1.Y + vector2.Y;
            vector.Z = vector1.Z + vector2.Z;
            return vector;
        }
        public static Vector Sub(Vector vector1, Vector vector2)
        {
            Vector vector = new Vector();
            vector.X = vector1.X - vector2.X;
            vector.Y = vector1.Y - vector2.Y;
            vector.Z = vector1.Z - vector2.Z;
            return vector;
        }

        public static float Mult(Vector vector1, Vector vector2)
        {
            Vector vector = new Vector();
            vector.X = vector1.X * vector2.X;
            vector.Y = vector1.Y * vector2.Y;
            vector.Z = vector1.Z * vector2.Z;
            float result = vector.X + vector.Y + vector.Z;
            return result;
        }

        public static float Dis(Vector vector1, Vector vector2)
        {
            Vector vector = new Vector();
            vector = Sub(vector1, vector2);
            float skalar = Mult(vector, vector);
            float result =(float) Math.Sqrt(skalar);
            return result;
        }

        public static float Length(Vector vector)
        {
            float skalar = SquareLength(vector);
            float result = (float)Math.Sqrt(skalar);
            return result;
        }

        public static float SquareLength(Vector vector)
        {
            float skalar = Mult(vector, vector);
            return skalar;
        }

        public float DistanceNoneStatic(Vector vector1, Vector vector2)
        {
            float result = Dis(vector1, vector2);
            return result;
        }
    }
}
