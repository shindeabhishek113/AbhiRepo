namespace Drawing;

public class Rectangle: Shape{

    public Point point1{get; set;}
    public Point point2{get; set;}

    public Rectangle()
    {
        this.point1=new Point(0,0);
        this.point2=new Point(0,0);
    }


    public Rectangle(Point pt1, Point pt2)
    {
        this.point1=pt1;
        this.point2=pt2;
    }

    public override void Draw()
    {
        Type t= this.GetType();
        Console.WriteLine("Type t= "+t.Name);
        Console.WriteLine(this.point1 +" "+ this.point2 +" "+ this.width +" "+ this.color);

    }

}