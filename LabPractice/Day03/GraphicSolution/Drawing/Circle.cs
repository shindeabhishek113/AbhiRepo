namespace Drawing;

public class Circle:Shape{

    public Point Centre{get; set;}
    public int Radius{get; set;}


    public Circle(){
        this.Centre= new Point(0,0);
        this.Radius= 1;

    }

    public Circle(Point c, int r){
        this.Centre=c;
        this.Radius=r;
    }

    public override void Draw(){

        Type t= this.GetType();

        Console.WriteLine("Type t= "+ t.Name);
        Console.WriteLine(this.Centre+ ", radius: "+ this.Radius+ ", Width= "+ this.width+ ", Color: "+ this.color);


    }

}