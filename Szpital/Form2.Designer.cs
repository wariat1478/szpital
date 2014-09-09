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
            this.line = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.end_button = new System.Windows.Forms.Button();
            this.endbreak_button = new System.Windows.Forms.Button();
            this.break_button = new System.Windows.Forms.Button();
            this.controls = new System.Windows.Forms.Panel();
            this.patients_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.body.SuspendLayout();
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
            this.header.Controls.Add(this.button1);
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
            // patients_panel
            // 
            this.patients_panel.BackColor = System.Drawing.Color.Silver;
            this.patients_panel.Location = new System.Drawing.Point(69, 122);
            this.patients_panel.Name = "patients_panel";
            this.patients_panel.Size = new System.Drawing.Size(683, 432);
            this.patients_panel.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
        private System.Windows.Forms.Button button1;
    }
}