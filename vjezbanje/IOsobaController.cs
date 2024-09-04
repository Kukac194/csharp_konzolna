using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbanje
{
    internal interface IOsobaController
    {
        void kreirajOsobu();
        void dohvatiOsobu(int id);

        void azurirajOsobu(int id);
        void obrisiOsobu(int id);

        void dohvatiSveOsobe();
    }
}
