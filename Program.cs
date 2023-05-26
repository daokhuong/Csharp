using System;

namespace Ex1
{
    class LibraryItem
    {
        protected string Title;
        protected string Author;
        protected int PublicationYear;

        public LibraryItem(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }

        public LibraryItem() { }

        public String PTitle
        {
            get { return Title; }
            set { Title = value; }
        }

        public String PAuthor
        {
            get { return Author; }
            set { Author = value; }
        }

        public int PPublicationYear
        {
            get { return PublicationYear; }
            set { PublicationYear = value; }
        }

        public virtual String ToString()
        {
            return "Title: " + PTitle + "  Author: " + PAuthor + "  Publication: " + PPublicationYear;
        }
    }

     class Book : LibraryItem
     {
        public Book() { }

        public override String ToString()
        {
            return "Title: " + PTitle + "  Author: " + PAuthor + "  Publication: " + PPublicationYear;
        }
     } 

    class Magazine : LibraryItem
    {
        public Magazine() { }
    
        public override String ToString()
        {
            return "Title: " + PTitle + "  Author: " + PAuthor + "  Publication: " + PPublicationYear;
        }
    }

     class DVD : LibraryItem
     {
        public DVD() { }
        public override String ToString()
        {
            return "Title: " + PTitle + "  Author: " + PAuthor + "  Publication: " + PPublicationYear;
        }
     }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            book.PTitle = "Nha Gia Kim";
            book.PAuthor = "Paulo Coelho";
            book.PPublicationYear = 1988;
            Console.WriteLine(book.ToString());
            Magazine maga = new Magazine();
            DVD dVd = new DVD(); 

        }
    }
}