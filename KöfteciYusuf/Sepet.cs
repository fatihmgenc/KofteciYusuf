using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KöfteciYusuf
{
    class Sepet
    {
        private static Sepet SepetOgesi = null;

        private Sepet()
        {

        }
        public static Sepet getSepetOgesi()
        {
            if (SepetOgesi == null)
            {
                SepetOgesi = new Sepet();
                return SepetOgesi;
            }
            else
            {
                return SepetOgesi;
            }

        }

        public List<string> SepettekiÜrünler = new List<string>();
        public List<string> SepettekiFiyatlar = new List<string>();
        public List<string> SepettekiPorsiyonlar= new List<string>();


    }
}
