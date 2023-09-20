using System;

namespace ConsoleApp_test
{
    interface IValuesWork
    {
        public int firstNumber { get; set; }
        public int secondNumber { get; set; }
    }
    class Subject8_Task2 : IValuesWork
    {
        public int firstNumber { get; set; }
        public int secondNumber { get; set; }
        public Subject8_Task2()
        {
            UseCommand();
        }

        private void UseCommand()
        {
            string manualText =
                      "Ввод действия" +
               "\n" + "1.Сложить 2 числа" +
               "\n" + "2.Вычесть первое из второго" +
               "\n" + "3.Перемножить два числа" +
               "\n" + "4.Разделить первое на второе" +
               "\n" + "5.Возвести в степень N первое число" +
               "\n" + "6.Найти корень степени N из числа" +
               "\n" + "7.Найти 1 процент от числа" +
               "\n" + "8.Найти факториал из числа" +
               "\n" + "9.Выйти из программы";
            int todayMonth = 0;

            while (todayMonth != 9)
            {
                Console.WriteLine(manualText);
                Console.WriteLine("--------------");
                Console.WriteLine("Введите комманду");
                todayMonth = Convert.ToInt32(Console.ReadLine());
                if (todayMonth == 9) return;
                else if (todayMonth < 7)
                {
                    Console.WriteLine("Введите первое число");
                    firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    secondNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(string.Format("Выполнена команда {0}", GetCommand(todayMonth)));
                }
                else
                {
                    Console.WriteLine("Введите число");
                    firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(string.Format("Выполнена команда {0}", GetCommand(todayMonth)));
                }

            }
        }
        private string GetCommand(int number)
        {
            string rezult = string.Empty;
            switch (number)
            {
                case 1:
                    return string.Format("{0} результат - {1}", "Сложение", Fold());
                case 2:
                    return string.Format("{0} результат - {1}", "Вычисления", Subtract());
                case 3:
                    return string.Format("{0} результат - {1}", "Умножения", Multiplication());
                case 4:
                    return string.Format("{0} результат - {1}", "Деления", DivisionNumbers());
                case 5:
                    return string.Format("{0} результат - {1}", "Возведения в стпень", RaiseNumbers());
                case 6:
                    return string.Format("{0} результат - {1}", "Нахождения корня", FindRoot());
                case 7:
                    return string.Format("{0} {1} результат - {2}", "Нахождения 1 процента от числа", firstNumber, FindPercent());
                case 8:
                    return string.Format("{0} {1} результат - {2}", "Нахождения факториала от числа", firstNumber, FindFactorial(firstNumber));
                default:
                    return string.Format("{0} - {1}", "Нет действия под номером", number);
            }
        }
        private int Fold()
        {
            return firstNumber + secondNumber;
        }
        private int Subtract()
        {
            return firstNumber - secondNumber;
        }
        private int Multiplication()
        {
            return firstNumber * secondNumber;
        }
        private double DivisionNumbers()
        {
            return firstNumber / secondNumber;
        }
        private int RaiseNumbers()
        {
            int rezult = firstNumber;
            for (int i = 1; i < secondNumber; i++)
            {
                rezult *= firstNumber;
            }
            return rezult;
        }
        private double FindRoot()
        {
            return Math.Pow(firstNumber, 1.0/ secondNumber);
        }
        private double FindPercent()
        {
            return Math.Round((double)(firstNumber * 1.0 / 100),10);
        }
        private int FindFactorial(int first)
        {
            if (first == 1) return 1;
            return first * FindFactorial(first - 1);
        }
    }
}
