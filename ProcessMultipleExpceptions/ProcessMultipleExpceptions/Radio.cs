﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExpceptions
{
    class Radio
    {
        public void TurnOn(bool on)
        {
            if (on)
            {
                Console.WriteLine("Jamming..."); // включен
            }
            else
            {
                Console.WriteLine("Quiet time..."); // выключен
            }
        }
    }
}
