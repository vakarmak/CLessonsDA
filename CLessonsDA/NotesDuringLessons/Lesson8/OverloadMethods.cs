namespace CLessonsDA.NotesDuringLessons.Lesson8;

public class OverloadMethods
{
    public static void Function()
    {
        Console.WriteLine("Hello!");
    }

    public static void Function(string s)
    {
        Console.WriteLine(s);
    }

    public static void Function(int i)
    {
        Console.WriteLine(i);
    }

    public static void Function(double d)
    {
        Console.WriteLine(d);
    }

    public static void Function(string s, int i)
    {
        Console.WriteLine(s + i);
    }

    public static void Function(int i, string s)
    {
        Console.WriteLine(i + s);
    }

    public static void Function(ref int i, string s)
    {
        Console.WriteLine(i + s);
    }
}