namespace TFLCollection;
using System.Collections;
using System.Collections.Generic;

public class Player:IComparable<Player> {
    private string name;
    private int runs;
    private int matches;
    private int age;

    public Player(string name, int age, int matches, int runs){
        this.name=name;
        this.age=age;
        this.matches=matches;
        this.runs=runs;
    }

    // public int CompareTo(object? obj)
    // {
    //     Player anotherPlayer=(Player) obj;

    //     if(this.runs > anotherPlayer.runs){
    //         return 1;
    //     }
    //     else if (this.runs < anotherPlayer.runs){
    //         return -1;
    //     }
    //     else
    //     return 0;

    // }

     // override object.Equals
    public override bool Equals(object obj)
    {
        //
        // See the full list of guidelines at
        //   http://go.microsoft.com/fwlink/?LinkID=85237
        // and also the guidance for operator== at
        //   http://go.microsoft.com/fwlink/?LinkId=85238
        //
        
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        
        
        // TODO: write your implementation of Equals() here
        throw new System.NotImplementedException();
        return base.Equals (obj);
    }

    // public bool Equals(Object anotherPlayer) {
	// 	Console.WriteLine("in vehicle's equals");
	// 	if (anotherPlayer as Player)
    //     {
    //         return this.runs.Equals(((Player) anotherPlayer).runs);
    //     }
			
	// 	// => not a vehicle

	// 	return false;
	// }
    
    // override object.GetHashCode
    public override int GetHashCode()
    {
        // TODO: write your implementation of GetHashCode() here
        throw new System.NotImplementedException();
        return base.GetHashCode();
    }
    public int CompareTo(Player anotherplayer){
        Console.WriteLine("in Player Comapare To");
        return this.runs.CompareTo(anotherplayer.runs);
    }

    public override string ToString(){
        return "name"+" "+name+" "+"age"+age+" "+"matches"+matches+"runs"+runs;
    }

}
