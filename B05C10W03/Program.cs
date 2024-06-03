using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B05C10W03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Program().Add(50);
            Get("Full stack web Application Develpment");
            Console.ReadLine();
        }
        public int Add(int x)
        {
            return x;
        }
        public float Add(float x)
        {
            return x;
        }
        public static void Get(string name)
        {
            Console.WriteLine(name);
        }
    }
}
