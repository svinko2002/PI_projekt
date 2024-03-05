using Olaksana_evidencija.Models;
using Olaksana_evidencija.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olaksana_evidencija
{
    /// <summary>
    /// Forma za dodavanje zaposlenika
    /// </summary>
    public partial class FrmEmployeeAdd : Form
    {
        public FrmEmployeeAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newEmployee = new Employees
            {
                OIB = txtOIB.Text,
                ime = txtIme.Text,
                prezime = txtPrezime.Text,
                mjestoStanovanja = txtMjestoStanovanja.Text,
                brojTelefona = txtBrojTelefona.Text,
                email = txtEmail.Text
            };
            Boolean validated = true;
            string errors = "";
            var allEmployees = EmployeeRepository.GetEmployees();
            for (int i = 0; i < allEmployees.Count; i++)
            {
                if (newEmployee.OIB.Equals(allEmployees[i].OIB))
                {
                    validated = false;
                    errors += "Zaposlenik sa tim OIB-om već postoji!!\n";
                }
            }
            if (newEmployee.OIB.Length != 11) { validated = false; errors += "OIB mora biti duljine 11!\n"; }
            if (newEmployee.ime.Length > 30) { validated = false; errors += "Ime prelazi granicu dužine od 30!\n"; }
            if (newEmployee.prezime.Length > 30) { validated = false; errors += "Prezime prelazi granicu dužine od 30!\n"; }
            if (newEmployee.mjestoStanovanja.Length > 100) { validated = false; errors += "Mjesto stanovanja prelazi granicu dužine od 100!\n"; }
            if (newEmployee.brojTelefona.Length > 15) { validated = false; errors += "Broj telefona prelazi granicu dužine od 15!\n"; }
            if (newEmployee.email.Length > 50) { validated = false; errors += "Email prelazi granicu dužine od 50!\n"; }

            if (newEmployee.ime.Length == 0) { validated = false; errors += "Ime ne smije biti prazno!\n"; }
            if (newEmployee.prezime.Length == 0) { validated = false; errors += "Prezime ne smije biti prazno!\n"; }
            if (newEmployee.mjestoStanovanja.Length == 0) { validated = false; errors += "Mjesto stanovanja ne smije biti prazno!\n"; }
            if (newEmployee.brojTelefona.Length == 0) { validated = false; errors += "Broj telefona ne smije biti prazan!\n"; }
            if (newEmployee.email.Length == 0) { validated = false; errors += "Email ne smije biti prazan!\n"; }

            if (validated)
            {
                EmployeeRepository.AddEmployee(newEmployee);
                Close();
            }
            else
            {
                MessageBox.Show(errors);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
