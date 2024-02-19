namespace CLessonsDA.NotesDuringLessons.Lesson8;

public class Recursion
{
    public static void SimpleRecursionMeth(int counter)
    {
        counter--;

        Console.WriteLine("Первая половина метода: {0}", counter);

        if (counter != 0)
        {
            SimpleRecursionMeth(counter);
        }

        Console.WriteLine("Вторая половина метода: {0}", counter);
    }

    public static void ComplexRecursionMethIni(int counter)
    {
        counter--;

        Console.WriteLine("Первая половина метода ComplexRecursionMethIni: {0}", counter);

        if (counter != 0)
        {
            ComplexRecursionMethCall(counter);
        }

        Console.WriteLine("Вторая половина метода ComplexRecursionMethIni: {0}", counter);
    }

    public static void ComplexRecursionMethCall(int counter)
    {
        Console.WriteLine("Первая половина метода ComplexRecursionMethCall: {0}", counter);

        ComplexRecursionMethIni(counter);

        Console.WriteLine("Вторая половина метода ComplexRecursionMethCall: {0}", counter);
    }
}