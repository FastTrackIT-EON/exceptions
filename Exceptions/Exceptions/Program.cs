using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Function1();
        }

        private static void Function1()
        {
            Console.WriteLine($"Starting {nameof(Function1)}");

            try
            {
                Console.WriteLine($"Entering {nameof(Function1)} - Try");
                Function2();
                Console.WriteLine($"Finished {nameof(Function1)} - Try");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Executing {nameof(Function1)} - Catch");
            }
            finally
            {
                Console.WriteLine($"Executing {nameof(Function1)} - Finally");
            }

            Console.WriteLine($"Finished {nameof(Function1)}");
        }

        private static void Function2()
        {
            Console.WriteLine($"Starting {nameof(Function2)}");
            Function3();
            Console.WriteLine($"Finished {nameof(Function2)}");
        }

        private static void Function3()
        {
            Console.WriteLine($"Starting {nameof(Function3)}");
            int number = 100;
            int divisor = 0;
            int result = number / divisor;
            Console.WriteLine($"Result={result}");
            Console.WriteLine($"Finished {nameof(Function3)}");
        }
    }

    
}
