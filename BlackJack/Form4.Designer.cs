namespace Sanki_s_BlackJack
{
    partial class FormMeciuJoc
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonOptiuni = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.linkLabelHowToPlay = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonExit.BackgroundImage = global::Sanki_s_BlackJack.Properties.Resources.exitNebun;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(641, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(49, 28);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Green;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(239, 80);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(193, 73);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Joaca";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            this.buttonPlay.MouseEnter += new System.EventHandler(this.buttonPlay_MouseEnter);
            this.buttonPlay.MouseLeave += new System.EventHandler(this.buttonPlay_MouseLeave);
            // 
            // buttonOptiuni
            // 
            this.buttonOptiuni.BackColor = System.Drawing.Color.Green;
            this.buttonOptiuni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOptiuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOptiuni.Location = new System.Drawing.Point(239, 186);
            this.buttonOptiuni.Name = "buttonOptiuni";
            this.buttonOptiuni.Size = new System.Drawing.Size(193, 73);
            this.buttonOptiuni.TabIndex = 2;
            this.buttonOptiuni.Text = "Optiuni";
            this.buttonOptiuni.UseVisualStyleBackColor = false;
            this.buttonOptiuni.Click += new System.EventHandler(this.buttonOptiuni_Click);
            this.buttonOptiuni.MouseEnter += new System.EventHandler(this.buttonOptiuni_MouseEnter);
            this.buttonOptiuni.MouseLeave += new System.EventHandler(this.buttonOptiuni_MouseLeave);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Green;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(517, 332);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 39);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Inapoi la meniu";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.MouseEnter += new System.EventHandler(this.buttonBack_MouseEnter);
            this.buttonBack.MouseLeave += new System.EventHandler(this.buttonBack_MouseLeave);
            // 
            // linkLabelHowToPlay
            // 
            this.linkLabelHowToPlay.AutoSize = true;
            this.linkLabelHowToPlay.BackColor = System.Drawing.Color.Green;
            this.linkLabelHowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelHowToPlay.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabelHowToPlay.Location = new System.Drawing.Point(271, 286);
            this.linkLabelHowToPlay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelHowToPlay.Name = "linkLabelHowToPlay";
            this.linkLabelHowToPlay.Size = new System.Drawing.Size(135, 24);
            this.linkLabelHowToPlay.TabIndex = 4;
            this.linkLabelHowToPlay.TabStop = true;
            this.linkLabelHowToPlay.Text = "Cum se joaca?";
            this.linkLabelHowToPlay.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkLabelHowToPlay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHowToPlay_LinkClicked);
            // 
            // FormMeciuJoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Sanki_s_BlackJack.Properties.Resources.Play;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.linkLabelHowToPlay);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonOptiuni);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMeciuJoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuJoc";
            this.Load += new System.EventHandler(this.FormMeciuJoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonOptiuni;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.LinkLabel linkLabelHowToPlay;
    }
}