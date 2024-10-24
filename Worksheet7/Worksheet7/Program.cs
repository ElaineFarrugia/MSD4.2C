using System.Collections.Generic;

List<int> lottoNumbers = new List<int>();
List<int> userNumbers = new List<int>();

do
{
    Console.WriteLine("Enter lotto number:");
    string input = Console.ReadLine();

    try
    {
        int inputNum = Convert.ToInt32(input);
        /*
        if ((inputNum > 0) && (inputNum < 91) 
                && (!lottoNumbers.Contains(inputNum)))
        {
            lottoNumbers.Add(inputNum);
        }
        else
        {
            Console.WriteLine("Invalid Number");
        }*/

        if ((inputNum < 0) || (inputNum > 90)
                        || lottoNumbers.Contains(inputNum))
        {
            Console.WriteLine("Invalid Number");
        }
        else
        {
            lottoNumbers.Add(inputNum);
        }
    }
    catch
    {
        Console.WriteLine("Please input a number.");
    }
}while(lottoNumbers.Count < 5);

Console.WriteLine("The prima number is: " + lottoNumbers[0]);
Console.WriteLine("Now Enter Your Numbers:");

do
{
    Console.WriteLine("Enter lotto number:");
    string input = Console.ReadLine();

    try
    {
        int inputNum = Convert.ToInt32(input);
        /*
        if ((inputNum > 0) && (inputNum < 91) 
                && (!lottoNumbers.Contains(inputNum)))
        {
            lottoNumbers.Add(inputNum);
        }
        else
        {
            Console.WriteLine("Invalid Number");
        }*/

        if ((inputNum < 0) || (inputNum > 90)
                        || userNumbers.Contains(inputNum))
        {
            Console.WriteLine("Invalid Number");
        }
        else
        {
            userNumbers.Add(inputNum);
        }
    }
    catch
    {
        Console.WriteLine("Please input a number.");
    }
} while (userNumbers.Count < 5);


int matching = 0;
foreach (int number in userNumbers)
{
    if (lottoNumbers.Contains(number))
        matching++;
}

Console.WriteLine("You have " + matching + " matching numbers");