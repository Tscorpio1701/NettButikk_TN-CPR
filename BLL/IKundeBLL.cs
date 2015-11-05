using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NettButikk_Oppg2.Model;
using NettButikk_Oppg2.BLL;

namespace BLL
{
    public interface IKundeBLL
    {
        bool endreKunde(int id, Kunde innKunde);
        List<Kunde> hentAlle();
        Kunde hentEnKunde(int id);
        bool leggTilKunde(Kunde innKunde);
        bool slettKunde(int id);
    }
}
