using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cylinder
{
    private double Radius;
    private double Height;
    private double BaseArea;
    private double LateralArea;
    private double TotalArea;
    private double Volume;

    public Cylinder(double Radius, double Height)
    {
        this.Radius = Radius;
        this.Height = Height;
    }

    public double radius
    {
        get { return Radius; }
        set { Radius = value; }
    }

    public double height
    {
        get { return Height; }
        set { Height = value; }
    }

    public void Process()
    {
        BaseArea = radius * radius * Math.PI;
        LateralArea = 2 * Math.PI * radius * height;
        TotalArea = 2 * Math.PI * radius * (height + radius);
        Volume = Math.PI * radius * radius * height;

        Result(BaseArea, LateralArea, TotalArea, Volume); 
    }

    public void Result(double BaseArea, double LateralArea, double TotalArea, double Volume)
    {
        Console.WriteLine();
        Console.WriteLine("Cylinder Characteristics");
        Console.WriteLine("Radius: " + radius + ",  Height: " + height);
        Console.WriteLine("Base: " + BaseArea + " | Lateral: " + LateralArea + " | Total: " + TotalArea + " | Volume: " + Volume);
    }
 
}

namespace GeometryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dimensions of the cylinder");
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Cylinder cylinder = new Cylinder(radius, height);

            cylinder.Process();

            Console.ReadLine();
        }
    }
}