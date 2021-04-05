using System;

namespace OOP.Task5
{
    class Validator
    {
     
        public int InputTaskParser()
        {
            int i = 0;
            int tries = 0;

            while (tries++ < 100)
            {
                string str = Console.ReadLine();
                if (int.TryParse(str, out i) && IsNumberIsCorrect(i))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введите целочисленное значение от 1 до 3 включительно");
                }

            }
            return i;
        }

        public int InputDayParser()
        {
            int i = 0;
            int tries = 0;

            while (tries++ < 100)
            {
                string str = Console.ReadLine();
                if (int.TryParse(str, out i))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введите целочисленное значение");
                }

            }
            return i;
        }

        public bool IsNumberIsCorrect(int i)
        {       
            if (i == 1 || i == 2 || i == 3)
            {
                return true;
            }
            else
            {
                return false;
            }                    
        }
    }
}
