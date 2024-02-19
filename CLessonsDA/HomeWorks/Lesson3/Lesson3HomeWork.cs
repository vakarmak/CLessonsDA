using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLessonsDA.Lesson3
{
    internal class Lesson3HomeWork
    {
        public static void Task1()
        {
            //Задание 1
            // Имеется 3 переменные типа int x = 10, y = 12, и z = 3;
            //Выполните и рассчитайте результат следующих операций для этих переменных:
            // 
            //	x += y - x++ * z; 
            //	z = --x – y * 5; 
            //	y /= x + 5 % z; 
            //	z = x++ + y * 5; 
            //	x = y - x++ * z;


            int x = 10;
            int y = 12;
            int z = 3;

            Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);

            x += y - x++ * z;
            Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);

            z = --x - y * 5;
            Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);

            y /= x + 5 % z;
            Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);

            z = x++ + y * 5;
            Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);

            x = y - x++ * z;
            Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
        }

        public static void Task2()
        {
            //Задание 2
            //Используя Visual Studio, создайте проект по шаблону Console Application.  
            //Вычислите среднее арифметическое трех целочисленных значений и выведите его на экран.
            //С какой проблемой вы столкнулись? Какой тип переменных лучше использовать для корректного отображения результата?

            int x1 = 13;
            int y1 = 23;
            int z1 = 45;

            int average = (x1 + y1 + z1) / 3;

            // при использовании типа данных дабл, что как по мне очевиднее, так как не всегда результат будет целым числом ругнулось на возможную утерю точности
            // немного не понял пассажа, получается если я использую инт вместо дабл то я достигаю большей точности?

            Console.WriteLine("Среднее арифметическое = " + average);
        }

        public static void Task3()
        {
            //Задание 3
            //Используя Visual Studio, создайте проект по шаблону Console Application.  
            //Создайте константу с именем -pi(число π «пи»), создайте переменную радиус с именем – r.Используя формулу πR 2 , вычислите площадь круга и выведите результат на экран.

            double pi = 3.14;
            int r = 45;

            var square = pi * Math.Pow(r, 2);
            Console.WriteLine("Площадь круга = " + square + " м^2");
        }

        public static void Task4()
        {
            //Задание 4
            //Используя Visual Studio, создайте проект по шаблону Console Application.  
            //Напишите программу расчета объема -V и площади поверхности - S цилиндра.
            //Объем V цилиндра радиусом – R и высотой – h, вычисляется по формуле: V = πR 2 h
            //Площадь S поверхности цилиндра вычисляется по формуле: S = 2πR 2 + 2πR 2 = 2πR(R + h)
            //Результаты расчетов выведите на экран.

            double pi = 3.14;
            int r = 25;
            int h = 11;

            var v = pi * Math.Pow(r, 2) * h;
            Console.WriteLine("Обьем цилиндра = " + v);

            var s = 2 * pi * r * (r + h);
            Console.WriteLine("Площадь поверхности цилиндра = " + s);
        }

        public static void Task5()
        {
            // string uberflu? ; //not possible
            string _Identifier;
            string \u006fIdentifier;
            // string &myVar; //not possible
            string myVariab1le;
        }
    }
}
