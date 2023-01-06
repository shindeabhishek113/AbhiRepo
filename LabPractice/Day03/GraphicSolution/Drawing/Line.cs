namespace Drawing;


public class Line:Shape{

    public Point point1{get;set;}
    public Point point2{get;set;}

    public Line(){
        this.point1=new Point(0,0);
        this.point2=new Point(0,0);
    }

    public Line(Point pt1 , Point pt2){
        this.point1=pt1;
        this.point2=pt2;
    }

    public override  void Draw(){
        Type t = this.GetType();
        Console.WriteLine("Type:->"+t.Name);

        Console.WriteLine("Point1:"+point1+" "+"Point2:"+point2+" "+"Width:"+" "+this.width+" "+"Color"+" "+this.color);
    }


}