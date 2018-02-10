using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** simple Exception Example *****");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);
            // Разогнаться до скоости, превышающей максимальный
            // предел автомобиля, для выдачи исключения.
            try
            {
                for (int i = 0; i < 10; i++)
                myCar.Accelerate(10);
            }
            catch(Exception e)
            {
                Console.WriteLine("\n*** Error! ***");            // ошибка
                Console.WriteLine("Member name: {0}", e.TargetSite); // имя члена
                Console.WriteLine("Class defining member: {0}",
                    e.TargetSite.DeclaringType);                   // класс, определяющий член
                Console.WriteLine("Member type: {0}",
                    e.TargetSite.DeclaringType);                  // тип члена
                Console.WriteLine("Message: {0}", e.Message);     // сообщение
                Console.WriteLine("Source: {0}", e.Source);       // источник
                Console.WriteLine("Stack: {0}", e.StackTrace);    // стек

                // По умолчанию поле данных является пустым, поэтому проверить его на null.
                Console.WriteLine("\n-> Costom Data:");
                if(e.Data != null)
                {
                    foreach (DictionaryEntry de in e.Data)
                        Console.WriteLine("-> {0} : {1}", de.Key, de.Value);
                }
            }
            // Ошибка была обработана, продолжается выполнение
            // следующего оператора.
            Console.WriteLine("\n***** Out of exception logic *****");
            Console.ReadLine();
        }
    }
}
