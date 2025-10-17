namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Genereerib numbreid ühest kuni kuueni");
            
            Random rnd = new Random();
            int number = rnd.Next(1, 7);  
            
            switch (number)
            {
               
                case 1:
                    Console.WriteLine("Number on 1");
                    break;
               
                case 2:
                    Console.WriteLine("Number on 2");
                    break;
                
                case 3:
                    Console.WriteLine("Number on 3");
                    break;
               
                case 4:
                    Console.WriteLine("Number on 4");
                    break;
                
                case 5:
                    Console.WriteLine("Number on 5");
                    break;
               
                case 6:
                    Console.WriteLine("Number on 6");
                    break;
               
                default:
                    Console.WriteLine("Midagi läks valesti");
                    break;
            }
        }
    }
}
