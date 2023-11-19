using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLessonsDA.Lesson2
{
    internal class Lesson2HomeWork
    {
        #region Task 1

        #region ЦЕЛЫЕ ТИПЫ

        // 8-bits == 1 byte.
        // Целое без знака. Диапазон - от 0 до 255.
        byte a = 0; // alias
        Byte b = 255; // full name

        // Целое со знаком. Диапазон - от -128 до +127.
        sbyte c = -128; // alias
        SByte d = +127; // full name

        // 16-bits == 2 bytes.
        // Целое без знака. Диапазон - от 0 до 65535.
        ushort e = 0; // alias
        UInt16 f = 65535; // full name

        // Целое со знаком. Диапазон - от -32768 до +32767.
        short g = -32768; // alias
        Int16 h = +32767; // full name

        // 32-bits = 4 bytes.
        // Целое без знака. Диапазон - от 0 до 4294967295.
        uint i = 0u; // alias
        UInt32 j = 4294967295U; // full name

        // Целое со знаком. Диапазон - от -2147483648 до +2147483647.
        int k = -2147483648; // alias
        Int32 l = +2147483647; // full name

        // 64-bits = 8 bytes. ---------------------------------------------------------------------------
        // Целое без знака. Диапазон - от 0 до 18446744073709551615.
        ulong m = 0ul; // alias
        UInt64 n = 18446744073709551615UL; // full name

        // Целое со знаком. Диапазон - от -9223372036854775808 до +9223372036854775807.
        long o = -9223372036854775808L; // alias
        Int64 p = +9223372036854775807L; // full name

        #endregion

        #region ВЕЩЕСТВЕННЫЕ ТИПЫ

        // Вещественные типы предназначены для представления дробных чисел.

        // 32-bits = 4 bytes.
        // Вещественное со знаком. Диапазон - от +/-1.5 x 10^-45 до +/-3.4 x 10^38.
        float q = -0.123456789f; // Указание суффикса f, является обязательным,  (alias)
        Single r = +1.123456789F; // т.к., компилятор интерпретирует данное число как double. (full name)


        // 64-bits = 8 bytes.
        // Вещественное со знаком. Диапазон - от +/-5.0 x 10^-324 до +/-1.7 x 10^308.
        double s = -0.123456789d; // alias
        Double t = +1.123456789; // full name

        #endregion

        #region ДЕСЯТИЧНЫЙ ТИП

        // 128-bits = 16 bytes.
        // Десятичное со знаком. Диапазон - от от +/-1.0 x 10^-28 до +/-7.9 x 10^28.
        decimal u = -0.12345m; // Указание суффикса m, является обязательным, (alias)
        Decimal v = +1.1234567M; // т.к., компилятор интерпретирует данное число как double. (full name)

        #endregion

        #region ЛОГИЧЕСКИЙ ТИП

        // 8-bits == 1 byte.
        // Логическая величина Истина/Ложь.
        bool w = true; // alias
        Boolean x = false; // full name

        #endregion

        #region СИМВОЛЬНЫЙ ТИП

        // 16-bits == 2 bytes.
        // Символ в формате UNICODE.
        char y = 'a'; // alias
        Char z = 'A'; // full name

        #endregion

        #region СТРОКОВОЙ ТИП

        // Строка в формате UNICODE.
        string firstString = "hello"; // alias
        String secondString = "HELLO"; // full name

        #endregion

        #endregion

        public static void Task2()
        {
            //Используя Visual Studio, создайте проект по шаблону Console Application.  
            //Дано значение числа pi, которое равно 3,141592653 и значение числа Эйлера е, 
            //которое равно 2,7182818284 590452.Создайте две переменные, присвойте им значения числа 
            //pi и числа е и выведите их на экран без потери точности.

            decimal pi = 3.141592653m;
            decimal el = 2.7182818284590452m;

            Console.WriteLine("pi = " + pi);
            Console.WriteLine("el = " + el);
        }

        public static void Task3()
        {
            //Используя Visual Studio, создайте проект по шаблону Console Application.  
            //Создайте три строковые переменные и присвойте им значения: 
            //"\nмоя строка 1"
            //"\tмоя строка 2"
            //"\aмоя строка 3"
            //Выведите значение каждой переменной на экран. Какие отличия вы увидели. Сделайте выводы.

            string str1 = "\nmy string 1";
            string str2 = "\nmy string 2";
            string str3 = "\nmy string 3";

            Console.Write(str1);
            Console.Write(str2);
            Console.Write(str3);
        }
    }
}

