using System.Threading.Channels;

namespace TestTaskAston;

public class TaskAston3
{
    public static void ThirdTask()
    {
        Console.WriteLine("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine() ?? String.Empty);
        int[] arr = new int[n];
        Console.WriteLine("Введите массив: ");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine() ?? String.Empty);
        }

        Console.WriteLine("Числа кратные трем: ");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 3 == 0)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}