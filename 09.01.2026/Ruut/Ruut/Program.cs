namespace Ruut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //teha for loopiga ruut

            Console.Write("Sisesta ruudu suurus: ");
            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)       
            {
                for (int j = 0; j < size; j++)   
                {
                    Console.Write("* ");
                }
                Console.WriteLine(); 
            }

            //kui suurus on sisestatud, siis kuvab meile ka ümbermõõdu ja pindala
            int area = size * size;
            int around = 4 * size;
            Console.WriteLine("Pindala on " + area);
            Console.WriteLine("Ümbermõõt on " + around);
        }
    }
}
