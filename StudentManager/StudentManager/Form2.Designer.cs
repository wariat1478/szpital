namespace StudentManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.select = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.setBusy = new System.Windows.Forms.Button();
            this.setAway = new System.Windows.Forms.Button();
            this.setActive = new System.Windows.Forms.Button();
            this.friends = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.changeStatus = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.statusImage = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.select.SuspendLayout();
            this.friends.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusImage)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(358, 448);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.select);
            this.panel2.Controls.Add(this.friends);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 446);
            this.panel2.TabIndex = 0;
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.Color.Transparent;
            this.select.BackgroundImage = global::StudentManager.Properties.Resources.select;
            this.select.Controls.Add(this.logout);
            this.select.Controls.Add(this.setBusy);
            this.select.Controls.Add(this.setAway);
            this.select.Controls.Add(this.setActive);
            this.select.Location = new System.Drawing.Point(53, 103);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(120, 128);
            this.select.TabIndex = 1;
            this.select.Visible = false;
            // 
            // logout
            // 
            this.logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(1, 100);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(118, 23);
            this.logout.TabIndex = 3;
            this.logout.Text = "Wyloguj";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // setBusy
            // 
            this.setBusy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.setBusy.FlatAppearance.BorderSize = 0;
            this.setBusy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.setBusy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.setBusy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setBusy.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.setBusy.Image = global::StudentManager.Properties.Resources.busy;
            this.setBusy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setBusy.Location = new System.Drawing.Point(1, 67);
            this.setBusy.Name = "setBusy";
            this.setBusy.Size = new System.Drawing.Size(118, 23);
            this.setBusy.TabIndex = 2;
            this.setBusy.Text = "Zajęty";
            this.setBusy.UseVisualStyleBackColor = true;
            this.setBusy.Click += new System.EventHandler(this.setBusy_Click);
            // 
            // setAway
            // 
            this.setAway.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.setAway.FlatAppearance.BorderSize = 0;
            this.setAway.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.setAway.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.setAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setAway.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.setAway.Image = global::StudentManager.Properties.Resources.away;
            this.setAway.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setAway.Location = new System.Drawing.Point(1, 39);
            this.setAway.Name = "setAway";
            this.setAway.Size = new System.Drawing.Size(118, 23);
            this.setAway.TabIndex = 1;
            this.setAway.Text = "Nieobecny";
            this.setAway.UseVisualStyleBackColor = true;
            this.setAway.Click += new System.EventHandler(this.setAway_Click);
            // 
            // setActive
            // 
            this.setActive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.setActive.FlatAppearance.BorderSize = 0;
            this.setActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.setActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.setActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setActive.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.setActive.Image = global::StudentManager.Properties.Resources.active;
            this.setActive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setActive.Location = new System.Drawing.Point(1, 10);
            this.setActive.Name = "setActive";
            this.setActive.Size = new System.Drawing.Size(118, 23);
            this.setActive.TabIndex = 0;
            this.setActive.Text = "Dostępny";
            this.setActive.UseVisualStyleBackColor = true;
            this.setActive.Click += new System.EventHandler(this.setActive_Click);
            // 
            // friends
            // 
            this.friends.Controls.Add(this.flowLayoutPanel1);
            this.friends.Location = new System.Drawing.Point(0, 139);
            this.friends.Name = "friends";
            this.friends.Size = new System.Drawing.Size(356, 308);
            this.friends.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(79, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::StudentManager.Properties.Resources.header;
            this.panel3.Controls.Add(this.changeStatus);
            this.panel3.Controls.Add(this.status);
            this.panel3.Controls.Add(this.statusImage);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.name);
            this.panel3.Controls.Add(this.minimizeButton);
            this.panel3.Controls.Add(this.maximizeButton);
            this.panel3.Controls.Add(this.closeButton);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 115);
            this.panel3.TabIndex = 4;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            // 
            // changeStatus
            // 
            this.changeStatus.BackColor = System.Drawing.Color.Transparent;
            this.changeStatus.BackgroundImage = global::StudentManager.Properties.Resources.dropdown;
            this.changeStatus.FlatAppearance.BorderSize = 0;
            this.changeStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changeStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.changeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeStatus.Location = new System.Drawing.Point(159, 84);
            this.changeStatus.Name = "changeStatus";
            this.changeStatus.Size = new System.Drawing.Size(9, 10);
            this.changeStatus.TabIndex = 13;
            this.changeStatus.UseVisualStyleBackColor = false;
            this.changeStatus.Click += new System.EventHandler(this.changeStatus_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.status.Location = new System.Drawing.Point(91, 82);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 14);
            this.status.TabIndex = 12;
            this.status.Click += new System.EventHandler(this.changeStatus_Click);
            // 
            // statusImage
            // 
            this.statusImage.BackColor = System.Drawing.Color.Transparent;
            this.statusImage.InitialImage = null;
            this.statusImage.Location = new System.Drawing.Point(79, 84);
            this.statusImage.Name = "statusImage";
            this.statusImage.Size = new System.Drawing.Size(10, 10);
            this.statusImage.TabIndex = 11;
            this.statusImage.TabStop = false;
            this.statusImage.Click += new System.EventHandler(this.changeStatus_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.panel4.Controls.Add(this.avatar);
            this.panel4.Location = new System.Drawing.Point(18, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(52, 52);
            this.panel4.TabIndex = 10;
            // 
            // avatar
            // 
            this.avatar.Location = new System.Drawing.Point(1, 1);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(50, 50);
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(220)))));
            this.name.Location = new System.Drawing.Point(76, 61);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(102, 17);
            this.name.TabIndex = 9;
            this.name.Text = "Łukasz Golder";
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = global::StudentManager.Properties.Resources.minimizeButton;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(309, 8);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(9, 9);
            this.minimizeButton.TabIndex = 8;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.BackgroundImage = global::StudentManager.Properties.Resources.maximizeButton;
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.Location = new System.Drawing.Point(324, 8);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(9, 9);
            this.maximizeButton.TabIndex = 7;
            this.maximizeButton.UseVisualStyleBackColor = true;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::StudentManager.Properties.Resources.closeButton;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(339, 8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(9, 9);
            this.closeButton.TabIndex = 6;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Znajomi";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.select.ResumeLayout(false);
            this.friends.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusImage)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Panel friends;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.PictureBox statusImage;
        private System.Windows.Forms.Button changeStatus;
        private System.Windows.Forms.Panel select;
        private System.Windows.Forms.Button setBusy;
        private System.Windows.Forms.Button setAway;
        private System.Windows.Forms.Button setActive;
        private System.Windows.Forms.Button logout;
    }
}