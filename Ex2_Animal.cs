using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Animal
{
    protected string name;
    protected double weight;

    public void SetMe(string name, double weight)
    {
        this.name = name;
        this.weight = weight;
    }

    public virtual void Show()
    {
        Console.WriteLine("Name: " + name + ", Weight: " + weight + "\n");
    }
}
class Lion : Animal
{
    public Lion(string name, double weight)
    {
        SetMe(name, weight);
    }

    public override void Show()
    {
        Console.WriteLine("Name: " + name + ", Weight: " + weight);
    }
    
}

class Tiger : Animal
{
    public Tiger(string name, double weight)
    {
        SetMe(name, weight);
    }

    public override void Show()
    {
        Console.WriteLine("Name: " + name + ", Weight: " + weight);
    }

}

namespace AnimalExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion("Lion", 200);
            Tiger tiger = new Tiger("Tiger", 100);

            lion.Show();
            tiger.Show();
        }
    }
}