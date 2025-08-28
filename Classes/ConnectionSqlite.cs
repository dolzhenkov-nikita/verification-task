using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using VerificationTask.Models;

namespace VerificationTask.Classes
{
    internal class ConnectionSqlite
    {
        static SQLiteConnection connection;
        static SQLiteCommand command;


        /*
         * Получение предыдущих показаний из указанной таблицы 
         * Так как в таблицах имя поля может отличатся, то добавлен параметр field
         */
        public static double GetIndicationDataByFieldNameAndTableName(string table,string field)
        {
            string connectionString = $"Data Source={GetConnectionString()};";


            double indications = 0;


            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string selectSql = $"SELECT {field} FROM {table} where {field}<>0 ORDER BY ID DESC LIMIT 1";
                using (var command = new SqliteCommand(selectSql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            indications = reader.GetInt32(0);
                        }
                    }
                }
            }
            return indications;
        }
        /*
         * ПОлучение предыдущих показаний для воды с указанием таблицы
         * */
        public static double GetIndicationDataByWater(string table)
        {
            string connectionString = $"Data Source={GetConnectionString()};";

            double indications = 0;

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string selectSql = $"SELECT indications FROM {table} where indications<>0 ORDER BY ID DESC LIMIT 1";
                using (var command = new SqliteCommand(selectSql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            indications = reader.GetInt32(0);
                        }
                    }
                }
            }
            return indications;
        }
        /*
         * Вставляем данные холодной воды в базу данных
         */
         public static void InserDataByColdWater(ColdWaterSupply coldWaterSupply)
        {
            string connectionString = $"Data Source={GetConnectionString()};";

            try
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    int lastRowID;
                    connection.Open();
                    string insertSql = "INSERT INTO ColdWater ( result, tariff,normativ, volume,count_person, indications) " +
                                      "VALUES ( @result, @tariff, @normativ, @volume, @count_person, @indications)";

                    using (var command = new SqliteCommand(insertSql, connection))
                    {
                        command.Parameters.AddWithValue("@result", coldWaterSupply.Getresult());
                        command.Parameters.AddWithValue("@tariff", coldWaterSupply.Gettariff());
                        command.Parameters.AddWithValue("@normativ", coldWaterSupply.Getnormativ());
                        command.Parameters.AddWithValue("@volume", coldWaterSupply.Getvolume());
                        command.Parameters.AddWithValue("@count_person", coldWaterSupply.Getcount_person());
                        command.Parameters.AddWithValue("@indications", coldWaterSupply.Getindications());

                        command.ExecuteNonQuery();

                        command.CommandText = "SELECT last_insert_rowid()";
                        lastRowID = Convert.ToInt32(command.ExecuteScalar());

                        coldWaterSupply.SetId(lastRowID);

                        Console.WriteLine($"Данные успешно добавлены!{lastRowID}");
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
        /*
         * Вставляем данные горячей воды в базу данных
         */
        public static void InserDataByHotWater(HotWaterSupply hotWaterSupply)
        {
            int lastRowID;

            string connectionString = $"Data Source={GetConnectionString()};";

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string insertSql = "INSERT INTO HotWater ( result,result_tn,result_te, tariff_tn,tariff_te,normativ_tn,normativ_te, volume_tn,volume_te,count_person, indications) " +
                                  "VALUES ( @result,@result_tn,@result_te ,@tariff_tn,@tariff_te, @normativ_tn,@normativ_te, @volume_tn,@volume_te, @count_person, @indications)";

                using (var command = new SqliteCommand(insertSql, connection))
                {
                    command.Parameters.AddWithValue("@result", hotWaterSupply.Result);
                    command.Parameters.AddWithValue("@result_tn", hotWaterSupply.ResultTN);
                    command.Parameters.AddWithValue("@result_te", hotWaterSupply.ResultTE);
                    command.Parameters.AddWithValue("@tariff_tn", hotWaterSupply.TariffTN);
                    command.Parameters.AddWithValue("@tariff_te", hotWaterSupply.TariffTE);
                    command.Parameters.AddWithValue("@normativ_tn", hotWaterSupply.NormativTN);
                    command.Parameters.AddWithValue("@normativ_te", hotWaterSupply.NormativTE);
                    command.Parameters.AddWithValue("@volume_tn", hotWaterSupply.VolumeTN);
                    command.Parameters.AddWithValue("@volume_te", hotWaterSupply.VolumeTE);
                    command.Parameters.AddWithValue("@count_person", hotWaterSupply.CountPerson);
                    command.Parameters.AddWithValue("@indications", hotWaterSupply.Indications);

                    command.ExecuteNonQuery();

                    command.CommandText = "SELECT last_insert_rowid()";
                    lastRowID = Convert.ToInt32(command.ExecuteScalar());

                    hotWaterSupply.Id=(lastRowID);
                    Console.WriteLine("Данные успешно добавлены!");
                }
            }
        }
        /*
         * Вставляем данные электроэнергии в базу данных
         */
        public static void InserDataToElecticalEnergy(ElectricalEnergy electricalEnergy)
        {
            string connectionString = $"Data Source={GetConnectionString()};";

            int lastRowID;

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string insertSql = "INSERT INTO ElectricalEnergy ( result, result_day,result_night," +
                                                                "tariff_default,tariff_day, tariff_night," +
                                                                "normativ,volume, volume_day," +
                                                                "volume_night,count_person,indications_default," +
                                                                "indications_day,indications_night) " +

                                                                "VALUES ( @result, @result_day,@result_night," +
                                                                "@tariff_default,@tariff_day, @tariff_night," +
                                                                "@normativ,@volume, @volume_day," +
                                                                "@volume_night,@count_person,@indications_default," +
                                                                "@indications_day,@indications_night)";

                using (var command = new SqliteCommand(insertSql, connection))
                {
                    command.Parameters.AddWithValue("@result", electricalEnergy.Result);
                    command.Parameters.AddWithValue("@result_day", electricalEnergy.ResultDay);
                    command.Parameters.AddWithValue("@result_night", electricalEnergy.ResultNight);
                    command.Parameters.AddWithValue("@tariff_default", electricalEnergy.TariffDefault);
                    command.Parameters.AddWithValue("@tariff_day", electricalEnergy.TariffDay);
                    command.Parameters.AddWithValue("@tariff_night", electricalEnergy.TariffNight);
                    command.Parameters.AddWithValue("@normativ", electricalEnergy.Normativ);
                    command.Parameters.AddWithValue("@volume", electricalEnergy.Volume);
                    command.Parameters.AddWithValue("@volume_day", electricalEnergy.VolumeDay);
                    command.Parameters.AddWithValue("@volume_night", electricalEnergy.VolumeNight);
                    command.Parameters.AddWithValue("@count_person", electricalEnergy.CountPerson);
                    command.Parameters.AddWithValue("@indications_default", electricalEnergy.IndicationsDefault);
                    command.Parameters.AddWithValue("@indications_day", electricalEnergy.IndicationsDay);
                    command.Parameters.AddWithValue("@indications_night", electricalEnergy.IndicationsNight);

                    command.ExecuteNonQuery();

                    command.CommandText = "SELECT last_insert_rowid()";
                    lastRowID = Convert.ToInt32(command.ExecuteScalar());

                    electricalEnergy.Id = (lastRowID);

                    Console.WriteLine("Данные успешно добавлены!");
                }
            }
        }
        public static void InserDataToAccrual(Accrual accrual)
        {

            string connectionString = $"Data Source={GetConnectionString()};";

            try
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    string insertSql = "INSERT INTO Accrual ( result, cold_water_id,hot_water_id, electrical_id) " +
                                      "VALUES ( @result, @cold_water_id, @hot_water_id, @electrical_id)";

                    using (var command = new SqliteCommand(insertSql, connection))
                    {
                        command.Parameters.AddWithValue("@result", accrual.GetsumAccrual());
                        command.Parameters.AddWithValue("@cold_water_id", accrual.GetColdWaterSupply().GetId());
                        command.Parameters.AddWithValue("@hot_water_id", accrual.GetHotWaterSupply().Id);
                        command.Parameters.AddWithValue("@electrical_id", accrual.GetElectricalEnergy().Id);

                        command.ExecuteNonQuery();

                        Console.WriteLine($"Данные успешно добавлены!");
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public static string GetConnectionString()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            string projectPath = Path.GetFullPath(Path.Combine(basePath, @"..\..\.."));

            string dbPath = Path.Combine(projectPath, "utilites.db");

            string connectionString = dbPath;

            return connectionString ;
        }
    }
}

