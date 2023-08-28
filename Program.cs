Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Guess The Door");
Console.WriteLine("  __________ ");
Console.WriteLine(" |  __  __  |");
Console.WriteLine(" | |  ||  | |");
Console.WriteLine(" | |  ||  | |");
Console.WriteLine(" | |__||__| |");
Console.WriteLine(" |  __  __()|");
Console.WriteLine(" | |  ||  | |");
Console.WriteLine(" | |  ||  | |");
Console.WriteLine(" | |__||__| |");
Console.WriteLine(" |__________|");
Console.WriteLine("             ");

Console.WriteLine("Choose the number:\n 1     2     3");

string userChoice = Console.ReadLine();
Random random = new Random();
int numberToGuess = random.Next(4);

if (userChoice == numberToGuess.ToString())
{
    Console.WriteLine("Your choice is correct!");
    userChoice = Console.ReadLine();
    numberToGuess = random.Next(4);

    if (userChoice == numberToGuess.ToString())
    {
        Console.WriteLine("Your choice is correct!");
        userChoice = Console.ReadLine();

        numberToGuess = random.Next(4);
        if (userChoice == numberToGuess.ToString())
        {
            Console.WriteLine("VICTORY!");
        }
        else
        {
            Console.WriteLine("GAME OVER");
            Console.WriteLine("Better luck next time");
        }
    }
    else
    {
        Console.WriteLine("GAME OVER");
    }
}
else
{
    Console.WriteLine("GAME OVER");
}


