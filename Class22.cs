using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class22
    {
        int ch;
        int z;
        public Class22(int x, int y)
        {
            ch = x; z = y;
        }
        public Class22(int x)
        {
            ch = x; z = 1; 
        }
        public Class22(int x, int y, int n)
        {
            ch = y*n+x; z = y; 
        }
        public double ToDouble() 
        {
            return (double)(ch) / z;
        }
      public static Class22 operator + (Class22 a, Class22 b)
        {
            return new Class22(a.ch + b.ch, a.z);
        }
    }
}
