Console.WriteLine("Enter your name and surname");
string fullName = Console.ReadLine();

int indexOfSpace = fullName.IndexOf(' ');

if (indexOfSpace == -1)
    Console.WriteLine("No space found!");
else
{
    char firstInitial = fullName[0];
    char surnameInitial = fullName[indexOfSpace+1];

    Console.WriteLine("Initials: " +
        firstInitial + "." + surnameInitial + ".");

    string name = fullName.Substring(0, indexOfSpace);
    string surname = fullName.Substring(indexOfSpace+1);

    Console.WriteLine("Name Only: " + name);
    Console.WriteLine("Surname Only: " + surname);

    Console.WriteLine("Your name has "+name.Length
                                     +" letters");
}
