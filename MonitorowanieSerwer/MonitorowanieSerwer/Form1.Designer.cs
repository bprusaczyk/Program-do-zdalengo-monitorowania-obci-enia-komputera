namespace MonitorowanieSerwer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zuzycieRamu = new System.Windows.Forms.CheckBox();
            this.zuzycieCpu = new System.Windows.Forms.CheckBox();
            this.zuzycieProces = new System.Windows.Forms.CheckBox();
            this.tekstZuzycieRamu = new System.Windows.Forms.Label();
            this.pasekZuzyciaRamu = new System.Windows.Forms.ProgressBar();
            this.pasekZuzyciaCpu = new System.Windows.Forms.ProgressBar();
            this.tekstZuzycieCpu = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.startPrzycisk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zuzycieProces);
            this.groupBox1.Controls.Add(this.zuzycieCpu);
            this.groupBox1.Controls.Add(this.zuzycieRamu);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publikuj";
            // 
            // zuzycieRamu
            // 
            this.zuzycieRamu.AutoSize = true;
            this.zuzycieRamu.Location = new System.Drawing.Point(7, 20);
            this.zuzycieRamu.Name = "zuzycieRamu";
            this.zuzycieRamu.Size = new System.Drawing.Size(97, 17);
            this.zuzycieRamu.TabIndex = 0;
            this.zuzycieRamu.Text = "zużycie RAM-u";
            this.zuzycieRamu.UseVisualStyleBackColor = true;
            // 
            // zuzycieCpu
            // 
            this.zuzycieCpu.AutoSize = true;
            this.zuzycieCpu.Location = new System.Drawing.Point(7, 44);
            this.zuzycieCpu.Name = "zuzycieCpu";
            this.zuzycieCpu.Size = new System.Drawing.Size(86, 17);
            this.zuzycieCpu.TabIndex = 1;
            this.zuzycieCpu.Text = "zużycie CPU";
            this.zuzycieCpu.UseVisualStyleBackColor = true;
            // 
            // zuzycieProces
            // 
            this.zuzycieProces.AutoSize = true;
            this.zuzycieProces.Location = new System.Drawing.Point(7, 68);
            this.zuzycieProces.Name = "zuzycieProces";
            this.zuzycieProces.Size = new System.Drawing.Size(163, 17);
            this.zuzycieProces.TabIndex = 2;
            this.zuzycieProces.Text = "zużycie pamięci przez proces";
            this.zuzycieProces.UseVisualStyleBackColor = true;
            // 
            // tekstZuzycieRamu
            // 
            this.tekstZuzycieRamu.AutoSize = true;
            this.tekstZuzycieRamu.Location = new System.Drawing.Point(196, 17);
            this.tekstZuzycieRamu.Name = "tekstZuzycieRamu";
            this.tekstZuzycieRamu.Size = new System.Drawing.Size(78, 13);
            this.tekstZuzycieRamu.TabIndex = 1;
            this.tekstZuzycieRamu.Text = "zużycie RAM-u";
            // 
            // pasekZuzyciaRamu
            // 
            this.pasekZuzyciaRamu.Location = new System.Drawing.Point(199, 33);
            this.pasekZuzyciaRamu.Maximum = 8192;
            this.pasekZuzyciaRamu.Name = "pasekZuzyciaRamu";
            this.pasekZuzyciaRamu.Size = new System.Drawing.Size(401, 23);
            this.pasekZuzyciaRamu.TabIndex = 2;
            // 
            // pasekZuzyciaCpu
            // 
            this.pasekZuzyciaCpu.Location = new System.Drawing.Point(199, 79);
            this.pasekZuzyciaCpu.Name = "pasekZuzyciaCpu";
            this.pasekZuzyciaCpu.Size = new System.Drawing.Size(401, 23);
            this.pasekZuzyciaCpu.TabIndex = 4;
            // 
            // tekstZuzycieCpu
            // 
            this.tekstZuzycieCpu.AutoSize = true;
            this.tekstZuzycieCpu.Location = new System.Drawing.Point(196, 63);
            this.tekstZuzycieCpu.Name = "tekstZuzycieCpu";
            this.tekstZuzycieCpu.Size = new System.Drawing.Size(67, 13);
            this.tekstZuzycieCpu.TabIndex = 3;
            this.tekstZuzycieCpu.Text = "zużycie CPU";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(199, 125);
            this.progressBar3.Maximum = 8192;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(401, 23);
            this.progressBar3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "zużycie pamięci przez proces";
            // 
            // startPrzycisk
            // 
            this.startPrzycisk.Location = new System.Drawing.Point(13, 155);
            this.startPrzycisk.Name = "startPrzycisk";
            this.startPrzycisk.Size = new System.Drawing.Size(591, 65);
            this.startPrzycisk.TabIndex = 7;
            this.startPrzycisk.Text = "START";
            this.startPrzycisk.UseVisualStyleBackColor = true;
            this.startPrzycisk.Click += new System.EventHandler(this.startPrzycisk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 235);
            this.Controls.Add(this.startPrzycisk);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pasekZuzyciaCpu);
            this.Controls.Add(this.tekstZuzycieCpu);
            this.Controls.Add(this.pasekZuzyciaRamu);
            this.Controls.Add(this.tekstZuzycieRamu);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Serwer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox zuzycieProces;
        private System.Windows.Forms.CheckBox zuzycieCpu;
        private System.Windows.Forms.CheckBox zuzycieRamu;
        private System.Windows.Forms.Label tekstZuzycieRamu;
        private System.Windows.Forms.ProgressBar pasekZuzyciaRamu;
        private System.Windows.Forms.ProgressBar pasekZuzyciaCpu;
        private System.Windows.Forms.Label tekstZuzycieCpu;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startPrzycisk;
    }
}

