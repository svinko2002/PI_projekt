namespace Olaksana_evidencija
{
    partial class FrmOdabir
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
            this.btnOpenServices = new System.Windows.Forms.Button();
            this.btnOpenEmployees = new System.Windows.Forms.Button();
            this.btnOpenClients = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenServices
            // 
            this.btnOpenServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.btnOpenServices.Location = new System.Drawing.Point(100, 12);
            this.btnOpenServices.Name = "btnOpenServices";
            this.btnOpenServices.Size = new System.Drawing.Size(711, 117);
            this.btnOpenServices.TabIndex = 0;
            this.btnOpenServices.Text = "Usluge";
            this.btnOpenServices.UseVisualStyleBackColor = true;
            this.btnOpenServices.Click += new System.EventHandler(this.btnOpenServices_Click);
            // 
            // btnOpenEmployees
            // 
            this.btnOpenEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.btnOpenEmployees.Location = new System.Drawing.Point(100, 135);
            this.btnOpenEmployees.Name = "btnOpenEmployees";
            this.btnOpenEmployees.Size = new System.Drawing.Size(711, 117);
            this.btnOpenEmployees.TabIndex = 1;
            this.btnOpenEmployees.Text = "Zaposlenici";
            this.btnOpenEmployees.UseVisualStyleBackColor = true;
            this.btnOpenEmployees.Click += new System.EventHandler(this.btnOpenEmployees_Click);
            // 
            // btnOpenClients
            // 
            this.btnOpenClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.btnOpenClients.Location = new System.Drawing.Point(100, 258);
            this.btnOpenClients.Name = "btnOpenClients";
            this.btnOpenClients.Size = new System.Drawing.Size(711, 117);
            this.btnOpenClients.TabIndex = 2;
            this.btnOpenClients.Text = "Klijenti";
            this.btnOpenClients.UseVisualStyleBackColor = true;
            this.btnOpenClients.Click += new System.EventHandler(this.btnOpenClients_Click);
            // 
            // FrmOdabir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 386);
            this.Controls.Add(this.btnOpenClients);
            this.Controls.Add(this.btnOpenEmployees);
            this.Controls.Add(this.btnOpenServices);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOdabir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odabir podataka";
            this.Load += new System.EventHandler(this.FrmOdabir_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenServices;
        private System.Windows.Forms.Button btnOpenEmployees;
        private System.Windows.Forms.Button btnOpenClients;
    }
}

