using System;

namespace bookStore
{

    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;

        public book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }
        public book(int i, string Title, string Author)
        {
            _Id = i;
            _Title = Title;
            _Author = Author;
        }
        public string GetTitle()
        {
            return _Title;
        }
        public string GetAuthor()
        {
            return _Author;
        }
        public int GetId()
        {
            return _Id;
        }

        public void SetId(int Identification)
        {
            _Id = Identification;
        }

        public void SetTitle(string Title)
        {
            _Title = Title;
        }

        public void SetAuthor(string Author)
        {
            _Author = Author;
        }
    }

        class myStore
        {
            static void Main(string[] args)
            {
                book book10 = new book();
                book10.SetId(10);
                book10.SetTitle("Goodnight Moon");
                book10.SetAuthor("Brown");

                book book20 = new book();
                Console.WriteLine("Please enter ID number: ");
                book20.SetId(int.Parse(Console.ReadLine()));
                Console.WriteLine("Please enter the title: ");
                book20.SetTitle(Console.ReadLine());
                Console.WriteLine("Please enter the author: ");
                book20.SetAuthor(Console.ReadLine());


                book book30 = new book(30, "The Very Hungry Caterpillar", "Carle");


                Console.WriteLine("Please enter ID number: ");
                int tempId = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter title: ");
                string tempTitle = Console.ReadLine();
                Console.WriteLine("Please enter the author: ");
                string tempAuthor = Console.ReadLine();
                book book40 = new book(i: tempId, Title: tempTitle, Author: tempAuthor);

            displayBooks(book10);
            displayBooks(book20);
            displayBooks(book30);
            displayBooks(book40);

        }
            static void displayBooks(book book)
            {
                Console.WriteLine("Here's the book information");
                Console.WriteLine($"ID Number: {book.GetId()}");
                Console.WriteLine($"Title: {book.GetTitle()}");
                Console.WriteLine($"Author Name: {book.GetAuthor()}");


            }

    }
}