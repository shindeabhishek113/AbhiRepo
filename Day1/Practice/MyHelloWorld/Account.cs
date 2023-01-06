namespace Banking;

public class Account{

     private String name;
    // private String city;
    private int balance;
    


    public Account (String name,int balance){
        this.name=name;
        this.balance=balance;
    }

    public String Name{
        get{return this.name;}
        set{this.name=value;}
    }

    // public String City{
    //     get{return this.city;}
    //     set{this.city=value;}
    // }

    public void SetBalance(int amount){
        this.balance=amount;
    }

    public int GetBalance(){
        return this.balance;   
    }


    public void Withdraw(int amt)
    {
        int initial_balance= this.GetBalance();
        int new_balance= initial_balance-amt;
        this.SetBalance(new_balance);
    }

    public void Deposit(int amt)
    {
        int initial_balance= this.GetBalance();
        int new_balance= initial_balance+amt;
        this.SetBalance(new_balance);

    }



   ~Account(){

   }

}