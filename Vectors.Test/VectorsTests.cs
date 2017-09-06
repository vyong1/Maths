using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vectors.VectorClasses;
using Vectors;

namespace Vectors.Test
{
    [TestFixture]
    public class VectorsTests
    {
        Vector a = new Vector(1, 2, 3);
        Vector b = new Vector(4, 5, 6);
        Vector c = new Vector(7, 8, 9);

        [Test]
        public void Cross3DTest1()
        {
            Assert.That(VectorOperation.Cross3D(a, b).Equals(new Vector(-3, 6, -3)));
        }

        [Test]
        public void Cross3DTest2()
        {
            Assert.That(VectorOperation.Cross3D(c, b).Equals(new Vector(-3, 6, -3)));
        }

        [Test]
        public void Cross3DTest3()
        {
            Assert.That(VectorOperation.Cross3D(b, c).Equals(new Vector(-3, 6, -3)));
        }
    }
}
