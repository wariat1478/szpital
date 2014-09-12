﻿namespace Szpital
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
            this.footer = new System.Windows.Forms.Panel();
            this.body = new System.Windows.Forms.Panel();
            this.editCardForm = new System.Windows.Forms.Panel();
            this.save_button = new System.Windows.Forms.Button();
            this.data_wypisu = new System.Windows.Forms.TextBox();
            this.data_przyjecia = new System.Windows.Forms.TextBox();
            this.rozpoznanie = new System.Windows.Forms.TextBox();
            this.sala = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.patientDetails = new System.Windows.Forms.Panel();
            this.editCard = new System.Windows.Forms.Button();
            this.patientCard = new System.Windows.Forms.TextBox();
            this.patientName = new System.Windows.Forms.TextBox();
            this.patients_panel = new System.Windows.Forms.Panel();
            this.line = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.patients_button = new System.Windows.Forms.Button();
            this.end_button = new System.Windows.Forms.Button();
            this.endbreak_button = new System.Windows.Forms.Button();
            this.break_button = new System.Windows.Forms.Button();
            this.controls = new System.Windows.Forms.Panel();
            this.restoreButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panelTreatment = new System.Windows.Forms.Panel();
            this.patientTreatment = new System.Windows.Forms.TextBox();
            this.body.SuspendLayout();
            this.editCardForm.SuspendLayout();
            this.patientDetails.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.controls.SuspendLayout();
            this.panelTreatment.SuspendLayout();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 574);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(798, 24);
            this.footer.TabIndex = 1;
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.body.Controls.Add(this.editCardForm);
            this.body.Controls.Add(this.patientDetails);
            this.body.Controls.Add(this.patients_panel);
            this.body.Controls.Add(this.line);
            this.body.Controls.Add(this.footer);
            this.body.Controls.Add(this.header);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(1, 1);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(798, 598);
            this.body.TabIndex = 10;
            // 
            // editCardForm
            // 
            this.editCardForm.Controls.Add(this.panelTreatment);
            this.editCardForm.Controls.Add(this.save_button);
            this.editCardForm.Controls.Add(this.data_wypisu);
            this.editCardForm.Controls.Add(this.data_przyjecia);
            this.editCardForm.Controls.Add(this.rozpoznanie);
            this.editCardForm.Controls.Add(this.sala);
            this.editCardForm.Controls.Add(this.label4);
            this.editCardForm.Controls.Add(this.label3);
            this.editCardForm.Controls.Add(this.label2);
            this.editCardForm.Controls.Add(this.label1);
            this.editCardForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editCardForm.Location = new System.Drawing.Point(200, 300);
            this.editCardForm.Name = "editCardForm";
            this.editCardForm.Size = new System.Drawing.Size(598, 274);
            this.editCardForm.TabIndex = 13;
            this.editCardForm.Visible = false;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(404, 203);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 26;
            this.save_button.Text = "Zapisz";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // data_wypisu
            // 
            this.data_wypisu.AccessibleName = "data_wypisu";
            this.data_wypisu.Location = new System.Drawing.Point(208, 146);
            this.data_wypisu.Multiline = true;
            this.data_wypisu.Name = "data_wypisu";
            this.data_wypisu.Size = new System.Drawing.Size(271, 20);
            this.data_wypisu.TabIndex = 25;
            // 
            // data_przyjecia
            // 
            this.data_przyjecia.AccessibleName = "data_przyjecia";
            this.data_przyjecia.Location = new System.Drawing.Point(208, 113);
            this.data_przyjecia.Multiline = true;
            this.data_przyjecia.Name = "data_przyjecia";
            this.data_przyjecia.Size = new System.Drawing.Size(271, 20);
            this.data_przyjecia.TabIndex = 24;
            // 
            // rozpoznanie
            // 
            this.rozpoznanie.AccessibleName = "rozpoznanie";
            this.rozpoznanie.Location = new System.Drawing.Point(208, 79);
            this.rozpoznanie.Multiline = true;
            this.rozpoznanie.Name = "rozpoznanie";
            this.rozpoznanie.Size = new System.Drawing.Size(271, 20);
            this.rozpoznanie.TabIndex = 23;
            // 
            // sala
            // 
            this.sala.AccessibleName = "sala";
            this.sala.Location = new System.Drawing.Point(208, 48);
            this.sala.Multiline = true;
            this.sala.Name = "sala";
            this.sala.Size = new System.Drawing.Size(271, 20);
            this.sala.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Data wypisu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Data przyjecia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Rozpoznanie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Sala: ";
            // 
            // patientDetails
            // 
            this.patientDetails.Controls.Add(this.editCard);
            this.patientDetails.Controls.Add(this.patientCard);
            this.patientDetails.Controls.Add(this.patientName);
            this.patientDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientDetails.Location = new System.Drawing.Point(200, 82);
            this.patientDetails.Name = "patientDetails";
            this.patientDetails.Size = new System.Drawing.Size(598, 218);
            this.patientDetails.TabIndex = 12;
            // 
            // editCard
            // 
            this.editCard.Location = new System.Drawing.Point(494, 138);
            this.editCard.Name = "editCard";
            this.editCard.Size = new System.Drawing.Size(75, 23);
            this.editCard.TabIndex = 2;
            this.editCard.Text = "edytuj";
            this.editCard.UseVisualStyleBackColor = true;
            this.editCard.Visible = false;
            this.editCard.Click += new System.EventHandler(this.editCard_Click);
            // 
            // patientCard
            // 
            this.patientCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.patientCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientCard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.patientCard.Location = new System.Drawing.Point(280, 20);
            this.patientCard.Multiline = true;
            this.patientCard.Name = "patientCard";
            this.patientCard.ReadOnly = true;
            this.patientCard.Size = new System.Drawing.Size(298, 150);
            this.patientCard.TabIndex = 1;
            // 
            // patientName
            // 
            this.patientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.patientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.patientName.Location = new System.Drawing.Point(20, 20);
            this.patientName.Multiline = true;
            this.patientName.Name = "patientName";
            this.patientName.ReadOnly = true;
            this.patientName.Size = new System.Drawing.Size(250, 150);
            this.patientName.TabIndex = 0;
            // 
            // patients_panel
            // 
            this.patients_panel.BackColor = System.Drawing.Color.Transparent;
            this.patients_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.patients_panel.Location = new System.Drawing.Point(0, 82);
            this.patients_panel.Name = "patients_panel";
            this.patients_panel.Padding = new System.Windows.Forms.Padding(20);
            this.patients_panel.Size = new System.Drawing.Size(200, 492);
            this.patients_panel.TabIndex = 11;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.line.Dock = System.Windows.Forms.DockStyle.Top;
            this.line.Location = new System.Drawing.Point(0, 80);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(798, 2);
            this.line.TabIndex = 2;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.patients_button);
            this.header.Controls.Add(this.end_button);
            this.header.Controls.Add(this.endbreak_button);
            this.header.Controls.Add(this.break_button);
            this.header.Controls.Add(this.controls);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(798, 80);
            this.header.TabIndex = 0;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Szpital.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // patients_button
            // 
            this.patients_button.Location = new System.Drawing.Point(152, 21);
            this.patients_button.Name = "patients_button";
            this.patients_button.Size = new System.Drawing.Size(106, 23);
            this.patients_button.TabIndex = 0;
            this.patients_button.Text = "Pokaż pacjentów";
            this.patients_button.UseVisualStyleBackColor = true;
            this.patients_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // end_button
            // 
            this.end_button.BackgroundImage = global::Szpital.Properties.Resources.endButton;
            this.end_button.FlatAppearance.BorderSize = 0;
            this.end_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.end_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.end_button.ForeColor = System.Drawing.Color.White;
            this.end_button.Location = new System.Drawing.Point(631, 10);
            this.end_button.Name = "end_button";
            this.end_button.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.end_button.Size = new System.Drawing.Size(60, 60);
            this.end_button.TabIndex = 13;
            this.end_button.Text = "Koniec";
            this.end_button.UseVisualStyleBackColor = true;
            this.end_button.Click += new System.EventHandler(this.end_button_Click);
            // 
            // endbreak_button
            // 
            this.endbreak_button.BackgroundImage = global::Szpital.Properties.Resources.playButton;
            this.endbreak_button.FlatAppearance.BorderSize = 0;
            this.endbreak_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endbreak_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endbreak_button.ForeColor = System.Drawing.Color.White;
            this.endbreak_button.Location = new System.Drawing.Point(561, 10);
            this.endbreak_button.Name = "endbreak_button";
            this.endbreak_button.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.endbreak_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.endbreak_button.Size = new System.Drawing.Size(60, 60);
            this.endbreak_button.TabIndex = 12;
            this.endbreak_button.Text = "Powrót";
            this.endbreak_button.UseVisualStyleBackColor = true;
            this.endbreak_button.Visible = false;
            this.endbreak_button.Click += new System.EventHandler(this.endbreak_button_Click);
            // 
            // break_button
            // 
            this.break_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.break_button.BackgroundImage = global::Szpital.Properties.Resources.puseButton;
            this.break_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.break_button.FlatAppearance.BorderSize = 0;
            this.break_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.break_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.break_button.ForeColor = System.Drawing.Color.White;
            this.break_button.Location = new System.Drawing.Point(561, 10);
            this.break_button.Name = "break_button";
            this.break_button.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.break_button.Size = new System.Drawing.Size(60, 60);
            this.break_button.TabIndex = 11;
            this.break_button.Text = "Przerwa";
            this.break_button.UseVisualStyleBackColor = false;
            this.break_button.Click += new System.EventHandler(this.break_button_Click);
            // 
            // controls
            // 
            this.controls.Controls.Add(this.restoreButton);
            this.controls.Controls.Add(this.minimizeButton);
            this.controls.Controls.Add(this.maximizeButton);
            this.controls.Controls.Add(this.closeButton);
            this.controls.Dock = System.Windows.Forms.DockStyle.Right;
            this.controls.Location = new System.Drawing.Point(701, 0);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(97, 80);
            this.controls.TabIndex = 0;
            this.controls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // restoreButton
            // 
            this.restoreButton.BackgroundImage = global::Szpital.Properties.Resources.restoreButton;
            this.restoreButton.FlatAppearance.BorderSize = 0;
            this.restoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreButton.Location = new System.Drawing.Point(59, 10);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(9, 9);
            this.restoreButton.TabIndex = 5;
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Visible = false;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = global::Szpital.Properties.Resources.minimizeButton;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(40, 10);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(9, 9);
            this.minimizeButton.TabIndex = 4;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.BackgroundImage = global::Szpital.Properties.Resources.maximizeButton;
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.Location = new System.Drawing.Point(59, 10);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(9, 9);
            this.maximizeButton.TabIndex = 3;
            this.maximizeButton.UseVisualStyleBackColor = true;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::Szpital.Properties.Resources.closeButton;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(78, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(9, 9);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panelTreatment
            // 
            this.panelTreatment.Controls.Add(this.patientTreatment);
            this.panelTreatment.Location = new System.Drawing.Point(0, 0);
            this.panelTreatment.Name = "panelTreatment";
            this.panelTreatment.Size = new System.Drawing.Size(598, 274);
            this.panelTreatment.TabIndex = 27;
            // 
            // patientTreatment
            // 
            this.patientTreatment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.patientTreatment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientTreatment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.patientTreatment.Location = new System.Drawing.Point(20, 27);
            this.patientTreatment.Multiline = true;
            this.patientTreatment.Name = "patientTreatment";
            this.patientTreatment.ReadOnly = true;
            this.patientTreatment.Size = new System.Drawing.Size(298, 150);
            this.patientTreatment.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Form2";
            this.body.ResumeLayout(false);
            this.editCardForm.ResumeLayout(false);
            this.editCardForm.PerformLayout();
            this.patientDetails.ResumeLayout(false);
            this.patientDetails.PerformLayout();
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.controls.ResumeLayout(false);
            this.panelTreatment.ResumeLayout(false);
            this.panelTreatment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Panel line;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel controls;
        private System.Windows.Forms.Button break_button;
        private System.Windows.Forms.Button endbreak_button;
        private System.Windows.Forms.Button end_button;
        private System.Windows.Forms.Panel patients_panel;
        private System.Windows.Forms.Button patients_button;
        private System.Windows.Forms.Panel patientDetails;
        private System.Windows.Forms.TextBox patientName;
        private System.Windows.Forms.TextBox patientCard;
        private System.Windows.Forms.Button editCard;
        private System.Windows.Forms.Panel editCardForm;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TextBox data_wypisu;
        private System.Windows.Forms.TextBox data_przyjecia;
        private System.Windows.Forms.TextBox rozpoznanie;
        private System.Windows.Forms.TextBox sala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTreatment;
        private System.Windows.Forms.TextBox patientTreatment;
    }
}