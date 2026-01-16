namespace MethodCallTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saad valida meetodi, kui sisestad numbri");
            Console.WriteLine("1. UpsideDownPyramid");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. QuadraticFormula");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    UpsideDownPyramid();
                    break;

                case "2":
                    Rectangle();
                    break;

                case "3":
                    QuadraticFormula();
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;

        static void UpsideDownPyramid()
        {
                        Console.WriteLine("Sisesta suurus: ");

                        int i, j, n;
                        n = Convert.ToInt32(Console.ReadLine());

                        for (i = n - 1; i >= 1; i--)
                        {
                            for (j = 1; j <= n - i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (j = 1; j <= 2 * i - 1; j++)
                            {
                                Console.Write("*");
                            }
                            Console.Write('\n');
                        }
                    }

        static void Rectangle()
        {
                        Console.WriteLine("Sisesta pikkus");
                        int row = int.Parse(Console.ReadLine());
                        Console.WriteLine("Sisesta laius");
                        int col = int.Parse(Console.ReadLine());

                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }

                        int area = row * col;
                        int around = 2 * (row + col);

                        Console.WriteLine("Pindala on " + area);
                        Console.WriteLine("Ümbermõõt on " + around);
                    }

        static void QuadraticFormula()
        {
                        Console.Write("Sisesta a väärtus: ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("Sisesta b väärtus: ");
                        double b = double.Parse(Console.ReadLine());

                        Console.Write("Sisesta c väärtus: ");
                        double c = double.Parse(Console.ReadLine());

                        double d = b * b - 4 * a * c;

                        Console.WriteLine($"x1 = {(-b + Math.Sqrt(d)) / (2 * a)}, x2 = {(-b + Math.Sqrt(d)) / (2 * a)}");
                }
            }
        }
    }
}
    

