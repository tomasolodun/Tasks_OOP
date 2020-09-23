using System;

namespace Task_2
{
    class Task_2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            Console.WriteLine("Введіть змінну a типу int: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть змінну b типу double: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть змінну c типу long: ");
            long c = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine($" a = {a}; b = {b}; c = {c}");
        }
    }
}
