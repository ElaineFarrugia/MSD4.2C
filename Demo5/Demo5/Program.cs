using System.Collections.Generic;

List<string> myList = new List<string>();
myList.Add("Mercury");
myList.Add("Venus");
myList.Add("Mars");
myList.Add("Jupiter");
myList.Add("Pluto");

foreach (string item in myList)
    Console.WriteLine(item);

Console.WriteLine("First item is: " + myList[0]);
Console.WriteLine("Number of items is: " + myList.Count);

int lastIndex = myList.Count - 1;
Console.WriteLine("Last item is: " + myList[lastIndex]);

Console.WriteLine("Adding Earth");
myList.Insert(2, "Earth");

foreach (string item in myList)
    Console.WriteLine(item);

Console.WriteLine("Removing Pluto");
myList.Remove("Pluto");     //remove by value
//OR
//myList.RemoveAt(myList.Count - 1); //remove by index

foreach (string item in myList)
    Console.WriteLine(item);

//change "Mars" to "Red Planet"
int indexOfMars = myList.IndexOf("Mars");
myList[indexOfMars] = "Red Planet";

foreach (string item in myList)
    Console.WriteLine(item);

Console.WriteLine("Checking if Moon is in the list");

if (myList.Contains("Moon"))
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");