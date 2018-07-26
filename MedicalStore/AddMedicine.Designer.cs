namespace MedicalStore
{
    partial class AddMedicine
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.medIdTextBox1 = new System.Windows.Forms.TextBox();
            this.medNameTextBox2 = new System.Windows.Forms.TextBox();
            this.medUnitsTextBox3 = new System.Windows.Forms.TextBox();
            this.medPriceTextBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.alertLabel6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Medicine";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Medicine Price per Unit : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Medicine Units : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Medicine Name : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Medicine ID : ";
            // 
            // medIdTextBox1
            // 
            this.medIdTextBox1.Location = new System.Drawing.Point(388, 89);
            this.medIdTextBox1.Name = "medIdTextBox1";
            this.medIdTextBox1.Size = new System.Drawing.Size(218, 20);
            this.medIdTextBox1.TabIndex = 9;
            // 
            // medNameTextBox2
            // 
            this.medNameTextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.medNameTextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.medNameTextBox2.Location = new System.Drawing.Point(388, 133);
            this.medNameTextBox2.Name = "medNameTextBox2";
            this.medNameTextBox2.Size = new System.Drawing.Size(218, 20);
            this.medNameTextBox2.TabIndex = 10;
            this.medNameTextBox2.TextChanged += new System.EventHandler(this.medNameTextBox2_TextChanged);
            // 
            // medUnitsTextBox3
            // 
            this.medUnitsTextBox3.Location = new System.Drawing.Point(388, 171);
            this.medUnitsTextBox3.Name = "medUnitsTextBox3";
            this.medUnitsTextBox3.Size = new System.Drawing.Size(218, 20);
            this.medUnitsTextBox3.TabIndex = 11;
            // 
            // medPriceTextBox4
            // 
            this.medPriceTextBox4.Location = new System.Drawing.Point(388, 223);
            this.medPriceTextBox4.Name = "medPriceTextBox4";
            this.medPriceTextBox4.Size = new System.Drawing.Size(218, 20);
            this.medPriceTextBox4.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(457, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 33);
            this.button4.TabIndex = 20;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(239, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alertLabel6
            // 
            this.alertLabel6.AutoSize = true;
            this.alertLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertLabel6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.alertLabel6.Location = new System.Drawing.Point(275, 273);
            this.alertLabel6.Name = "alertLabel6";
            this.alertLabel6.Size = new System.Drawing.Size(0, 18);
            this.alertLabel6.TabIndex = 22;
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alertLabel6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.medPriceTextBox4);
            this.Controls.Add(this.medUnitsTextBox3);
            this.Controls.Add(this.medNameTextBox2);
            this.Controls.Add(this.medIdTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddMedicine";
            this.Load += new System.EventHandler(this.AddMedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox medIdTextBox1;
        private System.Windows.Forms.TextBox medNameTextBox2;
        private System.Windows.Forms.TextBox medUnitsTextBox3;
        private System.Windows.Forms.TextBox medPriceTextBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label alertLabel6;
    }
}