using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificationTask.Models
{
    internal class HotWaterSupply
    {
        double result { get; set; }
        double tariff_tn { get; set; }
        double tariff_te { get; set; }
        double normativ_tn { get; set; }
        double normativ_te { get; set; }
        double volume_tn { get; set; }
        double volume_te { get; set; }
        int count_person { get; set; }
        double indications { get; set; }
    }
}
