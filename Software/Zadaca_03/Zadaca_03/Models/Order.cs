using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zadaca_03.Models
{
    public class Activity
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public string OrderDescription { get; set; }
        public int MaxGrade { get; set; }
        public int MinGrade { get; set; }

        public override string ToString()
        {
            return OrderName;
        }


    }
}
