Console.WriteLine("What number do you want to countdown from?");

string numStr = Console.ReadLine();
int num = Convert.ToInt32(numStr);

for(int i = num; i >= 0; i--)
{
    Console.WriteLine(i);
    Thread.Sleep(1000);
}
//OR
for (int i = 0; i < num; i++)
{
    Console.WriteLine(num-i);
    Thread.Sleep(1000);
}
