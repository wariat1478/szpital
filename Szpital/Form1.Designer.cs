namespace Szpital
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
            this.body = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.MaskedTextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.Panel();
            this.messageBody = new System.Windows.Forms.Panel();
            this.messageText = new System.Windows.Forms.TextBox();
            this.line = new System.Windows.Forms.Panel();
            this.footer = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.controls = new System.Windows.Forms.Panel();
            this.login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.body.SuspendLayout();
            this.message.SuspendLayout();
            this.messageBody.SuspendLayout();
            this.header.SuspendLayout();
            this.controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.body.Controls.Add(this.login);
            this.body.Controls.Add(this.password);
            this.body.Controls.Add(this.username);
            this.body.Controls.Add(this.message);
            this.body.Controls.Add(this.line);
            this.body.Controls.Add(this.footer);
            this.body.Controls.Add(this.header);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(1, 1);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(378, 448);
            this.body.TabIndex = 9;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password.Location = new System.Drawing.Point(20, 225);
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.Size = new System.Drawing.Size(338, 22);
            this.password.TabIndex = 5;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username.Location = new System.Drawing.Point(20, 190);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(338, 22);
            this.username.TabIndex = 4;
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(204)))));
            this.message.Controls.Add(this.messageBody);
            this.message.Location = new System.Drawing.Point(20, 103);
            this.message.Name = "message";
            this.message.Padding = new System.Windows.Forms.Padding(1);
            this.message.Size = new System.Drawing.Size(338, 64);
            this.message.TabIndex = 3;
            this.message.Visible = false;
            // 
            // messageBody
            // 
            this.messageBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(227)))));
            this.messageBody.Controls.Add(this.messageText);
            this.messageBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageBody.Location = new System.Drawing.Point(1, 1);
            this.messageBody.Name = "messageBody";
            this.messageBody.Padding = new System.Windows.Forms.Padding(15);
            this.messageBody.Size = new System.Drawing.Size(336, 62);
            this.messageBody.TabIndex = 0;
            // 
            // messageText
            // 
            this.messageText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(227)))));
            this.messageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageText.Cursor = System.Windows.Forms.Cursors.Default;
            this.messageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.messageText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(109)))), ((int)(((byte)(59)))));
            this.messageText.Location = new System.Drawing.Point(15, 15);
            this.messageText.Multiline = true;
            this.messageText.Name = "messageText";
            this.messageText.ReadOnly = true;
            this.messageText.Size = new System.Drawing.Size(306, 32);
            this.messageText.TabIndex = 0;
            this.messageText.Text = "Niepoprawna nazwa użytkownika lub/i hasło. Proszę spróbować ponownie.";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.line.Dock = System.Windows.Forms.DockStyle.Top;
            this.line.Location = new System.Drawing.Point(0, 80);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(378, 2);
            this.line.TabIndex = 2;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 424);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(378, 24);
            this.footer.TabIndex = 1;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.header.Controls.Add(this.textBox1);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.controls);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(378, 80);
            this.header.TabIndex = 0;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.textBox1.Location = new System.Drawing.Point(81, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Logowanie";
            // 
            // controls
            // 
            this.controls.Controls.Add(this.minimizeButton);
            this.controls.Controls.Add(this.closeButton);
            this.controls.Dock = System.Windows.Forms.DockStyle.Right;
            this.controls.Location = new System.Drawing.Point(281, 0);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(97, 80);
            this.controls.TabIndex = 0;
            this.controls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // login
            // 
            this.login.BackgroundImage = global::Szpital.Properties.Resources.loginButton;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(21, 257);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(336, 40);
            this.login.TabIndex = 6;
            this.login.Text = "Zaloguj";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Szpital.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = global::Szpital.Properties.Resources.minimizeButton;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(59, 10);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(9, 9);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::Szpital.Properties.Resources.closeButton;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(78, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(9, 9);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Student Manager";
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            this.message.ResumeLayout(false);
            this.messageBody.ResumeLayout(false);
            this.messageBody.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.controls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel controls;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Panel line;
        private System.Windows.Forms.Panel message;
        private System.Windows.Forms.Panel messageBody;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.MaskedTextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

