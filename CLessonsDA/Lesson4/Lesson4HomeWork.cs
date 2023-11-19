using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLessonsDA.Lesson4
{
    internal class Lesson4HomeWork
    {
        public static void Task1()
        {
            // Задание 1  
            // Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой промежуток
            // [0 - 14][15 - 35][36 - 50][50 - 100].Если да, то укажите, в какой именно промежуток.Если пользователь указывает число не
            // входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение. 

            Console.WriteLine("Введите целое число от 0 до 100");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0 & number <= 14)
            {
                Console.WriteLine("Ваше число - {0}, вы попали в промежуток от 0 до 14", number);
            }
            else if (number >= 15 & number <= 35)
            {
                Console.WriteLine("Ваше число - {0}, вы попали в промежуток от 15 до 35", number);
            }
            else if (number >= 36 & number <= 50)
            {
                Console.WriteLine("Ваше число {0}, вы попали в промежуток от 36 до 50", number);
            }
            else if (number >= 50 & number <= 100)
            {
                Console.WriteLine("Ваше число {0}, вы попали в промежуток от 50 до 100", number);
            }
            else
            {
                Console.WriteLine("Ваше число {0}, вы не попали ни в один из возможных промежутков", number);
            }
        }

        public static void Task2()
        {
            //Задание 2  
            //Напишите программу -консольный калькулятор.
            //Создайте две переменные с именами operand1 и operand2. Задайте переменным некоторые произвольные значения.
            //Предложите пользователю ввести знак арифметической операции. Примите значение введенное пользователем и поместите его в строковую переменную sign.
            //Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.Выведите на экран результат выполнения арифметической операции.  
            //В случае использования операции деления, организуйте проверку попытки деления на ноль. И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя.

            Console.WriteLine("Введите первое число: ");
            double operand1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            double operand2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите желаемую операцию из списка: +, -, *, /");
            char sing = Console.ReadKey().KeyChar;
            Console.Write("\b \b");

            switch (sing)
            {
                case '+':
                    {
                        Console.Write("Сумма равна: ");
                        Console.WriteLine(operand1 + operand2);
                        break;
                    }
                case '-':
                    {
                        Console.Write("Разница равна: ");
                        Console.WriteLine(operand1 - operand2);
                        break;
                    }
                case '*':
                    {
                        Console.Write("Произведение равно: ");
                        Console.WriteLine(operand1 * operand1);
                        break;
                    }
                case '/':
                    {
                        if (operand2 == 0)
                        {
                            Console.WriteLine("Одно из указанных значений равно 0, а делить на 0 нельзя");
                            break;
                        }
                        else
                        {
                            Console.Write("Частное равно: ");
                            Console.WriteLine(operand1 / operand2);
                            break;
                        }
                    }
            }
        }
    }
}