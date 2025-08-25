using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VerificationTask.Calculation.TariffEnums;

namespace VerificationTask.Calculation
{
    internal class CalculationAccrual
    {
        public static double getCost(Double volume, TariffEnum tariffEnums)
        {
            /*
             * result – Начисления за коммунальную услугу
             * volume – Объем потребления услуги
             * tariff – Тариф TariffEnums. 
             */

            double tariff = TariffEnums.getDoubleValueTariffEnum(tariffEnums);

            double result = volume * tariff;

            return result;
        }
    }
}
