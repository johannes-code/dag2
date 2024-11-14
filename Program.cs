
using System.Formats.Asn1;
using System.Runtime.InteropServices;

Library library = new Library();

library.AddNewBook(new Book("Martian", "Jane Doe", new DateTime(2004, 08, 10)));
library.AddNewBook(new Book("The Quantum Toaster", "Zack Neutron", new DateTime(2019, 03, 15)));
library.AddNewBook(new Book("Ninja Accountants", "Sumi Ledger", new DateTime(2018, 11, 22)));
library.AddNewBook(new Book("Dinosaurs in Space", "Rex Stardust", new DateTime(2020, 07, 01)));
library.AddNewBook(new Book("The Procrastinator's Guide to Time Travel", "Lazy Einstein", new DateTime(2022, 12, 31)));
library.AddNewBook(new Book("Zombie Etiquette", "Brains Manners", new DateTime(2017, 10, 31)));
library.AddNewBook(new Book("Cooking with Lava", "Magma Chef", new DateTime(2021, 05, 18)));
library.AddNewBook(new Book("The Invisible Man's Fashion Tips", "See-Through Stylist", new DateTime(2016, 02, 29)));
library.AddNewBook(new Book("Intergalactic Food Truck Wars", "Nebula Noms", new DateTime(2023, 08, 08)));
library.AddNewBook(new Book("Underwater Disco Dancing", "Coral Grooves", new DateTime(2015, 06, 15)));
library.AddNewBook(new Book("Telekinetic Knitting", "Psychic Purls", new DateTime(2020, 11, 11)));
library.AddNewBook(new Book("The Art of Dragon Dentistry", "Fang Floss", new DateTime(2019, 04, 01)));
library.AddNewBook(new Book("Extreme Ironing on Mount Everest", "Press Summit", new DateTime(2018, 05, 29)));
library.AddNewBook(new Book("Alien's Guide to Human Mating Rituals", "Zorp Confused", new DateTime(2022, 02, 14)));
library.AddNewBook(new Book("Breakdancing for Seniors", "Hip Pop", new DateTime(2017, 09, 21)));
library.AddNewBook(new Book("Vampire Veganism", "Count Carrot", new DateTime(2021, 10, 13)));
library.AddNewBook(new Book("Pirate Programming: Coding on the High Seas", "Captain JavaScript", new DateTime(2020, 09, 19)));
library.AddNewBook(new Book("Yeti Yoga", "Stretch Snowman", new DateTime(2016, 12, 01)));
library.AddNewBook(new Book("The Introvert's Guide to World Domination", "Quiet Overlord", new DateTime(2023, 01, 01)));
library.AddNewBook(new Book("Unicorn Rodeo: Taming Mythical Beasts", "Rainbow Lasso", new DateTime(2019, 07, 04)));
library.AddNewBook(new Book("Time-Traveling Barber: Haircuts Through History", "Scissor Chronos", new DateTime(2022, 06, 06)));


// Håndter bruker input
bool runProgram = true;
while (runProgram)
{
    // les av bruker input
    Console.WriteLine("Do you want to lend or return?");
    string? userInput = Console.ReadLine();

    // Vi må finne hva bruker skrev inn

    // List ut tilgjengelige bøker
    if (userInput == "list")
    {
        Console.WriteLine("Here are available books:");
        List<Book> availableBooks = library.ListAvailableBooks();

        foreach (var book in availableBooks)
        {
            Console.WriteLine(book.Title);
        }
    }
    // For å låne en bok (lend)
    else if (userInput == "lend")
    {
        Console.WriteLine("What is the title of the book?");
        string? wantedBookTitle = Console.ReadLine();

        if (wantedBookTitle == null)
        {
            continue; // Start hoved løkken på nytt
        }

        Book? book = library.LendBook(wantedBookTitle);

        // Det kan hend biblioteket ikke hadde boken vår
        if (book == null)
        {
            Console.WriteLine("No book with title found: " + wantedBookTitle);
        }
        else
        {
            Console.WriteLine("Lending book: " + book.Title);
        }
    }
    // For å lever tilbake en bok (return)
    else if (userInput == "return")
    {
        Console.WriteLine("Returning a book");
    }
    // For å avslutte (exit)
    else if (userInput == "exit")
    {
        runProgram = false;
    }
}