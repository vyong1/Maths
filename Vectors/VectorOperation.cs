using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vectors.VectorClasses;

namespace Vectors
{
    public static class VectorOperation3D
    {

        #region Add/Sub/Scalar Mult

        public static Vector Add(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Vector Subtract(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        public static Vector ScalarMultiply(decimal scalar, Vector a)
        {
            return new Vector(a.X * scalar, a.Y * scalar, a.Z * scalar);
        }

        #endregion

        #region Dot

        #endregion

        #region Cross

        public static Vector Cross(Vector a, Vector b)
        {
            decimal x_comp = Evaluate2x2Determinant(Component.X, a, b);
            decimal y_comp = Evaluate2x2Determinant(Component.Y, a, b) * -1;
            decimal z_comp = Evaluate2x2Determinant(Component.Z, a, b);
            return new Vector(x_comp, y_comp, z_comp);
        }

        private static decimal Evaluate2x2Determinant(Component component, Vector a, Vector b)
        {
            decimal topLeft;
            decimal topRight;
            decimal botLeft;
            decimal botRight;

            AssignDeterminantNumbers(out topLeft, out topRight, out botLeft, out botRight, component, a, b);
            return (topLeft * botRight) - (topRight * botLeft);
        }

        private static void AssignDeterminantNumbers
            (
            out decimal topLeft,
            out decimal topRight,
            out decimal botLeft,
            out decimal botRight,
            Component component,
            Vector a,
            Vector b
            )
        {
            switch (component)
            {
                case Component.X:
                    topLeft = a.Y;
                    topRight = a.Z;
                    botLeft = b.Y;
                    botRight = b.Z;
                    break;
                case Component.Y:
                    topLeft = a.X;
                    topRight = a.Z;
                    botLeft = b.X;
                    botRight = b.Z;
                    break;
                case Component.Z:
                    topLeft = a.X;
                    topRight = a.Y;
                    botLeft = b.X;
                    botRight = b.Y;
                    break;
                default:
                    topLeft = 0;
                    topRight = 0;
                    botLeft = 0;
                    botRight = 0;
                    break;
            }
        }

        #endregion
    }

    public enum Component
    {
        X,
        Y,
        Z
    }
}
