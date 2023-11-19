namespace Final_Term_Project
{
    partial class Form4
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
            this.button_adddoctor = new System.Windows.Forms.Button();
            this.button_doctorlist = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_deletedoctor = new System.Windows.Forms.Button();
            this.textBox_Did = new System.Windows.Forms.TextBox();
            this.textBox_DN = new System.Windows.Forms.TextBox();
            this.textBox_DS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_back_from4 = new System.Windows.Forms.Button();
            this.textBox_doctorsidsearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_doctorsidsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_adddoctor
            // 
            this.button_adddoctor.Location = new System.Drawing.Point(12, 341);
            this.button_adddoctor.Name = "button_adddoctor";
            this.button_adddoctor.Size = new System.Drawing.Size(116, 46);
            this.button_adddoctor.TabIndex = 0;
            this.button_adddoctor.Text = "Add Doctor";
            this.button_adddoctor.UseVisualStyleBackColor = true;
            this.button_adddoctor.Click += new System.EventHandler(this.button_adddoctor_Click);
            // 
            // button_doctorlist
            // 
            this.button_doctorlist.Location = new System.Drawing.Point(102, 12);
            this.button_doctorlist.Name = "button_doctorlist";
            this.button_doctorlist.Size = new System.Drawing.Size(109, 48);
            this.button_doctorlist.TabIndex = 1;
            this.button_doctorlist.Text = "Doctor List";
            this.button_doctorlist.UseVisualStyleBackColor = true;
            this.button_doctorlist.Click += new System.EventHandler(this.button_doctorlist_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(335, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(453, 362);
            this.dataGridView1.TabIndex = 2;
            // 
            // button_deletedoctor
            // 
            this.button_deletedoctor.Location = new System.Drawing.Point(174, 341);
            this.button_deletedoctor.Name = "button_deletedoctor";
            this.button_deletedoctor.Size = new System.Drawing.Size(141, 46);
            this.button_deletedoctor.TabIndex = 3;
            this.button_deletedoctor.Text = "Delete Doctor";
            this.button_deletedoctor.UseVisualStyleBackColor = true;
            this.button_deletedoctor.Click += new System.EventHandler(this.button_deletedoctor_Click);
            // 
            // textBox_Did
            // 
            this.textBox_Did.Location = new System.Drawing.Point(197, 109);
            this.textBox_Did.Name = "textBox_Did";
            this.textBox_Did.Size = new System.Drawing.Size(100, 22);
            this.textBox_Did.TabIndex = 4;
            // 
            // textBox_DN
            // 
            this.textBox_DN.Location = new System.Drawing.Point(197, 164);
            this.textBox_DN.Name = "textBox_DN";
            this.textBox_DN.Size = new System.Drawing.Size(100, 22);
            this.textBox_DN.TabIndex = 5;
            this.textBox_DN.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_DS
            // 
            this.textBox_DS.Location = new System.Drawing.Point(197, 209);
            this.textBox_DS.Name = "textBox_DS";
            this.textBox_DS.Size = new System.Drawing.Size(100, 22);
            this.textBox_DS.TabIndex = 6;
            this.textBox_DS.TextChanged += new System.EventHandler(this.textBox_DS_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doctor\'s ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Doctor\'s Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Doctor\'s Specialities";
            // 
            // button_back_from4
            // 
            this.button_back_from4.Location = new System.Drawing.Point(12, 405);
            this.button_back_from4.Name = "button_back_from4";
            this.button_back_from4.Size = new System.Drawing.Size(75, 23);
            this.button_back_from4.TabIndex = 10;
            this.button_back_from4.Text = "BACK";
            this.button_back_from4.UseVisualStyleBackColor = true;
            this.button_back_from4.Click += new System.EventHandler(this.button_back_from4_Click);
            // 
            // textBox_doctorsidsearch
            // 
            this.textBox_doctorsidsearch.Location = new System.Drawing.Point(435, 25);
            this.textBox_doctorsidsearch.Name = "textBox_doctorsidsearch";
            this.textBox_doctorsidsearch.Size = new System.Drawing.Size(244, 22);
            this.textBox_doctorsidsearch.TabIndex = 11;
            this.textBox_doctorsidsearch.TextChanged += new System.EventHandler(this.textBox_doctorsidsearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Doctor\'s Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button_doctorsidsearch
            // 
            this.button_doctorsidsearch.Location = new System.Drawing.Point(697, 24);
            this.button_doctorsidsearch.Name = "button_doctorsidsearch";
            this.button_doctorsidsearch.Size = new System.Drawing.Size(91, 25);
            this.button_doctorsidsearch.TabIndex = 13;
            this.button_doctorsidsearch.Text = "SEARCH";
            this.button_doctorsidsearch.UseVisualStyleBackColor = true;
            this.button_doctorsidsearch.Click += new System.EventHandler(this.button_doctorsidsearch_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_doctorsidsearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_doctorsidsearch);
            this.Controls.Add(this.button_back_from4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_DS);
            this.Controls.Add(this.textBox_DN);
            this.Controls.Add(this.textBox_Did);
            this.Controls.Add(this.button_deletedoctor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_doctorlist);
            this.Controls.Add(this.button_adddoctor);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_adddoctor;
        private System.Windows.Forms.Button button_doctorlist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_deletedoctor;
        private System.Windows.Forms.TextBox textBox_Did;
        private System.Windows.Forms.TextBox textBox_DN;
        private System.Windows.Forms.TextBox textBox_DS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_back_from4;
        private System.Windows.Forms.TextBox textBox_doctorsidsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_doctorsidsearch;
    }
}