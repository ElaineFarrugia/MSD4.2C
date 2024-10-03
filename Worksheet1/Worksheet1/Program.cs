string sequence = "hdgTG45"; //create sequence

Console.WriteLine("Remember this: "+sequence); //output sequence
Thread.Sleep(5000);//delay

Console.Clear();

Console.WriteLine("Enter the sequence: ");
string userInput = Console.ReadLine();

if (sequence == userInput)
    Console.WriteLine("You guessed!");
else
    Console.WriteLine("You did not guess");


