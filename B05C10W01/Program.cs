using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace B05C10W01
{
    internal class Program
    {
        //instance level(new)
        //non-instance level(static)
        static void Main(string[] args)
        {
          //Console.WriteLine(  new Program().Add(50));
          //  Get("Full stack web Application Develpment");

          var t=  Task.Run(() => {
                //Console.WriteLine(new Program().Add(50));
           return     new Program().Add(50);
            });
            Console.WriteLine(t.GetAwaiter().GetResult());
            Task.Run(() => {
                Get("Full stack web Application Develpment");
            });
            Console.ReadLine();
        }
        public int Add(int x)
        {
            Thread.Sleep(5000);
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
