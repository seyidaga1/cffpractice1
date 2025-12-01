using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Author :Book
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int NumberOfBooks { get; set; }

        public void DisplayAuthorInfo()
        {
            Console.WriteLine($"Author: {Name} {Surname}, Number of Books: {NumberOfBooks}, Title: {Title}");
        }
    }
}
