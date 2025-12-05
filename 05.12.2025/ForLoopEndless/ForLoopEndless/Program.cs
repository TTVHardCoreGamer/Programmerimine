namespace ForLoopEndless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ushort i = 1;

            for (; ; )
            {
                Console.WriteLine("i väärtus on " + i);
                i++;

                if (i > 10)
                {
                    break;
                }
            }
        }
    }
}

