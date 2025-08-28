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

        private long id;
        private double result;
        private double tariff;
        private double normativ;
        private double volume;
        private int count_person_first;
        private int count_person_second;
        private double indications;

        /*
         * Расчет обьема потребления
         * */
        public double getVolume(Dictionary<int,int> personCount, string indicationsForm)
        {
            double result = 0.0;
            double newIndications = 0;
            double indications = 0;
            double normative = TariffEnums.getDoubleValueNormativEnum(TariffEnum.HBC);
            double oldIndications = ConnectionSqlite.GetIndicationDataByWater("ColdWater");

            if (indicationsForm.Length > 0)
            {
                indications =  Convert.ToDouble(indicationsForm);
            }
            if (indications == 0)
            {
                result = personCount[1] * normative+ personCount[2] * normative;
            }
            else
            {
                newIndications = indications - oldIndications;
                result = newIndications;
            }
            this.SetCountPersonFirst(personCount[1]);
            this.SetCountPersonSecond(personCount[2]);
            this.Setnormativ(normative);
            this.Settariff(TariffEnums.getDoubleValueTariffEnum(TariffEnum.HBC));
            this.Setvolume(result);
            this.Setindications(indications);

            return result;
        }
        public long GetId()
        {
            return id;
        }

        public void SetId(long value)
        {
            id = value;
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

        public int GetCountPersonFirst()
        {
            return count_person_first;
        }

        public void SetCountPersonFirst(int value)
        {
            count_person_first = value;
        }
        public int GetCountPersonSecond()
        {
            return count_person_second;
        }

        public void SetCountPersonSecond(int value)
        {
            count_person_second = value;
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
