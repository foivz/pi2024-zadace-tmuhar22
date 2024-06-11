using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_03.Models
{
    public class Reviews
    {
        public int Id { get; set; }
        public int IdMeni { get; set; }
        public string MenuName { get; set; }
        public int TasteGrade { get; set; }
        public int QuantityGrade { get; set; }
        public string Comment { get; set; }

        public DateTime DateOfReview { get; set; }


    }
}
