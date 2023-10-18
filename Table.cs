using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoLiveLesson
{
    public abstract class Table : Furniture
    {
        public string Shape { get; }
        protected Table(string material, string color, int price, string shape) 
            : base(material, color, price)
        {
            Shape = shape;
        }
      
    }
}
