namespace Final_Term_Project
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_patientid = new System.Windows.Forms.TextBox();
            this.textBox_patientName = new System.Windows.Forms.TextBox();
            this.textBox_DoctorsName = new System.Windows.Forms.TextBox();
            this.textBox_patientage = new System.Windows.Forms.TextBox();
            this.textBox_patientgender = new System.Windows.Forms.TextBox();
            this.button_addpatient = new System.Windows.Forms.Button();
            this.button_showpatients = new System.Windows.Forms.Button();
            this.button_back_from5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(740, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doctor\'s Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Patient ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender";
            // 
            // textBox_patientid
            // 
            this.textBox_patientid.Location = new System.Drawing.Point(154, 47);
            this.textBox_patientid.Name = "textBox_patientid";
            this.textBox_patientid.Size = new System.Drawing.Size(210, 22);
            this.textBox_patientid.TabIndex = 6;
            // 
            // textBox_patientName
            // 
            this.textBox_patientName.Location = new System.Drawing.Point(578, 50);
            this.textBox_patientName.Name = "textBox_patientName";
            this.textBox_patientName.Size = new System.Drawing.Size(199, 22);
            this.textBox_patientName.TabIndex = 7;
            // 
            // textBox_DoctorsName
            // 
            this.textBox_DoctorsName.Location = new System.Drawing.Point(154, 94);
            this.textBox_DoctorsName.Name = "textBox_DoctorsName";
            this.textBox_DoctorsName.Size = new System.Drawing.Size(210, 22);
            this.textBox_DoctorsName.TabIndex = 8;
            // 
            // textBox_patientage
            // 
            this.textBox_patientage.Location = new System.Drawing.Point(578, 94);
            this.textBox_patientage.Name = "textBox_patientage";
            this.textBox_patientage.Size = new System.Drawing.Size(199, 22);
            this.textBox_patientage.TabIndex = 9;
            this.textBox_patientage.TextChanged += new System.EventHandler(this.textBox_patientage_TextChanged);
            // 
            // textBox_patientgender
            // 
            this.textBox_patientgender.Location = new System.Drawing.Point(154, 138);
            this.textBox_patientgender.Name = "textBox_patientgender";
            this.textBox_patientgender.Size = new System.Drawing.Size(210, 22);
            this.textBox_patientgender.TabIndex = 10;
            // 
            // button_addpatient
            // 
            this.button_addpatient.Location = new System.Drawing.Point(532, 141);
            this.button_addpatient.Name = "button_addpatient";
            this.button_addpatient.Size = new System.Drawing.Size(75, 23);
            this.button_addpatient.TabIndex = 11;
            this.button_addpatient.Text = "ADD";
            this.button_addpatient.UseVisualStyleBackColor = true;
            this.button_addpatient.Click += new System.EventHandler(this.button_addpatient_Click);
            // 
            // button_showpatients
            // 
            this.button_showpatients.Location = new System.Drawing.Point(647, 141);
            this.button_showpatients.Name = "button_showpatients";
            this.button_showpatients.Size = new System.Drawing.Size(130, 23);
            this.button_showpatients.TabIndex = 13;
            this.button_showpatients.Text = "PATIENT LIST";
            this.button_showpatients.UseVisualStyleBackColor = true;
            this.button_showpatients.Click += new System.EventHandler(this.button_showpatients_Click);
            // 
            // button_back_from5
            // 
            this.button_back_from5.Location = new System.Drawing.Point(48, 415);
            this.button_back_from5.Name = "button_back_from5";
            this.button_back_from5.Size = new System.Drawing.Size(75, 23);
            this.button_back_from5.TabIndex = 14;
            this.button_back_from5.Text = "BACK";
            this.button_back_from5.UseVisualStyleBackColor = true;
            this.button_back_from5.Click += new System.EventHandler(this.button_back_from5_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_back_from5);
            this.Controls.Add(this.button_showpatients);
            this.Controls.Add(this.button_addpatient);
            this.Controls.Add(this.textBox_patientgender);
            this.Controls.Add(this.textBox_patientage);
            this.Controls.Add(this.textBox_DoctorsName);
            this.Controls.Add(this.textBox_patientName);
            this.Controls.Add(this.textBox_patientid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_patientid;
        private System.Windows.Forms.TextBox textBox_patientName;
        private System.Windows.Forms.TextBox textBox_DoctorsName;
        private System.Windows.Forms.TextBox textBox_patientage;
        private System.Windows.Forms.TextBox textBox_patientgender;
        private System.Windows.Forms.Button button_addpatient;
        private System.Windows.Forms.Button button_showpatients;
        private System.Windows.Forms.Button button_back_from5;
    }
}