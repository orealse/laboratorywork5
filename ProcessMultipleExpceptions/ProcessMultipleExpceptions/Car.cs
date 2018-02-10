using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExpceptions
{
    class Car
    {
        // Константа для представления максимальной скорости.
        public const int MaxSpeed = 100;

        // Свойства автомобиля.
        public int CurrentSpeed
        {
            get;
            set;
        }
        public string PetName
        {
            get;
            set;
        }

        // Не вышел ли автомобиль из строя?
        private bool carIsDead;

        // Автомобиль имеет радиоприемник.
        private Radio theMusicBox = new Radio();

        // Конструкторы.
        public Car()
        { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        public void CrankTunes(bool state)
        {
            // Делегированный запрос внутреннему объекту.
            theMusicBox.TurnOn(state);
        }

        // Проверить, не перегрелся ли автомобиль.
        public void Accelerate(int delta)
        {
            if (delta < 0)
                throw new
                    // Скорость должна быть больше нуля!
                ArgumentOutOfRangeException("delta", "Speed must be greater than zero!");
            CarlsDeadException ex =
                new CarlsDeadException(string.Format("{0} has overheated!", PetName),
                    "You have a lead foot", DateTime.Now);
            ex.HelpLink = "http://www.CarsRUs.com";
            throw ex;
            if (carIsDead)
            {
                Console.WriteLine("{0} is out of order...", PetName);
            }
            else
            {
                CurrentSpeed += delta;
                if(CurrentSpeed >= MaxSpeed)
                {
                    CurrentSpeed = 0;
                    carIsDead = true;
                    // Создать локальную переменную перед генерацией объекта Exception,
                    // чтобы можно было обращаться к свойству HelpLink.
                   /* Exception ex = 
                    new Exception(string.Format("{0} has overheated!", PetName));
                    ex.HelpLink = "http://www.CarsRUs.com";*/

                    // Указать специальные данные, касающиеся ошибки.
                    ex.Data.Add("TimeStamp",
                        string.Format("The car exploded at {0}", DateTime.Now)); // метка времени
                    ex.Data.Add("Cause", "You have a lead foot.");              // причины
                    throw ex;
                }
                else
                {
                    Console.WriteLine("-> CurrentSpeed = {0}", CurrentSpeed); // Вывод текущей скорости
                }
            }
        }
    }
}
