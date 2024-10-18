Random generator = new Random();

do
{
    int rand = generator.Next(1, 4);

    char computerChoice;

    if (rand == 1)
        computerChoice = 'r';
    else if (rand == 2)
        computerChoice = 'p';
    else
        computerChoice = 's';

    Console.WriteLine("The computer chose " + computerChoice);

    Console.WriteLine("Choose rock (r), paper (p) or scissors (s)");

    char userInput = Console.ReadKey().KeyChar;

    if (userInput == computerChoice)
        Console.WriteLine("It's a tie!");
    else if ((userInput == 's' && computerChoice == 'p')
            || (userInput == 'r' && computerChoice == 's')
            || (userInput == 'p' && computerChoice == 'r'))
        Console.WriteLine("You Win!");
    else
        Console.WriteLine("You Lose");

    Console.WriteLine("Would you like to play again? (y/n)");
    char playAgain = Console.ReadKey().KeyChar;

    if (playAgain == 'n')
        break;

} while (true);