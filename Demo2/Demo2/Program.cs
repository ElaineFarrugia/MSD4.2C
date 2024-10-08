Console.WriteLine("Input theory mark:");
string theory = Console.ReadLine(); //read user input

Console.WriteLine("Input practical mark:");
string practical = Console.ReadLine();

int theoryInt = Convert.ToInt32(theory); //to int
int practicalInt = Convert.ToInt32(practical); //to int

int total = theoryInt + practicalInt; //calculate total

//3 conditions to pass. ALL of them need to be met
if ((theoryInt >= 50) && (practicalInt >= 50) && (total >= 125))
{
    Console.WriteLine("Congrats you passed!");
}
else
{
    Console.WriteLine("Better luck next time!");
}


