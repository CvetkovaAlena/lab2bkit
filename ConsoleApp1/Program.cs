 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

 namespace lab2
 {
 class Program
 {
 static void Main(string[] args)
 {
 Rectangle rect = new Rectangle(5, 4);
 Square square = new Square(5);
 Round round = new Round(5);
 rect.Print();
 square.Print();
 round.Print();

 Console.ReadLine();
 }
 }

 abstract class Figure
 {
 public string Type { get; set; }
 public abstract double Area();
 }

 class Rectangle : Figure, IPrint
{

 private double _property1 = 0;
 public double height
 {
 get {
 return _property1;
 }
set {
_property1 = value;
 }
 }
 private double _property2 = 0;
 public double width
 {
 get
 {
 return _property2;
 }
 set
 {
 _property2 = value;
 }
 }

 public Rectangle(double w, double h)
{
    this.height = h; this.width = w; this.Type =
"Прямоугольник";
}
 public override double Area()
 {
 return (this.height* this.width);
 }
 public override string ToString()
 {
 return this.Type + " co сторонами (" + this.width + "; " + this.height + ") и площадью " +
this.Area().ToString();
 }
 public void Print()
 {
 Console.WriteLine(this.ToString());
 }
 }

 class Square : Rectangle, IPrint
{
 public Square(double w) : base(w, w) { this.Type = "Квадрат"; }
 public void Print()
 {
 Console.WriteLine(this.ToString());
 }
 }

 class Round : Figure, IPrint
 {
 private double _property1 = 0;
 public double radius
 {
 get
 {
 return _property1;
 }
 set
 {
 _property1 = value;
 }
 }

 public Round(double r) { this.radius = r; this.Type = "Окружность"; }

 public override double Area()
 {
return (3.14159265 * this.radius* this.radius);
 }
 public override string ToString()
 {
 return this.Type + " c радиусом (" + this.radius + ") и площадью " + this.Area().ToString();
 }
 public void Print()
 {
 Console.WriteLine(this.ToString());
 }
 }

 interface IPrint
{
void Print();
 }
}