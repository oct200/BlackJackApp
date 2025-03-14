namespace Sanki_s_BlackJack
{
    partial class FormInregistrare
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
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxReParola = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelRePasw = new System.Windows.Forms.Label();
            this.labelPasw = new System.Windows.Forms.Label();
            this.buttonInregistrare = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(248, 50);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(247, 24);
            this.textBoxEmail.TabIndex = 0;
            // 
            // textBoxReParola
            // 
            this.textBoxReParola.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxReParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReParola.Location = new System.Drawing.Point(248, 193);
            this.textBoxReParola.Multiline = true;
            this.textBoxReParola.Name = "textBoxReParola";
            this.textBoxReParola.PasswordChar = '*';
            this.textBoxReParola.Size = new System.Drawing.Size(247, 24);
            this.textBoxReParola.TabIndex = 1;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParola.Location = new System.Drawing.Point(248, 120);
            this.textBoxParola.Multiline = true;
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.PasswordChar = '*';
            this.textBoxParola.Size = new System.Drawing.Size(247, 26);
            this.textBoxParola.TabIndex = 2;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Green;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(116, 48);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(73, 26);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email";
            // 
            // labelRePasw
            // 
            this.labelRePasw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRePasw.AutoSize = true;
            this.labelRePasw.BackColor = System.Drawing.Color.Green;
            this.labelRePasw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRePasw.Location = new System.Drawing.Point(11, 193);
            this.labelRePasw.Name = "labelRePasw";
            this.labelRePasw.Size = new System.Drawing.Size(226, 26);
            this.labelRePasw.TabIndex = 4;
            this.labelRePasw.Text = "Reintroduceti parola";
            // 
            // labelPasw
            // 
            this.labelPasw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPasw.AutoSize = true;
            this.labelPasw.BackColor = System.Drawing.Color.Green;
            this.labelPasw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasw.Location = new System.Drawing.Point(108, 120);
            this.labelPasw.Name = "labelPasw";
            this.labelPasw.Size = new System.Drawing.Size(81, 26);
            this.labelPasw.TabIndex = 5;
            this.labelPasw.Text = "Parola";
            // 
            // buttonInregistrare
            // 
            this.buttonInregistrare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInregistrare.BackColor = System.Drawing.Color.Green;
            this.buttonInregistrare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInregistrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInregistrare.Location = new System.Drawing.Point(531, 103);
            this.buttonInregistrare.Name = "buttonInregistrare";
            this.buttonInregistrare.Size = new System.Drawing.Size(171, 57);
            this.buttonInregistrare.TabIndex = 6;
            this.buttonInregistrare.Text = "Inregistrare";
            this.buttonInregistrare.UseVisualStyleBackColor = false;
            this.buttonInregistrare.Click += new System.EventHandler(this.buttonInregistrare_Click);
            this.buttonInregistrare.MouseEnter += new System.EventHandler(this.buttonInregistrare_MouseEnter);
            this.buttonInregistrare.MouseLeave += new System.EventHandler(this.buttonInregistrare_MouseLeave);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Green;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(555, 226);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(133, 40);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Inapoi la meniu";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.button2_Click);
            this.buttonBack.MouseEnter += new System.EventHandler(this.buttonBack_MouseEnter);
            this.buttonBack.MouseLeave += new System.EventHandler(this.buttonBack_MouseLeave);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonExit.BackgroundImage = global::Sanki_s_BlackJack.Properties.Resources.exitNebun;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Location = new System.Drawing.Point(642, 3);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(49, 28);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // FormInregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::Sanki_s_BlackJack.Properties.Resources.doualogreg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 336);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonInregistrare);
            this.Controls.Add(this.labelPasw);
            this.Controls.Add(this.labelRePasw);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxReParola);
            this.Controls.Add(this.textBoxEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInregistrare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormInregistrare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxReParola;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelRePasw;
        private System.Windows.Forms.Label labelPasw;
        private System.Windows.Forms.Button buttonInregistrare;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonExit;
    }
}