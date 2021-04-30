//Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).
using System;

namespace lesson3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст и нажмите клавишу Enter:");
            string UserText = Console.ReadLine();
            for (int i=0;i<UserText.Length; i++)
            {
                Console.Write(UserText[UserText.Length - i - 1]);
            }
            Console.ReadKey();
        }
    }
}
