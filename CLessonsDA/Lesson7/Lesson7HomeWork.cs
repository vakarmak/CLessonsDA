namespace CLessonsDA.Lesson7
{
    internal class Lesson7HomeWork
    {
        public static void Task1()
        {
            // Создайте четыре метода для выполнения арифметических операций, с именами:
            // Add - сложение, Sub - вычитание, Mul - умножение, Div - деление.
            // Каждый метод должен принимать два целочисленных аргумента и выводить на экран результат арифметической операции
            // соответствующей имени метода. Метод деления Div, должен выполнять попытку деления на ноль.
            // Требуется предоставить пользователю возможность вводить с клавиатуры значения операндов и знак арифметической операции,
            // для выполнения вычисления.

            Console.WriteLine("Введите первое число: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите знак желаемой операции: ");
            char sign = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");

            switch (sign)
            {

                case '+':
                    {
                        int result = Add(x, y);

                        Console.WriteLine("Сумма равна: {0}", result);
                        break;
                    }

                case '-':
                    {
                        int result = Sub(x, y);

                        Console.WriteLine("Разница равна: {0}", result);
                        break;
                    }

                case '*':
                    {
                        int result = Mul(x, y);

                        Console.WriteLine("Произведение равно: {0}", result);
                        break;
                    }

                case '/':
                    {
                        string result = Div(x, y);

                        Console.WriteLine("Частное равно: {0}", result);
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Неверный знак операции!");
                        break;
                    }
            }

            static int Add(int x, int y)
            {
                return x + y;
            }

            static int Sub(int x, int y)
            {
                return x - y;
            }

            static int Mul(int x, int y)
            {
                return (x * y);
            }

            static string Div(double x, double y)
            {
                if (y == 0)
                {
                    return "На ноль делить нельзя!";
                }
                    
                return (x / y).ToString();
            }
        }

        public static void Task2()
        {
            // Напишите программу, которая будет выполнять конвертирование валют.
            // Пользователь вводит:
            // сумму денег в определенной валюте,
            // курс для конвертации в другую валюту,
            // Организуйте вывод результата операции конвертирования валюты на экран.


        }

        public static void Task3()
        {
            // Напишите метод, который будет определять:
            // 1) является ли число положительным или отрицательным
            // 2) является ли оно простым (используйте технику перебора чисел)
            // Простое число - это натуральное число, которое делится на 1 и само на себя. Чтобы определить простое ли число следует найти все его целые делители.
            // Если делителей больше двух, значит оно не простое
            // 3) Делится ли на 2, 5, 3, 6, 9 без остатка


        }
    }
}
