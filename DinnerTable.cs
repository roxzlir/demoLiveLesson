using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoLiveLesson
{
    public class DinnerTable : Table
    {

        public int PlateSpaces { get; }

        public override string Type => "Matbord";

        public DinnerTable(string material, string color, int price, string shape, int plateSpaces) 
            : base(material, color, price, shape)
        {
            PlateSpaces = plateSpaces;
        }

        public override void PrintUniqeFurnitureInfo()
        {
            Console.WriteLine($"Vilken form: {Shape}\nAntal platser: {PlateSpaces}");
        }
    }
}
