namespace StudentManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.usernameContainer = new System.Windows.Forms.Panel();
            this.passwordContainer = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Panel();
            this.usernameContainer.SuspendLayout();
            this.passwordContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::StudentManager.Properties.Resources.closeButton;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(361, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(9, 9);
            this.closeButton.TabIndex = 4;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = global::StudentManager.Properties.Resources.minimizeButton;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(346, 10);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(9, 9);
            this.minimizeButton.TabIndex = 5;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(89, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nie posiadasz jeszcze konta?";
            // 
            // register
            // 
            this.register.BackgroundImage = global::StudentManager.Properties.Resources.bigButton;
            this.register.FlatAppearance.BorderSize = 0;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.register.ForeColor = System.Drawing.Color.White;
            this.register.Location = new System.Drawing.Point(55, 400);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(270, 40);
            this.register.TabIndex = 6;
            this.register.Text = "Załóż bezpłatne konto";
            this.register.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.username.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.username.Location = new System.Drawing.Point(6, 11);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(288, 18);
            this.username.TabIndex = 0;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password.Location = new System.Drawing.Point(6, 11);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(288, 18);
            this.password.TabIndex = 1;
            // 
            // login
            // 
            this.login.BackgroundImage = global::StudentManager.Properties.Resources.button;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(232, 264);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(108, 40);
            this.login.TabIndex = 3;
            this.login.Text = "Zaloguj";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // usernameContainer
            // 
            this.usernameContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.usernameContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameContainer.Controls.Add(this.username);
            this.usernameContainer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.usernameContainer.Location = new System.Drawing.Point(39, 160);
            this.usernameContainer.Name = "usernameContainer";
            this.usernameContainer.Padding = new System.Windows.Forms.Padding(6, 11, 6, 6);
            this.usernameContainer.Size = new System.Drawing.Size(302, 42);
            this.usernameContainer.TabIndex = 7;
            // 
            // passwordContainer
            // 
            this.passwordContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.passwordContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordContainer.Controls.Add(this.password);
            this.passwordContainer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordContainer.Location = new System.Drawing.Point(39, 212);
            this.passwordContainer.Name = "passwordContainer";
            this.passwordContainer.Padding = new System.Windows.Forms.Padding(6, 11, 6, 6);
            this.passwordContainer.Size = new System.Drawing.Size(302, 42);
            this.passwordContainer.TabIndex = 8;
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::StudentManager.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(39, 56);
            this.logo.Name = "logo";
            this.logo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logo.Size = new System.Drawing.Size(211, 80);
            this.logo.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentManager.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.passwordContainer);
            this.Controls.Add(this.usernameContainer);
            this.Controls.Add(this.login);
            this.Controls.Add(this.register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Student Manager";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.usernameContainer.ResumeLayout(false);
            this.usernameContainer.PerformLayout();
            this.passwordContainer.ResumeLayout(false);
            this.passwordContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Panel usernameContainer;
        private System.Windows.Forms.Panel passwordContainer;
        private System.Windows.Forms.Panel logo;
    }
}

