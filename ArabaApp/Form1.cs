using ArabaApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaApp
{
    public partial class Form1 : Form
    {
        Arabalar Araba;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Araba = new Arabalar()
            {
                Id = 1,
                Marka = tbMarka.Text,
                Model = tbModel.Text,
                ArabaTuru = (ArabaTuru)ddlArabaTuru.SelectedIndex,
                KapiSayisi = (KapiSayisi)ddlKapiSayisi.SelectedIndex,
                BeygirGücü = Convert.ToInt32(nudBeygirGücü.Value),
                MaxHiz = Convert.ToDouble(tbMaxHiz.Text),
                Cekis = (Cekis)ddlCekis.SelectedIndex,
                Hizlanma = Convert.ToInt32(tbHizlanma.Text),
                Agirlik = Convert.ToDouble(tbAgirlik.Text),
                MotorHacmi = Convert.ToDouble(tbMotorHacmi.Text)
            };
            MessageBox.Show("Araba oluşturuldu");
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            string result = "";
            result +="Id =" +Araba.Id + "\n";
            result += "Marka =" + Araba.Marka + "\n";
            result += "Model =" + Araba.Model + "\n";
            result += "Araba Türü =" + Araba.ArabaTuru + "\n";
            result += "KapıSayısı =" + Araba.KapiSayisi + "\n";
            result += "Beygir Gücü =" + Araba.BeygirGücü + "\n";
            result += "Max Hız =" + Araba.MaxHiz + "\n";
            result += "Çekiş =" + Araba.Cekis + "\n";
            result += "Hızlanma =" + Araba.Hizlanma + "\n";
            result += "Ağırlık =" + Araba.Agirlik + "\n";
            result += "Motor Hacmi =" + Araba.MotorHacmi;
            MessageBox.Show(result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ddlArabaTuru.SelectedIndex = 0;
            ddlCekis.SelectedIndex = 0;
            ddlKapiSayisi.SelectedIndex = 0;
        }
    }
}
