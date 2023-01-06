using Membership;
using HR;


Console.WriteLine("\nEnter Email ID");
String email = Console.ReadLine();

Console.WriteLine("\nEnter Password");
String password = Console.ReadLine();

Console.WriteLine("\n");

if(AuthManager.Validate(email,password)){
    Console.WriteLine("***************Welcome***************\n");
    Employee emp = new Employee(101,"Heisnberg","Texas",123456789, new DateTime(1995, 01, 06));
    Console.WriteLine(emp+"\n");
}else{
    Console.WriteLine("Invalid User");
}

SalesEmployee semp = new SalesEmployee(101,"Abhishek","Pune",20000,
                    new DateTime(1997,03,10),10000,12000);

Console.WriteLine(semp);

