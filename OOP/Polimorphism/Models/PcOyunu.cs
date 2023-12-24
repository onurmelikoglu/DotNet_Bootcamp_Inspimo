using Polimorphism.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism.Models
{
    public class PcOyunu : VideoOyunu
    {
        public string[] IsletimSistemleri { get; set; }
        public bool SteamOyunuMu { get; set; }
        public string IsletimSistemleriGosterim => string.Join(", ", IsletimSistemleri);
        public string SteamOyunuMuGosterim => SteamOyunuMu ? "Evet" : "Hayır";
    }
}
