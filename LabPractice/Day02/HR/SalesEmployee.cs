namespace HR;
public class SalesEmployee:Employee{

    public int Target{get;set;}
    public int SalesDone{get;set}
    public int Incentive{get;set;}

    public SalesEmployee():base(){
        this.Target=0;
        this.SalesDone=0;
        this.Incentive=0;
    }

    public SalesEmployee(int empid,String name,String city,double salary,
                        DateTime dob,int target,int salesdone,
                        ):base(empid,name,city,salary,dob,target,salesdone){
        
        this.Target=target;
        this.SalesDone=salesdone;
        this.Incentive=incentive;
    }

    public override void DoWork(){
        if(SalesDone>=Target){
            this.Incentive=5000;
        }else{
            this.Incentive=0;
        }
    }

    public override String ToString(){
        return base.ToString+" "+"SalesDone:"+" "+SalesDone+"Incentive:"+" "+Incentive;
    }
}