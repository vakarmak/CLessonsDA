namespace CLessonsDA.NotesDuringLessons.Lesson8;

public class Converter
{
    // Конвертер десятичного числа в двоичном формате
    public static void ConvertMeth(int n)
    {
        int temp = n % 2;

        if (n >= 2)
        {
            ConvertMeth(n / 2);
        }

        Console.Write(temp);
    }
}