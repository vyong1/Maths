using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.VectorClasses
{
    public class Vector
    {
        public decimal X { get; }
        public decimal Y { get; }
        public decimal Z { get; }

        public Vector(decimal X, decimal Y, decimal Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            //x
            sb.Append("<");
            sb.Append(this.X);
            //y
            sb.Append(", ");
            sb.Append(this.Y);
            //z
            sb.Append(", ");
            sb.Append(this.Z);
            sb.Append(">");

            return sb.ToString();
        }

        public bool Equals(Vector vec)
        {
            if (vec.X == X
                && vec.Y == Y
                && vec.Z == Z)
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
