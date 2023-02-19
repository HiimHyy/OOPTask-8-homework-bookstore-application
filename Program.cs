using OOPTask_8_homework_bookstore_application;
Bookstore bookstore = new Bookstore();
Console.WriteLine("Welcome to the bookstore");

while (true)
{
    Console.WriteLine("\nEnter one or more keywords to search for a book:");
    string input = Console.ReadLine();
    // this will split the 'input' string. The results store in the 'keyword' variable
    List<string> keywords = input.Split(' ').ToList();

    // this will search matching keywords
    List<Book> chosen = bookstore.BuyABook(keywords);

    if (chosen.Count == 0)
    {
        Console.WriteLine("No books found. Please try again.");
        continue;
    }
    Console.WriteLine("\nHere are the books that match your search:");
    // new variable 'book' refer to 'Book', loop iterates over 'chosen' list
    foreach (Book book in chosen)
    {
        Console.WriteLine("- " + book.Title + " ($" + book.Price + ")");
    }

    // new 
    double totalPrice = bookstore.CalcTotalPrice(chosen);
    Console.WriteLine("\nThe total price of your purchase is: $" + totalPrice);

    Console.Write("\nDo you want to search for another book? (Y/N): ");
    input = Console.ReadLine();
    if (input.ToLower() == "n")
    {
        break;
    }
    Console.WriteLine("Thank you for shopping with us");
}