namespace ArabaApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.ddlKapiSayisi = new System.Windows.Forms.ComboBox();
            this.nudBeygirGücü = new System.Windows.Forms.NumericUpDown();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.tbMaxHiz = new System.Windows.Forms.TextBox();
            this.tbHizlanma = new System.Windows.Forms.TextBox();
            this.tbAgirlik = new System.Windows.Forms.TextBox();
            this.tbMotorHacmi = new System.Windows.Forms.TextBox();
            this.ddlCekis = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ddlArabaTuru = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeygirGücü)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kapı Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Beygir Gücü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(313, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Max Hız (km/s)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(313, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Çekiş";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(313, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ağırlık (kg)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(313, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Hızlanma (sn)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(313, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Motor Hacmi (cm ³ )";
            // 
            // tbMarka
            // 
            this.tbMarka.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMarka.Location = new System.Drawing.Point(138, 32);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(138, 26);
            this.tbMarka.TabIndex = 0;
            // 
            // tbModel
            // 
            this.tbModel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbModel.Location = new System.Drawing.Point(138, 64);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(138, 26);
            this.tbModel.TabIndex = 1;
            // 
            // ddlKapiSayisi
            // 
            this.ddlKapiSayisi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ddlKapiSayisi.FormattingEnabled = true;
            this.ddlKapiSayisi.Items.AddRange(new object[] {
            "İki Kapılı",
            "Dört Kapılı",
            "Bes Kapılı"});
            this.ddlKapiSayisi.Location = new System.Drawing.Point(136, 142);
            this.ddlKapiSayisi.Name = "ddlKapiSayisi";
            this.ddlKapiSayisi.Size = new System.Drawing.Size(140, 26);
            this.ddlKapiSayisi.TabIndex = 3;
            // 
            // nudBeygirGücü
            // 
            this.nudBeygirGücü.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudBeygirGücü.Location = new System.Drawing.Point(138, 195);
            this.nudBeygirGücü.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudBeygirGücü.Name = "nudBeygirGücü";
            this.nudBeygirGücü.Size = new System.Drawing.Size(140, 26);
            this.nudBeygirGücü.TabIndex = 4;
            this.nudBeygirGücü.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkOrange;
            this.btnKaydet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(116, 262);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(160, 33);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGoster.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoster.Location = new System.Drawing.Point(406, 262);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(169, 33);
            this.btnGoster.TabIndex = 11;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // tbMaxHiz
            // 
            this.tbMaxHiz.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMaxHiz.Location = new System.Drawing.Point(454, 35);
            this.tbMaxHiz.Name = "tbMaxHiz";
            this.tbMaxHiz.Size = new System.Drawing.Size(120, 26);
            this.tbMaxHiz.TabIndex = 5;
            // 
            // tbHizlanma
            // 
            this.tbHizlanma.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbHizlanma.Location = new System.Drawing.Point(454, 107);
            this.tbHizlanma.Name = "tbHizlanma";
            this.tbHizlanma.Size = new System.Drawing.Size(120, 26);
            this.tbHizlanma.TabIndex = 7;
            // 
            // tbAgirlik
            // 
            this.tbAgirlik.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAgirlik.Location = new System.Drawing.Point(454, 145);
            this.tbAgirlik.Name = "tbAgirlik";
            this.tbAgirlik.Size = new System.Drawing.Size(120, 26);
            this.tbAgirlik.TabIndex = 8;
            // 
            // tbMotorHacmi
            // 
            this.tbMotorHacmi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMotorHacmi.Location = new System.Drawing.Point(454, 194);
            this.tbMotorHacmi.Name = "tbMotorHacmi";
            this.tbMotorHacmi.Size = new System.Drawing.Size(120, 26);
            this.tbMotorHacmi.TabIndex = 9;
            // 
            // ddlCekis
            // 
            this.ddlCekis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ddlCekis.FormattingEnabled = true;
            this.ddlCekis.Items.AddRange(new object[] {
            "Önden Çekiş",
            "Arkadan İtiş",
            "Dört Çeker"});
            this.ddlCekis.Location = new System.Drawing.Point(454, 70);
            this.ddlCekis.Name = "ddlCekis";
            this.ddlCekis.Size = new System.Drawing.Size(121, 26);
            this.ddlCekis.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(32, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "Araba Türü";
            // 
            // ddlArabaTuru
            // 
            this.ddlArabaTuru.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ddlArabaTuru.FormattingEnabled = true;
            this.ddlArabaTuru.Items.AddRange(new object[] {
            "Motosiklet",
            "Otomobil",
            "Otobüs",
            "Kamyonet",
            "Kamyon",
            "Tır"});
            this.ddlArabaTuru.Location = new System.Drawing.Point(136, 104);
            this.ddlArabaTuru.Name = "ddlArabaTuru";
            this.ddlArabaTuru.Size = new System.Drawing.Size(140, 26);
            this.ddlArabaTuru.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ddlArabaTuru);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ddlCekis);
            this.Controls.Add(this.tbMotorHacmi);
            this.Controls.Add(this.tbAgirlik);
            this.Controls.Add(this.tbHizlanma);
            this.Controls.Add(this.tbMaxHiz);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.nudBeygirGücü);
            this.Controls.Add(this.ddlKapiSayisi);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ArabaApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBeygirGücü)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.ComboBox ddlKapiSayisi;
        private System.Windows.Forms.NumericUpDown nudBeygirGücü;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.TextBox tbMaxHiz;
        private System.Windows.Forms.TextBox tbHizlanma;
        private System.Windows.Forms.TextBox tbAgirlik;
        private System.Windows.Forms.TextBox tbMotorHacmi;
        private System.Windows.Forms.ComboBox ddlCekis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ddlArabaTuru;
    }
}

