using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificationTask.Models
{
    internal class ElectricalEnergy
    {
        double result { get; set; }
        double tariff_default { get; set; }
        double tariff_day { get; set; }
        double tariff_night { get; set; }
        double normativ_tn { get; set; }
        double volume { get; set; }
        double volume_day { get; set; }
        double volume_night { get; set; }
        int count_person { get; set; }
        double indications_default { get; set; }
        double indications_day { get; set; }
        double indications_night { get; set; }
    }
}
