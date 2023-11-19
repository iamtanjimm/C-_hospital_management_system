namespace Final_Term_Project
{
    partial class Form7
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
            this.textBox_DoctorsName7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Doctorsearch7 = new System.Windows.Forms.Button();
            this.button_back7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(644, 245);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox_DoctorsName7
            // 
            this.textBox_DoctorsName7.Location = new System.Drawing.Point(326, 57);
            this.textBox_DoctorsName7.Multiline = true;
            this.textBox_DoctorsName7.Name = "textBox_DoctorsName7";
            this.textBox_DoctorsName7.Size = new System.Drawing.Size(173, 39);
            this.textBox_DoctorsName7.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "DOCTOR\'S NAME";
            // 
            // button_Doctorsearch7
            // 
            this.button_Doctorsearch7.Location = new System.Drawing.Point(364, 102);
            this.button_Doctorsearch7.Name = "button_Doctorsearch7";
            this.button_Doctorsearch7.Size = new System.Drawing.Size(92, 23);
            this.button_Doctorsearch7.TabIndex = 3;
            this.button_Doctorsearch7.Text = "SEARCH";
            this.button_Doctorsearch7.UseVisualStyleBackColor = true;
            this.button_Doctorsearch7.Click += new System.EventHandler(this.button_Doctorsearch7_Click);
            // 
            // button_back7
            // 
            this.button_back7.Location = new System.Drawing.Point(364, 417);
            this.button_back7.Name = "button_back7";
            this.button_back7.Size = new System.Drawing.Size(92, 23);
            this.button_back7.TabIndex = 4;
            this.button_back7.Text = "BACK";
            this.button_back7.UseVisualStyleBackColor = true;
            this.button_back7.Click += new System.EventHandler(this.button_back7_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.button_back7);
            this.Controls.Add(this.button_Doctorsearch7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_DoctorsName7);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_DoctorsName7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Doctorsearch7;
        private System.Windows.Forms.Button button_back7;
    }
}