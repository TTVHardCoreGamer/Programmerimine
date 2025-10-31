namespace SwitchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 10:
                    Console.WriteLine("Sisestasid numbri 10");
                    break;

                case 20:
                    Console.WriteLine("Sisestasid numbri 20");
                    break;

                case 30:
                    Console.WriteLine("Sisestasid numbri 30");
                    break;

                default:
                    Console.WriteLine("Tundmatu number!");
                    break;
            }
        }
    }
}
