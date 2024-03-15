using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


using Npgsql;
using System.Data;

namespace JKH
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;";
            //стартер для дебагинга (должен быть удален в релизной версии)
            ExecuteQuery($"DROP TABLE IF EXISTS vehicles");
            ExecuteQuery($"DROP TABLE IF EXISTS materials");
            Task start1 = Starter();
            Task start2 = Starter2();
            ExecuteQuery($"INSERT INTO Vehicles (type,brand,adress,serial,vacancy) VALUES ('gruz','volvo','SPB, Kont prospect 14','A695KA',true)");
            ExecuteQuery($"INSERT INTO Vehicles (type,brand,adress,serial,vacancy) VALUES ('car','merc','M, Bolshaya Ul 3','A888AA',true)");
            ExecuteQuery($"INSERT INTO Vehicles (type,brand,adress,serial,vacancy) VALUES ('gruz','gaz','SPB, Sankt-Peterburgskaya 20','C065MK',false)");

            ExecuteQuery($"INSERT INTO materials (name,adress,mass_kg,volume_v3,vacancy) VALUES ('graviy','SPB, Kont prospect 14',3000,3,true)");
            ExecuteQuery($"INSERT INTO materials (name,adress,mass_kg,volume_v3,vacancy) VALUES ('sand','M, Bolshaya Ul 3',2000,2,true)");
            ExecuteQuery($"INSERT INTO materials (name,adress,mass_kg,volume_v3,vacancy) VALUES ('planks','SPB, Sankt-Peterburgskaya 20',1000,1,false)");




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPanel());

        }
        static class UtilsPostgres
        {
            public static NpgsqlConnection Connect(string connectionString)
            {
                NpgsqlConnection conn = new NpgsqlConnection(connectionString);
                try
                {
                    conn.Open();
                }
                catch (Exception e)
                {
                    throw new Exception("Error connecting to the database", e);

                }
                return conn;
            }
        }

        static int ExecuteQuery(string query)
        {
            var con = new NpgsqlConnection(
     connectionString: "Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;");
            con.Open();
            using (NpgsqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                int result = cmd.ExecuteNonQuery();
                return result;
            }

        }

        static async Task Starter()
        {
            
            var con = new NpgsqlConnection(
     connectionString: "Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;");
            con.Open();
            var cmd = new NpgsqlCommand();
            cmd.Connection = con;

            

            cmd.CommandText = "CREATE TABLE vehicles (id SERIAL PRIMARY KEY," +
                "type VARCHAR(255)," +
                "brand VARCHAR(255)," +
                "adress VARCHAR(255)," +
                "serial VARCHAR(255)," +
                "vacancy BOOLEAN)";

           

          

            
            await cmd.ExecuteNonQueryAsync();
            


        }

        static async Task Starter2()
        {

            var con = new NpgsqlConnection(
     connectionString: "Server=localhost;Port=5432;User Id=postgres;Password=aflubin0;Database=GKH;");
            con.Open();
            var cmd = new NpgsqlCommand();
            cmd.Connection = con;






            cmd.CommandText = "CREATE TABLE materials (id SERIAL PRIMARY KEY," +
                "name VARCHAR(255)," +
                "adress VARCHAR(255)," +
                "mass_kg INT," +
                "volume_v3 INT," +
                "vacancy BOOLEAN)";



            await cmd.ExecuteNonQueryAsync();



        }
    }
}
