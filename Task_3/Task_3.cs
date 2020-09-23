using System;

namespace Task_3
{
    class Task_3
    {
        static void Main(string[] args)
        {
            bool check = true;

            while (check)
            {
                try
                {                   
                    Console.OutputEncoding = System.Text.Encoding.Unicode;

                    Console.WriteLine("Введіть змінну a типу int: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введіть змінну b типу double: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введіть змінну c типу long: ");
                    long c = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine($" a = {a}; b = {b}; c = {c}");

                    check = false;
                }
                catch
                {
                    Console.WriteLine("Введіть коректну змінну!");
                   
                }
            }
        }
    }
}
