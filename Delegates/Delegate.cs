using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Delegate
    {
        //Declaring delegates
        //[Access modifier + delegate + return type+ delegate name]
        public delegate void addnum(int a, int b);
        public void Addition(int a,int b)
        {
            Console.WriteLine("Addition of a and b = {0}", a + b);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //Creating instance of class
            Delegate p = new Delegate();

            //Creating instance of delegate
            addnum addnum = new addnum(p.Addition);
            addnum(10, 20);
            addnum(10, 50);

        }
    }
}
