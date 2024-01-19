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

            Console.WriteLine("Обмен производится между такими валютами: USD, EUR, GBP, UAH.");
            Console.WriteLine();

            string currencyName1 = "";
            while (true)
            {
                Console.WriteLine("Введите название валюты, которую хотите поменять:");
                currencyName1 = Console.ReadLine().ToUpper();

                if (currencyName1 == "USD" || currencyName1 == "EUR" || currencyName1 == "GBP" ||
                    currencyName1 == "UAH")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неправильный ввод!");
                }
            }

            Console.WriteLine("Введите необходимое кол-во валюты в {0}:", currencyName1);
            double currencyOneQuantity = double.Parse(Console.ReadLine());

            string currencyName2 = "";
            while (true)
            {
                Console.WriteLine("Введите название валюты, в которую хотите конвертировать {0}:", currencyName1);
                currencyName2 = Console.ReadLine().ToUpper();
                if (currencyName2 == "USD" || currencyName2 == "EUR" || currencyName2 == "GBP" ||
                    currencyName2 == "UAH")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неправильный ввод!");
                }
            }

            Console.WriteLine("Введите курс, по которому производится обмен {0} на {1}:", currencyName1, currencyName2);
            double exchangeRate = double.Parse(Console.ReadLine());

            static double ExchangeToUah(double currencyOneQuantity, double exchangeRate)
            {
                return currencyOneQuantity * exchangeRate;
            }

            double result = ExchangeToUah(currencyOneQuantity, exchangeRate);
            Console.WriteLine("При обмене {0} {1} на {2} выполучите {3} {2}", currencyOneQuantity, currencyName1,
                currencyName2, result);
        }

        public static void Task3()
        {
            // Напишите метод, который будет определять:
            // 1) является ли число положительным или отрицательным
            // 2) является ли оно простым (используйте технику перебора чисел)
            // Простое число - это натуральное число, которое делится на 1 и само на себя. Чтобы определить простое ли число следует найти все его целые делители.
            // Если делителей больше двух, значит оно не простое
            // 3) Делится ли на 2, 5, 3, 6, 9 без остатка

            IsPosOrNegMeth();
            IsPrimeOrComplexMeth();
            IsDivideNoRemainder();

            static void IsPosOrNegMeth()
            {
                Console.WriteLine("Метод для определения является ли введенное число положительным или отрицательным.");
                Console.WriteLine("Введите число:");
                double enteredNumber = double.Parse(Console.ReadLine());

                double isPosOrNeg = enteredNumber;

                if (isPosOrNeg > 0)
                {
                    Console.WriteLine("Число положительное!");
                }
                else if (isPosOrNeg < 0)
                {
                    Console.WriteLine("Число отрицательное!");
                }
                else
                {
                    Console.WriteLine("0 не является ни положительным, ни отрицательным числом");
                }
            }

            static void IsPrimeOrComplexMeth()
            {
                Console.WriteLine();
                Console.WriteLine("Метод для определения является ли введенное число простым.");
                Console.WriteLine("Введите число:");
                int enteredNumber2 = int.Parse(Console.ReadLine());

                if (IsPrime(enteredNumber2))
                {
                    Console.WriteLine("Введенное число {0} простое!", enteredNumber2);
                }
                else
                {
                    Console.WriteLine("Введенное число {0} не является простым!", enteredNumber2);
                }

                static bool IsPrime(int enteredNumber2)
                {
                    if (enteredNumber2 <= 1)
                    {
                        return false;
                    }

                    for (int i = 2; i <= Math.Sqrt(enteredNumber2); i++)
                    {
                        if (enteredNumber2 % i == 0)
                        {
                            return false;
                        }
                    }

                    return true;
                }
            }

            static void IsDivideNoRemainder()
            {
                Console.WriteLine();
                Console.WriteLine("Метод для определения делится ли число на 2, 5, 3, 6, 9 без остатка.");
                Console.WriteLine("Введите число:");
                int enteredNumber3 = int.Parse(Console.ReadLine());

                if (IsDivisibleByAll(enteredNumber3, 2, 5, 3, 6, 9))
                {
                    Console.WriteLine("Введенное число {0} делится на указанные числа без остатка.", enteredNumber3);
                }
                else
                {
                    Console.WriteLine("Введенное число {0} не делится на указанные числа без остатка.", enteredNumber3);
                }

                static bool IsDivisibleByAll(int enteredNumber3, params int[] divisors)
                {
                    foreach (int divisor in divisors)
                    {
                        if (enteredNumber3 % divisor != 0)
                        {
                            return false;
                        }
                    }

                    return true;
                }
            }
        }
    }
}