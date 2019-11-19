namespace MonitorowanieKlient
{
    partial class Form1
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
            this.subskrybujGrupa = new System.Windows.Forms.GroupBox();
            this.zuzycieProces = new System.Windows.Forms.CheckBox();
            this.zuzycieCpu = new System.Windows.Forms.CheckBox();
            this.dostepnyRAM = new System.Windows.Forms.CheckBox();
            this.tekstDostepnyRam = new System.Windows.Forms.Label();
            this.pasekZuzycieRamu = new System.Windows.Forms.ProgressBar();
            this.pasekZuzyciaCpu = new System.Windows.Forms.ProgressBar();
            this.tekstDostepnyCpu = new System.Windows.Forms.Label();
            this.pasekZuzyciaProces = new System.Windows.Forms.ProgressBar();
            this.tekstZuzycieProces = new System.Windows.Forms.Label();
            this.zarzadzajSerweremGrupa = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.zmienStalaCzasowa = new System.Windows.Forms.Button();
            this.interwal = new System.Windows.Forms.TextBox();
            this.wylacz = new System.Windows.Forms.Button();
            this.wlacz = new System.Windows.Forms.Button();
            this.pobierzObecniePublikowaneTematy = new System.Windows.Forms.Button();
            this.tematy = new System.Windows.Forms.ListBox();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.poleNaIp = new System.Windows.Forms.TextBox();
            this.polacz = new System.Windows.Forms.Button();
            this.pobierzStalaCzasowa = new System.Windows.Forms.Button();
            this.subskrybujGrupa.SuspendLayout();
            this.zarzadzajSerweremGrupa.SuspendLayout();
            this.SuspendLayout();
            // 
            // subskrybujGrupa
            // 
            this.subskrybujGrupa.Controls.Add(this.zuzycieProces);
            this.subskrybujGrupa.Controls.Add(this.zuzycieCpu);
            this.subskrybujGrupa.Controls.Add(this.dostepnyRAM);
            this.subskrybujGrupa.Location = new System.Drawing.Point(13, 13);
            this.subskrybujGrupa.Name = "subskrybujGrupa";
            this.subskrybujGrupa.Size = new System.Drawing.Size(251, 95);
            this.subskrybujGrupa.TabIndex = 0;
            this.subskrybujGrupa.TabStop = false;
            this.subskrybujGrupa.Text = "Subskrybuj";
            // 
            // zuzycieProces
            // 
            this.zuzycieProces.AutoSize = true;
            this.zuzycieProces.Location = new System.Drawing.Point(7, 68);
            this.zuzycieProces.Name = "zuzycieProces";
            this.zuzycieProces.Size = new System.Drawing.Size(200, 17);
            this.zuzycieProces.TabIndex = 2;
            this.zuzycieProces.Text = "zużycie RAM-u przez proces serwera";
            this.zuzycieProces.UseVisualStyleBackColor = true;
            // 
            // zuzycieCpu
            // 
            this.zuzycieCpu.AutoSize = true;
            this.zuzycieCpu.Location = new System.Drawing.Point(7, 44);
            this.zuzycieCpu.Name = "zuzycieCpu";
            this.zuzycieCpu.Size = new System.Drawing.Size(88, 17);
            this.zuzycieCpu.TabIndex = 1;
            this.zuzycieCpu.Text = "Zużycie CPU";
            this.zuzycieCpu.UseVisualStyleBackColor = true;
            // 
            // dostepnyRAM
            // 
            this.dostepnyRAM.AutoSize = true;
            this.dostepnyRAM.Location = new System.Drawing.Point(7, 20);
            this.dostepnyRAM.Name = "dostepnyRAM";
            this.dostepnyRAM.Size = new System.Drawing.Size(98, 17);
            this.dostepnyRAM.TabIndex = 0;
            this.dostepnyRAM.Text = "Dostępny RAM";
            this.dostepnyRAM.UseVisualStyleBackColor = true;
            // 
            // tekstDostepnyRam
            // 
            this.tekstDostepnyRam.AutoSize = true;
            this.tekstDostepnyRam.Location = new System.Drawing.Point(13, 115);
            this.tekstDostepnyRam.Name = "tekstDostepnyRam";
            this.tekstDostepnyRam.Size = new System.Drawing.Size(79, 13);
            this.tekstDostepnyRam.TabIndex = 1;
            this.tekstDostepnyRam.Text = "Dostępny RAM";
            // 
            // pasekZuzycieRamu
            // 
            this.pasekZuzycieRamu.Location = new System.Drawing.Point(13, 132);
            this.pasekZuzycieRamu.Maximum = 8192;
            this.pasekZuzycieRamu.Name = "pasekZuzycieRamu";
            this.pasekZuzycieRamu.Size = new System.Drawing.Size(395, 29);
            this.pasekZuzycieRamu.TabIndex = 2;
            // 
            // pasekZuzyciaCpu
            // 
            this.pasekZuzyciaCpu.Location = new System.Drawing.Point(13, 181);
            this.pasekZuzyciaCpu.Name = "pasekZuzyciaCpu";
            this.pasekZuzyciaCpu.Size = new System.Drawing.Size(395, 29);
            this.pasekZuzyciaCpu.TabIndex = 4;
            // 
            // tekstDostepnyCpu
            // 
            this.tekstDostepnyCpu.AutoSize = true;
            this.tekstDostepnyCpu.Location = new System.Drawing.Point(13, 164);
            this.tekstDostepnyCpu.Name = "tekstDostepnyCpu";
            this.tekstDostepnyCpu.Size = new System.Drawing.Size(69, 13);
            this.tekstDostepnyCpu.TabIndex = 3;
            this.tekstDostepnyCpu.Text = "Zużycie CPU";
            // 
            // pasekZuzyciaProces
            // 
            this.pasekZuzyciaProces.Location = new System.Drawing.Point(13, 231);
            this.pasekZuzyciaProces.Maximum = 8192;
            this.pasekZuzyciaProces.Name = "pasekZuzyciaProces";
            this.pasekZuzyciaProces.Size = new System.Drawing.Size(395, 29);
            this.pasekZuzyciaProces.TabIndex = 6;
            // 
            // tekstZuzycieProces
            // 
            this.tekstZuzycieProces.AutoSize = true;
            this.tekstZuzycieProces.Location = new System.Drawing.Point(13, 214);
            this.tekstZuzycieProces.Name = "tekstZuzycieProces";
            this.tekstZuzycieProces.Size = new System.Drawing.Size(186, 13);
            this.tekstZuzycieProces.TabIndex = 5;
            this.tekstZuzycieProces.Text = "Zużycie pamięci przez proces serwera";
            // 
            // zarzadzajSerweremGrupa
            // 
            this.zarzadzajSerweremGrupa.Controls.Add(this.pobierzStalaCzasowa);
            this.zarzadzajSerweremGrupa.Controls.Add(this.label4);
            this.zarzadzajSerweremGrupa.Controls.Add(this.zmienStalaCzasowa);
            this.zarzadzajSerweremGrupa.Controls.Add(this.interwal);
            this.zarzadzajSerweremGrupa.Controls.Add(this.wylacz);
            this.zarzadzajSerweremGrupa.Controls.Add(this.wlacz);
            this.zarzadzajSerweremGrupa.Controls.Add(this.pobierzObecniePublikowaneTematy);
            this.zarzadzajSerweremGrupa.Controls.Add(this.tematy);
            this.zarzadzajSerweremGrupa.Enabled = false;
            this.zarzadzajSerweremGrupa.Location = new System.Drawing.Point(430, 12);
            this.zarzadzajSerweremGrupa.Name = "zarzadzajSerweremGrupa";
            this.zarzadzajSerweremGrupa.Size = new System.Drawing.Size(511, 248);
            this.zarzadzajSerweremGrupa.TabIndex = 7;
            this.zarzadzajSerweremGrupa.TabStop = false;
            this.zarzadzajSerweremGrupa.Text = "Zarządzaj serwerem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Zmień stałą czasową";
            // 
            // zmienStalaCzasowa
            // 
            this.zmienStalaCzasowa.Location = new System.Drawing.Point(299, 164);
            this.zmienStalaCzasowa.Name = "zmienStalaCzasowa";
            this.zmienStalaCzasowa.Size = new System.Drawing.Size(206, 20);
            this.zmienStalaCzasowa.TabIndex = 5;
            this.zmienStalaCzasowa.Text = "Zmień stałą czasową";
            this.zmienStalaCzasowa.UseVisualStyleBackColor = true;
            this.zmienStalaCzasowa.Click += new System.EventHandler(this.zmienStalaCzasowa_Click);
            // 
            // interwal
            // 
            this.interwal.Location = new System.Drawing.Point(121, 164);
            this.interwal.Name = "interwal";
            this.interwal.Size = new System.Drawing.Size(172, 20);
            this.interwal.TabIndex = 4;
            // 
            // wylacz
            // 
            this.wylacz.Location = new System.Drawing.Point(287, 121);
            this.wylacz.Name = "wylacz";
            this.wylacz.Size = new System.Drawing.Size(218, 23);
            this.wylacz.TabIndex = 3;
            this.wylacz.Text = "Wyłącz";
            this.wylacz.UseVisualStyleBackColor = true;
            this.wylacz.Click += new System.EventHandler(this.wylacz_Click);
            // 
            // wlacz
            // 
            this.wlacz.Location = new System.Drawing.Point(7, 121);
            this.wlacz.Name = "wlacz";
            this.wlacz.Size = new System.Drawing.Size(218, 23);
            this.wlacz.TabIndex = 2;
            this.wlacz.Text = "Włącz";
            this.wlacz.UseVisualStyleBackColor = true;
            this.wlacz.Click += new System.EventHandler(this.wlacz_Click);
            // 
            // pobierzObecniePublikowaneTematy
            // 
            this.pobierzObecniePublikowaneTematy.Location = new System.Drawing.Point(6, 219);
            this.pobierzObecniePublikowaneTematy.Name = "pobierzObecniePublikowaneTematy";
            this.pobierzObecniePublikowaneTematy.Size = new System.Drawing.Size(498, 23);
            this.pobierzObecniePublikowaneTematy.TabIndex = 1;
            this.pobierzObecniePublikowaneTematy.Text = "Pobierz obecnie publikowane tematy";
            this.pobierzObecniePublikowaneTematy.UseVisualStyleBackColor = true;
            this.pobierzObecniePublikowaneTematy.Click += new System.EventHandler(this.pobierzObecniePublikowaneTematy_Click);
            // 
            // tematy
            // 
            this.tematy.FormattingEnabled = true;
            this.tematy.Location = new System.Drawing.Point(7, 20);
            this.tematy.Name = "tematy";
            this.tematy.Size = new System.Drawing.Size(498, 95);
            this.tematy.TabIndex = 0;
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Location = new System.Drawing.Point(270, 75);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(154, 23);
            this.start.TabIndex = 8;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Location = new System.Drawing.Point(270, 104);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(154, 23);
            this.stop.TabIndex = 9;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // poleNaIp
            // 
            this.poleNaIp.Location = new System.Drawing.Point(271, 13);
            this.poleNaIp.Name = "poleNaIp";
            this.poleNaIp.Size = new System.Drawing.Size(153, 20);
            this.poleNaIp.TabIndex = 10;
            // 
            // polacz
            // 
            this.polacz.Location = new System.Drawing.Point(271, 40);
            this.polacz.Name = "polacz";
            this.polacz.Size = new System.Drawing.Size(153, 23);
            this.polacz.TabIndex = 11;
            this.polacz.Text = "Połącz";
            this.polacz.UseVisualStyleBackColor = true;
            this.polacz.Click += new System.EventHandler(this.polacz_Click);
            // 
            // pobierzStalaCzasowa
            // 
            this.pobierzStalaCzasowa.Location = new System.Drawing.Point(6, 190);
            this.pobierzStalaCzasowa.Name = "pobierzStalaCzasowa";
            this.pobierzStalaCzasowa.Size = new System.Drawing.Size(498, 23);
            this.pobierzStalaCzasowa.TabIndex = 7;
            this.pobierzStalaCzasowa.Text = "Pobierz stałą czasową";
            this.pobierzStalaCzasowa.UseVisualStyleBackColor = true;
            this.pobierzStalaCzasowa.Click += new System.EventHandler(this.pobierzStalaCzasowa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 279);
            this.Controls.Add(this.polacz);
            this.Controls.Add(this.poleNaIp);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.zarzadzajSerweremGrupa);
            this.Controls.Add(this.pasekZuzyciaProces);
            this.Controls.Add(this.tekstZuzycieProces);
            this.Controls.Add(this.pasekZuzyciaCpu);
            this.Controls.Add(this.tekstDostepnyCpu);
            this.Controls.Add(this.pasekZuzycieRamu);
            this.Controls.Add(this.tekstDostepnyRam);
            this.Controls.Add(this.subskrybujGrupa);
            this.Name = "Form1";
            this.Text = "Klient";
            this.subskrybujGrupa.ResumeLayout(false);
            this.subskrybujGrupa.PerformLayout();
            this.zarzadzajSerweremGrupa.ResumeLayout(false);
            this.zarzadzajSerweremGrupa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox subskrybujGrupa;
        private System.Windows.Forms.CheckBox zuzycieProces;
        private System.Windows.Forms.CheckBox zuzycieCpu;
        private System.Windows.Forms.CheckBox dostepnyRAM;
        private System.Windows.Forms.Label tekstDostepnyRam;
        private System.Windows.Forms.ProgressBar pasekZuzycieRamu;
        private System.Windows.Forms.ProgressBar pasekZuzyciaCpu;
        private System.Windows.Forms.Label tekstDostepnyCpu;
        private System.Windows.Forms.ProgressBar pasekZuzyciaProces;
        private System.Windows.Forms.Label tekstZuzycieProces;
        private System.Windows.Forms.GroupBox zarzadzajSerweremGrupa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button zmienStalaCzasowa;
        private System.Windows.Forms.TextBox interwal;
        private System.Windows.Forms.Button wylacz;
        private System.Windows.Forms.Button wlacz;
        private System.Windows.Forms.Button pobierzObecniePublikowaneTematy;
        private System.Windows.Forms.ListBox tematy;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox poleNaIp;
        private System.Windows.Forms.Button polacz;
        private System.Windows.Forms.Button pobierzStalaCzasowa;
    }
}

