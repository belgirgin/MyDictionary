using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> bolgeler = new Dictionary<string, string>();
            bolgeler.Add("Aegean Region", "Ege Bölgesi");
            bolgeler.Add("Central Anatolia Region", "İç Anadolu Bölgesi");
            bolgeler.Add("Southeast Anatolia Region", "Güneydoğu Anadolu Bölgesi");
            bolgeler.Add("East Anatolia Region", "Doğu Anadolu Bölgesi");
            bolgeler.Add("Black Sea Region", "Karadeniz Bölgesi");
            bolgeler.Add("Mediterranean Region", "Akdeniz Bölgesi");
            bolgeler.Add("Marmara Region", "Marmara Bölgesi");


            foreach (var bolge in bolgeler.Values)
            {
                Console.WriteLine(bolge);
            }
        }
    }
}