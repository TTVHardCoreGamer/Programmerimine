using System.Threading.Channels;

namespace ForKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Eelnevaid teadmisi kasutades kirjuta programm, mis väljastaks:
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll

            Console.WriteLine("Sisesta korduste arv");
            int arv = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arv; i++)
            {
                Console.WriteLine("see on rida nr {0}", i);
                //nüüd siia lisada kaks for loopi
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("kill-koll");
                }

                for (int k = 0; k < 1; k++)
                {
                    Console.WriteLine("killadi-koll");
                }
            }
            Console.WriteLine("kill-koll");
        }
    }
}
