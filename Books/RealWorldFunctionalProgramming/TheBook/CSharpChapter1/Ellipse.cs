using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChapter1
{
    class Ellipse
    {
        private Rectangle _rectangle;

        public Ellipse(Rectangle rectangle)
        {
            _rectangle = rectangle;
        }

        public Rectangle BoundingBox { get { return _rectangle; } }
    }
}
