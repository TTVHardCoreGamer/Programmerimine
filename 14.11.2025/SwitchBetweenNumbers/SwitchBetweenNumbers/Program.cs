namespace SwitchBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case int n when (n >= 0 && n <= 100):
                    Console.WriteLine("Arv on vahemikus 0-100");
                    break;
                
                case int n when (n >= 101 && n <= 200):
                    Console.WriteLine("Arv on vahemikus 101-200");
                    break;

                case int n when (n >= 201 && n <= 300):
                    Console.WriteLine("Arv on vahemikus 201-300");
                    break;

                default:
                    Console.WriteLine("Arv ei ole vahemikus 0-300");
                    break;
            }
        }
    }
}
