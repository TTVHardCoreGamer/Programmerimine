namespace SwitchWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number 1, 2 või 3");

            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.Beep();
                    break;

                case 2:
                    Console.Beep();
                    Console.Beep();
                    break;

                case 3:
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    break;

                default:
                    Console.WriteLine("Vale number!");
                    break;
            }
        }
    }
}
