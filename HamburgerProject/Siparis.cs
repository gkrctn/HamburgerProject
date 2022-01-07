using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HamburgerProject
{
    public class Siparis
    {
  
     
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }
        public Boyut Boyutu { get; set; }

        public List<Extra> ExtraMalzemesi { get; set; }

        public Menu SeciliMenusu { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenusu.Fiyati;

            switch (Boyutu)
            {
                
                case Boyut.Orta: ToplamTutar += ToplamTutar * 4;
                    break;
                case Boyut.Buyuk: ToplamTutar += ToplamTutar * 6;
                    break;
                default:
                    break;
            }
            foreach (var extra in ExtraMalzemesi)

                ToplamTutar += extra.Fiyati;

            ToplamTutar = ToplamTutar * Adet;
        }
        public override string ToString()
        {
            if (ExtraMalzemesi.Count<1)
            {
                return string.Format("{0} Menu,x{1} Adet, {2} Boy, Toplam :{3}", SeciliMenusu.MenuAdi, Adet, Boyutu.ToString(), ToplamTutar.ToString("C2"));
            }
            else
            {
                string exMalzemeler = null;
                foreach (Extra item in ExtraMalzemesi)
                    exMalzemeler += item.ExtraAdi + ",";
                exMalzemeler = exMalzemeler.Trim(',');

                return string.Format("{0} Menu, x{1} Adet, {2} Boy, ({3}) Toplam : {4}", SeciliMenusu.MenuAdi, Adet, Boyutu.ToString(), exMalzemeler, ToplamTutar.ToString("C2"));
            }
        }





    }



}
