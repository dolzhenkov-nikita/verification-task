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
        private ColdWaterSupply coldWaterSupply;
        private HotWaterSupply hotWaterSupply;
        private ElectricalEnergy electricalEnergy;

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
            dataGridViewShowResults.ColumnCount = 6;
            dataGridViewShowResults.Columns[0].Name = "Наименование услуги";
            dataGridViewShowResults.Columns[1].Name = "Тариф";
            dataGridViewShowResults.Columns[2].Name = "Норматив";
            dataGridViewShowResults.Columns[3].Name = "Количество человек";
            dataGridViewShowResults.Columns[4].Name = "Показания";
            dataGridViewShowResults.Columns[5].Name = "Итого";

            /*
             * Вывожу данные по холодной воде
             */

            dataGridViewShowResults.Rows.Add();
            dataGridViewShowResults.Rows[0].Cells[0].Value="Холодная вода";
            dataGridViewShowResults.Rows[0].Cells[1].Value=this.coldWaterSupply.Gettariff();
            dataGridViewShowResults.Rows[0].Cells[2].Value=this.coldWaterSupply.Getnormativ();
            dataGridViewShowResults.Rows[0].Cells[3].Value=this.coldWaterSupply.Getcount_person();
            dataGridViewShowResults.Rows[0].Cells[4].Value=this.coldWaterSupply.Getindications();
            dataGridViewShowResults.Rows[0].Cells[5].Value=this.coldWaterSupply.Getresult();

            /*
             * Вывожу общие данные по горячей воде
              */
            dataGridViewShowResults.Rows.Add();
            dataGridViewShowResults.Rows[1].Cells[0].Value="Горячая вода";
            dataGridViewShowResults.Rows[1].Cells[1].Value=this.hotWaterSupply.TariffTN;
            dataGridViewShowResults.Rows[1].Cells[2].Value=this.hotWaterSupply.NormativTE;
            dataGridViewShowResults.Rows[1].Cells[3].Value=this.hotWaterSupply.CountPerson;
            dataGridViewShowResults.Rows[1].Cells[4].Value=this.hotWaterSupply.Indications;
            dataGridViewShowResults.Rows[1].Cells[5].Value=this.hotWaterSupply.Result;

            /*
             * Вывожу общие данные по электроэнергии
             */

            dataGridViewShowResults.Rows.Add();
            dataGridViewShowResults.Rows[2].Cells[0].Value="Электроэнергия";
            dataGridViewShowResults.Rows[2].Cells[1].Value=this.electricalEnergy.TariffDefault;
            dataGridViewShowResults.Rows[2].Cells[2].Value=this.electricalEnergy.Normativ;
            dataGridViewShowResults.Rows[2].Cells[3].Value=this.electricalEnergy.CountPerson;
            dataGridViewShowResults.Rows[2].Cells[4].Value=this.electricalEnergy.IndicationsDefault;
            dataGridViewShowResults.Rows[2].Cells[5].Value=this.electricalEnergy.Result;

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
    }
}
