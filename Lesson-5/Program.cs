using System.Collections;
namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList booksList = new ArrayList() { "book1", "book2", "book3" };
            ArrayList authors = new ArrayList() { "author1", "author2", "author3" };
            ArrayList price = new ArrayList() { };
            Hashtable quantities = new Hashtable();

            Console.WriteLine("Select an option");
            Console.WriteLine("1. Add a new book");
            Console.WriteLine("2. Remove a book");
            Console.WriteLine("3. Update quantity");
            Console.WriteLine("4. Calculate total value");
            Console.WriteLine("5. Show all books");
            Console.WriteLine("6. Exit");

            int x = 0;
            while (x < 6)
            {
                Console.Write("Select: ");
                int selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        


                        AddBook(booksList, authors, price);

                        break;

                    case 2:
                        RemoveBook(booksList);

                        break;

                    case 3:
                        Console.WriteLine("?????");

                        break;

                    case 4:
                        CalcTotalValue(price);
                        break;

                    case 5:
                        foreach (string item in booksList)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case 6:
                        x = 6;
                        Console.WriteLine("bye bye");
                        break;

                    default:
                        Console.WriteLine("not foun");
                        break;

                }








            }
            static void AddBook(ArrayList bookslist, ArrayList authors, ArrayList price)
            {
                Console.Write("Enter  title");
                string title = Console.ReadLine();

                Console.Write("Enter the author");
                string author = Console.ReadLine();

                Console.Write("Enter the price ");
                double priceOfBook = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{title} added to Stock");

                bookslist.Add(title);
                authors.Add(author);
                price.Add(priceOfBook);

            }

            static void RemoveBook(ArrayList bookslist)
            {
                Console.Write("Enter the book to remove: ");
                string removeBook = Console.ReadLine();

                if (bookslist.Contains(removeBook))
                {
                    bookslist.Remove(removeBook);
                    Console.WriteLine($"{removeBook} removed from the Stock");
                }
                else
                {
                    Console.WriteLine($"{removeBook} not found");
                }

            }


            static void CalcTotalValue(ArrayList price)
            {
                double value = 0.00;
                foreach (double item in price)
                {
                    value += item;
                }

                Console.WriteLine($"Total: {value}");
            }


        }

    }

}