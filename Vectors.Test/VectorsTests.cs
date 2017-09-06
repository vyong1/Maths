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
    public class Cross3DTests
    {
        Vector a = new Vector(1, 2, 3);
        Vector b = new Vector(4, 5, 6);
        Vector c = new Vector(7, 8, 9);
        Vector d = new Vector(1, 7, 9);
        Vector e = new Vector(8, 2, 4);

        [Test]
        public void Cross3DTest1()
        {
            Assert.That(VectorOperation.Cross3D(a, b).Equals(new Vector(-3, 6, -3)));
        }

        [Test]
        public void Cross3DTest2()
        {
            Assert.That(VectorOperation.Cross3D(c, b).Equals(new Vector(3, -6, 3)));
        }

        [Test]
        public void Cross3DTest3()
        {
            Assert.That(VectorOperation.Cross3D(b, c).Equals(new Vector(-3, 6, -3)));
        }

        [Test]
        public void Cross3DTest4()
        {
            Assert.That(VectorOperation.Cross3D(d, e).Equals(new Vector(10, 68, -54)));
        }

        [Test]
        public void Cross3DTest5()
        {
            Assert.That(!VectorOperation.Cross3D(a, b).Equals(VectorOperation.Cross3D(b, a)));
        }
    }
}
