using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
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

        public static double GetIndicationDataByFieldNameAndTableName(string table,string field)
        {
            string connectionString = "Data Source=E:\\Projects\\VerificationTask\\utilites.db;";
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
        public static double GetIndicationDataByWater(string table)
        {
            string connectionString = "Data Source=E:\\Projects\\VerificationTask\\utilites.db;";
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

         public static void InserDataByColdWater(ColdWaterSupply coldWaterSupply)
        {
            string connectionString = "Data Source=E:\\Projects\\VerificationTask\\utilites.db;";


            using (var connection = new SqliteConnection(connectionString))
            {
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
                    Console.WriteLine("Данные успешно добавлены!");
                }
            }
        }
        public static void InserDataByHotWater(HotWaterSupply coldWaterSupply)
        {
            string connectionString = "Data Source=E:\\Projects\\VerificationTask\\utilites.db;";


            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string insertSql = "INSERT INTO HotWater ( result, tariff_tn,tariff_te,normativ_tn,normativ_te, volume_tn,volume_te,count_person, indications) " +
                                  "VALUES ( @result, @tariff_tn,@tariff_te, @normativ_tn,@normativ_te, @volume_tn,@volume_te, @count_person, @indications)";

                using (var command = new SqliteCommand(insertSql, connection))
                {
                    command.Parameters.AddWithValue("@result", coldWaterSupply.Result);
                    command.Parameters.AddWithValue("@tariff_tn", coldWaterSupply.TariffTN);
                    command.Parameters.AddWithValue("@tariff_te", coldWaterSupply.TariffTE);
                    command.Parameters.AddWithValue("@normativ_tn", coldWaterSupply.NormativTN);
                    command.Parameters.AddWithValue("@normativ_te", coldWaterSupply.NormativTE);
                    command.Parameters.AddWithValue("@volume_tn", coldWaterSupply.VolumeTN);
                    command.Parameters.AddWithValue("@volume_te", coldWaterSupply.VolumeTE);
                    command.Parameters.AddWithValue("@count_person", coldWaterSupply.CountPerson);
                    command.Parameters.AddWithValue("@indications", coldWaterSupply.Indications);

                    command.ExecuteNonQuery();
                    Console.WriteLine("Данные успешно добавлены!");
                }
            }
        }
        public static void InserDataToElecticalEnergy(ElectricalEnergy electricalEnergy)
        {
            string connectionString = "Data Source=E:\\Projects\\VerificationTask\\utilites.db;";


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
                    Console.WriteLine("Данные успешно добавлены!");
                }
            }
        }
    }
}

