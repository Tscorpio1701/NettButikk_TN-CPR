using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NettButikk_Oppg2.DAL;
using NettButikk_Oppg2.Model;
using BLL;

namespace NettButikk_Oppg2.BLL
{
    public class VareBLL : IKundeBLL
    {

            private IKundeDAL dal;

            public VareBLL(IKundeDAL kunde)
            {
            dal = kunde;
            }

            public VareBLL()
            {
            dal = new KundeDAL();
            }
        
            public List<Kunde> hentAlle()
            {
                var KundeDAL = new KundeDAL();
                List<Kunde> alleKunder = KundeDAL.hentAlle();
                return alleKunder;
            }
            public bool leggTilKunde(Kunde innKunde)
            {
                var KundeDAL = new KundeDAL();
                return KundeDAL.leggTilKunde(innKunde);
            }
            public bool endreKunde(int id, Kunde innKunde)
            {
                var KundeDAL = new KundeDAL();
                return KundeDAL.endreKunde(id, innKunde);
            }
            public bool slettKunde(int slettId)
            {
                var KundeDAL = new KundeDAL();
                return KundeDAL.slettKunde(slettId);
            }
            public Kunde hentEnKunde(int id)
            {
                var KundeDAL = new KundeDAL();
                return KundeDAL.hentEnKunde(id);
            }

    }

    }

