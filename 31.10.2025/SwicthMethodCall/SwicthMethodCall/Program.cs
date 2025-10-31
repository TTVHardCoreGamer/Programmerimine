namespace SwicthMethodCall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car coupe või truck");

            string input = Console.ReadLine();

            switch (input)
            {
                case "Car coupe":
                    CarCoupe();
                    break;

                case "Truck":
                    Truck();
                    break;

                default:
                    Console.WriteLine("ERROR!!!");
                    break;
            }
        }

        static void CarCoupe()
        {
            Console.WriteLine("Sa valisid car coupe");
        }
        static void Truck()
        {
            Console.WriteLine("Sa valisid truck");
        }
    }
}
