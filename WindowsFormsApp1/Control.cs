using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
   public class Control
    {
        protected int top;
        protected int left;

        public Control(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        public virtual void DrawWindow()
        {
            Console.WriteLine("Control: rysowanie kontrolki na pozycji {0}, {1}", top, left );
        }
    }
}
