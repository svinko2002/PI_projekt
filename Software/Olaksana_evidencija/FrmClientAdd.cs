using Olaksana_evidencija.Models;
using Olaksana_evidencija.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Olaksana_evidencija
{
    /// <summary>
    /// Forma za dodavanje klijenta
    /// </summary>
    public partial class FrmClientAdd : Form
    {
        public FrmClientAdd()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var newClient = new Clients
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
            var allClients = ClientRepository.GetClients();
            for (int i = 0; i < allClients.Count; i++)
            {
                if (newClient.OIB.Equals(allClients[i].OIB))
                {
                    validated = false;
                    errors += "Klijent sa tim OIB-om već postoji!!\n";
                }
            }

            if (newClient.OIB.Length != 11) { validated = false; errors += "OIB mora biti duljine 11!\n"; }
            if (newClient.ime.Length == 0) { validated = false; errors += "Ime ne smije biti prazno!\n"; }
            if (newClient.prezime.Length == 0) { validated = false; errors += "Prezime ne smije biti prazno!\n"; }
            if (newClient.mjestoStanovanja.Length == 0) { validated = false; errors += "Mjesto stanovanja ne smije biti prazno!\n"; }
            if (newClient.brojTelefona.Length == 0) { validated = false; errors += "Broj telefona ne smije biti prazno!\n"; }
            if (newClient.email.Length == 0) { validated = false; errors += "Email prelazi ne smije biti prazno!\n"; }

            if (validated)
            {
                ClientRepository.AddClient(newClient);
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
