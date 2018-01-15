using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace Duser
{
    // Koden kan bruges fridt så længe denne tekst bliver i toppen af filen.
    // Copyright 2016 E-train I/S, Udviklet af Henrik Obsen

    /// <summary>
    /// AutoFac tilføjer CRUD mm til en valgt model
    /// </summary>
    /// <typeparam name="T">Modellen der skal tilknyttes</typeparam>
    public class AutoFac<T> where T : new()
    {
        private string table;
        public Mapper<T> mapper = new Mapper<T>();

        public AutoFac()
        {
            table = "[" + typeof(T).Name + "]";
        }

        /// <summary>
        /// Bruges til at fylde modeller der ikke har en tabel i databasen for eksempel når man bruger Inner Join i til at samle flere tabeller i en model.
        /// </summary>
        /// <typeparam name="R">R er den nye model der ikke har en tabel eller er en samling af flere.</typeparam>
        /// <param name="SQL">SQL-sætningen der bruges til at fylde modellen R</param>
        /// <returns>Retunere en Liste af typen R</returns>
        public List<R> ExecuteSQL<R>(string SQL) where R : new()
        {
            using (var cmd = new SqlCommand(SQL, Conn.CreateConnection()))
            {
                Mapper<R> mapper = new Mapper<R>();

                List<R> list = mapper.MapList(cmd.ExecuteReader());
                cmd.Connection.Close();
                return list;
            }
        }

        /// <summary>
        /// Bruges til at modeficere en tabel.
        /// </summary>
        /// <param name="SQL">SQL-sætningen der bruges for eksempel som en Insert, Update eller Delete</param>
        public void ExecuteSQL(string SQL)
        {
            using (var cmd = new SqlCommand(SQL, Conn.CreateConnection()))
            {
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }
    }
}

