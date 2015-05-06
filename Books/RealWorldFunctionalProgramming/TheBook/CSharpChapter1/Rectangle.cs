using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChapter1
{
    class Rectangle
    {
        private int _a;
        private int _b;
        private int _c;
        private int _d;

        public Rectangle(int a, int b, int c, int d)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }

        public void Inflate(int x, int y)
        {
            Console.WriteLine("Inflating {0} and {1}",x,y);
        }
    }
}
