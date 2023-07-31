using System;
using System.Threading;

namespace TestTaskAston;

public class Program
{
    public static void Main(string[] args)
    {
        ThreadStart firstTask = new ThreadStart(TaskAston1.FirstTask);
        Thread thread1 = new Thread(firstTask);
        thread1.Start();
        Thread.Sleep(10000);
        ThreadStart secondTask = new ThreadStart(TaskAston2.SecondTask);
        Thread thread2 = new Thread(secondTask);
        thread2.Start();
        Thread.Sleep(10000);
        ThreadStart thirdTask = new ThreadStart(TaskAston3.ThirdTask);
        Thread thread3 = new Thread(thirdTask);
        thread3.Start();
        Thread.Sleep(10000);
    }
}