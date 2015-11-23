using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vector;

namespace VectorCalculatorApp
{
    [TestFixture]
    class TestVectorCalculator
    {
        [Test]
        public void TestAddTwoVectors()
        {
            Cartesian2DVector vector1 = new Cartesian2DVector
            {
                X = 5,
                Y = 10
            };
            Cartesian2DVector vector2 = new Cartesian2DVector
            {
                X = 3,
                Y = 14
            };


            VectorCalculator calc = new VectorCalculator();
            Cartesian2DVector result = calc.Add(vector1, vector2);

            Assert.That(result.X, Is.EqualTo(8));
            Assert.That(result.Y, Is.EqualTo(24));
        }

        [Test]
        public void TestSubtractTwoVectors()
        {
            Cartesian2DVector vector1 = new Cartesian2DVector
            {
                X = 5,
                Y = 10
            };
            Cartesian2DVector vector2 = new Cartesian2DVector
            {
                X = 3,
                Y = 14
            };

            var calc = new VectorCalculator();
            Cartesian2DVector result = calc.Subtract(vector1, vector2);

            Assert.That(result.X, Is.EqualTo(2));
            Assert.That(result.Y, Is.EqualTo(-4));
        }
    }
}
