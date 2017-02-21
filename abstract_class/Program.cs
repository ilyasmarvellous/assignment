using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
   public abstract class AbsParent
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public abstract void Mul(int x, int y);
        public abstract void Div(int x, int y);
    }
    class AbsChild : AbsParent
    {  
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        public static void Main()
        {
            AbsParent c = new AbsChild();
            c.Add(100, 50);
            c.Sub(156, 78);
            c.Mul(50, 30);
            c.Div(625, 25);
            Console.ReadLine();
        }
    }


}
