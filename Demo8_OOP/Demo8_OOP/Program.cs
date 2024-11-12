using Demo8_OOP;

BankAccount account1 = new BankAccount();
account1.AccNum = "1";
account1.HolderName = "Sam";
account1.Pin = "1234";
account1.Balance = 500;


BankAccount account2 = new BankAccount();
account2.AccNum = "2";
account2.HolderName = "Mary";
account2.Pin = "5678";
account2.Balance = 1000;

Console.WriteLine(account1.GetData());
Console.WriteLine(account2.GetData());

account1.Deposit(200);
Console.WriteLine("After deposit:");
Console.WriteLine(account1.GetData());

bool result = account1.Withdraw(200);
if (result == true)
    Console.WriteLine("Withdraw accepted.");
else
    Console.WriteLine("Not enough funds!");

Console.WriteLine(account1.GetData());

BankAccount account3 = new BankAccount("3","Mick","3456",300);