using System.Xml.Linq;

namespace c_dies_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Book book1 = new Book("aaaaa", "aa aa", 1877, "comedie");
                Book book2 = new Book("bbbbb", "bb bb", 1700, "drama");
                Book book3 = new Book("ccccc", "cc cc", 1901, "tragedie");
                Book book4 = new Book("ddddd", "dd dd", 1605, "comedie");
                Book book5 = new Book("eeeee", "ee ee", 1899, "comedie");
                Library lll = new Library();
                lll.AddBook(book1);
                lll.AddBook(book2);
                lll.AddBook(book3);
                lll.AddBook(book4);
                lll.AddBook(book5);
                lll.DisplayAllBooks();
                BRRR(lll);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        static public void BRRR(Library liB)
        {
            Console.WriteLine("1. Просмотреть книги.\n2. Добавить книгу.\n3. Удалить книгу.\n4. Поиск по названию. \n5. Поиск по автору.\n6. Запись книг.\n7. Чтение.\n8. Выход.");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:liB.DisplayAllBooks(); BRRR(liB); break; case 2:liB.AddBook(); BRRR(liB); break; case 3:liB.RemoveBook();BRRR(liB); break ; case 4:liB.SearchByTitle(); BRRR(liB); break ; case 5:liB.SearchByAuthor();  BRRR(liB); break ;
                case 6:liB.Zap();  BRRR(liB); break;
                case 7:liB.Zap1();  BRRR(liB);break; case 8:return;
                default:  BRRR(liB); break;
            }
        }
    }
}