using Drawing;

//Point
Point point1 = new Point(10,12);
Point point2 = new Point(12,14);

Console.WriteLine("\n\nPoint Object creation:");
Console.WriteLine("Point1:->"+point1);
Console.WriteLine("Point2:->"+point2);

//Line
Console.WriteLine("\n\nLine Object creation:");
Line line1 = new Line(point1,point2);
line1.Draw();


//Circle
Console.WriteLine("\n\nCircle Object creation:");
Circle circle1= new Circle();
circle1.Draw();

//Circle with parameters
Console.WriteLine("\nCircle Object creation with arguments:");
Circle circle2= new Circle(point1, 5);
circle2.Draw();


//Reactangle
Console.WriteLine("\n\nRectangle Object creation:");
Rectangle rectangle1= new Rectangle();
rectangle1.Draw();

//Rectangle with parameters
Console.WriteLine("\nReactangle Object creation with arguments:");
Rectangle rectangle2= new Rectangle(point1,point2);
rectangle2.Draw();

Console.WriteLine("\n");
