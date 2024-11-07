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
