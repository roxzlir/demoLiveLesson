using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoLiveLesson
{
    public class OfficeChair : Chair
    {
        public bool IsErgonomic { get; }

        public override string Type => "Kontorsstol";

        public OfficeChair(string material, string color, int price, bool armrest, bool isErgonomic=true) 
            : base(material, color, price, armrest)
        {
            IsErgonomic = isErgonomic;
        }

        public override void PrintUniqeFurnitureInfo()
        {
            Console.WriteLine($"Är den ergonimisk: {IsErgonomic}\nHar den armstöd: {Armrest}");
        }
    }
}
