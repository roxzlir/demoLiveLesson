using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoLiveLesson
{
    public class BedsideTable : Table
    {
        public bool HasDrawers { get; }

        public override string Type => "Sängbord";

        public BedsideTable(string material, string color, int price, string shape, bool hasDrawers) 
            : base(material, color, price, shape)
        {
            HasDrawers = hasDrawers;
        }

        public override void PrintUniqeFurnitureInfo()
        {
            Console.WriteLine($"Vilken form: {Shape}\nHar den lådor: {HasDrawers}");
        }
    }
}
