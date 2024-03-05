using DBLayer;
using Olaksana_evidencija.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olaksana_evidencija.Repositories
{
    /// <summary>
    /// Repozitorj za upravljanje uslugama
    /// </summary>
    internal class ServiceRepository
    {
        /// <summary>
        /// Vraća sve usluge
        /// </summary>
        /// <returns>lista usluga</returns>
        public static List<Services> GetServices()
        {
            List<Services> services = new List<Services>();
            string sql = "SELECT * FROM Service";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Services service = CreateObject(reader);
                services.Add(service);
            }
            reader.Close();
            DB.CloseConnection();
            return services;
        }
        /// <summary>
        /// Kreira objekt na prenseni upit iz baze
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private static Services CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["id"].ToString());
            string vrstaUsluge = reader["vrstaUsluge"].ToString();
            string lokacijaObavljanja = reader["lokacijaObavljanja"].ToString();
            string procijenjenoVrijemeObavljanja = reader["procijenjenoVrijemeObavljanja"].ToString();
            //DateTime vrijemeObavljanja = DateTime.Parse(reader["vrijemeObavljanja"].ToString());
            DateTime vrijemeObavljanja = DateTime.Parse(reader["vrijemeObavljanja"].ToString());
            string ponavljajucaUsluga = reader["ponavljajucaUsluga"].ToString(); 
            string ponavljajuciPodsjetnik = reader["ponavljajuciPodsjetnik"].ToString();
            int.TryParse(reader["vremenskiInterval"].ToString(), out int vremenskiInterval);
            long OIB_klijenta = long.Parse(reader["OIB_klijenta"].ToString());
            var client = ClientRepository.GetClient(OIB_klijenta);
            var service = new Services
            {
                id = id,
                vrstaUsluge = vrstaUsluge,
                lokacijaObavljanja = lokacijaObavljanja,
                procijenjenoVrijemeObavljanja = procijenjenoVrijemeObavljanja,
                vrijemeObavljanja = vrijemeObavljanja,
                ponavljajuciPodsjetnik = ponavljajuciPodsjetnik,
                ponavljajucaUsluga = ponavljajucaUsluga,
                vremenskiInterval = vremenskiInterval,
                client = client,
            };
            return service;
        }
        /// <summary>
        /// Dodavanje prosljeđene usluge u bazu podataka
        /// </summary>
        /// <param name="service"></param>
        public static void AddService(Services service)
        {
            string vrijemeObavljanja = service.vrijemeObavljanja.ToString("yyyy-MM-dd HH:mm:ss");
            string ponavljajuciPodsjetnik, ponavljajucaUsluga;
            Console.WriteLine(service.ponavljajucaUsluga.ToString());
            Console.WriteLine(service.ponavljajuciPodsjetnik.ToString());
            if (service.ponavljajucaUsluga.ToString() == "True") { ponavljajucaUsluga = "D"; } else { ponavljajucaUsluga = "N"; }
            if (service.ponavljajuciPodsjetnik.ToString() == "True") { ponavljajuciPodsjetnik = "D"; } else { ponavljajuciPodsjetnik = "N"; }
            string sql = $"INSERT INTO Service(id,vrstaUsluge,lokacijaObavljanja,procijenjenoVrijemeObavljanja,vrijemeObavljanja,ponavljajucaUsluga,ponavljajuciPodsjetnik,vremenskiInterval,OIB_klijenta) VALUES('" + service.id + "','" + service.vrstaUsluge + "','" + service.lokacijaObavljanja + "','" + service.procijenjenoVrijemeObavljanja + "','" + vrijemeObavljanja + "','" + ponavljajucaUsluga + "','" + ponavljajuciPodsjetnik + "','" + service.vremenskiInterval + "','" + service.client.OIB + "')";
            Console.WriteLine(sql);
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void EditService(Services service)
        {
            string vrijemeObavljanja = service.vrijemeObavljanja.ToString("yyyy-MM-dd HH:mm:ss");
            string ponavljajuciPodsjetnik, ponavljajucaUsluga;
            if (service.ponavljajucaUsluga.ToString() == "True") { ponavljajucaUsluga = "D"; } else { ponavljajucaUsluga = "N"; }
            if (service.ponavljajuciPodsjetnik.ToString() == "True") { ponavljajuciPodsjetnik = "D"; } else { ponavljajuciPodsjetnik = "N"; }
            string sql = $"UPDATE Service SET vrstaUsluge = '" + service.vrstaUsluge + "',lokacijaObavljanja = '" + service.lokacijaObavljanja + "',procijenjenoVrijemeObavljanja = '" + service.procijenjenoVrijemeObavljanja + "',ponavljajucaUsluga = '" + ponavljajucaUsluga + "',ponavljajuciPodsjetnik = '" + ponavljajuciPodsjetnik + "',OIB_klijenta = '" + service.client.OIB + "',vrijemeObavljanja = '" + vrijemeObavljanja + "' WHERE id ='" + service.id + "'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        /// <summary>
        /// Brisanje prosljeđene usluge iz baze podataka
        /// </summary>
        /// <param name="service"></param>
        public static void DeleteService(Services service)
        {
            string sql = $"DELETE FROM Service WHERE id = '" + service.id + "'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
