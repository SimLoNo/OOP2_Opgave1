using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Opgave1
{
    class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public string Colour { get; set; }


        public Car(int id, string model, string brand, int year, int price, string colour) 
        {
            Id = id;
            Model = model;
            Brand = brand;
            Year = year;
            Price = price;
            Colour = colour;
        }


    }
}
