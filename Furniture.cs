using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoLiveLesson
{
    public abstract class Furniture
    {
        public string Material { get; }
        public string Color { get; }
        public abstract string Type { get; }
        
        public int Price { get; set; }
        public Furniture(string material, string color, int price)
        {
            Material = material;
            Color = color;
            Price = price;
        }
        public void PrintBasicInfo()
        {
            Console.WriteLine($"Typ: {Type}\nGjord av: {Material}\nFärg: {Color}\nPris: {Price}");
        }
        public abstract void PrintUniqeFurnitureInfo();

    }
}
