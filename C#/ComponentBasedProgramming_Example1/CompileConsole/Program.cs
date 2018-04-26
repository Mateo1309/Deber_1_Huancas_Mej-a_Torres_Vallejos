using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileConsole
{
    using ComponentBasedProgramming.LibTrigonometricOperations;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CTrigonometricOperations.SinFunction((Math.PI) / 2));
            Console.WriteLine(CTrigonometricOperations.CosFunction(0));
            Console.WriteLine(CTrigonometricOperations.TanFunction((Math.PI) / 4));
            Console.ReadKey(true);
        }
    }
}
