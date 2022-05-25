using System;

namespace PenktaUzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> raide;
            char raide2;

            raide = NuskaitoLista();
            Console.WriteLine("Išvestos raidės:");
            IsvestiListaForEach(raide);
            Console.WriteLine("Ieškoma raidė:");
            raide2 = NuskaitytiRaide();
            Console.WriteLine("Išvesta ieškoma raidė:");
            Console.WriteLine(raide2);
            Console.WriteLine("Ar liste yra ieškoma raidė?");
            Console.WriteLine(ArEgzistuojaRaide(raide2, raide));
            
            


            

        }
        static List<char> NuskaitoLista()
        {
            int kiekis;
            Console.WriteLine("Kiekis:");
            kiekis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nuskaitomos raidės:");
            

            List<char> listas = new List<char>();
            for (int i = 0; i < kiekis; i++)
            {
                listas.Add(Convert.ToChar(Console.ReadLine()));
            }
            return listas;
        }
        static void IsvestiListaForEach(List<char> listas)
        {
            foreach (char elementas in listas)
            {
                Console.WriteLine(elementas);

            }
           

        }
        static char NuskaitytiRaide()
        {
            char x;
            x = Convert.ToChar(Console.ReadLine());
            return x;
        }
        static bool ArEgzistuojaRaide(char ieskomRaide, List<char> raidziuListas)
        {
            bool rezultatas = false;

            for (int i = 0; i < raidziuListas.Count; i++)
            {
                if (raidziuListas[i] == ieskomRaide)
                { 
                    rezultatas =  true;
                }
            }
            return  rezultatas ;
        }

    } 
}