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
    /// Forma za prikazivanje klijenata
    /// </summary>
    public partial class FrmClients : Form
    {
        public FrmClients()
        {
            InitializeComponent();
        }

        private void FrmClients_Load(object sender, EventArgs e)
        {
            ShowClients();
        }
        /// <summary>
        /// Dodaje podatke u DataGridView
        /// </summary>
        private void ShowClients()
        {
            List<Clients> clients = ClientRepository.GetClients();
            dgvClients.DataSource = clients;

            dgvClients.Columns["OIB"].HeaderText = "OIB";
            dgvClients.Columns["ime"].HeaderText = "Ime";
            dgvClients.Columns["prezime"].HeaderText = "Prezime";
            dgvClients.Columns["MjestoStanovanja"].HeaderText = "Mjesto stanovanja";
            dgvClients.Columns["BrojTelefona"].HeaderText = "Broj telefona";
            dgvClients.Columns["Email"].HeaderText = "E-mail";
        }

        private void btnEditClient_Click(object sender, EventArgs e )
        {
            if (dgvClients.Rows.Count > 0)
            {
                Clients selectedClient = dgvClients.CurrentRow.DataBoundItem as Clients;
                if (selectedClient != null)
                {
                    FrmClientEdit frmClientEdit = new FrmClientEdit(selectedClient);
                    frmClientEdit.ShowDialog();
                    ShowClients();
                }
            }
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            FrmClientAdd frmClientAdd = new FrmClientAdd();
            frmClientAdd.ShowDialog();
            ShowClients();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClients.Rows.Count > 0)
            {
                Clients selectedClient = dgvClients.CurrentRow.DataBoundItem as Clients;
                if (selectedClient != null)
                {
                    var allServices = ServiceRepository.GetServices();
                    for (int i = 0; i < allServices.Count; i++)
                    {
                        if (allServices[i].client.OIB == selectedClient.OIB)
                        {
                            MessageBox.Show("Klijent se ne može obrisati zato jer ima uslugu!");
                            return;
                        }
                    }
                    ClientRepository.DeleteClient(selectedClient);
                    ShowClients();
                }
            }

        }
    }
}
