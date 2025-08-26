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
        public static double GetIndicationDataByColdWater()
        {
            string connectionString = "Data Source=E:\\Projects\\VerificationTask\\utilites.db;";
            double indications=0.0;


            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string selectSql = "SELECT * FROM ColdWater ORDER BY ID DESC LIMIT 1";
                using (var command = new SqliteCommand(selectSql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                             indications = reader.GetDouble(4);
                        }
                    }
                }
            }
            return indications;
        }
    }
   
}
