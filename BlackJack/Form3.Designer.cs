namespace Sanki_s_BlackJack
{
    partial class FormAutentificare
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
            this.buttonIntrare = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPasw = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIntrare
            // 
            this.buttonIntrare.BackColor = System.Drawing.Color.Green;
            this.buttonIntrare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIntrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIntrare.Location = new System.Drawing.Point(516, 86);
            this.buttonIntrare.Name = "buttonIntrare";
            this.buttonIntrare.Size = new System.Drawing.Size(154, 65);
            this.buttonIntrare.TabIndex = 0;
            this.buttonIntrare.Text = "Intra in cont";
            this.buttonIntrare.UseVisualStyleBackColor = false;
            this.buttonIntrare.Click += new System.EventHandler(this.buttonIntrare_Click);
            this.buttonIntrare.MouseEnter += new System.EventHandler(this.buttonIntrare_MouseEnter);
            this.buttonIntrare.MouseLeave += new System.EventHandler(this.buttonIntrare_MouseLeave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(242, 66);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(221, 25);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParola.Location = new System.Drawing.Point(242, 156);
            this.textBoxParola.Multiline = true;
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.PasswordChar = '*';
            this.textBoxParola.Size = new System.Drawing.Size(221, 25);
            this.textBoxParola.TabIndex = 2;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Green;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(86, 64);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(81, 26);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "E-mail";
            // 
            // labelPasw
            // 
            this.labelPasw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPasw.AutoSize = true;
            this.labelPasw.BackColor = System.Drawing.Color.Green;
            this.labelPasw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasw.Location = new System.Drawing.Point(86, 154);
            this.labelPasw.Name = "labelPasw";
            this.labelPasw.Size = new System.Drawing.Size(81, 26);
            this.labelPasw.TabIndex = 4;
            this.labelPasw.Text = "Parola";
            this.labelPasw.Click += new System.EventHandler(this.labelPasw_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Green;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(534, 198);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(136, 41);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Inapoi la meniu";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.MouseEnter += new System.EventHandler(this.buttonBack_MouseEnter);
            this.buttonBack.MouseLeave += new System.EventHandler(this.buttonBack_MouseLeave);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonExit.BackgroundImage = global::Sanki_s_BlackJack.Properties.Resources.exitNebun;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Location = new System.Drawing.Point(645, 3);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(49, 28);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            // 
            // FormAutentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::Sanki_s_BlackJack.Properties.Resources.doualogreg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 285);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelPasw);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonIntrare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAutentificare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormAutentificare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIntrare;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPasw;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonExit;
    }
}