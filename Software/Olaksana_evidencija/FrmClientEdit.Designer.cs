namespace Olaksana_evidencija
{
    partial class FrmClientEdit
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.txtMjestoStanovanja = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.lblMjestoStanovanja = new System.Windows.Forms.Label();
            this.lblOIB = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.txtEmail.Location = new System.Drawing.Point(41, 378);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(443, 44);
            this.txtEmail.TabIndex = 41;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.txtBrojTelefona.Location = new System.Drawing.Point(416, 178);
            this.txtBrojTelefona.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrojTelefona.MaxLength = 15;
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(277, 44);
            this.txtBrojTelefona.TabIndex = 40;
            this.txtBrojTelefona.TextChanged += new System.EventHandler(this.txtBrojTelefona_TextChanged);
            // 
            // txtMjestoStanovanja
            // 
            this.txtMjestoStanovanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.txtMjestoStanovanja.Location = new System.Drawing.Point(41, 278);
            this.txtMjestoStanovanja.Margin = new System.Windows.Forms.Padding(4);
            this.txtMjestoStanovanja.MaxLength = 100;
            this.txtMjestoStanovanja.Name = "txtMjestoStanovanja";
            this.txtMjestoStanovanja.Size = new System.Drawing.Size(443, 44);
            this.txtMjestoStanovanja.TabIndex = 39;
            this.txtMjestoStanovanja.TextChanged += new System.EventHandler(this.txtMjestoStanovanja_TextChanged);
            // 
            // txtOIB
            // 
            this.txtOIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.txtOIB.Location = new System.Drawing.Point(41, 178);
            this.txtOIB.Margin = new System.Windows.Forms.Padding(4);
            this.txtOIB.MaxLength = 11;
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.ReadOnly = true;
            this.txtOIB.Size = new System.Drawing.Size(283, 44);
            this.txtOIB.TabIndex = 38;
            this.txtOIB.TextChanged += new System.EventHandler(this.txtOIB_TextChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.txtPrezime.Location = new System.Drawing.Point(416, 82);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.MaxLength = 30;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(277, 44);
            this.txtPrezime.TabIndex = 37;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.txtIme.Location = new System.Drawing.Point(41, 82);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.MaxLength = 30;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(283, 44);
            this.txtIme.TabIndex = 36;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.lblEmail.Location = new System.Drawing.Point(47, 336);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(109, 38);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "E-mail";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.lblBrojTelefona.Location = new System.Drawing.Point(435, 138);
            this.lblBrojTelefona.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(199, 38);
            this.lblBrojTelefona.TabIndex = 34;
            this.lblBrojTelefona.Text = "Broj telefona";
            this.lblBrojTelefona.Click += new System.EventHandler(this.lblBrojTelefona_Click);
            // 
            // lblMjestoStanovanja
            // 
            this.lblMjestoStanovanja.AutoSize = true;
            this.lblMjestoStanovanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.lblMjestoStanovanja.Location = new System.Drawing.Point(47, 238);
            this.lblMjestoStanovanja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMjestoStanovanja.Name = "lblMjestoStanovanja";
            this.lblMjestoStanovanja.Size = new System.Drawing.Size(280, 38);
            this.lblMjestoStanovanja.TabIndex = 33;
            this.lblMjestoStanovanja.Text = "Mjesto stanovanja";
            this.lblMjestoStanovanja.Click += new System.EventHandler(this.lblMjestoStanovanja_Click);
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.lblOIB.Location = new System.Drawing.Point(47, 138);
            this.lblOIB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(73, 38);
            this.lblOIB.TabIndex = 32;
            this.lblOIB.Text = "OIB";
            this.lblOIB.Click += new System.EventHandler(this.lblOIB_Click);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.lblPrezime.Location = new System.Drawing.Point(471, 42);
            this.lblPrezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(137, 38);
            this.lblPrezime.TabIndex = 31;
            this.lblPrezime.Text = "Prezime";
            this.lblPrezime.Click += new System.EventHandler(this.lblPrezime_Click);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.lblIme.Location = new System.Drawing.Point(47, 42);
            this.lblIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(70, 38);
            this.lblIme.TabIndex = 30;
            this.lblIme.Text = "Ime";
            this.lblIme.Click += new System.EventHandler(this.lblIme_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.btnCancel.Location = new System.Drawing.Point(555, 358);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 65);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.btnSave.Location = new System.Drawing.Point(555, 258);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 65);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmClientEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 466);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtBrojTelefona);
            this.Controls.Add(this.txtMjestoStanovanja);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblBrojTelefona);
            this.Controls.Add(this.lblMjestoStanovanja);
            this.Controls.Add(this.lblOIB);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmClientEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uređivanje klijenta";
            this.Load += new System.EventHandler(this.FrmClientEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.TextBox txtMjestoStanovanja;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.Label lblMjestoStanovanja;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}