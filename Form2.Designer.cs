namespace Final_Term_Project
{
    partial class Form2
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
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.textBox_USID = new System.Windows.Forms.TextBox();
            this.label_UserID = new System.Windows.Forms.Label();
            this.label_Pass = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Location = new System.Drawing.Point(407, 166);
            this.textBox_Pass.Multiline = true;
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.PasswordChar = '*';
            this.textBox_Pass.Size = new System.Drawing.Size(123, 32);
            this.textBox_Pass.TabIndex = 0;
            this.textBox_Pass.TextChanged += new System.EventHandler(this.textBox_Pass_TextChanged);
            // 
            // textBox_USID
            // 
            this.textBox_USID.Location = new System.Drawing.Point(407, 118);
            this.textBox_USID.Multiline = true;
            this.textBox_USID.Name = "textBox_USID";
            this.textBox_USID.Size = new System.Drawing.Size(123, 33);
            this.textBox_USID.TabIndex = 1;
            this.textBox_USID.TextChanged += new System.EventHandler(this.textBox_USID_TextChanged);
            // 
            // label_UserID
            // 
            this.label_UserID.AutoSize = true;
            this.label_UserID.Location = new System.Drawing.Point(286, 124);
            this.label_UserID.Name = "label_UserID";
            this.label_UserID.Size = new System.Drawing.Size(52, 16);
            this.label_UserID.TabIndex = 3;
            this.label_UserID.Text = "User ID";
            // 
            // label_Pass
            // 
            this.label_Pass.AutoSize = true;
            this.label_Pass.Location = new System.Drawing.Point(286, 172);
            this.label_Pass.Name = "label_Pass";
            this.label_Pass.Size = new System.Drawing.Size(67, 16);
            this.label_Pass.TabIndex = 4;
            this.label_Pass.Text = "Password";
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(428, 246);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(102, 41);
            this.button_Login.TabIndex = 5;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.label_Pass);
            this.Controls.Add(this.label_UserID);
            this.Controls.Add(this.textBox_USID);
            this.Controls.Add(this.textBox_Pass);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.TextBox textBox_USID;
        private System.Windows.Forms.Label label_UserID;
        private System.Windows.Forms.Label label_Pass;
        private System.Windows.Forms.Button button_Login;
    }
}