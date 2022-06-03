using System;

namespace oppervlakte_berekene
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area;
            Console.WriteLine("Geef de diameter van de cirkel");
            radius = Convert.ToDouble(Console.ReadLine());

            area = Math.PI * radius * radius;

            Console.WriteLine("oppervlakte van de cirkel met een radius van {0} = {1}", radius, area);

            Console.WriteLine("Sla op toetsenbord om te sluiten");
            _ = Console.ReadKey();
        }
    }
}
