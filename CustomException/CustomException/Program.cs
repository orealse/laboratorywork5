using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom Rxceptions *****\n");
            Car myCar = new Car("Rusty", 90);
            try
            {
                // Отслеживание исключений
                myCar.Accelerate(50);
            }
            catch (CarlsDeadException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CauseOfError);
            }
            Console.ReadLine();
        }
    }
}
