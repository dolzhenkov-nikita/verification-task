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
    internal class ElectricalEnergy
    {
       public int Id { get; set; }
       public double Result { get; set; }
       public double ResultDay { get; set; }
       public double ResultNight { get; set; }
       public double TariffDefault { get; set; }
       public double TariffDay { get; set; }
       public double TariffNight { get; set; }
       public double Normativ { get; set; }
       public double Volume { get; set; }
       public double VolumeDay { get; set; }
       public double VolumeNight { get; set; }
       public int CountPerson { get; set; }
       public double IndicationsDefault { get; set; }
       public double IndicationsDay { get; set; }
       public double IndicationsNight { get; set; }

        /*
         * Расчитываем опату электроэнергии
         * */
        public void getResult(int personCount, string indicationsFormDay, string indicationsFormNight)
        {

            double indications = 0.0;
            double indications_day = 0.0;
            double indicationsNight = 0.0;
            /*
             * Проверяе и ковентрируем показания за день и ночь
             */
            if (indicationsFormDay.Length > 0)
            {
                indications = Convert.ToDouble(indicationsFormDay);
                indications_day = indications;
            }

            if (indicationsFormNight.Length > 0)
            {
                indicationsNight = Convert.ToDouble(indicationsFormNight);
            }

            /*
             * Получем нормативы общий, дневной и ночной
             * */
            Normativ = TariffEnums.getDoubleValueNormativEnum(TariffEnum.EE_DEFAULT);
            double normative_day = TariffEnums.getDoubleValueNormativEnum(TariffEnum.EE_DAY);
            double normative_night = TariffEnums.getDoubleValueNormativEnum(TariffEnum.EE_NIGHT);

            /*
             *  Если есть показания за ночь, то есть и за день
             *  тогда расчитываем оплату за день и ночь и их сумму
             */
            if (indicationsNight != 0.0)
            {
                double oldIndicationDay = ConnectionSqlite.GetIndicationDataByFieldNameAndTableName("ElectricalEnergy","indications_day");
                double oldIndicationNight = ConnectionSqlite.GetIndicationDataByFieldNameAndTableName("ElectricalEnergy", "indications_night");
                
                VolumeDay = indications - oldIndicationDay;
                VolumeNight = indicationsNight - oldIndicationNight;
                Volume = VolumeDay + VolumeNight;


                ResultDay = CalculationAccrual.getCost(VolumeDay, TariffEnum.EE_DAY);
                ResultNight = CalculationAccrual.getCost(VolumeNight, TariffEnum.EE_NIGHT);
                Result = ResultDay + ResultNight;

                IndicationsDay = indications;
                IndicationsNight = indicationsNight;
                IndicationsDefault = IndicationsDay+IndicationsNight;
            }
            /*
             *  Если есть показания за день, но нет за ночь
             *  тогда расчитываем оплату за день по тарифу?
             */
            else if (indications != 0.0 && indicationsNight == 0.0)
            {
                double oldIndication = ConnectionSqlite.GetIndicationDataByFieldNameAndTableName("ElectricalEnergy", "indications_default");

                Volume = indications - oldIndication;
                Result = CalculationAccrual.getCost(Volume, TariffEnum.EE_DEFAULT);
            }

            /*
             * Если нет показаний то расчитываем формулу без показанйи
             */
            else if (indications == 0.0 && indicationsNight == 0.0)
            {
                double oldIndication = ConnectionSqlite.GetIndicationDataByFieldNameAndTableName("ElectricalEnergy", "indications_default");

                Volume = personCount * Normativ;
                Result = CalculationAccrual.getCost(Volume, TariffEnum.EE_DEFAULT);
            }

            this.CountPerson = (personCount);
            this.TariffDefault = (TariffEnums.getDoubleValueTariffEnum(TariffEnum.EE_DEFAULT));
            this.TariffDay = (TariffEnums.getDoubleValueTariffEnum(TariffEnum.EE_DAY));
            this.TariffNight = (TariffEnums.getDoubleValueTariffEnum(TariffEnum.EE_NIGHT));

        }
    }
}
