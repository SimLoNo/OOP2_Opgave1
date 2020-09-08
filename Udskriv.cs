using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Opgave1
{
    class Udskriv
    {
        static public void UdskrivListe(List<int> Liste, List<Car> BilListe) 
        {
            foreach (var item in Liste)
            {
                Console.WriteLine(item);
            }

            foreach (var item in BilListe)
            {
                if (item.Model == "Rio") Console.WriteLine(item);
                else if (item.Brand == "Ferrari") Console.WriteLine(item);
                else if (item.Year >= 2010) Console.WriteLine(item);
                else if (item.Colour == "White") Console.WriteLine(item);
                else if (item.Id == 8) Console.WriteLine(item);
            }
        }
    }
}
