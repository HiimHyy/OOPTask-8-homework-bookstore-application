using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask_8_homework_bookstore_application
{
    internal class Bookstore
    {
        private List<Book> books = new List<Book>()
        {
            new Book("The Miserable Ones", 23.85),
            new Book("East of Eden", 31.10),
            new Book("Anna Karenina", 31.45),
            new Book("Bury My Heart at Wounded Knee", 25.80),
            new Book("Nana", 27.35),
            new Book("Crime and Punishment", 26.55),
            new Book("The Mother", 34.75),
            new Book("Found", 10.90),
            new Book("The Story of My Life", 18.60),
            new Book("The Complete Chronicles of Narnia", 44.65),
            new Book("Till We Have Faces", 14.95),
            new Book("The Lord of the Rings", 32.95),
            new Book("Pride and Prejudice", 24.15),
            new Book("A Farewell to Arms", 28.70),
            new Book("Harry Potter and the Order of the Phoenix", 33.25),
            new Book("The Catcher in the Rye", 17.65),
            new Book("Paradise Lost", 32.50),
            new Book("To Kill a Mockingbird", 20.95),
            new Book("In Search of Lost Time", 23.15),
            new Book("And Then There Were None", 13.35),
            new Book("The Name of the Rose", 25.55),
            new Book("Death of a Salesman", 29.90),
            new Book("Don Quixote", 18.85),
            new Book("Hamlet", 27.35),
            new Book("The Purpose Driven Life", 33.75),
            new Book("War and Peace", 30.55),
            new Book("The five love languages", 13.70),
            new Book("The Brothers Karamazov", 33.35),
            new Book("Wuthering Heights", 27.75),
            new Book("Little Women", 19.85),
            new Book("The Trial", 37.05),
            new Book("The Grapes of Wrath", 29.95),
            new Book("Great Expectations", 22.25),
            new Book("Dead Souls", 17.45),
            new Book("For Whom the Bells Tolls", 31.25),
            new Book("Vanity Fair", 22.95),
            new Book("The Old Man and the Sea", 29.65),
            new Book("The Tin Drum", 16.65),
            new Book("Les Miserables", 24.40),
            new Book("Wall Street Coyotes, part 1", 23.80),
            new Book("Wall Street Coyotes, part 2", 24.70),
            new Book("Wall Street Coyotes, part 3", 25.60),
            new Book("Fire and Fury", 30.00),
            new Book("The Woman in the Window", 21.20),
            new Book("A Higher Loyalty: Truth, Lies, and Leadership", 19.45),
        };

        public List<Book> BuyABook(List<string> keywords)
        {
            // create a new list 'matchingBooks' to store books that match given 'keyword'
            List<Book> matchingBooks = new List<Book>();
            foreach (string keyword in keywords)
            {
                matchingBooks.AddRange(books.Where(book => book.Title.ToLower().Contains(keyword.ToLower())));
            }

            // create a new list 'chosenBooks' to store books that has been selected to add to the shopping list
            List<Book> chosenBooks = new List<Book>();

            // the while loop keep repeat the shopping until you enter '0';
            while(matchingBooks.Count > 0)
            {
                Console.WriteLine("\nMatching books: ");
                for (int i = 0; i < matchingBooks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {matchingBooks[i].Title} (${matchingBooks[i].Price})");
                }

                Console.Write("\nEnter the number of the book you want to add to your shopping list (or type '0' to finish shopping): ");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > matchingBooks.Count)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and {0}.", matchingBooks.Count);
                }

                if (choice == 0)
                {
                    break;
                }

                chosenBooks.Add(matchingBooks[choice - 1]);
                matchingBooks.RemoveAt(choice - 1);
            }
            return chosenBooks;
        }
        public double CalcTotalPrice(List<Book> matchingBooks)
        {
            double totalPrice = 0;
            foreach (Book book in matchingBooks)
            {
                totalPrice += book.Price;
            }
            return totalPrice;
        }
    }
}
