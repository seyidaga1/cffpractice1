using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Year: {Year}");
        }


    }
}
