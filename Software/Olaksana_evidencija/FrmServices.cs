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
    /// Forma za prikazivanje svih usluga
    /// </summary>
    public partial class FrmServices : Form
    {
        public FrmServices()
        {
            InitializeComponent();
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            if(dgvServices.Rows.Count > 0)
            {
                Services selectedService = dgvServices.CurrentRow.DataBoundItem as Services;

                if (selectedService != null)
                {
                    FrmServiceEdit frmServiceEdit = new FrmServiceEdit(selectedService);
                    frmServiceEdit.ShowDialog();
                    ShowServices();
                }
            }
        }

        private void FrmServices_Load(object sender, EventArgs e)
        {
            ShowServices();
        }
        /// <summary>
        /// Učitava podatke na formu
        /// </summary>
        private void ShowServices()
        {
            dgvServices.Columns.Clear();
            List<Services> services = ServiceRepository.GetServices();
            dgvServices.DataSource = services;
            DataGridViewTextBoxColumn zadnjiStupac = new DataGridViewTextBoxColumn();
            zadnjiStupac.Name = "Klijent";
            zadnjiStupac.HeaderText = "Klijent";
            dgvServices.Columns.RemoveAt(dgvServices.ColumnCount-1);
            dgvServices.Columns.Insert(dgvServices.ColumnCount, zadnjiStupac);
            for (int i = 0; i < dgvServices.RowCount; i++)
            {
                dgvServices[dgvServices.ColumnCount - 1, i].Value = services[i].client.ime.Trim() + " " + services[i].client.prezime.Trim();
            }

            dgvServices.Columns["Id"].HeaderText = "ID";
            dgvServices.Columns["vrstaUsluge"].HeaderText = "Vrsta usluge";
            dgvServices.Columns["lokacijaObavljanja"].HeaderText = "Lokacija obavljanja";
            dgvServices.Columns["procijenjenoVrijemeObavljanja"].HeaderText = "Procijenjeno vrijeme obavljanja u satima";
            dgvServices.Columns["vrijemeObavljanja"].HeaderText = "Vrijeme obavljanja";
            dgvServices.Columns["ponavljajucaUsluga"].HeaderText = "Ponavljajuca usluga";
            dgvServices.Columns["ponavljajuciPodsjetnik"].HeaderText = "Ponavljajuci podsjetnik";
            dgvServices.Columns["vremenskiInterval"].HeaderText = "Vremenski interval u danima";
            dgvServices.Columns["Klijent"].HeaderText = "Ime i prezime klijenta";
        }
        
        private void btnAddNewService_Click(object sender, EventArgs e)
        {
            FrmServiceAdd frmServiceAdd = new FrmServiceAdd();
            frmServiceAdd.ShowDialog();
            ShowServices();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvServices.Rows.Count > 0)
            {
                Services selectedService = dgvServices.CurrentRow.DataBoundItem as Services;

                if (selectedService != null)
                {
                    ServiceRepository.DeleteService(selectedService);
                    ShowServices();
                }
            }
        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            ShowServicesPretrazi();
        }
        /// <summary>
        /// Učitava podatke na formu koji su pretraženi putem textboxa
        /// </summary>
        private void ShowServicesPretrazi()
        {
            dgvServices.Columns.Clear();
            List<Services> services = ServiceRepository.GetServices();
            List<Services> servicesPretrazi = new List<Services>();
            for (int i = 0; i < services.Count; i++)
            {
                if (services[i].ToString().Contains(txtPretrazi.Text.ToString().Trim())){
                    servicesPretrazi.Add(services[i]);
                }
            }
            dgvServices.DataSource = servicesPretrazi;
            DataGridViewTextBoxColumn zadnjiStupac = new DataGridViewTextBoxColumn();
            zadnjiStupac.Name = "Klijent";
            zadnjiStupac.HeaderText = "Klijent";

            dgvServices.Columns.RemoveAt(dgvServices.ColumnCount - 1);
            dgvServices.Columns.Insert(dgvServices.ColumnCount, zadnjiStupac);

            if(dgvServices.RowCount > 0)
            { 
                for (int i = 0; i < dgvServices.RowCount; i++)
                {
                    dgvServices[dgvServices.ColumnCount - 1, i].Value = services[i].client.ime.Trim() + " " + services[i].client.prezime.Trim();
                }
            }

            dgvServices.Columns["Id"].HeaderText = "ID";
            dgvServices.Columns["vrstaUsluge"].HeaderText = "Vrsta usluge";
            dgvServices.Columns["lokacijaObavljanja"].HeaderText = "Lokacija obavljanja";
            dgvServices.Columns["procijenjenoVrijemeObavljanja"].HeaderText = "Procijenjeno vrijeme obavljanja u satima";
            dgvServices.Columns["vrijemeObavljanja"].HeaderText = "Vrijeme obavljanja";
            dgvServices.Columns["ponavljajucaUsluga"].HeaderText = "Ponavljajuca usluga";
            dgvServices.Columns["ponavljajuciPodsjetnik"].HeaderText = "Ponavljajuci podsjetnik";
            dgvServices.Columns["vremenskiInterval"].HeaderText = "Vremenski interval u danima";
            dgvServices.Columns["Klijent"].HeaderText = "Ime i prezime klijenta";
        }
    }
}
