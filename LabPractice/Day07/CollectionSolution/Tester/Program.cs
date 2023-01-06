using System.Collections.Generic;
using WareHouse;
using TFLCollection;


List<Object> allObjects=new List<Object>();
allObjects.Add(12);
allObjects.Add("Ravi Tambade");
// allObjects.Add(true);
allObjects.Add(45.6);

List<Part> allParts=new List<Part>();

allObjects.Add(new { Id=23, Title="Jasmine", Description="Smelling flower"});
allParts.Add(new Part("crank arm",1234));

// allParts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
// allParts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
// allParts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
// allParts.Add(new Part() { PartName = "cassette", PartId = 1534 });
// allParts.Add(new Part() { PartName = "shift lever", PartId = 1634 });



foreach ( object  o in allObjects){
    Console.WriteLine(o);
}

foreach ( Part  part in allParts){
    Console.WriteLine(part);
}

Part p = new Part("Piston",1);
Part q = new Part("Clutch",2);
Console.WriteLine("p:"+p+"   "+"q"+q);
bool ans = p.PartId.Equals(q.PartId);
Console.WriteLine("Part Equals:-"+p.Equals(q));
Console.WriteLine(ans);

// Stack<Part>  assembly=new Stack<Part>();
// Queue<Part> container=new Queue<Part>();
// container.Enqueue(new Part() { PartName = "regular seat", PartId = 1434 });

Dictionary<int, Part> todaysSpareParts=new Dictionary<int, Part>();
todaysSpareParts.Add(1,new Part("crank arm",1234));
todaysSpareParts.Add(2,new Part("shift lever",1634)); 
todaysSpareParts.Add(3,new Part("shift lever",1634)); 
todaysSpareParts.Add(4,new Part("shift lever",1634)); 
todaysSpareParts.Add(5,new Part("shift lever",1634)); 


// foreach (Part thepart in todaysSpareParts){
//   key=todaysSpareParts.Values;
// Console.WriteLine("Part "+key);
// }
// foreach (var index in Enumerable.Range(3, 5))
//         {
//           Console.WriteLine("in Dictonary");
//             Console.WriteLine($"Part {index} is {todaysSpareParts[index].PartName} {todaysSpareParts[index].PartId}");
//         }

Dictionary<string, Part> todaysSpareParts1=new Dictionary<string, Part>();
todaysSpareParts1.Add("a",new Part("crank arm",1234));
todaysSpareParts1.Add("b",new Part("shift lever",1634)); 
todaysSpareParts1.Add("c",new Part("shift lever",1634)); 
todaysSpareParts1.Add("d",new Part("shift lever",1634)); 
todaysSpareParts1.Add("e",new Part("shift lever",1634)); 
foreach(KeyValuePair<string,Part> kvp in todaysSpareParts1)
{
  Console.WriteLine("\n\nin key value pair");
  Console.WriteLine(kvp.Key+",  "+kvp.Value);
}

// for(int i= 0;i<todaysSpareParts.Count(); i++){
// Console.WriteLine("Key:->"+todaysSpareParts);
// }



// Part thePart=todaysSpareParts["main"];




List<Employee> employees=new List<Employee>();
employees.Add(new Employee(1, "Raghu",30000));
employees.Add(new Employee(2, "Rajendra",67000));
employees.Add(new Employee(4, "Sham",20000));
employees.Add(new Employee(5, "Abhi",10000));
employees.Add(new Employee(9, "Abhis",25000));

Console.WriteLine("List of Employees before Sort");
foreach(Employee emp in employees){
    Console.WriteLine(emp.id + "--"+ emp.name + "--"+ emp.salary);
}


//Implement logic for Sorting
// EmpComparer ec = new EmpComparer();

// employees.Sort(ec);
employees.Sort(new EmpComparer());

Console.WriteLine("List of Employees after Sort");
foreach(Employee emp in employees){
    Console.WriteLine(emp.id + "--"+ emp.name + "--"+ emp.salary);
}





Player p1= new Player("Sourav Ganguly",50, 300, 50000);
Player p2= new Player("Sachin Tendulkar",49, 350, 100000);
Player p3= new Player("Rahul Dravid",48, 250, 70000);

List<Player> indianPlayers=new List<Player>();
indianPlayers.Add(p1);
indianPlayers.Add(p2);
indianPlayers.Add(p3);

// indianPlayers.Sort();

indianPlayers.Sort();


foreach( Player currentPlayer in indianPlayers){
  Console.WriteLine(currentPlayer);
}
