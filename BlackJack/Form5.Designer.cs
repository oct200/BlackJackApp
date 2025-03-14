namespace Sanki_s_BlackJack
{
    partial class FormOptiuni
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
            this.labelLimba = new System.Windows.Forms.Label();
            this.buttonEngl = new System.Windows.Forms.Button();
            this.buttonRom = new System.Windows.Forms.Button();
            this.buttonInserare = new System.Windows.Forms.Button();
            this.comboBoxPachet = new System.Windows.Forms.ComboBox();
            this.labelPac = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelPuncteTot = new System.Windows.Forms.Label();
            this.labelVictorii = new System.Windows.Forms.Label();
            this.labelVictoriiCons = new System.Windows.Forms.Label();
            this.textBoxPuncteTot = new System.Windows.Forms.TextBox();
            this.textBoxVictorii = new System.Windows.Forms.TextBox();
            this.textBoxVictoriiCons = new System.Windows.Forms.TextBox();
            this.pictureBoxCarte1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLimba
            // 
            this.labelLimba.AutoSize = true;
            this.labelLimba.BackColor = System.Drawing.Color.Green;
            this.labelLimba.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLimba.Location = new System.Drawing.Point(18, 306);
            this.labelLimba.Name = "labelLimba";
            this.labelLimba.Size = new System.Drawing.Size(92, 31);
            this.labelLimba.TabIndex = 0;
            this.labelLimba.Text = "Limba";
            // 
            // buttonEngl
            // 
            this.buttonEngl.BackColor = System.Drawing.Color.Lime;
            this.buttonEngl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEngl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEngl.Location = new System.Drawing.Point(290, 306);
            this.buttonEngl.Name = "buttonEngl";
            this.buttonEngl.Size = new System.Drawing.Size(102, 30);
            this.buttonEngl.TabIndex = 1;
            this.buttonEngl.Text = "Engleza";
            this.buttonEngl.UseVisualStyleBackColor = false;
            this.buttonEngl.Click += new System.EventHandler(this.button1_Click);
            this.buttonEngl.MouseEnter += new System.EventHandler(this.buttonEngl_MouseEnter);
            this.buttonEngl.MouseLeave += new System.EventHandler(this.buttonEngl_MouseLeave);
            // 
            // buttonRom
            // 
            this.buttonRom.BackColor = System.Drawing.Color.Lime;
            this.buttonRom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRom.Location = new System.Drawing.Point(154, 306);
            this.buttonRom.Name = "buttonRom";
            this.buttonRom.Size = new System.Drawing.Size(106, 30);
            this.buttonRom.TabIndex = 2;
            this.buttonRom.Text = "Romana";
            this.buttonRom.UseVisualStyleBackColor = false;
            this.buttonRom.Click += new System.EventHandler(this.button2_Click);
            this.buttonRom.MouseEnter += new System.EventHandler(this.buttonRom_MouseEnter);
            this.buttonRom.MouseLeave += new System.EventHandler(this.buttonRom_MouseLeave);
            // 
            // buttonInserare
            // 
            this.buttonInserare.BackColor = System.Drawing.Color.Lime;
            this.buttonInserare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInserare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserare.Location = new System.Drawing.Point(429, 4);
            this.buttonInserare.Name = "buttonInserare";
            this.buttonInserare.Size = new System.Drawing.Size(148, 30);
            this.buttonInserare.TabIndex = 3;
            this.buttonInserare.Text = "Selecteaza pachetul";
            this.buttonInserare.UseVisualStyleBackColor = false;
            this.buttonInserare.Click += new System.EventHandler(this.buttonInserare_Click);
            this.buttonInserare.MouseEnter += new System.EventHandler(this.buttonInserare_MouseEnter);
            this.buttonInserare.MouseLeave += new System.EventHandler(this.buttonInserare_MouseLeave);
            // 
            // comboBoxPachet
            // 
            this.comboBoxPachet.FormattingEnabled = true;
            this.comboBoxPachet.Items.AddRange(new object[] {
            "Pachetul Basic",
            "Pachetul Into the Weird",
            "Pachetul Tikilandia",
            "Pachetul Hand Lords",
            "Pachetul Blue Hell"});
            this.comboBoxPachet.Location = new System.Drawing.Point(288, 9);
            this.comboBoxPachet.Name = "comboBoxPachet";
            this.comboBoxPachet.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPachet.TabIndex = 4;
            this.comboBoxPachet.SelectedIndexChanged += new System.EventHandler(this.comboBoxPachet_SelectedIndexChanged);
            // 
            // labelPac
            // 
            this.labelPac.AutoSize = true;
            this.labelPac.BackColor = System.Drawing.Color.Green;
            this.labelPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPac.Location = new System.Drawing.Point(6, 9);
            this.labelPac.Name = "labelPac";
            this.labelPac.Size = new System.Drawing.Size(261, 25);
            this.labelPac.TabIndex = 5;
            this.labelPac.Text = "Pachetul de carti folosit";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonExit.BackgroundImage = global::Sanki_s_BlackJack.Properties.Resources.exitNebun;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(632, 6);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(49, 28);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Green;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(534, 291);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(147, 46);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Inapoi la meniu";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.MouseEnter += new System.EventHandler(this.buttonBack_MouseEnter);
            this.buttonBack.MouseLeave += new System.EventHandler(this.buttonBack_MouseLeave);
            this.buttonBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonBack_MouseMove);
            // 
            // labelPuncteTot
            // 
            this.labelPuncteTot.AutoSize = true;
            this.labelPuncteTot.BackColor = System.Drawing.Color.Green;
            this.labelPuncteTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuncteTot.Location = new System.Drawing.Point(89, 214);
            this.labelPuncteTot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPuncteTot.Name = "labelPuncteTot";
            this.labelPuncteTot.Size = new System.Drawing.Size(96, 20);
            this.labelPuncteTot.TabIndex = 8;
            this.labelPuncteTot.Text = "Dolari totali: ";
            // 
            // labelVictorii
            // 
            this.labelVictorii.AutoSize = true;
            this.labelVictorii.BackColor = System.Drawing.Color.Green;
            this.labelVictorii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVictorii.Location = new System.Drawing.Point(121, 240);
            this.labelVictorii.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVictorii.Name = "labelVictorii";
            this.labelVictorii.Size = new System.Drawing.Size(64, 20);
            this.labelVictorii.TabIndex = 9;
            this.labelVictorii.Text = "Victorii: ";
            // 
            // labelVictoriiCons
            // 
            this.labelVictoriiCons.AutoSize = true;
            this.labelVictoriiCons.BackColor = System.Drawing.Color.Green;
            this.labelVictoriiCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVictoriiCons.Location = new System.Drawing.Point(33, 267);
            this.labelVictoriiCons.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVictoriiCons.Name = "labelVictoriiCons";
            this.labelVictoriiCons.Size = new System.Drawing.Size(152, 20);
            this.labelVictoriiCons.TabIndex = 10;
            this.labelVictoriiCons.Text = "Victorii consecutive: ";
            // 
            // textBoxPuncteTot
            // 
            this.textBoxPuncteTot.BackColor = System.Drawing.Color.Green;
            this.textBoxPuncteTot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPuncteTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPuncteTot.Location = new System.Drawing.Point(212, 214);
            this.textBoxPuncteTot.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPuncteTot.Multiline = true;
            this.textBoxPuncteTot.Name = "textBoxPuncteTot";
            this.textBoxPuncteTot.Size = new System.Drawing.Size(75, 18);
            this.textBoxPuncteTot.TabIndex = 11;
            // 
            // textBoxVictorii
            // 
            this.textBoxVictorii.BackColor = System.Drawing.Color.Green;
            this.textBoxVictorii.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVictorii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxVictorii.Location = new System.Drawing.Point(212, 242);
            this.textBoxVictorii.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVictorii.Multiline = true;
            this.textBoxVictorii.Name = "textBoxVictorii";
            this.textBoxVictorii.Size = new System.Drawing.Size(75, 18);
            this.textBoxVictorii.TabIndex = 12;
            // 
            // textBoxVictoriiCons
            // 
            this.textBoxVictoriiCons.BackColor = System.Drawing.Color.Green;
            this.textBoxVictoriiCons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVictoriiCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxVictoriiCons.Location = new System.Drawing.Point(213, 269);
            this.textBoxVictoriiCons.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVictoriiCons.Multiline = true;
            this.textBoxVictoriiCons.Name = "textBoxVictoriiCons";
            this.textBoxVictoriiCons.Size = new System.Drawing.Size(75, 18);
            this.textBoxVictoriiCons.TabIndex = 13;
            // 
            // pictureBoxCarte1
            // 
            this.pictureBoxCarte1.Location = new System.Drawing.Point(7, 43);
            this.pictureBoxCarte1.Name = "pictureBoxCarte1";
            this.pictureBoxCarte1.Size = new System.Drawing.Size(131, 154);
            this.pictureBoxCarte1.TabIndex = 14;
            this.pictureBoxCarte1.TabStop = false;
            this.pictureBoxCarte1.Click += new System.EventHandler(this.pictureBoxCarte1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(155, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 154);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FormOptiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Sanki_s_BlackJack.Properties.Resources.options;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 352);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxCarte1);
            this.Controls.Add(this.textBoxVictoriiCons);
            this.Controls.Add(this.textBoxVictorii);
            this.Controls.Add(this.textBoxPuncteTot);
            this.Controls.Add(this.labelVictoriiCons);
            this.Controls.Add(this.labelVictorii);
            this.Controls.Add(this.labelPuncteTot);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelPac);
            this.Controls.Add(this.comboBoxPachet);
            this.Controls.Add(this.buttonInserare);
            this.Controls.Add(this.buttonRom);
            this.Controls.Add(this.buttonEngl);
            this.Controls.Add(this.labelLimba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOptiuni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optiuni";
            this.Load += new System.EventHandler(this.FormOptiuni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLimba;
        private System.Windows.Forms.Button buttonEngl;
        private System.Windows.Forms.Button buttonRom;
        private System.Windows.Forms.Button buttonInserare;
        private System.Windows.Forms.ComboBox comboBoxPachet;
        private System.Windows.Forms.Label labelPac;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelPuncteTot;
        private System.Windows.Forms.Label labelVictorii;
        private System.Windows.Forms.Label labelVictoriiCons;
        private System.Windows.Forms.TextBox textBoxPuncteTot;
        private System.Windows.Forms.TextBox textBoxVictorii;
        private System.Windows.Forms.TextBox textBoxVictoriiCons;
        private System.Windows.Forms.PictureBox pictureBoxCarte1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}