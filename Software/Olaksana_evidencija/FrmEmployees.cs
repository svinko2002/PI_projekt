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
    /// Forma za prikazivanje zaposlenika
    /// </summary>
    public partial class FrmEmployees : Form
    {
        public FrmEmployees()
        {
            InitializeComponent();
        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployeeAdd frmEmployeeAdd = new FrmEmployeeAdd();
            frmEmployeeAdd.ShowDialog();
            ShowEmplyees();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            Employees selectedEmployee = dgvEmployees.CurrentRow.DataBoundItem as Employees;
            if (selectedEmployee != null)
            {
                FrmEmployeeEdit frmEmployeeEdit = new FrmEmployeeEdit(selectedEmployee);
                frmEmployeeEdit.ShowDialog();
                ShowEmplyees();
            }
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {

            ShowEmplyees();
        }

        private void ShowEmplyees()
        {
            List<Employees> employees = EmployeeRepository.GetEmployees();
            dgvEmployees.DataSource = employees;

            dgvEmployees.Columns["OIB"].HeaderText = "OIB";
            dgvEmployees.Columns["ime"].HeaderText = "Ime";
            dgvEmployees.Columns["prezime"].HeaderText = "Prezime";
            dgvEmployees.Columns["MjestoStanovanja"].HeaderText = "Mjesto stanovanja";
            dgvEmployees.Columns["BrojTelefona"].HeaderText = "Broj telefona";
            dgvEmployees.Columns["Email"].HeaderText = "E-mail";
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
