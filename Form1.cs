using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text.RegularExpressions;
using VerificationTask.Calculation;
using VerificationTask.Classes;
using VerificationTask.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static VerificationTask.Calculation.TariffEnums;

namespace VerificationTask
{
    public partial class FormCalculator : Form
    {
        Accrual accrual = new Accrual();

        public FormCalculator()
        {
            InitializeComponent();
        }

        private void buttonCalculateHBC_Click(object sender, EventArgs e)
        {
            /*
             * Минимальное количество человек 1
             * Если с формы пришли данные, то конвертируем в целое число
             */

            int personCount = 1;
            if (textBoxCountPerson.Text.Length > 0)
            {
                personCount = Convert.ToInt32(textBoxCountPerson.Text);
            }

            /*
             * Создаем экземпляр начислений, для связывания расчетов показаний
            */


            /*
             * Создаем экземпляры для расчетов холодной и горячей воды
             * и электричества
             */

            ColdWaterSupply coldWater = new ColdWaterSupply();
            HotWaterSupply hotWater = new HotWaterSupply();
            ElectricalEnergy electricalEnergy = new ElectricalEnergy();

            /*
             * Расчитываем обьем потребления холодной и горячей воды
             */

            double volumeColdWater = coldWater.getVolume(personCount, indicationsForm: textBoxCounterHBC.Text.ToString());
            double volumeHotWater = hotWater.getVolume(personCount, indicationsForm: textBoxCounterGBC.Text.ToString());
            electricalEnergy.getResult(personCount,
                                            indicationsFormDay: textBoxCounterEE.Text.ToString(),
                                            indicationsFormNight: textBoxCounterEENight.Text.ToString());

            /*
           * Расчитываем размер оплыт холодной и горячей воды
           */

            double utilitiesColdWaterSum = CalculationAccrual.getCost(volumeColdWater, TariffEnum.HBC);
            double utilitiesHotWaterSum = CalculationAccrual.getCost(volumeColdWater, TariffEnum.GBC_THERMAL_ENERGY);

            /*
             * Сохраняем полученные результаты в экзмпляры
             */

            coldWater.Setresult(utilitiesColdWaterSum);
            hotWater.Result = (utilitiesHotWaterSum);


            /*
             * Сохранение в начисления
             */

            accrual.SetColdWaterSupply(coldWater);
            accrual.SetHotWaterSupply(hotWater);
            accrual.SetElectricalEnergy(electricalEnergy);
            accrual.ShowData(dataGridViewShowResults);

        }


        private void textBoxCounterHBC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back) return;
            else
                e.Handled = true;
        }

        private void textBoxCountPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back) return;
            else
                e.Handled = true;
        }
        static SQLiteConnection connection;
        static SQLiteCommand command;
        static public bool Connect()
        {
            try
            {
                connection = new SQLiteConnection("Data Source=E:\\Projects\\VerificationTask\\utilites.db;Version=3; FailIfMissing=False");
                connection.Open();
                return true;
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"Ошибка доступа к базе данных. Исключение: {ex.Message}");
                return false;
            }
        }
        private void FormCalculator_Load(object sender, EventArgs e)
        {

            //if (Connect())
            //{
            //    command = new SQLiteCommand(connection)
            //    {
            //        CommandText = "CREATE TABLE IF NOT EXISTS [Accrual]([id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE," +
            //        " [result] REAL NOT NULL," +
            //        " [cold_water_id] INTEGER  NOT NULL, " +
            //        " [hot_water_id] INTEGER NOT NULL," +
            //        " [electical_id] INTEGER NOT NULL," +
            //        " FOREIGN KEY (cold_water_id) REFERENCES ColdWater(id)," +
            //        " FOREIGN KEY (hot_water_id) REFERENCES HotWater(id)," +
            //        " FOREIGN KEY (electical_id) REFERENCES ElectricalEnergy(id)" +
            //        ");"
            //CommandText = "CREATE TABLE IF NOT EXISTS [HotWater]([id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE," +
            //" [result] REAL NOT NULL," +
            //" [tariff_tn] REAL ," +
            //" [tariff_te] REAL ," +
            //" [normativ_tn] REAL ," +
            //" [normativ_te] REAL ," +
            //" [volume_tn] REAL NOT NULL ," +
            //" [volume_te] REAL NOT NULL ," +
            //" [count_person] INTEGER NOT NULL ," +
            //" [indications] INTEGER NOT NULL);"
            //CommandText = "CREATE TABLE IF NOT EXISTS [ElecticalEnergy]([id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE," +
            //" [result] REAL NOT NULL," +
            //" [result_day] REAL NOT NULL," +
            //" [result_night ] REAL NOT NULL," +
            //" [tariff_default] REAL ," +
            //" [tariff_day] REAL ," +
            //" [tariff_night] REAL ," +
            //" [normativ] REAL ," +
            //" [volume] REAL NOT NULL ," +
            //" [volume_day] REAL NOT NULL ," +
            //" [volume_night] REAL NOT NULL ," +
            //" [count_person] INTEGER NOT NULL ," +
            //" [indications_default] INTEGER NOT NULL ," +
            //" [indications_day] INTEGER NOT NULL ," +
            //" [indications_night] INTEGER NOT NULL);"
            //CommandText = "CREATE TABLE IF NOT EXISTS [ColdWater]([id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE," +
            //" [result] REAL NOT NULL," +
            //" [tariff] REAL ," +
            //" [normativ] REAL ," +
            //" [volume] REAL NOT NULL ," +
            //" [count_person] INTEGER NOT NULL ," +
            //" [indications] INTEGER NOT NULL ," +
            //};
            //command.ExecuteNonQuery();
            //MessageBox.Show("Таблица софздана");

            //command.CommandText = "INSERT INTO Accrual (type_id, result, tariff_one, volume_one, indications_one) VALUES (1, 21.0, 22.0, 23.0, 24.0)";

            //command.ExecuteNonQuery();
            //command = new SQLiteCommand(connection)
            //{
            //    CommandText = "SELECT * FROM Accrual"
            //};
            //DataTable data = new DataTable();
            //SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            //adapter.Fill(data);
            //MessageBox.Show($"Прочитано {data.Rows.Count} записей из таблицы БД");
            //foreach (DataRow row in data.Rows)
            //{
            //    MessageBox.Show($"id = {row.Field<long>("id")} result = {row.Field<double>("result")} volume_one = {row.Field<double>("volume_one")}");
            //}
            //}
            //connection.Close();

        }

        private void textBoxCounterGBC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back) return;
            else
                e.Handled = true;
        }

        private void textBoxCounterEE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back) return;
            else
                e.Handled = true;
        }

        private void textBoxCounterEENight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back) return;
            else
                e.Handled = true;
        }

        private void textBoxCounterEE_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCounterEENight.Text))
            {
                return;
            }

            if (!string.IsNullOrEmpty(textBoxCounterEENight.Text))
            {
                if (string.IsNullOrEmpty(textBoxCounterEE.Text))
                {
                    MessageBox.Show("При заполненном Показания по ЭЭ необходимо заполнить Показания по ЭЭ!");
                    textBoxCounterEE.Focus();
                    textBoxCounterEENight.Clear();
                }
            }
        }

        private void textBoxCounterEENight_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCounterEENight.Text))
            {
                if (string.IsNullOrEmpty(textBoxCounterEE.Text))
                {
                    MessageBox.Show("При заполненном Показания по ЭЭ необходимо заполнить Показания по ЭЭ!");
                    textBoxCounterEE.Focus();
                    textBoxCounterEENight.Clear();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            /*
           * Сохраняем полученные результаты в базу (временно здесь)
           */
            try
            {
                ConnectionSqlite.InserDataByColdWater(accrual.GetColdWaterSupply());
                ConnectionSqlite.InserDataByHotWater(accrual.GetHotWaterSupply());
                ConnectionSqlite.InserDataToElecticalEnergy(accrual.GetElectricalEnergy());
            }
            catch {
                MessageBox.Show("Ошибка сохранения");

            }
            MessageBox.Show("Данные сохранены");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            dataGridViewShowResults.Rows.Clear();
            dataGridViewShowResults.Visible=false;
            textBoxCounterEE.Clear();
            textBoxCounterEENight.Clear();
            textBoxCounterGBC.Clear();
            textBoxCounterHBC.Clear();
            textBoxCountPerson.Clear();
        }
    }
}
