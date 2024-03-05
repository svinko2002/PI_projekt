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
    /// Forma za dodavanje usluge
    /// </summary>
    public partial class FrmServiceAdd : Form
    {
        public FrmServiceAdd()
        {
            List<Services> services = ServiceRepository.GetServices();
            int najveci = 0;
            for(int i = 0; i < services.Count; i++)
            {
                int ucitani = int.Parse(services[i].id.ToString());
                if (ucitani > najveci) { najveci = ucitani; }
            }
            najveci++;
            InitializeComponent();
            var allClients = ClientRepository.GetClients();
            cboKlijenti.DataSource = allClients;
            txtId.Text = najveci.ToString();
            cboVrsteUsluga2.Items.Add("Nije odabrana kategorija");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int vremenskiInterval;
            int.TryParse(txtVremenskiInterval.Text.ToString(), out vremenskiInterval);
            long OIB;
            long.TryParse(txtClient.Text.ToString(), out OIB);

            var newService = new Services
            {
                id = int.Parse(txtId.Text.ToString()),
                vrstaUsluge = txtVrstaUsluge.Text,
                lokacijaObavljanja = txtLokacijaObavljanja.Text,
                procijenjenoVrijemeObavljanja = txtProcijenjenoVrijemeObavljanja.Text,
                vrijemeObavljanja = DateTime.Parse(dateTPVrijemeObavljanja.Value.ToShortDateString()),
                ponavljajuciPodsjetnik = chkPonavljajuciPodsjetnik.Checked.ToString(),
                ponavljajucaUsluga = chkPonavljajucaUsluga.Checked.ToString(),
                client = ClientRepository.GetClient(OIB),
                vremenskiInterval = vremenskiInterval
            };
            Console.WriteLine(newService.vremenskiInterval.ToString());
            Boolean validated = true;
            string errors = "";

            if (newService.vrstaUsluge.Length == 0) { validated = false; errors += "Vrsta usluge ne smije biti prazna!\n"; }
            if (newService.lokacijaObavljanja.Length == 0) { validated = false; errors += "Lokacija obavljanja ne smije biti prazna!\n"; }
            if (newService.procijenjenoVrijemeObavljanja.Length == 0) { validated = false; errors += "Procijenjeno vrijeme obavljanja ne smije biti prazno!\n"; }
            if (OIB == 0) { validated = false; errors += "Klijent ne smije biti prazan!\n"; }
            if (validated)
            {
                ServiceRepository.AddService(newService);
                Close();
            }
            else
            {
                MessageBox.Show(errors);
            }
        }

        private void cboKlijenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            var client = cboKlijenti.SelectedItem as Clients;
            txtClient.Text = client.OIB.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string odabranaKategorija = cboVrsteUsluga1.SelectedItem as string;
            int broj;
            int.TryParse(odabranaKategorija[0].ToString(), out broj);
            cboVrsteUsluga2.Items.Clear();
            switch (broj)
            {
                case 1:
                    cboVrsteUsluga2.Items.Add("1.1. čišćenje stambenih i poslovnih prostora");
                    cboVrsteUsluga2.Items.Add("1.2. čišćenje apartmana");
                    cboVrsteUsluga2.Items.Add("1.3. čišćenje i održavanje stubišta");
                    break;
                case 2:
                    cboVrsteUsluga2.Items.Add("2.1. generalno čišćenje stambenih i poslovnih prostora");
                    cboVrsteUsluga2.Items.Add("2.2. generalno čišćenje nakon radova");
                    cboVrsteUsluga2.Items.Add("2.3. generalno čišćenje pojedinih prostorija");
                    break;
                case 3:
                    cboVrsteUsluga2.Items.Add("3.1. kemijsko čišćenje tapeciranog namještaja");
                    cboVrsteUsluga2.Items.Add("3.2. kemijsko čišćenje tepiha");
                    break;
                case 4:
                    cboVrsteUsluga2.Items.Add("4. Čišćenje vanjskih površina i objekata");
                    break;
                default:
                    cboVrsteUsluga2.Items.Add("Nije odabrana kategorija");
                    break;
            }
        }

        private void FrmServiceAdd_Load(object sender, EventArgs e)
        {

        }

        private void lblVrstaUsluge_Click(object sender, EventArgs e)
        {

        }

        private void cboVrsteUsluga2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string odabranaPodKategorija = cboVrsteUsluga1.SelectedItem as string;
            if(odabranaPodKategorija != "Nije odabrana kategorija")
            {
                txtVrstaUsluge.Text = odabranaPodKategorija.Remove(0, 3);
            }
        }
    }
}
