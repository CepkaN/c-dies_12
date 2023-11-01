using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace c_dies_12
{
    [Serializable]
    internal class Library
    {
        
        public List<Book> lib;
        public Library() { lib = new List<Book>(); }
        public void AddBook(Book book) { lib.Add(book);}
        public void AddBook()
        {
            Console.WriteLine("Введите название : ");
            string ?name=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите автора : ");
            string ?autor = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите год : ");
            int ans = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите жанр : ");
            string ?genre = Convert.ToString(Console.ReadLine());
            Book boo = new Book(name, autor, ans, genre);
            AddBook(boo);
        }
        public void RemoveBook() {
            Console.WriteLine(" Введите название книги для удаления : ");
            string ?sr=Convert.ToString(Console.ReadLine());           
            lib.Remove(SearchByTitle(sr));}
        public void SearchByAuthor() {
            Console.WriteLine("Введите автора : ");
            string? author = Convert.ToString(Console.ReadLine());
            int t = 0;
            foreach (var ss in lib) {

                if (ss.Autor == author) {ss.Info();
                ++t; }
            }
            if (t == 0)
            {
                Console.WriteLine(" Автора нет ");
            }
            }
        public Book SearchByTitle(string title) {
            Book boo=new Book();
            foreach (var ss in lib)
            {
                if (ss.Name == title) ss.Info();
                boo = ss;
            }
            return boo; }
        public void SearchByTitle()
        {
            Console.WriteLine("Введите название");
            string ?str=Convert.ToString(Console.ReadLine());
            foreach (var ss in lib)
            {
                if (ss.Name == str)
                {
                    ss.Info();
                    return;
                }
            }
            Console.WriteLine(" Книги нет ");

        }
        public void DisplayAllBooks()
        {
            foreach(var dd in lib)
            {
                dd.Info();
            }
        }
        public void Zap()
        {
            string ssss = "C:\\Users\\Ж - 6\\Documents\\Чеп\\c dies_12\\text.txt";
            using(FileStream filo=new FileStream(ssss, FileMode.Create))
            {
                BinaryFormatter format=new BinaryFormatter();
                format.Serialize(filo, lib);
            }
        }
        public void Zap1()
        {
            using (StreamReader reader1 = new StreamReader("C:\\Users\\Ж - 6\\Documents\\Чеп\\c dies_12\\text.txt", true))
            {
                string line1 = reader1.ReadLine();
                Console.WriteLine(line1);
            }
        }
    }
}
