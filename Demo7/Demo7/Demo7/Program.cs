List<int> marks = new List<int> ();

while (true)
{
    Console.Write("Enter mark: ");
    string inputStr = Console.ReadLine ();
    int mark = Convert.ToInt32(inputStr);

    if (mark == -1)
    {
        //PrintMarks(marks);
        break;
    }

    marks.Add(mark);
}
PrintMarks(marks);

Console.WriteLine("Average: "+CalculateAverage(marks));
//OR
float average = CalculateAverage(marks);
Console.WriteLine("Average: " + average);

foreach (int mark in marks)
    Console.WriteLine(ConvertToGrade(mark));

void PrintMarks(List<int> studentmarks)
{
    foreach (int mark in studentmarks)
        Console.WriteLine(mark);
}

float CalculateAverage(List<int> studentmarks)
{
    int sum = 0;
    foreach (int mark in studentmarks)
        sum += mark;

    float avg = sum / studentmarks.Count;
    return avg;
}

float ConvertToGrade(int mark)
{
    if (mark >= 90)
        return 'A';
    else if (mark >= 80)
        return 'B';
    else if (mark >= 70)
        return 'C';
    else if (mark >= 60)
        return 'D';
    else
        return 'U';

}
