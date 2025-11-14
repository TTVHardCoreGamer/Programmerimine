namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sisesta esimene number: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.Write("Vali tehe (+, -, *, /): ");
            string tehe = Console.ReadLine();

            Console.Write("Sisesta teine number: ");
            float num2 = float.Parse(Console.ReadLine());

            float tulemus = 0;

            switch (tehe)
            {
                case "+":
                    tulemus = num1 + num2;
                    break;
                
                case "-":
                    tulemus = num1 - num2;
                    break;
                
                case "*":
                    tulemus = num1 * num2;
                    break;
                
                case "/":
                    tulemus = num1 / num2;
                    break;
            }
            Console.WriteLine("Tulemus: " + tulemus);
        }
    }
}
