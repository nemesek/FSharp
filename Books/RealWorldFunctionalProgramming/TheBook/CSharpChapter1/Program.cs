using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Listing1dot1();
        }

        static void Listing1dot1()
        {
            // working with ellipse and rectangle
            GetEllipse();
        }

        static Ellipse GetEllipse()
        {
            // how do we know what the state of elipse will be by the time it gets returned?
            // Immutability would offer more insight
            var elipse = new Ellipse(new Rectangle(0, 0, 100, 100));
            var boundingBox = elipse.BoundingBox;
            boundingBox.Inflate(10, 10);
            return elipse;
        }
    }
}
