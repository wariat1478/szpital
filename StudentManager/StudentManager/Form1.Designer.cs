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
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.usernameContainer = new System.Windows.Forms.Panel();
            this.passwordContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.usernameContainer.SuspendLayout();
            this.passwordContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(90, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nie posiadasz jeszcze konta?";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.username.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.username.Location = new System.Drawing.Point(9, 7);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(280, 15);
            this.username.TabIndex = 0;
            this.username.Text = "Nazwa użytkownika";
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.KeyUp += new System.Windows.Forms.KeyEventHandler(this.username_KeyUp);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.password.Location = new System.Drawing.Point(9, 7);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(280, 15);
            this.password.TabIndex = 1;
            this.password.Text = "Hasło";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.username_KeyUp);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // usernameContainer
            // 
            this.usernameContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.usernameContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameContainer.Controls.Add(this.username);
            this.usernameContainer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.usernameContainer.Location = new System.Drawing.Point(38, 160);
            this.usernameContainer.Name = "usernameContainer";
            this.usernameContainer.Padding = new System.Windows.Forms.Padding(9, 7, 9, 0);
            this.usernameContainer.Size = new System.Drawing.Size(300, 32);
            this.usernameContainer.TabIndex = 7;
            // 
            // passwordContainer
            // 
            this.passwordContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.passwordContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordContainer.Controls.Add(this.password);
            this.passwordContainer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordContainer.Location = new System.Drawing.Point(38, 202);
            this.passwordContainer.Name = "passwordContainer";
            this.passwordContainer.Padding = new System.Windows.Forms.Padding(9, 7, 9, 0);
            this.passwordContainer.Size = new System.Drawing.Size(300, 32);
            this.passwordContainer.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(378, 448);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(21)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.login);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 446);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 29);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.minimizeButton);
            this.panel4.Controls.Add(this.closeButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(276, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 29);
            this.panel4.TabIndex = 0;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = global::StudentManager.Properties.Resources.minimize;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(56, 10);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(9, 9);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseEnter += new System.EventHandler(this.minimizeButton_MouseEnter);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeButton_MouseLeave);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::StudentManager.Properties.Resources.close;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(81, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(9, 9);
            this.closeButton.TabIndex = 4;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // login
            // 
            this.login.BackgroundImage = global::StudentManager.Properties.Resources.button;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(36, 243);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(130, 34);
            this.login.TabIndex = 3;
            this.login.Text = "Zaloguj";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.passwordContainer);
            this.Controls.Add(this.usernameContainer);
            this.Controls.Add(this.register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Student Manager";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.usernameContainer.ResumeLayout(false);
            this.usernameContainer.PerformLayout();
            this.passwordContainer.ResumeLayout(false);
            this.passwordContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Panel usernameContainer;
        private System.Windows.Forms.Panel passwordContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

