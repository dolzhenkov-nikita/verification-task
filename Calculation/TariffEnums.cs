using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificationTask.Calculation
{
    internal class TariffEnums
    {
        public enum TariffEnum
        {
            HBC,
            EE_DEFAULT,
            EE_DAY,
            EE_NIGHT,
            GBC_HEAR_CARRIER,
            GBC_THERMAL_ENERGY,
        }
        /*
         * Так как Enum работает только с целочисленными типами, создаю функцию
         * которая вернет тариф по enum
         */
        public static double getDoubleValueTariffEnum(TariffEnum tariffEnum)
        {
            switch (tariffEnum)
            {
                case TariffEnum.HBC: return 35.78;
                case TariffEnum.EE_DEFAULT: return 4.28;
                case TariffEnum.EE_DAY: return 4.9;
                case TariffEnum.EE_NIGHT: return 2.31;
                case TariffEnum.GBC_HEAR_CARRIER: return 35.78;
                case TariffEnum.GBC_THERMAL_ENERGY: return 998.69;
                default: return 0.0;
            }
        }
        public static double getDoubleValueNormativEnum(TariffEnum tariffEnum)
        {
            switch (tariffEnum)
            {
                case TariffEnum.HBC: return 4.85;
                case TariffEnum.EE_DEFAULT: return 164;
                case TariffEnum.EE_DAY: return 0;
                case TariffEnum.EE_NIGHT: return 0;
                case TariffEnum.GBC_HEAR_CARRIER: return 4.01;
                case TariffEnum.GBC_THERMAL_ENERGY: return 0.05349;
                default: return 0.0;
            }
        }
    }
}



