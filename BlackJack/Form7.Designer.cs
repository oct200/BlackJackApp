namespace Sanki_s_BlackJack
{
    partial class FormJoc
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
            this.panelControaleJoc = new System.Windows.Forms.Panel();
            this.buttonInsurance = new System.Windows.Forms.Button();
            this.buttonSplit = new System.Windows.Forms.Button();
            this.buttonDouble = new System.Windows.Forms.Button();
            this.buttonStand = new System.Windows.Forms.Button();
            this.buttonHit = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timerInceput = new System.Windows.Forms.Timer(this.components);
            this.timerMiscare = new System.Windows.Forms.Timer(this.components);
            this.labelSuma = new System.Windows.Forms.Label();
            this.labelRezultat = new System.Windows.Forms.Label();
            this.labelSumaDealer = new System.Windows.Forms.Label();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.buttonIncepe = new System.Windows.Forms.Button();
            this.panelBet = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPariaza = new System.Windows.Forms.TextBox();
            this.labelPariaza = new System.Windows.Forms.Label();
            this.panelCarti = new System.Windows.Forms.Panel();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.labelLoading = new System.Windows.Forms.Label();
            this.labelAsi = new System.Windows.Forms.Label();
            this.labelRezultatDr = new System.Windows.Forms.Label();
            this.labelRezultatSt = new System.Windows.Forms.Label();
            this.labelSumaDr = new System.Windows.Forms.Label();
            this.labelSumaSt = new System.Windows.Forms.Label();
            this.textBoxDr = new System.Windows.Forms.TextBox();
            this.textBoxSt = new System.Windows.Forms.TextBox();
            this.buttonFullScreen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPuncteTot = new System.Windows.Forms.Label();
            this.textBoxPuncteTot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.button_allIn = new System.Windows.Forms.Button();
            this.panelControaleJoc.SuspendLayout();
            this.panelBet.SuspendLayout();
            this.panelCarti.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControaleJoc
            // 
            this.panelControaleJoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelControaleJoc.BackColor = System.Drawing.Color.Transparent;
            this.panelControaleJoc.Controls.Add(this.buttonInsurance);
            this.panelControaleJoc.Controls.Add(this.buttonSplit);
            this.panelControaleJoc.Controls.Add(this.buttonDouble);
            this.panelControaleJoc.Controls.Add(this.buttonStand);
            this.panelControaleJoc.Controls.Add(this.buttonHit);
            this.panelControaleJoc.Location = new System.Drawing.Point(860, 72);
            this.panelControaleJoc.Name = "panelControaleJoc";
            this.panelControaleJoc.Size = new System.Drawing.Size(152, 301);
            this.panelControaleJoc.TabIndex = 2;
            this.panelControaleJoc.Visible = false;
            // 
            // buttonInsurance
            // 
            this.buttonInsurance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInsurance.BackColor = System.Drawing.Color.Green;
            this.buttonInsurance.Enabled = false;
            this.buttonInsurance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsurance.Location = new System.Drawing.Point(28, 12);
            this.buttonInsurance.Name = "buttonInsurance";
            this.buttonInsurance.Size = new System.Drawing.Size(101, 40);
            this.buttonInsurance.TabIndex = 4;
            this.buttonInsurance.Text = "Asiguranta";
            this.buttonInsurance.UseVisualStyleBackColor = false;
            this.buttonInsurance.Click += new System.EventHandler(this.buttonInsurance_Click);
            this.buttonInsurance.MouseEnter += new System.EventHandler(this.buttonInsurance_MouseEnter);
            this.buttonInsurance.MouseLeave += new System.EventHandler(this.buttonInsurance_MouseLeave);
            // 
            // buttonSplit
            // 
            this.buttonSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSplit.BackColor = System.Drawing.Color.Green;
            this.buttonSplit.Enabled = false;
            this.buttonSplit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSplit.Location = new System.Drawing.Point(28, 69);
            this.buttonSplit.Name = "buttonSplit";
            this.buttonSplit.Size = new System.Drawing.Size(102, 40);
            this.buttonSplit.TabIndex = 3;
            this.buttonSplit.Text = "Desparte";
            this.buttonSplit.UseVisualStyleBackColor = false;
            this.buttonSplit.Click += new System.EventHandler(this.buttonSplit_Click);
            this.buttonSplit.MouseEnter += new System.EventHandler(this.buttonSplit_MouseEnter);
            this.buttonSplit.MouseLeave += new System.EventHandler(this.buttonSplit_MouseLeave);
            // 
            // buttonDouble
            // 
            this.buttonDouble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDouble.BackColor = System.Drawing.Color.Green;
            this.buttonDouble.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDouble.Location = new System.Drawing.Point(28, 128);
            this.buttonDouble.Name = "buttonDouble";
            this.buttonDouble.Size = new System.Drawing.Size(102, 40);
            this.buttonDouble.TabIndex = 2;
            this.buttonDouble.Text = "Dubleaza";
            this.buttonDouble.UseVisualStyleBackColor = false;
            this.buttonDouble.Click += new System.EventHandler(this.buttonDouble_Click);
            this.buttonDouble.MouseEnter += new System.EventHandler(this.buttonDouble_MouseEnter);
            this.buttonDouble.MouseLeave += new System.EventHandler(this.buttonDouble_MouseLeave);
            // 
            // buttonStand
            // 
            this.buttonStand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStand.BackColor = System.Drawing.Color.Green;
            this.buttonStand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStand.Location = new System.Drawing.Point(28, 240);
            this.buttonStand.Name = "buttonStand";
            this.buttonStand.Size = new System.Drawing.Size(102, 40);
            this.buttonStand.TabIndex = 1;
            this.buttonStand.Text = "Stai";
            this.buttonStand.UseVisualStyleBackColor = false;
            this.buttonStand.Click += new System.EventHandler(this.buttonStand_Click);
            this.buttonStand.MouseEnter += new System.EventHandler(this.buttonStand_MouseEnter);
            this.buttonStand.MouseLeave += new System.EventHandler(this.buttonStand_MouseLeave);
            // 
            // buttonHit
            // 
            this.buttonHit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHit.BackColor = System.Drawing.Color.Green;
            this.buttonHit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHit.Location = new System.Drawing.Point(28, 184);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(102, 40);
            this.buttonHit.TabIndex = 0;
            this.buttonHit.Text = "Carte";
            this.buttonHit.UseVisualStyleBackColor = false;
            this.buttonHit.Click += new System.EventHandler(this.buttonHit_Click);
            this.buttonHit.MouseEnter += new System.EventHandler(this.buttonHit_MouseEnter);
            this.buttonHit.MouseLeave += new System.EventHandler(this.buttonHit_MouseLeave);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonExit.BackgroundImage = global::Sanki_s_BlackJack.Properties.Resources.exitNebun;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(981, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(49, 28);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            // 
            // timerInceput
            // 
            this.timerInceput.Interval = 1000;
            this.timerInceput.Tick += new System.EventHandler(this.timerInceput_Tick);
            // 
            // labelSuma
            // 
            this.labelSuma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSuma.AutoSize = true;
            this.labelSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuma.ForeColor = System.Drawing.Color.Black;
            this.labelSuma.Location = new System.Drawing.Point(283, 310);
            this.labelSuma.Name = "labelSuma";
            this.labelSuma.Size = new System.Drawing.Size(25, 25);
            this.labelSuma.TabIndex = 5;
            this.labelSuma.Text = "0";
            this.labelSuma.Visible = false;
            // 
            // labelRezultat
            // 
            this.labelRezultat.AutoSize = true;
            this.labelRezultat.BackColor = System.Drawing.Color.Green;
            this.labelRezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRezultat.ForeColor = System.Drawing.Color.Black;
            this.labelRezultat.Location = new System.Drawing.Point(44, 50);
            this.labelRezultat.Name = "labelRezultat";
            this.labelRezultat.Size = new System.Drawing.Size(143, 26);
            this.labelRezultat.TabIndex = 4;
            this.labelRezultat.Text = "Ai pierdut =(";
            this.labelRezultat.Visible = false;
            // 
            // labelSumaDealer
            // 
            this.labelSumaDealer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSumaDealer.AutoSize = true;
            this.labelSumaDealer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelSumaDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumaDealer.ForeColor = System.Drawing.Color.Black;
            this.labelSumaDealer.Location = new System.Drawing.Point(194, 32);
            this.labelSumaDealer.Name = "labelSumaDealer";
            this.labelSumaDealer.Size = new System.Drawing.Size(25, 25);
            this.labelSumaDealer.TabIndex = 6;
            this.labelSumaDealer.Text = "0";
            this.labelSumaDealer.Visible = false;
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInapoi.BackColor = System.Drawing.Color.Green;
            this.buttonInapoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInapoi.Location = new System.Drawing.Point(18, 158);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(172, 61);
            this.buttonInapoi.TabIndex = 3;
            this.buttonInapoi.Text = "Inapoi la meniu";
            this.buttonInapoi.UseVisualStyleBackColor = false;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            this.buttonInapoi.MouseEnter += new System.EventHandler(this.buttonInapoi_MouseEnter);
            this.buttonInapoi.MouseLeave += new System.EventHandler(this.buttonInapoi_MouseLeave);
            // 
            // buttonIncepe
            // 
            this.buttonIncepe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIncepe.BackColor = System.Drawing.Color.Green;
            this.buttonIncepe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIncepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncepe.Location = new System.Drawing.Point(18, 81);
            this.buttonIncepe.Name = "buttonIncepe";
            this.buttonIncepe.Size = new System.Drawing.Size(172, 61);
            this.buttonIncepe.TabIndex = 2;
            this.buttonIncepe.Text = "Incepe Jocul";
            this.buttonIncepe.UseVisualStyleBackColor = false;
            this.buttonIncepe.Click += new System.EventHandler(this.buttonIncepe_Click);
            this.buttonIncepe.MouseEnter += new System.EventHandler(this.buttonIncepe_MouseEnter);
            this.buttonIncepe.MouseLeave += new System.EventHandler(this.buttonIncepe_MouseLeave);
            // 
            // panelBet
            // 
            this.panelBet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelBet.BackColor = System.Drawing.Color.Transparent;
            this.panelBet.Controls.Add(this.label1);
            this.panelBet.Controls.Add(this.textBoxPariaza);
            this.panelBet.Controls.Add(this.labelPariaza);
            this.panelBet.Controls.Add(this.buttonInapoi);
            this.panelBet.Controls.Add(this.buttonIncepe);
            this.panelBet.Location = new System.Drawing.Point(9, 92);
            this.panelBet.Name = "panelBet";
            this.panelBet.Size = new System.Drawing.Size(194, 260);
            this.panelBet.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(170, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "$";
            // 
            // textBoxPariaza
            // 
            this.textBoxPariaza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPariaza.BackColor = System.Drawing.Color.DarkOrange;
            this.textBoxPariaza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPariaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPariaza.Location = new System.Drawing.Point(98, 41);
            this.textBoxPariaza.Multiline = true;
            this.textBoxPariaza.Name = "textBoxPariaza";
            this.textBoxPariaza.Size = new System.Drawing.Size(72, 29);
            this.textBoxPariaza.TabIndex = 5;
            this.textBoxPariaza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPariaza_KeyPress);
            // 
            // labelPariaza
            // 
            this.labelPariaza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPariaza.AutoSize = true;
            this.labelPariaza.BackColor = System.Drawing.Color.Green;
            this.labelPariaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPariaza.Location = new System.Drawing.Point(3, 41);
            this.labelPariaza.Name = "labelPariaza";
            this.labelPariaza.Size = new System.Drawing.Size(93, 26);
            this.labelPariaza.TabIndex = 4;
            this.labelPariaza.Text = "Pariaza";
            // 
            // panelCarti
            // 
            this.panelCarti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCarti.BackColor = System.Drawing.Color.Transparent;
            this.panelCarti.Controls.Add(this.progressBarLoading);
            this.panelCarti.Controls.Add(this.labelLoading);
            this.panelCarti.Controls.Add(this.labelAsi);
            this.panelCarti.Controls.Add(this.labelRezultatDr);
            this.panelCarti.Controls.Add(this.labelRezultatSt);
            this.panelCarti.Controls.Add(this.labelSumaDr);
            this.panelCarti.Controls.Add(this.labelSumaSt);
            this.panelCarti.Controls.Add(this.labelSuma);
            this.panelCarti.Controls.Add(this.labelSumaDealer);
            this.panelCarti.Controls.Add(this.textBoxDr);
            this.panelCarti.Controls.Add(this.textBoxSt);
            this.panelCarti.Location = new System.Drawing.Point(220, 58);
            this.panelCarti.Margin = new System.Windows.Forms.Padding(2);
            this.panelCarti.Name = "panelCarti";
            this.panelCarti.Size = new System.Drawing.Size(623, 479);
            this.panelCarti.TabIndex = 10;
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.progressBarLoading.BackColor = System.Drawing.Color.Black;
            this.progressBarLoading.ForeColor = System.Drawing.Color.Green;
            this.progressBarLoading.Location = new System.Drawing.Point(224, 210);
            this.progressBarLoading.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(190, 28);
            this.progressBarLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarLoading.TabIndex = 9;
            // 
            // labelLoading
            // 
            this.labelLoading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLoading.AutoSize = true;
            this.labelLoading.BackColor = System.Drawing.Color.Transparent;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.Color.Green;
            this.labelLoading.Location = new System.Drawing.Point(160, 106);
            this.labelLoading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(384, 108);
            this.labelLoading.TabIndex = 8;
            this.labelLoading.Text = "Loading";
            this.labelLoading.Click += new System.EventHandler(this.labelLoading_Click);
            // 
            // labelAsi
            // 
            this.labelAsi.AutoSize = true;
            this.labelAsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelAsi.Location = new System.Drawing.Point(47, 167);
            this.labelAsi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAsi.Name = "labelAsi";
            this.labelAsi.Size = new System.Drawing.Size(0, 13);
            this.labelAsi.TabIndex = 7;
            // 
            // labelRezultatDr
            // 
            this.labelRezultatDr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelRezultatDr.AutoSize = true;
            this.labelRezultatDr.BackColor = System.Drawing.Color.Green;
            this.labelRezultatDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRezultatDr.Location = new System.Drawing.Point(515, 283);
            this.labelRezultatDr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRezultatDr.Name = "labelRezultatDr";
            this.labelRezultatDr.Size = new System.Drawing.Size(94, 20);
            this.labelRezultatDr.TabIndex = 5;
            this.labelRezultatDr.Text = "Ai pierdut =(";
            this.labelRezultatDr.Visible = false;
            // 
            // labelRezultatSt
            // 
            this.labelRezultatSt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRezultatSt.AutoSize = true;
            this.labelRezultatSt.BackColor = System.Drawing.Color.Green;
            this.labelRezultatSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRezultatSt.Location = new System.Drawing.Point(2, 283);
            this.labelRezultatSt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRezultatSt.Name = "labelRezultatSt";
            this.labelRezultatSt.Size = new System.Drawing.Size(94, 20);
            this.labelRezultatSt.TabIndex = 4;
            this.labelRezultatSt.Text = "Ai pierdut =(";
            this.labelRezultatSt.Visible = false;
            // 
            // labelSumaDr
            // 
            this.labelSumaDr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSumaDr.AutoSize = true;
            this.labelSumaDr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelSumaDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumaDr.ForeColor = System.Drawing.Color.Black;
            this.labelSumaDr.Location = new System.Drawing.Point(514, 310);
            this.labelSumaDr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSumaDr.Name = "labelSumaDr";
            this.labelSumaDr.Size = new System.Drawing.Size(27, 29);
            this.labelSumaDr.TabIndex = 3;
            this.labelSumaDr.Text = "0";
            this.labelSumaDr.Visible = false;
            // 
            // labelSumaSt
            // 
            this.labelSumaSt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSumaSt.AutoSize = true;
            this.labelSumaSt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelSumaSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumaSt.ForeColor = System.Drawing.Color.Black;
            this.labelSumaSt.Location = new System.Drawing.Point(47, 310);
            this.labelSumaSt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSumaSt.Name = "labelSumaSt";
            this.labelSumaSt.Size = new System.Drawing.Size(27, 29);
            this.labelSumaSt.TabIndex = 2;
            this.labelSumaSt.Text = "0";
            this.labelSumaSt.Visible = false;
            // 
            // textBoxDr
            // 
            this.textBoxDr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxDr.BackColor = System.Drawing.Color.Lime;
            this.textBoxDr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDr.Enabled = false;
            this.textBoxDr.Location = new System.Drawing.Point(561, 310);
            this.textBoxDr.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDr.Multiline = true;
            this.textBoxDr.Name = "textBoxDr";
            this.textBoxDr.Size = new System.Drawing.Size(24, 26);
            this.textBoxDr.TabIndex = 1;
            this.textBoxDr.Visible = false;
            // 
            // textBoxSt
            // 
            this.textBoxSt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSt.BackColor = System.Drawing.Color.Lime;
            this.textBoxSt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSt.Enabled = false;
            this.textBoxSt.Location = new System.Drawing.Point(6, 310);
            this.textBoxSt.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSt.Multiline = true;
            this.textBoxSt.Name = "textBoxSt";
            this.textBoxSt.Size = new System.Drawing.Size(24, 26);
            this.textBoxSt.TabIndex = 0;
            this.textBoxSt.Visible = false;
            // 
            // buttonFullScreen
            // 
            this.buttonFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFullScreen.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonFullScreen.BackgroundImage = global::Sanki_s_BlackJack.Properties.Resources.fullscreen;
            this.buttonFullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFullScreen.Location = new System.Drawing.Point(917, 3);
            this.buttonFullScreen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFullScreen.Name = "buttonFullScreen";
            this.buttonFullScreen.Size = new System.Drawing.Size(47, 28);
            this.buttonFullScreen.TabIndex = 11;
            this.buttonFullScreen.UseVisualStyleBackColor = false;
            this.buttonFullScreen.Visible = false;
            this.buttonFullScreen.Click += new System.EventHandler(this.buttonFullScreen_Click);
            this.buttonFullScreen.MouseEnter += new System.EventHandler(this.buttonFullScreen_MouseEnter);
            this.buttonFullScreen.MouseLeave += new System.EventHandler(this.buttonFullScreen_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.buttonFullScreen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 36);
            this.panel2.TabIndex = 12;
            // 
            // labelPuncteTot
            // 
            this.labelPuncteTot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPuncteTot.AutoSize = true;
            this.labelPuncteTot.BackColor = System.Drawing.Color.Green;
            this.labelPuncteTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuncteTot.Location = new System.Drawing.Point(14, 370);
            this.labelPuncteTot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPuncteTot.Name = "labelPuncteTot";
            this.labelPuncteTot.Size = new System.Drawing.Size(96, 20);
            this.labelPuncteTot.TabIndex = 13;
            this.labelPuncteTot.Text = "Dolari totali: ";
            // 
            // textBoxPuncteTot
            // 
            this.textBoxPuncteTot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPuncteTot.BackColor = System.Drawing.Color.Green;
            this.textBoxPuncteTot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPuncteTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPuncteTot.ForeColor = System.Drawing.Color.Black;
            this.textBoxPuncteTot.Location = new System.Drawing.Point(116, 370);
            this.textBoxPuncteTot.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPuncteTot.Multiline = true;
            this.textBoxPuncteTot.Name = "textBoxPuncteTot";
            this.textBoxPuncteTot.ReadOnly = true;
            this.textBoxPuncteTot.Size = new System.Drawing.Size(87, 20);
            this.textBoxPuncteTot.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 370);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "$";
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 50;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // button_allIn
            // 
            this.button_allIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_allIn.BackColor = System.Drawing.Color.Green;
            this.button_allIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_allIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_allIn.Location = new System.Drawing.Point(27, 544);
            this.button_allIn.Name = "button_allIn";
            this.button_allIn.Size = new System.Drawing.Size(186, 33);
            this.button_allIn.TabIndex = 5;
            this.button_allIn.Text = "All-in";
            this.button_allIn.UseVisualStyleBackColor = false;
            this.button_allIn.Visible = false;
            this.button_allIn.Click += new System.EventHandler(this.button_allIn_Click);
            // 
            // FormJoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 569);
            this.Controls.Add(this.button_allIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPuncteTot);
            this.Controls.Add(this.labelPuncteTot);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCarti);
            this.Controls.Add(this.panelBet);
            this.Controls.Add(this.labelRezultat);
            this.Controls.Add(this.panelControaleJoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormJoc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJoc";
            this.Load += new System.EventHandler(this.FormJoc_Load);
            this.panelControaleJoc.ResumeLayout(false);
            this.panelBet.ResumeLayout(false);
            this.panelBet.PerformLayout();
            this.panelCarti.ResumeLayout(false);
            this.panelCarti.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelControaleJoc;
        private System.Windows.Forms.Button buttonSplit;
        private System.Windows.Forms.Button buttonDouble;
        private System.Windows.Forms.Button buttonStand;
        private System.Windows.Forms.Button buttonHit;
        private System.Windows.Forms.Button buttonInsurance;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timerInceput;
        private System.Windows.Forms.Timer timerMiscare;
        private System.Windows.Forms.Label labelSuma;
        private System.Windows.Forms.Label labelRezultat;
        private System.Windows.Forms.Label labelSumaDealer;
        private System.Windows.Forms.Button buttonInapoi;
        private System.Windows.Forms.Button buttonIncepe;
        private System.Windows.Forms.Panel panelBet;
        private System.Windows.Forms.TextBox textBoxPariaza;
        private System.Windows.Forms.Label labelPariaza;
        private System.Windows.Forms.Panel panelCarti;
        private System.Windows.Forms.TextBox textBoxDr;
        private System.Windows.Forms.TextBox textBoxSt;
        private System.Windows.Forms.Label labelSumaDr;
        private System.Windows.Forms.Label labelSumaSt;
        private System.Windows.Forms.Label labelRezultatDr;
        private System.Windows.Forms.Label labelRezultatSt;
        private System.Windows.Forms.Button buttonFullScreen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAsi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPuncteTot;
        private System.Windows.Forms.TextBox textBoxPuncteTot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.ProgressBar progressBarLoading;
        private System.Windows.Forms.Button button_allIn;
    }
}