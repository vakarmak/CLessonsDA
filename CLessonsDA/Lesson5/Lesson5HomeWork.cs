using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLessonsDA.Lesson5
{
    internal class Lesson5HomeWork
    {
        public static void Task1()
        {
            // Задание 1
            // Известно, что у чисел, которые являются степенью двойки, только один бит имеет значение 1.
            // Напишите программу, которая будет выполнять проверку – является ли указанное число степенью двойки или нет.

            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (IsPowerOfTwo(number))
            {
                Console.WriteLine($"{number} является степенью двойки.");
            }
            else
            {
                Console.WriteLine($"{number} не является степенью двойки.");
            }

            static bool IsPowerOfTwo(int n)
            {
                // Если число является степенью двойки, то у него должен быть только один установленный бит.
                // Проверяем это с использованием битовых операций.
                return (n > 0) && ((n & (n - 1)) == 0);
            }
        }

            
        public static void Task2()
        {
            // Задание 2
            // Используя теорему Де Моргана, преобразуйте исходное выражение A | B, в эквивалентное выражение.

            bool A = true;
            bool B = false;

            // Исходное выражение из задания
            bool originalExpression = A | B;
            Console.WriteLine($"Исходное выражение: A | B =  {originalExpression}");

            // Преобразование согласно теореме Де Моргана
            bool equivalentExpression = !(A && B);
            Console.WriteLine($"Эквивалентное выражение: !(A && B) = {equivalentExpression}");
        }

        public static void Task3()
        {
            // Задание 3
            // Известно, что у четных чисел младший бит имеет значение 0
            // Напишите программу, которая будет выполнять проверку чисел на четность. 
            // Предложите два варианта решения поставленной задачи. 

            Console.WriteLine("Введите число:");
            int number2 = int.Parse(Console.ReadLine());

            // Первый вариант решения (простое решение)
            //if (number2 % 2 == 0)
            //{
            //    Console.WriteLine("число четное");
            //}
            //else
            //{
            //    Console.WriteLine("число не четное");
            //}

            // Второй вариант решения (побитовая проверка)
            static bool isEvenNumber (int n)
            {
                return (n > 0) && ((n & (n - 1)) == 0) && ((n & 1) == 0);
            }

            if (isEvenNumber(number2))
            {
                Console.WriteLine("Число четное");
            } 
            else
            {
                Console.WriteLine("Число не четное");
            }
        }

        public static void Task4()
        {
            // Задание 4
            // Имеется 3 переменные типа int x = 5, y = 10, и z = 15;
            // Выполните и рассчитайте результат следующих операций для этих переменных: 
            // § x += y >> x++ * z; 
            // § z = ++x & y * 5; 
            // § y /= x + 5 | z; 
            // § z = x++ & y * 5; 
            // § x = y << x++ ^ z;

            int x1 = 5, y1 = 10, z1 = 15;
            int res1 = x1 += y1 >> x1++ * z1;
            Console.WriteLine(res1);

            int x2 = 5, y2 = 10, z2 = 15;
            int res2 = z2 = ++x2 & y2 * 5;
            Console.WriteLine(res2);

            int x3 = 5, y3 = 10, z3 = 15;
            int res3 = y3 /= x3 + 5 | z3;
            Console.WriteLine(res3);

            int x4 = 5, y4 = 10, z4 = 15;
            int res4 = z4 = x4++ & y4 * 5;
            Console.WriteLine(res4);

            int x5 = 5, y5 = 10, z5 = 15;
            int res5 = x5 = y5 << x5++ ^ z5;
            Console.WriteLine(res5);
        }

        public static void Task5()
        {
            // Задание 5
            // Напишите программу расчета начисления премий сотрудникам. Премии рассчитываются согласно выслуге лет.
            // Если выслуга до 5 лет, премия составляет 10 % от заработной платы.  
            // Если выслуга от 5 лет(включительно) до 10 лет, премия составляет 15 % от заработной платы.  
            // Если выслуга от 10 лет(включительно) до 15 лет, премия составляет 25 % от заработной платы.  
            // Если выслуга от 15 лет(включительно) до 20 лет, премия составляет 35 % от заработной платы.  
            // Если выслуга от 20 лет(включительно) до 25 лет, премия составляет 45 % от заработной платы. 
            // Если выслуга от 25 лет(включительно) и более, премия составляет 50 % от заработной платы.  
            // Результаты расчета, выведите на экран. 

            Console.WriteLine("Укажите ваш рабочий стаж:");
            int workAge = int.Parse(Console.ReadLine());

            if (workAge > 0 && workAge < 5)
            {
                Console.WriteLine("Ваша премия составляет 10% от заработной платы");
            }
            else if (workAge >= 5 && workAge < 10)
            {
                Console.WriteLine("Ваша премия составляет 15% от заработной платы");
            }
            else if (workAge >= 10 && workAge < 15)
            {
                Console.WriteLine("Ваша премия составляет 25% от заработной платы");
            }
            else if (workAge >= 15 && workAge < 20)
            {
                Console.WriteLine("Ваша премия составляет 35% от заработной платы");
            }
            else if (workAge >= 20 && workAge < 25)
            {
                Console.WriteLine("Ваша премия составляет 45% от заработной платы");
            }
            else if (workAge > 25)
            {
                Console.WriteLine("Ваша премия составляет 50% от заработной платы");
            }
            Console.WriteLine("Вы либо не работаете либо пытаетесь проверить программу на работоспособность!");
        }
    }
}
