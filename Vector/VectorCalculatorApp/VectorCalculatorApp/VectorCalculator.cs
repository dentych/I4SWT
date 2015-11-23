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

        internal Cartesian2DVector Subtract(Cartesian2DVector vector1, Cartesian2DVector vector2)
        {
            var vec = new Cartesian2DVector();
            vec.X = vector1.X - vector2.X;
            vec.Y = vector1.Y - vector2.Y;

            return vec;
        }
    }
}
