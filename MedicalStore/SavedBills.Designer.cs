namespace MedicalStore
{
    partial class SavedBills
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fromDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ToDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1SavedBills = new System.Windows.Forms.DataGridView();
            this.billId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1SavedBills)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(445, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saved Bills";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search with Date : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "To : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "From : ";
            // 
            // fromDateTimePicker1
            // 
            this.fromDateTimePicker1.Location = new System.Drawing.Point(304, 76);
            this.fromDateTimePicker1.Name = "fromDateTimePicker1";
            this.fromDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.fromDateTimePicker1.TabIndex = 4;
            this.fromDateTimePicker1.ValueChanged += new System.EventHandler(this.fromDateTimePicker1_ValueChanged);
            // 
            // ToDateTimePicker2
            // 
            this.ToDateTimePicker2.Location = new System.Drawing.Point(588, 76);
            this.ToDateTimePicker2.Name = "ToDateTimePicker2";
            this.ToDateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.ToDateTimePicker2.TabIndex = 5;
            this.ToDateTimePicker2.ValueChanged += new System.EventHandler(this.ToDateTimePicker2_ValueChanged);
            // 
            // dataGridView1SavedBills
            // 
            this.dataGridView1SavedBills.AllowUserToAddRows = false;
            this.dataGridView1SavedBills.AllowUserToDeleteRows = false;
            this.dataGridView1SavedBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1SavedBills.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1SavedBills.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1SavedBills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1SavedBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1SavedBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billId,
            this.customerName,
            this.customerContact,
            this.medicineList,
            this.totalPrice,
            this.billDate});
            this.dataGridView1SavedBills.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1SavedBills.Name = "dataGridView1SavedBills";
            this.dataGridView1SavedBills.ReadOnly = true;
            this.dataGridView1SavedBills.Size = new System.Drawing.Size(960, 386);
            this.dataGridView1SavedBills.TabIndex = 6;
            // 
            // billId
            // 
            this.billId.DataPropertyName = "billId";
            this.billId.HeaderText = "Bill ID";
            this.billId.Name = "billId";
            this.billId.ReadOnly = true;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "customerName";
            this.customerName.HeaderText = "Customer Name";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            // 
            // customerContact
            // 
            this.customerContact.DataPropertyName = "customerContact";
            this.customerContact.HeaderText = "Customer Contact";
            this.customerContact.Name = "customerContact";
            this.customerContact.ReadOnly = true;
            // 
            // medicineList
            // 
            this.medicineList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.medicineList.DataPropertyName = "medicineList";
            this.medicineList.HeaderText = "Medicine List";
            this.medicineList.Name = "medicineList";
            this.medicineList.ReadOnly = true;
            this.medicineList.Width = 94;
            // 
            // totalPrice
            // 
            this.totalPrice.DataPropertyName = "totalPrice";
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // billDate
            // 
            this.billDate.DataPropertyName = "billDate";
            this.billDate.HeaderText = "Bill Date";
            this.billDate.Name = "billDate";
            this.billDate.ReadOnly = true;
            // 
            // SavedBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 550);
            this.Controls.Add(this.dataGridView1SavedBills);
            this.Controls.Add(this.ToDateTimePicker2);
            this.Controls.Add(this.fromDateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SavedBills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SavedBills";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1SavedBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker1;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1SavedBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn billId;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineList;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn billDate;
    }
}