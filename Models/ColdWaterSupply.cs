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
        private double indications;

        public double getVolume(int personCount = 1, string counter = "0.0")
        {
            double counterHBC = 0.0;
            double result = 0.0;
            double normative = TariffEnums.getDoubleValueNormativEnum(TariffEnum.HBC);

            bool chekedText = CheckText.checkingTextForConverToDouble(counter);
            if (chekedText == true)
            {
                counterHBC = Convert.ToDouble(counter);
            }

            if (counterHBC == 0.0)
            {
                result = personCount * normative;
            }
            else
            {
                double oldCounter = ConnectionSqlite.GetIndicationDataByColdWater();
                result = counterHBC - oldCounter;

            }
            this.Setcount_person(personCount);
            this.Setnormativ(normative);
            this.Settariff(TariffEnums.getDoubleValueTariffEnum(TariffEnum.HBC));
            this.Setvolume(result);

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

        public double Getindications()
        {
            return indications;
        }

        public void Setindications(double value)
        {
            indications = value;
        }
    }
}
