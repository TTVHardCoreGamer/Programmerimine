using System.Runtime.InteropServices;

namespace ArrayString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Euroopa üks pealinnadest on ";
            Console.WriteLine("Tuple");

            //näide 1
            var cities = Tuple.Create("Tallinn", "Pariis", "Rooma", "London", "Helsingi");
            //tuple all on viis erinevat väärtust ja sellepärast saab antud
            //juhul 5 itemit sisestada
            Console.WriteLine(sentence + cities.Item5);
            Console.WriteLine("------------------------------------");

            //näide 2
            string[] city = { "Tallinn", "Pariis", "Rooma", "London", "Helsingi" };
            for (int i = 0; i < city.Length; i++)
            {
                Console.WriteLine(sentence + city[i]);
            }
            Console.WriteLine("------------------------------------");

            //näide 3
            Console.WriteLine(sentence + city[2]);
            Console.WriteLine("------------------------------------");

            //näide 4
            Random number = new Random();
            int randomNumber = number.Next(0, 5);
            Console.WriteLine(sentence + city[randomNumber]);
            Console.WriteLine("------------------------------------");
        }
    }
}
