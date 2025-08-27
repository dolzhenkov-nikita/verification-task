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
    internal class ColdWaterSupply
    {
        private double result;
        private double tariff;
        private double normativ;
        private double volume;
        private int count_person;
        private int indications;

        public double getVolume(int personCount, string indicationsForm)
        {
            double result = 0.0;
            double newIndications = 0;
            int indications = 0;
            double normative = TariffEnums.getDoubleValueNormativEnum(TariffEnum.HBC);

            if (indicationsForm.Length > 0)
            {
                indications = Convert.ToInt32(indicationsForm);
            }
            if (indications == 0)
            {
                result = personCount * normative;
            }
            else
            {
                double oldIndications = ConnectionSqlite.GetIndicationDataByWater("ColdWater");
                newIndications = indications - oldIndications;
                result = newIndications;

            }
            this.Setcount_person(personCount);
            this.Setnormativ(normative);
            this.Settariff(TariffEnums.getDoubleValueTariffEnum(TariffEnum.HBC));
            this.Setvolume(result);
            this.Setindications(indications);

            return result;
        }

        public double Getresult()
        {
            return result;
        }

        public void Setresult(double value)
        {
            result = value;
        }

        public double Gettariff()
        {
            return tariff;
        }

        public void Settariff(double value)
        {
            tariff = value;
        }

        public double Getnormativ()
        {
            return normativ;
        }

        public void Setnormativ(double value)
        {
            normativ = value;
        }

        public double Getvolume()
        {
            return volume;
        }

        public void Setvolume(double value)
        {
            volume = value;
        }

        public int Getcount_person()
        {
            return count_person;
        }

        public void Setcount_person(int value)
        {
            count_person = value;
        }

        public int Getindications()
        {
            return indications;
        }

        public void Setindications(int value)
        {
            indications = value;
        }
    }
}
