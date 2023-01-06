namespace HR;
public abstract class Employee
{

    public int Empid{get;set;}
    public String Name{get;set;}
    public String City{get;set;}
    public double Salary{get;set;}
    public DateTime Dob{get;set;}


    public Employee(int empid,String name,String city,double salary,DateTime dob){
        this.Empid=empid;
        this.Name=name;
        this.City=city;
        this.Salary=salary;
        this.Dob=dob;
    }



    public abstract void Dowork();
    public override String ToString(){
        return Empid+" "+Name+" "+City+" "+Salary+" "+Dob;
    }


}
