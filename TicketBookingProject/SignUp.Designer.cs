namespace TicketBookingProject
{
    partial class SignUp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFullname = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSignup = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(322, 44);
            label1.Name = "label1";
            label1.Size = new Size(170, 54);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(195, 156);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 1;
            label2.Text = "Fullname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(195, 219);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(195, 282);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 3;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(195, 342);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // txtFullname
            // 
            txtFullname.BackColor = SystemColors.ControlLight;
            txtFullname.Location = new Point(314, 152);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(323, 27);
            txtFullname.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLight;
            txtEmail.Location = new Point(314, 215);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(323, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ControlLight;
            txtUsername.Location = new Point(314, 278);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(323, 27);
            txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ControlLight;
            txtPassword.Location = new Point(314, 338);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(323, 27);
            txtPassword.TabIndex = 8;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = SystemColors.ControlText;
            btnSignup.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignup.ForeColor = SystemColors.ControlLightLight;
            btnSignup.Location = new Point(195, 430);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(442, 44);
            btnSignup.TabIndex = 9;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 502);
            Controls.Add(btnSignup);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(txtFullname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUp";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFullname;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSignup;
    }
}