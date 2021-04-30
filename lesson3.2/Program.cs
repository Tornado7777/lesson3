/*Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий список телефонных 
 * контактов: первый элемент хранит имя контакта, второй — номер телефона/e-mail. */
using System;

namespace lesson3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phonebook = { { "Радость", "+7-900-000-00-03" }, 
                                    { "Сестра", "sister@mail" }, 
                                    { "Знакомая", "8-ХХХ-ХХХ-ХХ-ХХ" },
                                    {"Дружбан","НаСвязи@почта" },
                                    {"Мама","М-МММ-МММ-ММ-ММ" }    };
            int i = 0;
            Console.WriteLine("Имя:      Телефон/e-mail");
            while (i < phonebook.GetLength(0))
            {
                Console.WriteLine($"{phonebook[i,0]}   {phonebook[i,1]}");
                i++;
            }
            Console.ReadKey();
        }
    }
}
