using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NettButikk_Oppg2.DAL;
using NettButikk_Oppg2.Model;

namespace NettButikk_Oppg2.DAL
{
    public interface IKundeDAL
    {
        bool endreKunde(int id, Kunde innKunde);
        List<Kunde> hentAlle();
        Kunde hentEnKunde(int id);
        bool settInn(Kunde innKunde);
        bool slettKunde(int id);
    }
}
