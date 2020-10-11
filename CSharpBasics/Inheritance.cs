using System;

public abstract class Shape
{
    public abstract double GetArea();

    public abstract double getCircumference();

    public virtual void PrintResults()
    {
        Console.WriteLine("asjkhajkshdkjas");
    }
}

interface IDiagonalComputabe
{
    public double GetDiagonal();
}



public class Rectangle : Shape, IDiagonalComputabe

{

    public Rectangle(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }
    public double Length { get; set; }
    public double Breadth { get; set; }

    public override double GetArea() => Length * Breadth;
    public override double getCircumference() => 2 * (Length * Breadth);

    public double GetDiagonal() => Math.Sqrt(Length * Length + Breadth * Breadth);


    public override void PrintResults()
    {
        Console.WriteLine($"Print Result for rectangle [{Length}x{Breadth}]:");
        Console.WriteLine($"Area:{this.GetArea()}");
        Console.WriteLine($"Area:{this.getCircumference()}");

    }


}
public class Square : Rectangle
{
    public Square(double side) : base(side, side)
    {

    }
}
public class Circle : Shape
{
    public double Radius { get; set; }

    public override double GetArea() => Math.PI * Radius * Radius;
    public override double getCircumference() => 2 * Math.PI * Radius;



}

class A
{

}
class B : A { }

class C : B { }

class D : A, IA, IB { }

interface IA
{

}
interface IB
{

}