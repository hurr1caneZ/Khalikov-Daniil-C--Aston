

using System.Threading.Channels;

namespace TestTaskAston;

public class TaskAston2
{
    public static void SecondTask()
    {
        Console.WriteLine("Введите имя: ");
        string name = Console.ReadLine() ?? String.Empty;
        if (name.Equals("Вячеслав"))
        {
            Console.WriteLine("Привет " + name);
        }
        else
        {
            Console.WriteLine("Нет такого имени");
        }
    }
}