namespace TestTaskAston;

public class TaskAston1
{
    public static void FirstTask()
    {
        Console.WriteLine("Введите число: ");
        int number = int.Parse(Console.ReadLine() ?? string.Empty);
        if (number > 7)
        {
            Console.WriteLine("Привет");
        }
    }
}
        