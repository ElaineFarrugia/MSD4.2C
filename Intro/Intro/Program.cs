int generatedNumber; //variable declaration

Random generator = new Random();//preparing generator
generatedNumber = generator.Next(1,11); //get random no. 1-10

Console.WriteLine(generatedNumber); //print generated number

Console.WriteLine("I selected a number 1-10. Can you guess it?");

string userInput = Console.ReadLine(); //get user input

int userInputInt = Convert.ToInt32(userInput); //convert str to int

if (userInputInt == generatedNumber)    //checking if user guessed
    Console.WriteLine("You guessed!");
else                                    //otherwise
    Console.WriteLine("You did not guess");