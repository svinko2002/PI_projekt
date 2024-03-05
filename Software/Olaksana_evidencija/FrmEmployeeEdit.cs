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
    /// Forma za uređivanje zaposlenika
    /// </summary>
    public partial class FrmEmployeeEdit : Form
    {
        private Employees employee;

        public FrmEmployeeEdit(Employees selectedEmployee)
        {
            employee = selectedEmployee;
            InitializeComponent();
            loadData();
        }
        /// <summary>
        /// Učitava podatke na formu
        /// </summary>
        private void loadData()
        {
            txtOIB.Text = employee.OIB.Trim();
            txtIme.Text = employee.ime.Trim();
            txtPrezime.Text = employee.prezime.Trim();
            txtMjestoStanovanja.Text = employee.mjestoStanovanja.Trim();
            txtBrojTelefona.Text = employee.brojTelefona.Trim();
            txtEmail.Text = employee.email.Trim();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var oldEmployee = new Employees
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

            if (oldEmployee.ime.Length == 0) { validated = false; errors += "Ime ne smije biti prazno!\n"; }
            if (oldEmployee.prezime.Length == 0) { validated = false; errors += "Prezime ne smije biti prazno!\n"; }
            if (oldEmployee.mjestoStanovanja.Length == 0) { validated = false; errors += "Mjesto stanovanja ne smije biti prazno!\n"; }
            if (oldEmployee.brojTelefona.Length == 0) { validated = false; errors += "Broj telefona ne smije biti prazno!\n"; }
            if (oldEmployee.email.Length == 0) { validated = false; errors += "Email prelazi ne smije biti prazno!\n"; }

            if (validated)
            {
                EmployeeRepository.EditEmployee(oldEmployee, employee.OIB.Trim());
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
