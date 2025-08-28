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
        public int Id {  get; set; }
        public double Result {  get; set; }
        public double ResultTN {  get; set; }
        public double ResultTE {  get; set; }
        public double TariffTN { get; set; }
        public double TariffTE { get; set; }
        public double NormativTN { get; set; }
        public double NormativTE { get; set; }
        public double VolumeTN { get; set; }
        public double VolumeTE { get; set; }
        public int CountPersonFirst { get; set; }
        public int CountPersonSecond { get; set; }
        public double Indications { get; set; }

        /*
         * Расчет обьема потребления
         * */
        public double getVolumeTE()
        {
            double normative_te = TariffEnums.getDoubleValueNormativEnum(TariffEnum.GBC_THERMAL_ENERGY);

            VolumeTE = VolumeTN * normative_te;

            this.NormativTE=(normative_te);
            this.TariffTE=(TariffEnums.getDoubleValueTariffEnum(TariffEnum.GBC_THERMAL_ENERGY));

            return VolumeTE;
        }
        public double getVolumeTN(Dictionary<int,int> personCount, string indicationsForm)
        {
            double result = 0.0;
            double newIndications = 0.0;
            double indications = 0.0;
            double normative_tn = TariffEnums.getDoubleValueNormativEnum(TariffEnum.GBC_HEAR_CARRIER);

            if (indicationsForm.Length > 0)
            {
                indications = Convert.ToDouble(indicationsForm);
            }

            if (indications == 0.0)
            {
                VolumeTN = personCount[1] * normative_tn+ personCount[2] * normative_tn;
            }
            else
            {
                double oldIndications = ConnectionSqlite.GetIndicationDataByWater("HotWater");
                newIndications = indications - oldIndications;
                VolumeTN = newIndications;

            }
            this.CountPersonFirst = (personCount[1]);
            this.CountPersonSecond = (personCount[2]);
            this.NormativTN=(normative_tn);
            this.TariffTN=(TariffEnums.getDoubleValueTariffEnum(TariffEnum.GBC_HEAR_CARRIER));
            this.Indications=(indications);

            return VolumeTN;
        }
    }

}
