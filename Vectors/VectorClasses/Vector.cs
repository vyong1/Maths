using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.VectorClasses
{
    public class Vector
    {
        public decimal X_Component { get; }
        public decimal Y_Component { get; }
        public decimal Z_Component { get; }

        public Vector(decimal X_Component, decimal Y_Component, decimal Z_Component)
        {
            this.X_Component = X_Component;
            this.Y_Component = Y_Component;
            this.Z_Component = Z_Component;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            //x
            sb.Append("<");
            sb.Append(this.X_Component);
            //y
            sb.Append(", ");
            sb.Append(this.Y_Component);
            //z
            sb.Append(", ");
            sb.Append(this.Z_Component);
            sb.Append(">");

            return sb.ToString();
        }

        public bool Equals(Vector vec)
        {
            if (vec.X_Component == X_Component
                && vec.Y_Component == Y_Component
                && vec.Z_Component == Z_Component)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
