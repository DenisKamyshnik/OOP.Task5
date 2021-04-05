using System;
using System.Collections.Generic;

namespace OOP.Task5
{
    class Task
    {
        private static List<Task> tasks = new List<Task>();
        private int Difficulty { get; set; }
        private int Priority { get; set; }
        private int Time { get; set; }
        private string Name { get; set; }

        Validator validator = new Validator();

        public void SetTasks()
        {
            int tries = 0;

            while (tries++ < 100)
            {

                Task task = new Task();
                Console.WriteLine("Введите задание");
                task.Name = Console.ReadLine();

                Console.WriteLine("Введите приоритет: 1 - Высокий, 2 - Средний, 3 - Низкий");
             
                task.Priority = validator.InputTaskParser(); 

                Console.WriteLine("Введите сложность:  1 - Высокая, 2 - Средняя, 3 - Низкая");

                task.SetTimeToTask(task.Difficulty = validator.InputTaskParser());

                tasks.Add(task);

                Console.WriteLine("Желаете продолжить ввод? Если да - нажмите 1, если нет - любую другую цифру/букву/спец. символ");
                string selector = Console.ReadLine();
                if (selector != "1")
                {
                    break;
                }
       
            }
        }

        public void GetSumTimeOfTasks()
        {

            int sum = 0;
            foreach (Task task in tasks)
            {
                sum += task.Time;
            }
            Console.WriteLine("Сумма времени выполнения всех заданий = {0}", sum);

        }

        public void GetTasksbyPriprity()
        {
            Console.WriteLine("Введите приоритет для поиска задач: 1 - Высокий, 2 - Средний, 3 - Низкий");
            int priority = validator.InputTaskParser();

            foreach (Task task in tasks)
            {
                if (priority == task.Priority)
                {
                    Console.WriteLine(task.Name);
                }
            }

        }

        public void GetTasksbyPriorityforDays()
        {
            int day;
            int time = 0;
            int hours;
            Console.WriteLine("Введите кол-во дней");

            day = validator.InputDayParser();        
            hours = day * 8;
 


            foreach (Task task in tasks)
            {
                if (task.Priority == 1)
                {
                    time = task.Time + time;
                    if (time <= hours)
                    {
                        Console.WriteLine(task.Name);

                    }
                }
                else
                {
                    continue;
                }
            }

            foreach (Task task in tasks)
            {
                if (task.Priority == 2)
                {
                    time = task.Time + time;
                    if (time <= hours)
                    {
                        Console.WriteLine(task.Name);

                    }
                }
                else
                {
                    continue;
                }
            }

            foreach (Task task in tasks)
            {

                if (task.Priority == 3)
                {
                    time = task.Time + time;
                    if (time <= hours)
                    {
                        Console.WriteLine(task.Name);

                    }

                }
                else
                {
                    continue;
                }
            }
        }

        public int SetTimeToTask(int compl)
        {
            Difficulty = compl;
            if (compl == 1)
            {
                return Time = 4;
            }

            if (compl == 2)
            {
                return Time = 2;
            }

            if (compl == 3)
            {
                return Time = 1;
            }

            return default;
        }

    }
}
