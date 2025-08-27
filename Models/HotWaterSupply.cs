using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerificationTask.Calculation;
using VerificationTask.Classes;
using static VerificationTask.Calculation.TariffEnums;

namespace VerificationTask.Models
{
    internal class HotWaterSupply
    {
        public double Result {  get; set; }
        public double TariffTN { get; set; }
        public double TariffTE { get; set; }
        public double NormativTN { get; set; }
        public double NormativTE { get; set; }
        public double VolumeTN { get; set; }
        public double VolumeTE { get; set; }
        public int CountPerson { get; set; }
        public int Indications { get; set; }

        /*
         * Расчет обьема потребления
         * */
        public double getVolume(int personCount, string indicationsForm)
        {
            double result = 0.0;
            double newIndications = 0;
            int indications = 0;
            double normative_tn = TariffEnums.getDoubleValueNormativEnum(TariffEnum.GBC_HEAR_CARRIER);
            double normative_te = TariffEnums.getDoubleValueNormativEnum(TariffEnum.GBC_THERMAL_ENERGY);

            if (indicationsForm.Length > 0)
            {
                indications = Convert.ToInt32(indicationsForm);
            }

            if (indications == 0)
            {
                VolumeTN = personCount * normative_tn;
                VolumeTE = VolumeTN * normative_te;
                result = VolumeTE;
            }
            else
            {
                double oldIndications = ConnectionSqlite.GetIndicationDataByWater("HotWater");
                newIndications = indications - oldIndications;
                VolumeTE = VolumeTN * normative_te;
                result = VolumeTE;

            }
            this.CountPerson=(personCount);
            this.NormativTN=(normative_tn);
            this.NormativTE=(normative_te);
            this.TariffTN=(TariffEnums.getDoubleValueTariffEnum(TariffEnum.GBC_HEAR_CARRIER));
            this.TariffTE=(TariffEnums.getDoubleValueTariffEnum(TariffEnum.GBC_THERMAL_ENERGY));
            this.Indications=(indications);

            return result;
        }
    }

}
