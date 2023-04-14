
using BookWithInterface.App.Services.Implementations;

BookService BookService = new BookService();

Console.WriteLine("0. Close App");

Console.WriteLine("1. Create a Book");

Console.WriteLine("2.Show all Books");

string RequestNumber = Console.ReadLine();

while (RequestNumber != "0")
{
    switch (RequestNumber)
    {
        case "1":

            BookService.Create();
            break;

        case "2":

            BookService.ShowAll();
            break;

        default:

            Console.WriteLine("Please, select valid option");
            break;
    }

    Console.WriteLine("0. Close App");

    Console.WriteLine("1. Create a Book");

    Console.WriteLine("2.Show all Books");

    RequestNumber = Console.ReadLine();


}