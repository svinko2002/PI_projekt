namespace Olaksana_evidencija
{
    partial class FrmServiceAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblVrstaUsluge = new System.Windows.Forms.Label();
            this.txtVrstaUsluge = new System.Windows.Forms.TextBox();
            this.lblLokacijaObavljanja = new System.Windows.Forms.Label();
            this.txtLokacijaObavljanja = new System.Windows.Forms.TextBox();
            this.lblProcijenjenoVrijemeObavljanja = new System.Windows.Forms.Label();
            this.txtProcijenjenoVrijemeObavljanja = new System.Windows.Forms.TextBox();
            this.lblvrijemeObavljanja = new System.Windows.Forms.Label();
            this.lblVremenskiInterval = new System.Windows.Forms.Label();
            this.chkPonavljajucaUsluga = new System.Windows.Forms.CheckBox();
            this.chkPonavljajuciPodsjetnik = new System.Windows.Forms.CheckBox();
            this.txtVremenskiInterval = new System.Windows.Forms.TextBox();
            this.dateTPVrijemeObavljanja = new System.Windows.Forms.DateTimePicker();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.cboKlijenti = new System.Windows.Forms.ComboBox();
            this.lblOIBKlijenta = new System.Windows.Forms.Label();
            this.cboVrsteUsluga1 = new System.Windows.Forms.ComboBox();
            this.cboVrsteUsluga2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.btnSave.Location = new System.Drawing.Point(611, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(209, 78);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.btnCancel.Location = new System.Drawing.Point(386, 405);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(209, 78);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtId.Location = new System.Drawing.Point(101, 39);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(185, 34);
            this.txtId.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblId.Location = new System.Drawing.Point(172, 7);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(36, 29);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID";
            // 
            // lblVrstaUsluge
            // 
            this.lblVrstaUsluge.AutoSize = true;
            this.lblVrstaUsluge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblVrstaUsluge.Location = new System.Drawing.Point(69, 89);
            this.lblVrstaUsluge.Name = "lblVrstaUsluge";
            this.lblVrstaUsluge.Size = new System.Drawing.Size(273, 29);
            this.lblVrstaUsluge.TabIndex = 5;
            this.lblVrstaUsluge.Text = "Vrsta usluge (kategorija)";
            this.lblVrstaUsluge.Click += new System.EventHandler(this.lblVrstaUsluge_Click);
            // 
            // txtVrstaUsluge
            // 
            this.txtVrstaUsluge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtVrstaUsluge.Location = new System.Drawing.Point(778, 145);
            this.txtVrstaUsluge.MaxLength = 30;
            this.txtVrstaUsluge.Name = "txtVrstaUsluge";
            this.txtVrstaUsluge.ReadOnly = true;
            this.txtVrstaUsluge.Size = new System.Drawing.Size(42, 34);
            this.txtVrstaUsluge.TabIndex = 4;
            this.txtVrstaUsluge.Visible = false;
            // 
            // lblLokacijaObavljanja
            // 
            this.lblLokacijaObavljanja.AutoSize = true;
            this.lblLokacijaObavljanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblLokacijaObavljanja.Location = new System.Drawing.Point(96, 232);
            this.lblLokacijaObavljanja.Name = "lblLokacijaObavljanja";
            this.lblLokacijaObavljanja.Size = new System.Drawing.Size(217, 29);
            this.lblLokacijaObavljanja.TabIndex = 7;
            this.lblLokacijaObavljanja.Text = "Lokacija obavljanja";
            // 
            // txtLokacijaObavljanja
            // 
            this.txtLokacijaObavljanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtLokacijaObavljanja.Location = new System.Drawing.Point(40, 264);
            this.txtLokacijaObavljanja.MaxLength = 50;
            this.txtLokacijaObavljanja.Name = "txtLokacijaObavljanja";
            this.txtLokacijaObavljanja.Size = new System.Drawing.Size(339, 34);
            this.txtLokacijaObavljanja.TabIndex = 6;
            // 
            // lblProcijenjenoVrijemeObavljanja
            // 
            this.lblProcijenjenoVrijemeObavljanja.AutoSize = true;
            this.lblProcijenjenoVrijemeObavljanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblProcijenjenoVrijemeObavljanja.Location = new System.Drawing.Point(35, 317);
            this.lblProcijenjenoVrijemeObavljanja.Name = "lblProcijenjenoVrijemeObavljanja";
            this.lblProcijenjenoVrijemeObavljanja.Size = new System.Drawing.Size(349, 29);
            this.lblProcijenjenoVrijemeObavljanja.TabIndex = 9;
            this.lblProcijenjenoVrijemeObavljanja.Text = "Procijenjeno vrijeme obavljanja";
            // 
            // txtProcijenjenoVrijemeObavljanja
            // 
            this.txtProcijenjenoVrijemeObavljanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtProcijenjenoVrijemeObavljanja.Location = new System.Drawing.Point(104, 349);
            this.txtProcijenjenoVrijemeObavljanja.MaxLength = 2;
            this.txtProcijenjenoVrijemeObavljanja.Name = "txtProcijenjenoVrijemeObavljanja";
            this.txtProcijenjenoVrijemeObavljanja.Size = new System.Drawing.Size(185, 34);
            this.txtProcijenjenoVrijemeObavljanja.TabIndex = 8;
            // 
            // lblvrijemeObavljanja
            // 
            this.lblvrijemeObavljanja.AutoSize = true;
            this.lblvrijemeObavljanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblvrijemeObavljanja.Location = new System.Drawing.Point(90, 398);
            this.lblvrijemeObavljanja.Name = "lblvrijemeObavljanja";
            this.lblvrijemeObavljanja.Size = new System.Drawing.Size(211, 29);
            this.lblvrijemeObavljanja.TabIndex = 11;
            this.lblvrijemeObavljanja.Text = "Vrijeme obavljanja";
            // 
            // lblVremenskiInterval
            // 
            this.lblVremenskiInterval.AutoSize = true;
            this.lblVremenskiInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblVremenskiInterval.Location = new System.Drawing.Point(471, 145);
            this.lblVremenskiInterval.Name = "lblVremenskiInterval";
            this.lblVremenskiInterval.Size = new System.Drawing.Size(210, 29);
            this.lblVremenskiInterval.TabIndex = 17;
            this.lblVremenskiInterval.Text = "Vremenski interval";
            // 
            // chkPonavljajucaUsluga
            // 
            this.chkPonavljajucaUsluga.AutoSize = true;
            this.chkPonavljajucaUsluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.chkPonavljajucaUsluga.Location = new System.Drawing.Point(471, 99);
            this.chkPonavljajucaUsluga.Name = "chkPonavljajucaUsluga";
            this.chkPonavljajucaUsluga.Size = new System.Drawing.Size(248, 33);
            this.chkPonavljajucaUsluga.TabIndex = 18;
            this.chkPonavljajucaUsluga.Text = "Ponavljajuca usluga";
            this.chkPonavljajucaUsluga.UseVisualStyleBackColor = true;
            // 
            // chkPonavljajuciPodsjetnik
            // 
            this.chkPonavljajuciPodsjetnik.AutoSize = true;
            this.chkPonavljajuciPodsjetnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.chkPonavljajuciPodsjetnik.Location = new System.Drawing.Point(471, 51);
            this.chkPonavljajuciPodsjetnik.Name = "chkPonavljajuciPodsjetnik";
            this.chkPonavljajuciPodsjetnik.Size = new System.Drawing.Size(281, 33);
            this.chkPonavljajuciPodsjetnik.TabIndex = 19;
            this.chkPonavljajuciPodsjetnik.Text = "Ponavljajuci podsjetnik";
            this.chkPonavljajuciPodsjetnik.UseVisualStyleBackColor = true;
            // 
            // txtVremenskiInterval
            // 
            this.txtVremenskiInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtVremenskiInterval.Location = new System.Drawing.Point(486, 177);
            this.txtVremenskiInterval.Name = "txtVremenskiInterval";
            this.txtVremenskiInterval.Size = new System.Drawing.Size(185, 34);
            this.txtVremenskiInterval.TabIndex = 16;
            // 
            // dateTPVrijemeObavljanja
            // 
            this.dateTPVrijemeObavljanja.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTPVrijemeObavljanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.dateTPVrijemeObavljanja.Location = new System.Drawing.Point(61, 430);
            this.dateTPVrijemeObavljanja.Name = "dateTPVrijemeObavljanja";
            this.dateTPVrijemeObavljanja.Size = new System.Drawing.Size(261, 34);
            this.dateTPVrijemeObavljanja.TabIndex = 20;
            // 
            // txtClient
            // 
            this.txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtClient.Location = new System.Drawing.Point(436, 337);
            this.txtClient.MaxLength = 11;
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(199, 34);
            this.txtClient.TabIndex = 21;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblClient.Location = new System.Drawing.Point(452, 232);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(80, 29);
            this.lblClient.TabIndex = 22;
            this.lblClient.Text = "Klijent";
            this.lblClient.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboKlijenti
            // 
            this.cboKlijenti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKlijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.cboKlijenti.FormattingEnabled = true;
            this.cboKlijenti.Location = new System.Drawing.Point(436, 264);
            this.cboKlijenti.Name = "cboKlijenti";
            this.cboKlijenti.Size = new System.Drawing.Size(410, 37);
            this.cboKlijenti.TabIndex = 23;
            this.cboKlijenti.SelectedIndexChanged += new System.EventHandler(this.cboKlijenti_SelectedIndexChanged);
            // 
            // lblOIBKlijenta
            // 
            this.lblOIBKlijenta.AutoSize = true;
            this.lblOIBKlijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblOIBKlijenta.Location = new System.Drawing.Point(431, 304);
            this.lblOIBKlijenta.Name = "lblOIBKlijenta";
            this.lblOIBKlijenta.Size = new System.Drawing.Size(136, 29);
            this.lblOIBKlijenta.TabIndex = 24;
            this.lblOIBKlijenta.Text = "OIB klijenta";
            this.lblOIBKlijenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboVrsteUsluga1
            // 
            this.cboVrsteUsluga1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVrsteUsluga1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cboVrsteUsluga1.FormattingEnabled = true;
            this.cboVrsteUsluga1.Items.AddRange(new object[] {
            "1. Redovito čišćenje ",
            "2. Generalno čišćenje",
            "3. Kemijsko čišćenje ",
            "4. Čišćenje vanjskih površina i objekata"});
            this.cboVrsteUsluga1.Location = new System.Drawing.Point(22, 121);
            this.cboVrsteUsluga1.Name = "cboVrsteUsluga1";
            this.cboVrsteUsluga1.Size = new System.Drawing.Size(409, 30);
            this.cboVrsteUsluga1.TabIndex = 25;
            this.cboVrsteUsluga1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboVrsteUsluga2
            // 
            this.cboVrsteUsluga2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVrsteUsluga2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cboVrsteUsluga2.FormattingEnabled = true;
            this.cboVrsteUsluga2.Location = new System.Drawing.Point(22, 192);
            this.cboVrsteUsluga2.Name = "cboVrsteUsluga2";
            this.cboVrsteUsluga2.Size = new System.Drawing.Size(409, 30);
            this.cboVrsteUsluga2.TabIndex = 26;
            this.cboVrsteUsluga2.SelectedIndexChanged += new System.EventHandler(this.cboVrsteUsluga2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.Location = new System.Drawing.Point(69, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Vrsta usluge (podkategorija)";
            // 
            // FrmServiceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboVrsteUsluga2);
            this.Controls.Add(this.cboVrsteUsluga1);
            this.Controls.Add(this.lblOIBKlijenta);
            this.Controls.Add(this.cboKlijenti);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.dateTPVrijemeObavljanja);
            this.Controls.Add(this.chkPonavljajuciPodsjetnik);
            this.Controls.Add(this.chkPonavljajucaUsluga);
            this.Controls.Add(this.lblVremenskiInterval);
            this.Controls.Add(this.txtVremenskiInterval);
            this.Controls.Add(this.lblvrijemeObavljanja);
            this.Controls.Add(this.lblProcijenjenoVrijemeObavljanja);
            this.Controls.Add(this.txtProcijenjenoVrijemeObavljanja);
            this.Controls.Add(this.lblLokacijaObavljanja);
            this.Controls.Add(this.txtLokacijaObavljanja);
            this.Controls.Add(this.lblVrstaUsluge);
            this.Controls.Add(this.txtVrstaUsluge);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "FrmServiceAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje usluge";
            this.Load += new System.EventHandler(this.FrmServiceAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblVrstaUsluge;
        private System.Windows.Forms.TextBox txtVrstaUsluge;
        private System.Windows.Forms.Label lblLokacijaObavljanja;
        private System.Windows.Forms.TextBox txtLokacijaObavljanja;
        private System.Windows.Forms.Label lblProcijenjenoVrijemeObavljanja;
        private System.Windows.Forms.TextBox txtProcijenjenoVrijemeObavljanja;
        private System.Windows.Forms.Label lblvrijemeObavljanja;
        private System.Windows.Forms.Label lblVremenskiInterval;
        private System.Windows.Forms.CheckBox chkPonavljajucaUsluga;
        private System.Windows.Forms.CheckBox chkPonavljajuciPodsjetnik;
        private System.Windows.Forms.TextBox txtVremenskiInterval;
        private System.Windows.Forms.DateTimePicker dateTPVrijemeObavljanja;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cboKlijenti;
        private System.Windows.Forms.Label lblOIBKlijenta;
        private System.Windows.Forms.ComboBox cboVrsteUsluga1;
        private System.Windows.Forms.ComboBox cboVrsteUsluga2;
        private System.Windows.Forms.Label label1;
    }
}