using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vectors.VectorClasses;

namespace Vectors
{
    public class VectorOperation
    {
        public static Vector Cross3D(Vector a, Vector b)
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
                    topLeft = a.Y_Component;
                    topRight = a.Z_Component;
                    botLeft = b.Y_Component;
                    botRight = b.Z_Component;
                    break;
                case Component.Y:
                    topLeft = a.X_Component;
                    topRight = a.Z_Component;
                    botLeft = b.X_Component;
                    botRight = b.Z_Component;
                    break;
                case Component.Z:
                    topLeft = a.X_Component;
                    topRight = a.Y_Component;
                    botLeft = b.X_Component;
                    botRight = b.Y_Component;
                    break;
                default:
                    topLeft = 0;
                    topRight = 0;
                    botLeft = 0;
                    botRight = 0;
                    break;
            }
        }
    }

    public enum Component
    {
        X,
        Y,
        Z
    }
}
