using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NettButikk_Oppg2.Model;

namespace BLL
{
    public interface IBestillingBLL
    {
        List<Bestilling> hentAlleBestillinger();
        bool leggTilBestilling(int id);
        bool endreBestilling(int id, Bestilling innBestilling);
        bool slettBestilling(int slettId);
        Bestilling hentEnBestilling(int id);
    }
}
