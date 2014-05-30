namespace StudentManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.headerRight = new System.Windows.Forms.Panel();
            this.friends = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.statusImage = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.header.SuspendLayout();
            this.headerRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusImage)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(1200, 700);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(1);
            this.panel2.Size = new System.Drawing.Size(1198, 698);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(21)))), ((int)(((byte)(34)))));
            this.panel3.Controls.Add(this.header);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1196, 696);
            this.panel3.TabIndex = 0;
            // 
            // header
            // 
            this.header.BackgroundImage = global::StudentManager.Properties.Resources.header1;
            this.header.Controls.Add(this.headerRight);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1196, 79);
            this.header.TabIndex = 0;
            // 
            // headerRight
            // 
            this.headerRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(24)))));
            this.headerRight.BackgroundImage = global::StudentManager.Properties.Resources.header1;
            this.headerRight.Controls.Add(this.friends);
            this.headerRight.Controls.Add(this.closeButton);
            this.headerRight.Controls.Add(this.maximizeButton);
            this.headerRight.Controls.Add(this.minimizeButton);
            this.headerRight.Controls.Add(this.panel4);
            this.headerRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.headerRight.Location = new System.Drawing.Point(996, 0);
            this.headerRight.Name = "headerRight";
            this.headerRight.Size = new System.Drawing.Size(200, 79);
            this.headerRight.TabIndex = 0;
            // 
            // friends
            // 
            this.friends.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(24)))));
            this.friends.FlatAppearance.BorderSize = 0;
            this.friends.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.friends.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.friends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friends.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.friends.ForeColor = System.Drawing.Color.White;
            this.friends.Image = global::StudentManager.Properties.Resources.friends;
            this.friends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.friends.Location = new System.Drawing.Point(114, 37);
            this.friends.Name = "friends";
            this.friends.Size = new System.Drawing.Size(60, 30);
            this.friends.TabIndex = 6;
            this.friends.Text = "5";
            this.friends.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.friends.UseVisualStyleBackColor = true;
            this.friends.Click += new System.EventHandler(this.friends_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.status.Location = new System.Drawing.Point(21, 22);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(52, 13);
            this.status.TabIndex = 5;
            this.status.Text = "Dostępny";
            // 
            // statusImage
            // 
            this.statusImage.Image = global::StudentManager.Properties.Resources.active2;
            this.statusImage.Location = new System.Drawing.Point(5, 24);
            this.statusImage.Name = "statusImage";
            this.statusImage.Size = new System.Drawing.Size(10, 10);
            this.statusImage.TabIndex = 4;
            this.statusImage.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(0, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(102, 17);
            this.name.TabIndex = 3;
            this.name.Text = "Łukasz Golder";
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::StudentManager.Properties.Resources.close;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(181, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(9, 9);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // maximizeButton
            // 
            this.maximizeButton.BackgroundImage = global::StudentManager.Properties.Resources.maxmize;
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.Location = new System.Drawing.Point(156, 10);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(9, 9);
            this.maximizeButton.TabIndex = 1;
            this.maximizeButton.UseVisualStyleBackColor = true;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            this.maximizeButton.MouseEnter += new System.EventHandler(this.maximizeButton_MouseEnter);
            this.maximizeButton.MouseLeave += new System.EventHandler(this.maximizeButton_MouseLeave);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = global::StudentManager.Properties.Resources.minimize;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(131, 10);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(9, 9);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseEnter += new System.EventHandler(this.minimizeButton_MouseEnter);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeButton_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.name);
            this.panel4.Controls.Add(this.statusImage);
            this.panel4.Controls.Add(this.status);
            this.panel4.Location = new System.Drawing.Point(0, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(107, 46);
            this.panel4.TabIndex = 7;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.headerRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusImage)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel headerRight;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox statusImage;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button friends;
        private System.Windows.Forms.Panel panel4;

    }
}