using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> TalListe = new List<int> { 4, 7, 12, 17, -3, 8, 0, -45, 101 };
            List<int> L1 = new List<int>();
            List<int> L2 = new List<int>();
            List<int> L3 = new List<int>();

            foreach (var item in TalListe)
            {
                if (item <= 0) L1.Add(item);
            }
            foreach (var item in TalListe)
            {
                if (item == 7) L2.Add(item);
            }
            foreach (var item in TalListe)
            {
                if (item > 4) L3.Add(item);
            }
            Car C1 = new Car(1, "Rio", "Kia", 2006, 250000, "Red");
            Car C2 = new Car(2, "Rio","Kia",2007,265000, "Black");
            Car C3 = new Car(3, "Panda","Fiat",2017,265000, "Black");
            Car C4 = new Car(4, "Panda", "Fiat", 2017, 365000, "Yellow");
            Car C5 = new Car(5, "S40","Volvo",2018,665000, "White");
            Car C6 = new Car(6,"S65","Volvo",2018,600000,"White");
            Car C7 = new Car(7,"Gorm","Ferrari",2000,4665000,"White");
            Car C8 = new Car(8,"Gorm","Ferrari",2018,4665000,"White");
            List<Car> BilListe = new List<Car> { C1, C2, C3, C4, C5, C6, C7, C8 };
        }
    }
}
