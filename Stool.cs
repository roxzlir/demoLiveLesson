using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoLiveLesson
{
    public class Stool : Chair
    {
        public bool HasFootrest { get; }

        public override string Type => "Pall";

        public Stool(string material, string color,int price,bool hasFootrest) 
            : base(material, color, price)
        {
            HasFootrest = hasFootrest;
        }

        public override void PrintUniqeFurnitureInfo()
        {
            Console.WriteLine($"Har den fotstöd: {HasFootrest}\nHar den armstöd: {Armrest}");
        }
    }
}
