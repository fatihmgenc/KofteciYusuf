using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KöfteciYusuf
{
    class SingeltonService
    {
        private static SingeltonService servisOgesi = null;

        private SingeltonService()
        {

        }

        public static SingeltonService getServisOgesi()
        {
            if (servisOgesi == null)
            {
                servisOgesi = new SingeltonService();
                return servisOgesi;
            }
            else
            {
                return servisOgesi;
            }

        }

        public ServiceReference1.Service1Client Server = new ServiceReference1.Service1Client();

    }
}
