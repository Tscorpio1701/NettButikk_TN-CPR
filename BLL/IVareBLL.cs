using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NettButikk_Oppg2.Model;
using NettButikk_Oppg2.BLL;

namespace BLL
{
    public interface IVareBLL
    {
        bool endreVare(int id, Kunde innVare);
        List<Vare> hentAlleVarer();
        Vare hentEnVare(int id);
        bool leggTilVare(Kunde innVare);
        bool slettVare(int id);
    }
}
