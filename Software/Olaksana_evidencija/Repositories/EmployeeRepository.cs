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
    /// Repozitorij za upravljanje zaposlenicima
    /// </summary>
    internal class EmployeeRepository
    {
        /// <summary>
        /// Vraća sve zaposlenike
        /// </summary>
        /// <returns>lista zaposlenika</returns>
        public static List<Employees> GetEmployees()
        {
            List<Employees> employees = new List<Employees>();
            string sql = "SELECT * FROM Employee";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Employees employee = CreateObject(reader);
                employees.Add(employee);
            }
            reader.Close();
            DB.CloseConnection();
            return employees;
        }
        /// <summary>
        /// Kreira objekt na prenseni upit iz baze
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private static Employees CreateObject(SqlDataReader reader)
        {
            string OIB = reader["OIB"].ToString();
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string mjestoStanovanja = reader["MjestoStanovanja"].ToString();
            string brojTelefona = reader["BrojTelefona"].ToString();
            string email = reader["Email"].ToString();
            var employee = new Employees
            {
                OIB = OIB,
                ime = ime,
                prezime = prezime,
                mjestoStanovanja = mjestoStanovanja,
                brojTelefona = brojTelefona,
                email = email
            };
            return employee;
        }
        /// <summary>
        /// Dodaje prenesnog zaposlenika u bazu podataka
        /// </summary>
        /// <param name="employee"></param>
        public static void AddEmployee(Employees employee)
        {
            string sql = $"INSERT INTO Employee(OIB,Ime,Prezime,MjestoStanovanja,BrojTelefona,Email) VALUES('" + employee.OIB + "','" + employee.ime + "','" + employee.prezime + "','" + employee.mjestoStanovanja + "','" + employee.brojTelefona + "','" + employee.email + "')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        /// <summary>
        /// Prenesenog zaposlenika spremu u bazu podataka na mjesto prenesenog starog oiba
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="stariOib"></param>
        public static void EditEmployee(Employees employee, string stariOib)
        {
            string sql = $"UPDATE Employee SET OIB ='" + employee.OIB + "',Ime = '" + employee.ime + "',Prezime = '" + employee.prezime + "',MjestoStanovanja = '" + employee.mjestoStanovanja + "',BrojTelefona = '" + employee.brojTelefona + "',Email = '" + employee.email + "' WHERE OIB ='" + stariOib + "'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
