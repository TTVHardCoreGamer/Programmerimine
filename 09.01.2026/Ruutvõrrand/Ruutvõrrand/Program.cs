namespace Ruutvõrrand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ruutvõrrand!");

            //ax2 + bx + c 

            //sisesta a, b ja c väärtus
            //kasutaja peab saama sisestada neid väärtuseid

            Console.Write("Sisesta a v''rtus: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Sisesta b v''rtus: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Sisesta c v''rtus: ");
            double c = double.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;

            Console.WriteLine($"x1 = {(-b + Math.Sqrt(d)) / (2 * a)}, x2 = {(-b + Math.Sqrt(d)) / (2 * a)}");
        }
    }
}