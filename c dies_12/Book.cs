using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_dies_12
{
    [Serializable]
    internal class Book
    {
        public string Name { get; set; }
        public string Autor { get; set; }
        public int Ans { get; set; }
        public string Genre { get; set; }
        public Book(string name, string autor, int ans, string genre)
        {
            Name = name; Autor = autor; Ans = ans; Genre = genre;
        }
        public Book() { }
        public void Info()
        {
            Console.WriteLine(" Название : " + Name + " \n Автор : " + Autor + "\n Год : " + Ans + "\n Жанр : " + Genre + "\n");
        }
    }
}
