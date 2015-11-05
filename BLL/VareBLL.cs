using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NettButikk_Oppg2.DAL;
using NettButikk_Oppg2.Model;

namespace NettButikk_Oppg2.BLL
{
    public class VareBLL
    {
        public List<Vare> HentAlleVarer()
        {
            var VareDal = new VareDAL();
            List<Vare> alleVarer = VareDal.HentAlleVarer();
            return alleVarer;
        }

        public bool leggTilVare(Vare innVare)
        {
            var VareDal = new VareDAL();
            return VareDal.leggTilVare(innVare);
        }

        public bool endreVare(int id, Vare innVare)
        {
            var VareDAL = new VareDAL();
            return VareDAL.endreVare(id, innVare);
        }

        public bool slettVare(int slettId)
        {
            var VareDAL = new VareDAL();
            return VareDAL.slettVare(slettId);
        }

        public Vare hentEnVare(int id)
        {
            var VareDAL = new VareDAL();
            return VareDAL.hentEnVare(id);
        }
    }
}
