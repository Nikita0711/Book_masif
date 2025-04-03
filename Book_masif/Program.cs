using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_masif
{
    internal class Program
    {
        static void Main()
        {
            string[][] book = new string[3][];

            for (int i = 0; i < book.Length; i++)
            {
                Console.WriteLine("Введите имя книги: ");
               string namebook = Console.ReadLine();

                Console.WriteLine("Введите автора: ");
                string nameavtor = Console.ReadLine();


                book[i] = new string[] { namebook,nameavtor};
            }
            Console.WriteLine("\nВы ввели: ");
            for (int i = 0;i < book.Length;i++)
            {
                
                Console.WriteLine($"Книгу:{book[i][0]} - {book[i][1]} ");
            }
            
        }
    }
}
