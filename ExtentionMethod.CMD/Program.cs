using System;

namespace ExtentionMethod.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать.");

            Console.Write("Введите число: ");
            var numb = int.Parse(Console.ReadLine());

            var answer = numb + " - ";

            if (!numb.IsPolindrom())
                answer += "не ";

            Console.WriteLine(answer + "палиндром.");
        }
    }
}