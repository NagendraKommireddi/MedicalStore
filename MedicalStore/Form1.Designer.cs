namespace MedicalStore
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medical Store Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sno,
            this.unitPrice,
            this.medStatus,
            this.medId,
            this.medName,
            this.medUnits});
            this.dataGridView1.Location = new System.Drawing.Point(68, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 55;
            this.dataGridView1.Size = new System.Drawing.Size(959, 431);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sno
            // 
            this.sno.Frozen = true;
            this.sno.HeaderText = "S.No";
            this.sno.Name = "sno";
            // 
            // unitPrice
            // 
            this.unitPrice.Frozen = true;
            this.unitPrice.HeaderText = "Price per Unit";
            this.unitPrice.Name = "unitPrice";
            // 
            // medStatus
            // 
            this.medStatus.Frozen = true;
            this.medStatus.HeaderText = "Availability";
            this.medStatus.Name = "medStatus";
            // 
            // medId
            // 
            this.medId.Frozen = true;
            this.medId.HeaderText = "Medicine ID";
            this.medId.Name = "medId";
            // 
            // medName
            // 
            this.medName.Frozen = true;
            this.medName.HeaderText = "Medicine Name";
            this.medName.Name = "medName";
            // 
            // medUnits
            // 
            this.medUnits.Frozen = true;
            this.medUnits.HeaderText = "Total Units";
            this.medUnits.Name = "medUnits";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medical Store Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn medStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn medId;
        private System.Windows.Forms.DataGridViewTextBoxColumn medName;
        private System.Windows.Forms.DataGridViewTextBoxColumn medUnits;
    }
}

