namespace Szpital
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
            this.patientDetails = new System.Windows.Forms.Panel();
            this.patientCard = new System.Windows.Forms.TextBox();
            this.patientName = new System.Windows.Forms.TextBox();
            this.patients_panel = new System.Windows.Forms.Panel();
            this.line = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.patients_button = new System.Windows.Forms.Button();
            this.end_button = new System.Windows.Forms.Button();
            this.endbreak_button = new System.Windows.Forms.Button();
            this.break_button = new System.Windows.Forms.Button();
            this.controls = new System.Windows.Forms.Panel();
            this.editCard = new System.Windows.Forms.Button();
            this.editCardForm = new System.Windows.Forms.Panel();
            this.body.SuspendLayout();
            this.patientDetails.SuspendLayout();
            this.header.SuspendLayout();
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
            this.patientCard.DoubleClick += new System.EventHandler(this.patientCard_DoubleClick);
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
            // patients_button
            // 
            this.patients_button.Location = new System.Drawing.Point(400, 3);
            this.patients_button.Name = "patients_button";
            this.patients_button.Size = new System.Drawing.Size(106, 23);
            this.patients_button.TabIndex = 0;
            this.patients_button.Text = "Pokaż pacjentów";
            this.patients_button.UseVisualStyleBackColor = true;
            this.patients_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // end_button
            // 
            this.end_button.Location = new System.Drawing.Point(580, 32);
            this.end_button.Name = "end_button";
            this.end_button.Size = new System.Drawing.Size(96, 23);
            this.end_button.TabIndex = 13;
            this.end_button.Text = "Koniec";
            this.end_button.UseVisualStyleBackColor = true;
            this.end_button.Click += new System.EventHandler(this.end_button_Click);
            // 
            // endbreak_button
            // 
            this.endbreak_button.Location = new System.Drawing.Point(580, 3);
            this.endbreak_button.Name = "endbreak_button";
            this.endbreak_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.endbreak_button.Size = new System.Drawing.Size(96, 23);
            this.endbreak_button.TabIndex = 12;
            this.endbreak_button.Text = "Koniec przerwy";
            this.endbreak_button.UseVisualStyleBackColor = true;
            this.endbreak_button.Visible = false;
            this.endbreak_button.Click += new System.EventHandler(this.endbreak_button_Click);
            // 
            // break_button
            // 
            this.break_button.Location = new System.Drawing.Point(580, 3);
            this.break_button.Name = "break_button";
            this.break_button.Size = new System.Drawing.Size(96, 23);
            this.break_button.TabIndex = 11;
            this.break_button.Text = "Przerwa";
            this.break_button.UseVisualStyleBackColor = true;
            this.break_button.Click += new System.EventHandler(this.break_button_Click);
            // 
            // controls
            // 
            this.controls.Dock = System.Windows.Forms.DockStyle.Right;
            this.controls.Location = new System.Drawing.Point(701, 0);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(97, 80);
            this.controls.TabIndex = 0;
            this.controls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
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
            // editCardForm
            // 
            this.editCardForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editCardForm.Location = new System.Drawing.Point(200, 300);
            this.editCardForm.Name = "editCardForm";
            this.editCardForm.Size = new System.Drawing.Size(598, 274);
            this.editCardForm.TabIndex = 13;
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
            this.patientDetails.ResumeLayout(false);
            this.patientDetails.PerformLayout();
            this.header.ResumeLayout(false);
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
    }
}