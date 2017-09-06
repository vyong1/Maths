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
    public class CrossTests
    {
        Vector a = new Vector(1, 2, 3);
        Vector b = new Vector(4, 5, 6);
        Vector c = new Vector(7, 8, 9);
        Vector d = new Vector(1, 7, 9);
        Vector e = new Vector(8, 2, 4);

        [Test]
        public void CrossTest1()
        {
            Assert.That(VectorOperation3D.Cross(a, b).Equals(new Vector(-3, 6, -3)));
        }

        [Test]
        public void CrossTest2()
        {
            Assert.That(VectorOperation3D.Cross(c, b).Equals(new Vector(3, -6, 3)));
        }

        [Test]
        public void CrossTest3()
        {
            Assert.That(VectorOperation3D.Cross(b, c).Equals(new Vector(-3, 6, -3)));
        }

        [Test]
        public void CrossTest4()
        {
            Assert.That(VectorOperation3D.Cross(d, e).Equals(new Vector(10, 68, -54)));
        }

        [Test]
        public void CrossTest5()
        {
            Assert.That(!VectorOperation3D.Cross(a, b).Equals(VectorOperation3D.Cross(b, a)));
        }
    }
}
