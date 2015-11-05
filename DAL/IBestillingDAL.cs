using NettButikk_Oppg2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NettButikk_Oppg2.DAL
{
    public interface IBestillingDAL
    {
        List<Bestilling> hentAlleBestillinger();
        bool leggTilBestilling(int id);
        bool settVare(int id, Vare vare);
        bool endreBestilling(int id, Bestilling bestilling);
        bool slettBestilling(int slettID);
        Bestilling hentEnBestilling(int id);

    }
}
