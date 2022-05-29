using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaApp.Model
{
    public class Arabalar
    {
        public int Id { get; set; }

        public string Marka { get; set; }

        public string Model { get; set; }

        public int BeygirGücü { get; set; }

        public double MaxHiz { get; set; }

        public Cekis Cekis { get; set; }

        public int Hizlanma { get; set; }

        public double Agirlik { get; set; }

        public double MotorHacmi { get; set; }

        public ArabaTuru ArabaTuru { get; set; }

        public KapiSayisi KapiSayisi { get; set; }
    }
}
