// See https://aka.ms/new-console-template for more information

using VaticanLibrary.Core.BusinessLogic;

Console.WriteLine("Choose your option");
Console.WriteLine();
Console.WriteLine("1) Insert a new book into the bookshelf");
Console.WriteLine("2) Update a book informations");
Console.WriteLine("3) Show Book's informations");
Console.WriteLine("4) Remove a book from the bookshelf");
Console.WriteLine();
Console.WriteLine("5) Register a new user");
Console.WriteLine("6) Update a user's informations");
Console.WriteLine("7) Show user's informations");
Console.WriteLine("8) Remove registration of a user");
Console.WriteLine();
Console.WriteLine("0) Exit the program");
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
            Console.WriteLine("case 5");
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
