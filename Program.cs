using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Version: {Environment.Version}");
            Console.WriteLine("Press Enter to close.");
            Console.ReadKey();
        }
    }
}
