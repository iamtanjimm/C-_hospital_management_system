namespace Final_Term_Project
{
    partial class Form3
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
            this.button_doctorsinfo = new System.Windows.Forms.Button();
            this.button_patientinfo = new System.Windows.Forms.Button();
            this.button_empinfo = new System.Windows.Forms.Button();
            this.button_back_from3 = new System.Windows.Forms.Button();
            this.button_appointmentbydoc = new System.Windows.Forms.Button();
            this.button_appoinment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_doctorsinfo
            // 
            this.button_doctorsinfo.Location = new System.Drawing.Point(72, 29);
            this.button_doctorsinfo.Name = "button_doctorsinfo";
            this.button_doctorsinfo.Size = new System.Drawing.Size(237, 113);
            this.button_doctorsinfo.TabIndex = 0;
            this.button_doctorsinfo.Text = "Doctors Info";
            this.button_doctorsinfo.UseVisualStyleBackColor = true;
            this.button_doctorsinfo.Click += new System.EventHandler(this.button_doctorsinfo_Click);
            // 
            // button_patientinfo
            // 
            this.button_patientinfo.Location = new System.Drawing.Point(522, 29);
            this.button_patientinfo.Name = "button_patientinfo";
            this.button_patientinfo.Size = new System.Drawing.Size(243, 113);
            this.button_patientinfo.TabIndex = 1;
            this.button_patientinfo.Text = "Patient Info";
            this.button_patientinfo.UseVisualStyleBackColor = true;
            this.button_patientinfo.Click += new System.EventHandler(this.button_patientinfo_Click);
            // 
            // button_empinfo
            // 
            this.button_empinfo.Location = new System.Drawing.Point(72, 274);
            this.button_empinfo.Name = "button_empinfo";
            this.button_empinfo.Size = new System.Drawing.Size(237, 101);
            this.button_empinfo.TabIndex = 2;
            this.button_empinfo.Text = "Employee Info";
            this.button_empinfo.UseVisualStyleBackColor = true;
            this.button_empinfo.Click += new System.EventHandler(this.button_empinfo_Click);
            // 
            // button_back_from3
            // 
            this.button_back_from3.Location = new System.Drawing.Point(13, 391);
            this.button_back_from3.Name = "button_back_from3";
            this.button_back_from3.Size = new System.Drawing.Size(75, 23);
            this.button_back_from3.TabIndex = 3;
            this.button_back_from3.Text = "BACK";
            this.button_back_from3.UseVisualStyleBackColor = true;
            this.button_back_from3.Click += new System.EventHandler(this.button_back_from3_Click);
            // 
            // button_appointmentbydoc
            // 
            this.button_appointmentbydoc.Location = new System.Drawing.Point(522, 274);
            this.button_appointmentbydoc.Name = "button_appointmentbydoc";
            this.button_appointmentbydoc.Size = new System.Drawing.Size(243, 101);
            this.button_appointmentbydoc.TabIndex = 4;
            this.button_appointmentbydoc.Text = "Appointment By Doctors Name";
            this.button_appointmentbydoc.UseVisualStyleBackColor = true;
            this.button_appointmentbydoc.Click += new System.EventHandler(this.button_appointmentbydoc_Click);
            // 
            // button_appoinment
            // 
            this.button_appoinment.Location = new System.Drawing.Point(309, 148);
            this.button_appoinment.Name = "button_appoinment";
            this.button_appoinment.Size = new System.Drawing.Size(219, 109);
            this.button_appoinment.TabIndex = 5;
            this.button_appoinment.Text = "APPOINMENT";
            this.button_appoinment.UseVisualStyleBackColor = true;
            this.button_appoinment.Click += new System.EventHandler(this.button_appoinment_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_appoinment);
            this.Controls.Add(this.button_appointmentbydoc);
            this.Controls.Add(this.button_back_from3);
            this.Controls.Add(this.button_empinfo);
            this.Controls.Add(this.button_patientinfo);
            this.Controls.Add(this.button_doctorsinfo);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_doctorsinfo;
        private System.Windows.Forms.Button button_patientinfo;
        private System.Windows.Forms.Button button_empinfo;
        private System.Windows.Forms.Button button_back_from3;
        private System.Windows.Forms.Button button_appointmentbydoc;
        private System.Windows.Forms.Button button_appoinment;
    }
}