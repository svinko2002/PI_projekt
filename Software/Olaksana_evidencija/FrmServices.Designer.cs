namespace Olaksana_evidencija
{
    partial class FrmServices
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
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.btnEditService = new System.Windows.Forms.Button();
            this.btnAddNewService = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServices
            // 
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Location = new System.Drawing.Point(26, 50);
            this.dgvServices.Margin = new System.Windows.Forms.Padding(4);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersWidth = 51;
            this.dgvServices.Size = new System.Drawing.Size(1360, 517);
            this.dgvServices.TabIndex = 7;
            this.dgvServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellContentClick);
            // 
            // btnEditService
            // 
            this.btnEditService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnEditService.Location = new System.Drawing.Point(735, 575);
            this.btnEditService.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(300, 63);
            this.btnEditService.TabIndex = 6;
            this.btnEditService.Text = "Uredi uslugu";
            this.btnEditService.UseVisualStyleBackColor = true;
            this.btnEditService.Click += new System.EventHandler(this.btnEditService_Click);
            // 
            // btnAddNewService
            // 
            this.btnAddNewService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnAddNewService.Location = new System.Drawing.Point(1086, 575);
            this.btnAddNewService.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewService.Name = "btnAddNewService";
            this.btnAddNewService.Size = new System.Drawing.Size(300, 63);
            this.btnAddNewService.TabIndex = 5;
            this.btnAddNewService.Text = "Dodaj uslugu";
            this.btnAddNewService.UseVisualStyleBackColor = true;
            this.btnAddNewService.Click += new System.EventHandler(this.btnAddNewService_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnPovratak.Location = new System.Drawing.Point(42, 575);
            this.btnPovratak.Margin = new System.Windows.Forms.Padding(4);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(300, 63);
            this.btnPovratak.TabIndex = 4;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnDelete.Location = new System.Drawing.Point(386, 575);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(300, 63);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Obriši uslugu";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtPretrazi.Location = new System.Drawing.Point(179, 9);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(314, 34);
            this.txtPretrazi.TabIndex = 9;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pretraživanje";
            // 
            // FrmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 674);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.btnEditService);
            this.Controls.Add(this.btnAddNewService);
            this.Controls.Add(this.btnPovratak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmServices";
            this.Load += new System.EventHandler(this.FrmServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Button btnEditService;
        private System.Windows.Forms.Button btnAddNewService;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Label label1;
    }
}