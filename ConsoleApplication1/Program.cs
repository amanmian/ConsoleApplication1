using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello there..");
            int a = 100;
            float x = 2.5f;
            string str = "I belong to Uttarakhand, India";
            string s = str.ToUpper();
            string t = str.ToLower();
            string r = "this is c#.NET".ToUpper();
            int box = 10;
            object obj = box;
            box = 20;
            int unbox = (int)obj;
            Console.WriteLine("After boxing: "+obj);
            Console.WriteLine("After unboxing: " + unbox);
            Console.WriteLine("box: " + box);
            Console.WriteLine("Simple string: "+str);
            Console.WriteLine("Upper case string: "+s);
            Console.WriteLine("Lower case string: "+t);
            Console.WriteLine("Direct function: "+r);
            Console.WriteLine("value of a=: " + a);
            Console.WriteLine("Floating point number: "+x);
           // ExecuteRectangle ex = new ExecuteRectangle();
            


            Console.ReadKey();
        }
    }
}
