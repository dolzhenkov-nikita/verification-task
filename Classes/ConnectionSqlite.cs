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


        public static double GetIndicationDataByWater(string table)
        {
            string connectionString = "Data Source=E:\\Projects\\VerificationTask\\utilites.db;";
            double indications = 0.0;


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
    }
}

