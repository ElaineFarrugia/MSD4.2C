using System.Collections.Generic;

List<string> names = new List<string>();

string input;

while (true)
{
    Console.WriteLine("Enter a name: ");
    input = Console.ReadLine();

    if (input == "stop")
        break;

    names.Add(input);   
}

foreach (string name in names)
    Console.WriteLine(name);


Random generator = new Random();
int rand  = generator.Next(0, names.Count);

Console.WriteLine("The lucky winner is: " + names[rand]);