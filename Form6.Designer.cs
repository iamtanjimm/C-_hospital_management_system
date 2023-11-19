namespace Final_Term_Project
{
    partial class Form6
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox_empname = new System.Windows.Forms.TextBox();
            this.textBox_empage = new System.Windows.Forms.TextBox();
            this.textBox_workingas = new System.Windows.Forms.TextBox();
            this.textBox_empid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_addemp = new System.Windows.Forms.Button();
            this.button_deleteemp = new System.Windows.Forms.Button();
            this.button_showemp = new System.Windows.Forms.Button();
            this.button_back_from6 = new System.Windows.Forms.Button();
            this.textBox_empidsearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_empidsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(282, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(506, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(603, 195);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(12, 11);
            this.dataGridView2.TabIndex = 1;
            // 
            // textBox_empname
            // 
            this.textBox_empname.Location = new System.Drawing.Point(162, 105);
            this.textBox_empname.Name = "textBox_empname";
            this.textBox_empname.Size = new System.Drawing.Size(100, 22);
            this.textBox_empname.TabIndex = 2;
            // 
            // textBox_empage
            // 
            this.textBox_empage.Location = new System.Drawing.Point(162, 153);
            this.textBox_empage.Name = "textBox_empage";
            this.textBox_empage.Size = new System.Drawing.Size(100, 22);
            this.textBox_empage.TabIndex = 3;
            // 
            // textBox_workingas
            // 
            this.textBox_workingas.Location = new System.Drawing.Point(162, 198);
            this.textBox_workingas.Name = "textBox_workingas";
            this.textBox_workingas.Size = new System.Drawing.Size(100, 22);
            this.textBox_workingas.TabIndex = 4;
            this.textBox_workingas.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox_empid
            // 
            this.textBox_empid.Location = new System.Drawing.Point(162, 62);
            this.textBox_empid.Name = "textBox_empid";
            this.textBox_empid.Size = new System.Drawing.Size(100, 22);
            this.textBox_empid.TabIndex = 5;
            this.textBox_empid.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Working As";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Employee ID";
            // 
            // button_addemp
            // 
            this.button_addemp.Location = new System.Drawing.Point(42, 261);
            this.button_addemp.Name = "button_addemp";
            this.button_addemp.Size = new System.Drawing.Size(75, 23);
            this.button_addemp.TabIndex = 10;
            this.button_addemp.Text = "ADD";
            this.button_addemp.UseVisualStyleBackColor = true;
            this.button_addemp.Click += new System.EventHandler(this.button_addemp_Click);
            // 
            // button_deleteemp
            // 
            this.button_deleteemp.Location = new System.Drawing.Point(187, 261);
            this.button_deleteemp.Name = "button_deleteemp";
            this.button_deleteemp.Size = new System.Drawing.Size(75, 23);
            this.button_deleteemp.TabIndex = 11;
            this.button_deleteemp.Text = "DELETE";
            this.button_deleteemp.UseVisualStyleBackColor = true;
            // 
            // button_showemp
            // 
            this.button_showemp.Location = new System.Drawing.Point(95, 315);
            this.button_showemp.Name = "button_showemp";
            this.button_showemp.Size = new System.Drawing.Size(120, 23);
            this.button_showemp.TabIndex = 12;
            this.button_showemp.Text = "EMPLOYEE LIST";
            this.button_showemp.UseVisualStyleBackColor = true;
            this.button_showemp.Click += new System.EventHandler(this.button_showemp_Click);
            // 
            // button_back_from6
            // 
            this.button_back_from6.Location = new System.Drawing.Point(123, 377);
            this.button_back_from6.Name = "button_back_from6";
            this.button_back_from6.Size = new System.Drawing.Size(75, 23);
            this.button_back_from6.TabIndex = 15;
            this.button_back_from6.Text = "BACK";
            this.button_back_from6.UseVisualStyleBackColor = true;
            this.button_back_from6.Click += new System.EventHandler(this.button_back_from6_Click);
            // 
            // textBox_empidsearch
            // 
            this.textBox_empidsearch.Location = new System.Drawing.Point(535, 12);
            this.textBox_empidsearch.Name = "textBox_empidsearch";
            this.textBox_empidsearch.Size = new System.Drawing.Size(166, 22);
            this.textBox_empidsearch.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "EMPLOYEE ID";
            // 
            // button_empidsearch
            // 
            this.button_empidsearch.Location = new System.Drawing.Point(713, 12);
            this.button_empidsearch.Name = "button_empidsearch";
            this.button_empidsearch.Size = new System.Drawing.Size(75, 23);
            this.button_empidsearch.TabIndex = 18;
            this.button_empidsearch.Text = "SEARCH";
            this.button_empidsearch.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_empidsearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_empidsearch);
            this.Controls.Add(this.button_back_from6);
            this.Controls.Add(this.button_showemp);
            this.Controls.Add(this.button_deleteemp);
            this.Controls.Add(this.button_addemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_empid);
            this.Controls.Add(this.textBox_workingas);
            this.Controls.Add(this.textBox_empage);
            this.Controls.Add(this.textBox_empname);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox_empname;
        private System.Windows.Forms.TextBox textBox_empage;
        private System.Windows.Forms.TextBox textBox_workingas;
        private System.Windows.Forms.TextBox textBox_empid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_addemp;
        private System.Windows.Forms.Button button_deleteemp;
        private System.Windows.Forms.Button button_showemp;
        private System.Windows.Forms.Button button_back_from6;
        private System.Windows.Forms.TextBox textBox_empidsearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_empidsearch;
    }
}