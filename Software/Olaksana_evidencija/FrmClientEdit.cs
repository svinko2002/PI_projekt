using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Olaksana_evidencija.Models;
using Olaksana_evidencija.Repositories;

namespace Olaksana_evidencija
{
    /// <summary>
    /// Forma za uređivanje klijenta
    /// </summary>
    public partial class FrmClientEdit : Form
    {
        private Clients client;

        public FrmClientEdit(Clients selectedClient)
        {
            client = selectedClient;
            InitializeComponent();
            loadData();
        }
        /// <summary>
        /// Učitava podatke na formu
        /// </summary>
        private void loadData()
        {
            txtOIB.Text = client.OIB.Trim();
            txtIme.Text = client.ime.Trim();
            txtPrezime.Text = client.prezime.Trim();
            txtMjestoStanovanja.Text = client.mjestoStanovanja.Trim();
            txtBrojTelefona.Text = client.brojTelefona.Trim();
            txtEmail.Text = client.email.Trim();
        }

        private void FrmClientEdit_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var oldClient = new Clients
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

            if (oldClient.ime.Length == 0) { validated = false; errors += "Ime ne smije biti prazno!\n"; }
            if (oldClient.prezime.Length == 0) { validated = false; errors += "Prezime ne smije biti prazno!\n"; }
            if (oldClient.mjestoStanovanja.Length == 0) { validated = false; errors += "Mjesto stanovanja ne smije biti prazno!\n"; }
            if (oldClient.brojTelefona.Length == 0) { validated = false; errors += "Broj telefona ne smije biti prazan!\n"; }
            if (oldClient.email.Length == 0) { validated = false; errors += "Email ne smije biti prazan!\n"; }
            
            if (validated)
            {
                ClientRepository.EditClient(oldClient, client.OIB.Trim());
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

        private void txtBrojTelefona_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMjestoStanovanja_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOIB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblBrojTelefona_Click(object sender, EventArgs e)
        {

        }

        private void lblMjestoStanovanja_Click(object sender, EventArgs e)
        {

        }

        private void lblOIB_Click(object sender, EventArgs e)
        {

        }

        private void lblPrezime_Click(object sender, EventArgs e)
        {

        }

        private void lblIme_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
