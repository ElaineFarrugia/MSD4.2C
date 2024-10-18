using System;

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine("hello "+i);
}

/*
Console.WriteLine("Till what number do you want to print?");
string inputStr = Console.ReadLine();
int input = Convert.ToInt32(inputStr);

for (int i = 1; i <= input; i++)
{
    Console.WriteLine("hello " + i);
}*/

Console.WriteLine("Multiplication table of which number?");
string inputStr = Console.ReadLine();
int input = Convert.ToInt32(inputStr);

for (int i = 1; i <= 10; i++)
{
    int result = input * i;
    Console.WriteLine(input + " * " + i + " = " + result);
    //OR
    Console.WriteLine($"{input} * {i} = {result}");
}
