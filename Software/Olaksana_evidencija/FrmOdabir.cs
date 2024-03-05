using Olaksana_evidencija.Models;
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
    /// Početna forma na kojoj se može birati između više podataka za prikazivanje
    /// </summary>
    public partial class FrmOdabir : Form
    {
        public FrmOdabir()
        {
            InitializeComponent();
        }

        private void FrmOdabir_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenClients_Click(object sender, EventArgs e)
        {
            Hide();
            FrmClients frmClients = new FrmClients();
            frmClients.ShowDialog();
            Show();
        }

        private void btnOpenEmployees_Click(object sender, EventArgs e)
        {
            Hide();
            FrmEmployees frmEmployees = new FrmEmployees();
            frmEmployees.ShowDialog();
            Show();
        }

        private void btnOpenServices_Click(object sender, EventArgs e)
        {
            Hide();
            FrmServices frmServices = new FrmServices();
            frmServices.ShowDialog();
            Show();
        }
    }
}
