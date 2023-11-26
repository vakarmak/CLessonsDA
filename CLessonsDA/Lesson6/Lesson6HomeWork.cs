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

            Console.WriteLine("Прямоугольник");
            Console.WriteLine();
            for (int rectangle = 0; rectangle < 4; rectangle++)
            {
                for (int rectangle2 = 0; rectangle2 < 10; rectangle2++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Прямоугольный треугольник");
            Console.WriteLine();
            for (int rightTriangle = 0; rightTriangle < 10; rightTriangle++)
            {
                for (int rightTriangle2 = 0; rightTriangle2 < rightTriangle; rightTriangle2++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ромб");
            Console.WriteLine();

            // rSize - изначальный размер ромба, используется для контролирования кол-ва строк, в которых рисуются пробелы или *
            // line - линия, в которой рисуется пробел или *
            // indentation - отступ, программа построена прежде всего на отступах, так как для того чтобы нарисовать ромб сначала нужно отступить на несколько символов,
            // если в цикле указать начальное значение не 0, а 1 то нарисованная фигура в конечном итоге сместиться влево на один символ.
            // Программа построена таким образом, что рисуется сначала верхняя часть, а потом нижняя.
            // Условие indentation < 2 * line - 1 обеспечивает рисование с двух сторон, если число 2 заменить на 1, то полученный результат будет похож на половину ромба,
            // при чем отрисована будет только левая его часть, данное условие применяется только в части отрисовывания * так как после завершения данной операции следует переход на новую строку.
            // Console.Write("\n"); в данном случае используется намеренно после отрисовывания * так как нужен переход на новую строку.
            // Отрисовывание середины ромба происходит на самой последней иттерации 2-го цикла ("*") где условно обозначена верхняя часть ромба. 

            int rSize = 5;
            
            // верхняя часть ромба
            
            for (int line = 1; line <= rSize; line++)
            {
                for (int indentation = 0; indentation < rSize - line; indentation++)
                {
                    Console.Write(" ");
                }

                for (int indentation = 0; indentation < 2 * line - 1; indentation++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
            
            //нижняя часть ромба

            for (int line = rSize - 1; line >= 1; line--)
            {
                for (int indentation = 0; indentation < rSize - line; indentation++)
                {
                    Console.Write(" ");
                }

                for (int indentation = 0; indentation < 2 * line - 1; indentation++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
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
