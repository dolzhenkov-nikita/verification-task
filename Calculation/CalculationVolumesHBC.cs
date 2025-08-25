using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerificationTask.Classes;
using static VerificationTask.Calculation.TariffEnums;

namespace VerificationTask.Calculation
{
    internal class CalculationVolumeHBC
    {
        public static double getVolumeHBC(int personCount=1,string counter= "0.0")
        {
            double counterHBC = 0.0;
            double result = 0.0;

            bool chekedText = CheckText.checkingTextForConverToDouble(counter);
            if (chekedText == true)
            {
               counterHBC = Convert.ToDouble(counter);
            }

            if (counterHBC == 0.0)
            {
                double normative = TariffEnums.getDoubleValueNormativEnum(TariffEnum.HBC);

                result = personCount * normative;
            }
                return result;
        }
    }
}
