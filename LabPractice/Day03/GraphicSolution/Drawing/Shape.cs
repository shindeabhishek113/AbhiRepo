namespace Drawing;

public enum Color{red,blue,orange,yellow};

public abstract class Shape{


protected int width {get;set;}
protected Color color {get;set;}

public abstract void Draw();

}