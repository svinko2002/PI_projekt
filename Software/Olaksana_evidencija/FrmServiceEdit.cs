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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Olaksana_evidencija
{
    /// <summary>
    /// Forma za uređivanje usluge
    /// </summary>
    public partial class FrmServiceEdit : Form
    {
        private Services service;
        public FrmServiceEdit(Models.Services selectedService)
        {
            service = selectedService;
            InitializeComponent();
            loadData();
        }
        /// <summary>
        /// Učitava podatke na formu
        /// </summary>
        private void loadData()
        {
            txtId.Text = service.id.ToString();
            txtVrstaUsluge.Text = service.vrstaUsluge.Trim();
            txtLokacijaObavljanja.Text = service.lokacijaObavljanja.Trim();
            txtProcijenjenoVrijemeObavljanja.Text = service.procijenjenoVrijemeObavljanja.Trim();
            txtVremenskiInterval.Text = service.vremenskiInterval.ToString();

            if (service.ponavljajucaUsluga == "D") { chkPonavljajucaUsluga.Checked = true; } else { chkPonavljajucaUsluga.Checked = false; }
            if (service.ponavljajuciPodsjetnik == "D") { chkPonavljajuciPodsjetnik.Checked = true; } else { chkPonavljajuciPodsjetnik.Checked = false; }

            dateTPVrijemeObavljanja.Text = service.vrijemeObavljanja.ToString();
            txtClient.Text = service.client.OIB.ToString();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            var oldService = new Services
            {
                id = int.Parse(txtId.Text.ToString()),
                vrstaUsluge = txtVrstaUsluge.Text.ToString(),
                lokacijaObavljanja = txtLokacijaObavljanja.Text.ToString(),
                procijenjenoVrijemeObavljanja = txtProcijenjenoVrijemeObavljanja.Text.ToString(),
                vrijemeObavljanja = DateTime.Parse(dateTPVrijemeObavljanja.Value.ToShortDateString()),
                ponavljajuciPodsjetnik = chkPonavljajuciPodsjetnik.Checked.ToString(),
                ponavljajucaUsluga = chkPonavljajucaUsluga.Checked.ToString(),
                vremenskiInterval = int.Parse(txtVremenskiInterval.Text.ToString()),
                client = ClientRepository.GetClient(long.Parse(txtClient.Text))
            };
            Boolean validated = true;
            string errors = "";

            if (oldService.vrstaUsluge.Length == 0) { validated = false; errors += "Vrsta usluga ne smije biti prazno!\n"; }
            if (oldService.lokacijaObavljanja.Length == 0) { validated = false; errors += "Lokacija obavljanja ne smije biti prazno!\n"; }
            if (oldService.procijenjenoVrijemeObavljanja.Length == 0) { validated = false; errors += "Procijenjeno vrijeme obavljanja ne smije biti prazno!\n"; }

            if (validated)
            {
                ServiceRepository.EditService(oldService);
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
