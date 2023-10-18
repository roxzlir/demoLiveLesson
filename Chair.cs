using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoLiveLesson
{
    public abstract class Chair : Furniture
    {
        public bool Armrest { get; set; }

        protected Chair(string material, string color, int price, bool armrest=false) 
            : base(material, color, price)
        {
            Armrest = armrest;
        }
    }
}
