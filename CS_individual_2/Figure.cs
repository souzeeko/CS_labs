using System;

namespace CS_individual_2
{
    public class Figure
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double SideLength { get; set; }
        
        public void Read()
        {
            Console.Write("input figure's name: ");
            Name = Console.ReadLine();
            Console.Write("input figure's height: ");
            Height = double.Parse(Console.ReadLine());
            Console.Write("input figure's side length: ");
            SideLength = double.Parse(Console.ReadLine());
        }
        
        public double Square()
        {
            return 3 * SideLength * (Math.Sqrt(3) * SideLength + 2 * Height);
        }
        
        public double Volume()
        {
            return (3 * Math.Pow(SideLength, 2) / 2) * Height * Math.Sqrt(3);
        }
        
        public void Print()
        {
            Console.WriteLine($"figure's name: {Name}");
            Console.WriteLine($"figure's square: {Square()}");
            Console.WriteLine($"figure's volume: {Volume()}");
        }

        public Figure(string Name, double Height, double SideLength)
        {
            this.Name = Name;
            this.Height = Height;
            this.SideLength = SideLength;

        }
        
        public Figure(): this(" ", 0, 0){}
    }
}