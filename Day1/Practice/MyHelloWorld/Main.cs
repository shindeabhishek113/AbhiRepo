using Banking;


Console.WriteLine("\nGet name & balance operation: ");
Account acct = new Account("Abhisehk",2000);
String name=acct.Name;
int amount=acct.GetBalance();
Console.WriteLine("Account Deatils: "+name+" "+amount);



Console.WriteLine("\nSet name operation: ");
Account acct3 = new Account("Abhisehk",2000);
Console.WriteLine(acct3.Name);
 acct3.Name="Abh";
 Console.WriteLine("name: "+acct3.Name);



Console.WriteLine("\nAnonymous class operation: ");
var person = new{
    FirstName="Abhishek",
    LastName="Shinde"
};

Console.WriteLine(person.FirstName+" "+person.LastName);

Console.WriteLine("\nDeposit operation: ");
Account acct1=new Account("Abhi",5000);
acct1.Deposit(2000);
int newbalance=acct1.GetBalance();
Console.WriteLine(newbalance);


Console.WriteLine("\nWithdraw operation: ");
acct1.Withdraw(1000);
int newbalance1=acct1.GetBalance();
Console.WriteLine(newbalance1);



List<Account> act= new List<Account>();
act.Add(acct);
act.Add(acct1);
act.Add(acct3);









