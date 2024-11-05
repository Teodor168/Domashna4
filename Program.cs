using System.Collections;
namespace Domashna4
{
    internal class Program
    {
        static ArrayList titles = new ArrayList();
        static ArrayList authors = new ArrayList();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Izberi opciq: ");
                Console.WriteLine("1-dobavqne na kniga");
                Console.WriteLine("2-premahvane na kniga po zaglavie");
                Console.WriteLine("3=tursene na kniga po zaglavie");
                Console.WriteLine("4-izvejdane na vsichki knigi");
                Console.WriteLine("5-krai");
                Console.Write("vashiqt izbor: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBook();
                        break;
                    case "2":
                        DeleteBook();
                        break;
                    case "3":
                        SearchBook();
                        break;
                    case "4":
                        DisplayAllBooks();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("nevaliden izbor");
                        Console.WriteLine();
                        break;
                }
            }
        }

        static void AddBook()
        {
            Console.Write("Zaglavie na knigata: ");
            titles.Add(Console.ReadLine());

            Console.Write("Avtora na knigata: ");
            authors.Add(Console.ReadLine());

            Console.WriteLine("Knigata e dobavena\n");

        }

        static void DeleteBook()
        {
            Console.Write("Zaglavie na kniga za premahvane: ");
            string title = Console.ReadLine();

            if (titles.Contains(title))
            {
                int index = titles.IndexOf(title);
                titles.RemoveAt(index);
                authors.RemoveAt(index);
                Console.WriteLine($"Knigata {title} e mahnata\n");
            }
            else
            {
                Console.WriteLine($"namq kiga: {title}\n");
            }
        }

        static void SearchBook()
        {
            Console.Write("Koq kniga tursish: ");
            string title = Console.ReadLine();

            for (int i = 0; i < titles.Count; i++)
            {
                if (((string)titles[i]) == title)
                {
                    Console.WriteLine($"Knigata {titles[i]} q ima v bibliotekata\n");
                    return;
                }                                                 
            }
            Console.WriteLine($"Knigata {title} q nqma v bibliotekata\n");
        }

        static void DisplayAllBooks()
        {
            Console.WriteLine("Vsichki knigi v bibliotekata:");
            for (int i = 0; i < titles.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Zaglavie: {titles[i]}  Avtor: {authors[i]}");
            }
            Console.WriteLine();
        }
    }
}