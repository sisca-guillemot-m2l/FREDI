using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fredi
{
    public class Slip
    {
        public string SlipDate { get; set; }
        public string SlipPattern { get; set; }
        public string SlipPath { get; set; }
        public int SlipKilometers { get; set; }
        public decimal PathCost { get; set; }
        public decimal TollCost { get; set; }
        public decimal MealCost { get; set; }
        public decimal AccommodationCost { get; set; }
        public decimal TotalCost { get; set; }
    }
}
