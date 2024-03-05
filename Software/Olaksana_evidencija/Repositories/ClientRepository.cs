using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using Olaksana_evidencija.Models;

namespace Olaksana_evidencija.Repositories
{
    /// <summary>
    /// Repozitorij za upravljanje klijentima
    /// </summary>
    public class ClientRepository
    {
        /// <summary>
        /// Vraća klijenta sa prenesenim oibom
        /// </summary>
        /// <param name="OIB"></param>
        /// <returns>Client</returns>
        public static Clients GetClient(long OIB)
        {
            Clients client = null;
            string sql = $"SELECT * FROM Client WHERE OIB = {OIB}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                client = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return client;
        }
        /// <summary>
        /// Vraća sve klijente
        /// </summary>
        /// <returns>lista klijenata</returns>
        public static List<Clients> GetClients()
        {
            List<Clients> clients = new List<Clients>();
            string sql = "SELECT * FROM Client";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Clients client = CreateObject(reader);
                clients.Add(client);
            }
            reader.Close();
            DB.CloseConnection();
            return clients;
        }
        /// <summary>
        /// Kreira objekt na preneseni upit iz baze
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private static Clients CreateObject(SqlDataReader reader)
        {
            string OIB = reader["OIB"].ToString();
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string mjestoStanovanja = reader["MjestoStanovanja"].ToString();
            string brojTelefona = reader["BrojTelefona"].ToString();
            string email = reader["Email"].ToString();
            var client = new Clients
            {
                OIB = OIB,
                ime = ime,
                prezime = prezime,
                mjestoStanovanja = mjestoStanovanja,
                brojTelefona = brojTelefona,
                email = email
            };
            return client;
        }
        /// <summary>
        /// Prenesenog klijenta spremi u bazu podataka
        /// </summary>
        /// <param name="client"></param>
        public static void AddClient(Clients client)
        {
            string sql = $"INSERT INTO Client(OIB,Ime,Prezime,MjestoStanovanja,BrojTelefona,Email) VALUES('"+ client.OIB  + "','" + client.ime + "','" + client.prezime + "','" + client.mjestoStanovanja + "','" + client.brojTelefona + "','"+client.email+"')";  
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        /// <summary>
        /// Prenesenog klijenta spremu u bazu podataka na mjesto prenesenog starog oiba
        /// </summary>
        /// <param name="client"></param>
        /// <param name="stariOib"></param>
        public static void EditClient(Clients client, string stariOib)
        {
            string sql = $"UPDATE Client SET OIB ='"+client.OIB+"',Ime = '"+client.ime+"',Prezime = '"+client.prezime+"',MjestoStanovanja = '"+client.mjestoStanovanja+ "',BrojTelefona = '" + client.brojTelefona+ "',Email = '" + client.email+ "' WHERE OIB ='"+stariOib+"'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        /// <summary>
        /// Prenesenog klijenta briše iz baze podataka
        /// </summary>
        /// <param name="client"></param>
        public static void DeleteClient(Clients client)
        {
            string sql = $"DELETE FROM Client WHERE OIB = '" + client.OIB + "'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
