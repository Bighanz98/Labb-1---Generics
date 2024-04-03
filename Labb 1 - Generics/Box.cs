using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Generics
{
    internal class Box : IEquatable<Box>
    {
        public int Height { get; set; }
        public int Lenght { get; set; }
        public int Width { get; set; }


        public Box(int height, int lenght, int width) 
        {
            this.Height = height;
            this.Lenght = lenght;
            this.Width = width;
        }

        public bool Equals(Box? other)
        {
            if (new BoxSameProp().Equals(this, other))
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
