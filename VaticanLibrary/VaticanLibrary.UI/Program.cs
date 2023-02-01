// See https://aka.ms/new-console-template for more information

using VaticanLibrary.Core.BusinessLogic;
using VaticanLibrary.Core.Entities;
using VaticanLibrary.Core.Interfaces;
using VaticanLibrary.Core.Mock;

int id = 0;
IMainBusinessLogic business = new MainBusinessLogic(new MockBookRepository(), new MockUserRepository());

Console.WriteLine("--- BENVENUTO NELLA BIBLIOTECA VATICANA ---");
Console.WriteLine("Dove anche le pecorelle smarrite posso ritrovare il proprio gregge");
Console.WriteLine();
Console.WriteLine("1) Inserisci un libro nella tua biblioteca");
Console.WriteLine("2) Aggiorna le informazioni relative a un libro");
Console.WriteLine("3) Mostra le informazioni relative a un libro");
Console.WriteLine("4) Rimuovi un libro dalla biblioteca");
Console.WriteLine("5) Mostra tutti i libri registrati all'interno della biblioteca");
Console.WriteLine();
Console.WriteLine("6) Registra un nuovo fedele");
Console.WriteLine("7) Aggiorna le informazioni relative a un fedele");
Console.WriteLine("8) Mostra le informazioni relative a un fedele");
Console.WriteLine("9) Scomunica un utente");
Console.WriteLine();
Console.WriteLine("0) Andate in pace");
Console.WriteLine();

string choice = "1";

while (choice != "0")
{
    Console.WriteLine("choose your option");
    choice = Console.ReadLine();
    Console.WriteLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Insersci il titolo, l'autore e il genere del libro");
            string nome = Console.ReadLine(); string autore = Console.ReadLine(); string genere = Console.ReadLine();
            business.InsertBook(new Book(id++, nome, autore, genere));
            Console.WriteLine("New book added to the bookshelf");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            break;

        case "2":
            Console.WriteLine("case 2");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            break;

        case "3":
            Console.WriteLine("case 3");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            break;

        case "4":
            Console.WriteLine("case 4");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            break;

        case "5":
            var books= business.GetAllBooks();
            Console.WriteLine("Ecco i libri della bibloteca");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine();
            break;

        case "6":
            Console.WriteLine("case 6");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            break;

        case "7":
            Console.WriteLine("case 7");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            break;

        case "8":
            Console.WriteLine("case 8");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            break;

        case "0":
            break;

        default:
            Console.WriteLine("That choice doesn't exist");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            break;

    }
}
