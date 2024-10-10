Console.WriteLine("Enter a name for your character:");
string name = Console.ReadLine();

Console.WriteLine("You have a total of 10 points to allocate.");

Console.WriteLine("Strength:");
string strength = Console.ReadLine();
int strengthInt = Convert.ToInt32(strength);

Console.WriteLine("Agility:");
string agility = Console.ReadLine();
int agilityInt = Convert.ToInt32(agility);

Console.WriteLine("Intelligence:");
string intelligence = Console.ReadLine();
int intelligenceInt = Convert.ToInt32(intelligence);

int total = strengthInt + agilityInt + intelligenceInt;

//METHOD 1
if ((total == 10) && (strengthInt > 0) && (agilityInt > 0) && (intelligenceInt > 0))
{
    Console.WriteLine("Character successfully created!");
    Console.WriteLine("Name: " + name);
    Console.WriteLine("Strength: " + strengthInt);
    Console.WriteLine("Agility: " + agilityInt);
    Console.WriteLine("Intelligence: " + intelligenceInt);
}
else
{
    Console.WriteLine("Problem while creating character.");
}

//METHOD 2
if ((total != 10) || (strengthInt == 0) || (agilityInt == 0) || (intelligenceInt == 0))
{
    Console.WriteLine("Problem while creating character.");
}
else
{
    Console.WriteLine("Character successfully created!");
    Console.WriteLine("Name: " + name);
    Console.WriteLine("Strength: " + strengthInt);
    Console.WriteLine("Agility: " + agilityInt);
    Console.WriteLine("Intelligence: " + intelligenceInt);
}