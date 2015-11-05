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
    public class BestillingBLL : IBestillingBLL
    {
        private IBestillingDAL bestilling;

        public BestillingBLL(IBestillingDAL bestillingdal)
        {
            bestilling = bestillingdal;
        }

        public BestillingBLL()
        {
            bestilling = new BestillingDAL();
        }
        public List<Bestilling> hentAlleBestillinger()
        {
            var BestillingDAL = new DAL.BestillingDAL();
            List<Bestilling> allebestillinger = BestillingDAL.hentAlleBestillinger();
            return allebestillinger;
        }

        public bool leggTilBestilling(int id)
        {
            var BestillingDAL = new DAL.BestillingDAL();
            return BestillingDAL.leggTilBestilling(id);
        }

        public bool endreBestilling(int id, Bestilling innBestilling)
        {
            var BestillingDAL = new DAL.BestillingDAL();
            return BestillingDAL.endreBestilling(id, innBestilling);
        }

        public bool slettBestilling(int slettId)
        {
            var BestillingDAL = new DAL.BestillingDAL();
            return BestillingDAL.slettBestilling(slettId);
        }

        public Bestilling hentEnBestilling(int id)
        {
            var BestillingDAL = new DAL.BestillingDAL();
            return BestillingDAL.hentEnBestilling(id);
        }
    }
    
}
