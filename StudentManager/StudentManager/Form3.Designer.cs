namespace StudentManager
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
            this.components = new System.ComponentModel.Container();
            this.logo = new System.Windows.Forms.Panel();
            this.messageContainer = new System.Windows.Forms.Panel();
            this.message = new System.Windows.Forms.TextBox();
            this.history = new System.Windows.Forms.TextBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.messageContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::StudentManager.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logo.Size = new System.Drawing.Size(211, 80);
            this.logo.TabIndex = 10;
            // 
            // messageContainer
            // 
            this.messageContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.messageContainer.Controls.Add(this.message);
            this.messageContainer.Location = new System.Drawing.Point(0, 332);
            this.messageContainer.Name = "messageContainer";
            this.messageContainer.Size = new System.Drawing.Size(380, 118);
            this.messageContainer.TabIndex = 11;
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(15, 10);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(350, 80);
            this.message.TabIndex = 0;
            this.message.KeyUp += new System.Windows.Forms.KeyEventHandler(this.message_KeyUp);
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.WhiteSmoke;
            this.history.Location = new System.Drawing.Point(15, 126);
            this.history.Multiline = true;
            this.history.Name = "history";
            this.history.ReadOnly = true;
            this.history.Size = new System.Drawing.Size(350, 182);
            this.history.TabIndex = 12;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = global::StudentManager.Properties.Resources.minimizeButton;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(344, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(9, 9);
            this.minimizeButton.TabIndex = 13;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::StudentManager.Properties.Resources.closeButton;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(359, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(9, 9);
            this.closeButton.TabIndex = 14;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.history);
            this.Controls.Add(this.messageContainer);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.messageContainer.ResumeLayout(false);
            this.messageContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel messageContainer;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.TextBox history;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Timer timer1;
    }
}