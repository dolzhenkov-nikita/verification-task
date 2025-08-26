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
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void buttonCalculateHBC_Click(object sender, EventArgs e)
        {
            Accrual accrual = new Accrual();

            ColdWaterSupply coldWater = new ColdWaterSupply();

            double volumeHBC = coldWater.getVolume(counter: textBoxCounterHBC.Text.ToString());

            double utilitiesHBCSum = CalculationAccrual.getCost(volumeHBC, TariffEnum.HBC);
            coldWater.Setresult(utilitiesHBCSum);

            ConnectionSqlite.InserDataByColdWater(coldWater);

            accrual.SetColdWaterSupply(coldWater);

            MessageBox.Show(utilitiesHBCSum.ToString());
        }


        private void textBoxCounterHBC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == Convert.ToChar(".")) return;
            else
                e.Handled = true;
        }

        private void textBoxCountPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar)) return;
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
                    //" [count_person] REAL NOT NULL ," +
                    //" [indications] REAL NOT NULL);"
                    //CommandText = "CREATE TABLE IF NOT EXISTS [ElecticalEnergy]([id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE," +
                    //" [result] REAL NOT NULL," +
                    //" [tariff_default] REAL ," +
                    //" [tariff_day] REAL ," +
                    //" [tariff_night] REAL ," +
                    //" [normativ] REAL ," +
                    //" [volume] REAL NOT NULL ," +
                    //" [volume_day] REAL NOT NULL ," +
                    //" [volume_night] REAL NOT NULL ," +
                    //" [count_person] REAL NOT NULL ," +
                    //" [indications_default] REAL NOT NULL ," +
                    //" [indications_day] REAL NOT NULL ," +
                    //" [indications_night] REAL NOT NULL);"
                    //CommandText = "CREATE TABLE IF NOT EXISTS [ColdWater]([id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE," +
                    //" [result] REAL NOT NULL," +
                    //" [tariff] REAL ," +
                    //" [normativ] REAL ," +
                    //" [volume] REAL NOT NULL ," +
                    //" [count_person] REAL NOT NULL ," +
                    //" [indications] REAL NOT NULL ," +
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
    }
}
