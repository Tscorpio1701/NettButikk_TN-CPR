using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NettButikk_Oppg2.DAL;
using NettButikk_Oppg2.Model;

namespace DAL
{
    public interface IVareDAL
    {
        List<Vare> HentAlleVarer();
        bool leggTilVare(Vare innVare);
        bool endreVare(int id, Vare vare);
        bool slettVare(int slettId);
        Vare hentEnVare(int id);


    }
}
