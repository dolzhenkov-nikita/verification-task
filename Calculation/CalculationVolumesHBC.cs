using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VerificationTask.Calculation.TariffEnums;

namespace VerificationTask.Calculation
{
    internal class CalculationVolumeHBC
    {
        public static double getVolumeHBC(int personCount=1,Double counter= 0.0)
        {
            double result = 0.0;
            if (counter==0.0)
            {
                double tariff = TariffEnums.getDoubleValueTariffEnum(TariffEnum.HBC);

                result = personCount * tariff;
            }
            return result;
        }
    }
}
