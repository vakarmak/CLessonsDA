using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLessonsDA.Lesson6
{
    internal class Lesson6HomeWork
    {
        public static void Task1()
        {
            // Задание 2
            // Дано два числа A и B (A < B) выведите суму всех чисел расположенных между данными числами на экран.
            // Дано два числа A и B (A < B) выведите все нечетные значения, расположенные между данными числами.

            
        }

        public static void Task2()
        {
            // Задание 3
            // Используя циклы и метод:
            // Console.Write("*"), Console.Write(" "), Console.Write("\n")(для перехода на новую строку).
            // Выведите на экран:
            //· прямоугольник 
            //· прямоугольный треугольник  
            //· равносторонний треугольник   
            //· ромб


        }

        public static void Task3()
        {
            // Задание 4
            // Имеется N клиентов, которым компания производитель должна доставить товар.Сколько существует возможных маршрутов доставки товара, с учетом того, что товар будет доставлять одна машина ?
            // Напишите программу, которая будет рассчитывать, и выводить на экран количество возможных вариантов доставки товара.Для решения задачи, используйте факториал N!, рассчитываемый с помощью цикла do -while.

            Console.WriteLine("Введите количество клентов: ");
            int clientNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("У компании {0} клиента", clientNumber);
            int minimalPossibleRoutes = 1;

            do
            {
                minimalPossibleRoutes *= clientNumber--;
            }
            while (clientNumber > 0);
            Console.WriteLine("Существует {0} возможных варианта доставки товара", minimalPossibleRoutes);
        }
    }
}
