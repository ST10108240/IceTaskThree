namespace IceTaskThree
{
    internal interface ICalculateArea
    {
        
    class Circle : Shape, ICalculateArea
        {
            public double Radius { get; set; }
            public Circle(string name, double radius) : base(name)
            {
                Radius = radius;
            }
            public double CalculateArea()
            {
                double calculateC = Math.PI * (Radius * Radius);
                return calculateC;

            }

            public override void Display()
            {
                base.Display();
                Console.WriteLine($"Radius: {Radius}\nCalculated Area: {CalculateArea()}");
            }


        }
    }
}