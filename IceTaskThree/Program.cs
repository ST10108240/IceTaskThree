using System.Security.Cryptography.X509Certificates;
using static IceTaskThree.iInterface1;

namespace IceTaskThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle("Rectangle", 5, 10);
            rectangle.Display();

            Console.WriteLine(" The rea is : ");

            Circle circle = new Circle("Circle", 7);
            circle.Display();
        }
    }
}


