

bool runProgram = true;
while (runProgram)
{
    //les bruker input
    Console.WriteLine("Do you want to lend or return? for exit write exit");
    string? userInput = Console.ReadLine();


    if (userInput == "lend")
    {
        Console.WriteLine("Lending a book");
    }

    else if (userInput == "return")
    {
        Console.WriteLine("Returning a book");
    }
    else if (userInput == "exit")
    {
        runProgram = false;
    }
}