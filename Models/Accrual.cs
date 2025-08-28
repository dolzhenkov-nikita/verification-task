using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VerificationTask.Models
{
    internal class Accrual
    {
        private double sumAccrual; 
        private ColdWaterSupply coldWaterSupply;
        private HotWaterSupply hotWaterSupply;
        private ElectricalEnergy electricalEnergy;

        public double CalculateSum()
        {
            return coldWaterSupply.Getresult()+hotWaterSupply.Result+electricalEnergy.Result;
        }
      
        public void ShowData(DataGridView dataGridViewShowResults)
        {
            /*
             * Статично вывожу данные 
             * */
            dataGridViewShowResults.Visible = true;
            dataGridViewShowResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewShowResults.ReadOnly = true;
            /*
             * Указываем количество столбцов и их подписи
             */
            dataGridViewShowResults.ColumnCount = 7;
            dataGridViewShowResults.Columns[0].Name = "Наименование услуги";
            dataGridViewShowResults.Columns[1].Name = "Тариф";
            dataGridViewShowResults.Columns[2].Name = "Норматив";
            dataGridViewShowResults.Columns[3].Name = "Количество человек первый период";
            dataGridViewShowResults.Columns[4].Name = "Количество человек второй период";
            dataGridViewShowResults.Columns[5].Name = "Показания";
            dataGridViewShowResults.Columns[6].Name = "Итого";

            /*
             * Вывожу данные по холодной воде
             */

            dataGridViewShowResults.Rows.Add();
            dataGridViewShowResults.Rows[0].Cells[0].Value="Холодная вода";
            dataGridViewShowResults.Rows[0].Cells[1].Value=this.coldWaterSupply.Gettariff();
            dataGridViewShowResults.Rows[0].Cells[2].Value=this.coldWaterSupply.Getnormativ();
            dataGridViewShowResults.Rows[0].Cells[3].Value=this.coldWaterSupply.GetCountPersonFirst();
            dataGridViewShowResults.Rows[0].Cells[4].Value=this.coldWaterSupply.GetCountPersonSecond();
            dataGridViewShowResults.Rows[0].Cells[5].Value=this.coldWaterSupply.Getindications();
            dataGridViewShowResults.Rows[0].Cells[6].Value=this.coldWaterSupply.Getresult();

            /*
             * Вывожу общие данные по горячей воде
              */
            dataGridViewShowResults.Rows.Add();
            dataGridViewShowResults.Rows[1].Cells[0].Value="Горячая вода";
            dataGridViewShowResults.Rows[1].Cells[3].Value=this.hotWaterSupply.CountPersonFirst;
            dataGridViewShowResults.Rows[1].Cells[4].Value=this.hotWaterSupply.CountPersonSecond;
            dataGridViewShowResults.Rows[1].Cells[5].Value=this.hotWaterSupply.Indications;
            dataGridViewShowResults.Rows[1].Cells[6].Value=this.hotWaterSupply.Result;

            dataGridViewShowResults.Rows.Add();
            dataGridViewShowResults.Rows[2].Cells[0].Value= "ГВС Теплоноситель";
            dataGridViewShowResults.Rows[2].Cells[1].Value=this.hotWaterSupply.TariffTN;
            dataGridViewShowResults.Rows[2].Cells[2].Value=this.hotWaterSupply.NormativTN;
            dataGridViewShowResults.Rows[2].Cells[4].Value=this.hotWaterSupply.Indications;
            dataGridViewShowResults.Rows[2].Cells[5].Value=this.hotWaterSupply.ResultTN;
            dataGridViewShowResults.Rows.Add();

            dataGridViewShowResults.Rows[3].Cells[0].Value= "ГВС Тепловая энергия";
            dataGridViewShowResults.Rows[3].Cells[1].Value = this.hotWaterSupply.TariffTE;
            dataGridViewShowResults.Rows[3].Cells[2].Value = this.hotWaterSupply.NormativTE;
            dataGridViewShowResults.Rows[3].Cells[4].Value = this.hotWaterSupply.Indications;
            dataGridViewShowResults.Rows[3].Cells[5].Value = this.hotWaterSupply.ResultTE;

            /*
             * Вывожу общие данные по электроэнергии
             */

            dataGridViewShowResults.Rows.Add();
            dataGridViewShowResults.Rows[4].Cells[0].Value="Электроэнергия";
            dataGridViewShowResults.Rows[4].Cells[1].Value=this.electricalEnergy.TariffDefault;
            dataGridViewShowResults.Rows[4].Cells[2].Value=this.electricalEnergy.Normativ;
            dataGridViewShowResults.Rows[4].Cells[3].Value=this.electricalEnergy.CountPersonFirst;
            dataGridViewShowResults.Rows[4].Cells[4].Value=this.electricalEnergy.CountPersonSecond;
            dataGridViewShowResults.Rows[4].Cells[5].Value=this.electricalEnergy.IndicationsDefault;
            dataGridViewShowResults.Rows[4].Cells[6].Value=this.electricalEnergy.Result;

            dataGridViewShowResults.Rows.Add();
            dataGridViewShowResults.Rows[5].Cells[0].Value="Электроэнергия день";
            dataGridViewShowResults.Rows[5].Cells[1].Value=this.electricalEnergy.TariffDay;
            dataGridViewShowResults.Rows[5].Cells[4].Value=this.electricalEnergy.IndicationsDay;
            dataGridViewShowResults.Rows[5].Cells[5].Value=this.electricalEnergy.ResultDay;

            dataGridViewShowResults.Rows.Add();
            dataGridViewShowResults.Rows[6].Cells[0].Value="Электроэнергия ночь";
            dataGridViewShowResults.Rows[6].Cells[1].Value=this.electricalEnergy.TariffNight;
            dataGridViewShowResults.Rows[6].Cells[4].Value=this.electricalEnergy.IndicationsNight;
            dataGridViewShowResults.Rows[6].Cells[5].Value=this.electricalEnergy.ResultNight;

            dataGridViewShowResults.Rows.Add();
            dataGridViewShowResults.Rows[7].Cells[0].Value = "ИТОГО";
            dataGridViewShowResults.Rows[7].Cells[5].Value = this.GetsumAccrual();



        }
        public ColdWaterSupply GetColdWaterSupply()
        {
            return coldWaterSupply;
        }

        public void SetColdWaterSupply(ColdWaterSupply value)
        {
            coldWaterSupply = value;
        }

        public HotWaterSupply GetHotWaterSupply()
        {
            return hotWaterSupply;
        }

        public void SetHotWaterSupply(HotWaterSupply value)
        {
            hotWaterSupply = value;
        }

        public ElectricalEnergy GetElectricalEnergy()
        {
            return electricalEnergy;
        }

        public void SetElectricalEnergy(ElectricalEnergy value)
        {
            electricalEnergy = value;
        }
        public double GetsumAccrual()
        {
            return sumAccrual;
        }
        public void SetsumAccrual(double value)
        {
            sumAccrual = value;
        }
    }
}
