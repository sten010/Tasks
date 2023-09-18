using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_test
{
    internal class Subject5_Task1
    {
        public class QuestOne
        {
            public static void CalculetYearBirthday()
            {
                Console.WriteLine("Введите месяц рождения");
                int personMonth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите год рождения");
                int personYear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Укажите сегодняшний месяц");
                int todayMonth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Укажите сегодняшний год");
                int todayYear = Convert.ToInt32(Console.ReadLine());

                if (personYear > todayYear) Console.WriteLine("Неправильно указан год");
                int rezultYear = todayYear - personYear;
                if (todayMonth > personMonth) rezultYear++;
                Console.WriteLine(string.Format("Возраст человека состовляет - {0}", rezultYear));
            }
        }
        public class QuestTwo
        {
            public static void IntLook()
            {
                Console.WriteLine("Введите первое число");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите третье число");
                int c = Convert.ToInt32(Console.ReadLine());

                if (a < b && b < c)
                {
                    Console.WriteLine("Выполнено неравенство a < b < c");
                    return;
                }
                if (b > a && a > c)
                {
                    Console.WriteLine("Выполнено неравенство b > a > c");
                    return;
                }
                Console.WriteLine("Неравенство не выполнено");
            }
        }
        public class QuestThree
        {
            public static void DayOfWeek()
            {
                Console.WriteLine("Укажите число от 1 до 7");
                int day = Convert.ToInt32(Console.ReadLine());
                if (day < 1 || day > 7)
                {
                    Console.WriteLine("Нельзя указывать числа больше 7 и меньше 1");
                    return;
                }
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Понедельник");
                        return;
                    case 2:
                        Console.WriteLine("Вторник");
                        return;
                    case 3:
                        Console.WriteLine("Среда");
                        return;
                    case 4:
                        Console.WriteLine("Четверг");
                        return;
                    case 5:
                        Console.WriteLine("Пятница");
                        return;
                    case 6:
                        Console.WriteLine("Суббота");
                        return;
                    case 7:
                        Console.WriteLine("Воскресенье");
                        return;
                }
            }
        }
        public class QuestTour
        {
            public static void QuestSelect()
            {
                Console.WriteLine("Укажите номер задания");
                int questNumber = Convert.ToInt32(Console.ReadLine());
                if (questNumber < 1 || questNumber > 3)
                {
                    Console.WriteLine("Такого задания нет");
                    return;
                }
                if (questNumber.Equals(1))
                {
                    QuestOne.CalculetYearBirthday();
                    return;
                }
                else if (questNumber.Equals(2))
                {
                    QuestTwo.IntLook();
                    return;
                }
                else
                {
                    QuestThree.DayOfWeek();
                }
            }
        }

    }
}
