using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    public class VectorCalculator
    {
        public Cartesian2DVector Add(Cartesian2DVector vector1, Cartesian2DVector vector2)
        {
            var vec = new Cartesian2DVector();
            vec.X = vector1.X + vector2.X;
            vec.Y = vector1.Y + vector2.Y;

            return vec;
        }

        public Cartesian2DVector Subtract(Cartesian2DVector vector1, Cartesian2DVector vector2)
        {
            var vec = new Cartesian2DVector();
            vec.X = vector1.X - vector2.X;
            vec.Y = vector1.Y - vector2.Y;

            return vec;
        }

        public Cartesian2DVector Scale(Cartesian2DVector vector, int factor)
        {
            var vec = new Cartesian2DVector();
            vec.X = vector.X * factor;
            vec.Y = vector.Y * factor;

            return vec;
        }

        public double Magnitude(Cartesian2DVector vector)
        {
            return Math.Sqrt(Math.Pow(vector.X, 2) + Math.Pow(vector.Y, 2));
        }

        public int DotProduct(Cartesian2DVector vector1, Cartesian2DVector vector2)
        {
            return (vector1.X * vector2.X) + (vector1.Y * vector2.Y);
        }
    }
}
