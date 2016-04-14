using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* code will create console application which will ask your to enter 
 * user name and read that and display 
*/
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name,Please");
            string name = Console.ReadLine();
            Console.WriteLine("hello " + name);
            Console.WriteLine("enter to end");

            Console.Read();
        }
    }
}

