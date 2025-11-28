namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double coinDiameter = 25.75;
            double earthRadius = 6378100000;
            double aroundEarth = 2 * Math.PI * earthRadius;

            Console.WriteLine(aroundEarth);
            double howManyCoins = aroundEarth / coinDiameter;

            Console.WriteLine("Kahe eurosed läheb ümber maa {0:0}",howManyCoins);
        }
    }
}
