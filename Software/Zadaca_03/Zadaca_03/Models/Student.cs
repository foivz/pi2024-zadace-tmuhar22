using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_03.Models
{
    public class Student : Person
    {
        public int OrderNumber { get; set; }
        public int Review { get; set; }
        public string Komentar { get; set; }

    }
}
