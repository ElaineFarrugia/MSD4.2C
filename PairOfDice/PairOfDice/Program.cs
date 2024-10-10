Random generator = new Random();

Console.WriteLine("Rolling first dice...");

Thread.Sleep(1000);
int dice1 = generator.Next(1, 7);
Console.WriteLine("Dice 1: "+dice1);

Console.WriteLine("Rolling second dice...");
Thread.Sleep(1000);
int dice2 = generator.Next(1, 7);
Console.WriteLine("Dice 2: " + dice2);

int total = dice1 + dice2;
Console.WriteLine("You got a total of: " + total);

if ((total == 7) || (total == 11))
    Console.WriteLine("You Win");
else if (total == 2)
    Console.WriteLine("Snake Eyes");
else
    Console.WriteLine("Try Again!");