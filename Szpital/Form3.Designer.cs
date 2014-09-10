namespace Szpital
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sala = new System.Windows.Forms.TextBox();
            this.rozpoznanie = new System.Windows.Forms.TextBox();
            this.data_przyjecia = new System.Windows.Forms.TextBox();
            this.data_wypisu = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sala: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rozpoznanie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data przyjecia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data wypisu:";
            // 
            // sala
            // 
            this.sala.AccessibleName = "sala";
            this.sala.Location = new System.Drawing.Point(105, 61);
            this.sala.Multiline = true;
            this.sala.Name = "sala";
            this.sala.Size = new System.Drawing.Size(100, 20);
            this.sala.TabIndex = 4;
            // 
            // rozpoznanie
            // 
            this.rozpoznanie.AccessibleName = "rozpoznanie";
            this.rozpoznanie.Location = new System.Drawing.Point(105, 92);
            this.rozpoznanie.Multiline = true;
            this.rozpoznanie.Name = "rozpoznanie";
            this.rozpoznanie.Size = new System.Drawing.Size(100, 20);
            this.rozpoznanie.TabIndex = 5;
            // 
            // data_przyjecia
            // 
            this.data_przyjecia.AccessibleName = "data_przyjecia";
            this.data_przyjecia.Location = new System.Drawing.Point(105, 126);
            this.data_przyjecia.Multiline = true;
            this.data_przyjecia.Name = "data_przyjecia";
            this.data_przyjecia.Size = new System.Drawing.Size(100, 20);
            this.data_przyjecia.TabIndex = 6;
            // 
            // data_wypisu
            // 
            this.data_wypisu.AccessibleName = "data_wypisu";
            this.data_wypisu.Location = new System.Drawing.Point(105, 159);
            this.data_wypisu.Multiline = true;
            this.data_wypisu.Name = "data_wypisu";
            this.data_wypisu.Size = new System.Drawing.Size(100, 20);
            this.data_wypisu.TabIndex = 7;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(67, 199);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(155, 23);
            this.save_button.TabIndex = 8;
            this.save_button.Text = "Zapisz";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // name
            // 
            this.name.AccessibleName = "name";
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(18, 18);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 9;
            this.name.Text = "name";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.name);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.data_wypisu);
            this.Controls.Add(this.data_przyjecia);
            this.Controls.Add(this.rozpoznanie);
            this.Controls.Add(this.sala);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sala;
        private System.Windows.Forms.TextBox rozpoznanie;
        private System.Windows.Forms.TextBox data_przyjecia;
        private System.Windows.Forms.TextBox data_wypisu;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label name;
    }
}