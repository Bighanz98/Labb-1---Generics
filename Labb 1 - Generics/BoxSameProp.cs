using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Generics
{
    internal class BoxSameProp: EqualityComparer<Box>
    {
        public override bool Equals(Box x, Box y)
        {
            if (x.Height == y.Height && x.Lenght == y.Lenght && x.Width == y.Width) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(Box b)
        {
            return b.GetHashCode();
        }

    }
}
