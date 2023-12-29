using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo3.Models
{
    public class Organizasyon
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Duzenleyeni { get; set; }
        public DateTime BaslangicTarihiVeSaati { get; set; }
        public TimeSpan Suresi { get; set; }

        // BaslangicTarihiVeSaati ile Sure özellikleri üzerinden atanan readonly (sadece okunur) özellik
        // 1. yöntem:
        //public DateTime BitisTarihiVeSaati
        //{
        //    get
        //    {
        //        return BaslangicTarihiVeSaati.Add(Suresi);
        //    }
        //}
        // 2. yöntem:
        public DateTime BitisTarihiVeSaati => BaslangicTarihiVeSaati.Add(Suresi);
    }
}
