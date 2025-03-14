namespace Sanki_s_BlackJack
{
    partial class FormStart
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
            this.buttonInregistrare = new System.Windows.Forms.Button();
            this.buttonAutentificare = new System.Windows.Forms.Button();
            this.buttonIesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInregistrare
            // 
            this.buttonInregistrare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInregistrare.BackColor = System.Drawing.Color.Green;
            this.buttonInregistrare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInregistrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInregistrare.Location = new System.Drawing.Point(334, 120);
            this.buttonInregistrare.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInregistrare.Name = "buttonInregistrare";
            this.buttonInregistrare.Size = new System.Drawing.Size(249, 89);
            this.buttonInregistrare.TabIndex = 0;
            this.buttonInregistrare.Text = "Inregistrare";
            this.buttonInregistrare.UseVisualStyleBackColor = false;
            this.buttonInregistrare.Click += new System.EventHandler(this.buttonInregistrare_Click);
            this.buttonInregistrare.MouseEnter += new System.EventHandler(this.buttonInregistrare_MouseEnter);
            this.buttonInregistrare.MouseLeave += new System.EventHandler(this.buttonInregistrare_MouseLeave);
            // 
            // buttonAutentificare
            // 
            this.buttonAutentificare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAutentificare.BackColor = System.Drawing.Color.Green;
            this.buttonAutentificare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAutentificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAutentificare.Location = new System.Drawing.Point(334, 272);
            this.buttonAutentificare.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAutentificare.Name = "buttonAutentificare";
            this.buttonAutentificare.Size = new System.Drawing.Size(249, 89);
            this.buttonAutentificare.TabIndex = 1;
            this.buttonAutentificare.Text = "Autentificare";
            this.buttonAutentificare.UseVisualStyleBackColor = false;
            this.buttonAutentificare.Click += new System.EventHandler(this.buttonAutentificare_Click);
            this.buttonAutentificare.MouseEnter += new System.EventHandler(this.buttonAutentificare_MouseEnter);
            this.buttonAutentificare.MouseLeave += new System.EventHandler(this.buttonAutentificare_MouseLeave);
            // 
            // buttonIesire
            // 
            this.buttonIesire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIesire.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonIesire.BackgroundImage = global::Sanki_s_BlackJack.Properties.Resources.exitNebun;
            this.buttonIesire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIesire.Location = new System.Drawing.Point(855, 4);
            this.buttonIesire.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIesire.Name = "buttonIesire";
            this.buttonIesire.Size = new System.Drawing.Size(65, 34);
            this.buttonIesire.TabIndex = 2;
            this.buttonIesire.UseVisualStyleBackColor = false;
            this.buttonIesire.Click += new System.EventHandler(this.buttonIesire_Click);
            this.buttonIesire.MouseEnter += new System.EventHandler(this.buttonIesire_MouseEnter);
            this.buttonIesire.MouseLeave += new System.EventHandler(this.buttonIesire_MouseLeave);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImage = global::Sanki_s_BlackJack.Properties.Resources.login_register;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 492);
            this.Controls.Add(this.buttonIesire);
            this.Controls.Add(this.buttonAutentificare);
            this.Controls.Add(this.buttonInregistrare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInregistrare;
        private System.Windows.Forms.Button buttonAutentificare;
        private System.Windows.Forms.Button buttonIesire;
    }
}

