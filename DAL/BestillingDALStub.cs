using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NettButikk_Oppg2.DAL;
using NettButikk_Oppg2.Model;

namespace NettButikk_Oppg2.DAL
{
    public class BestillingDALStub : IBestillingDAL
    {
        public bool endreBestilling(int id, Bestilling bestilling)
        {
            if (id == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Bestilling> hentAlleBestillinger()
        {
            var bestillingListe = new List<Bestilling>();
            var bestilling = new Bestilling()
            {
                BestillingID = 1,
                Total = 23,
                OrdreDato = DateTime.Now,
                Vare = new Vare() { Varenavn = "Eple", Pris = 12, Varebeholdning = 77}
            };
            bestillingListe.Add(bestilling);
            bestillingListe.Add(bestilling);
            bestillingListe.Add(bestilling);
            return bestillingListe;
        }

        public Bestilling hentEnBestilling(int id)
        {
            if(id == 0)
            {
                var bestilling = new Bestilling();
                bestilling.BestillingID = 0;
                return bestilling;
            }
            else
            {
                var bestilling = new Bestilling()
                {
                    BestillingID = 1,
                    Total = 23,
                    OrdreDato = DateTime.Now,
                    Vare = new Vare() { Varenavn = "Eple", Pris = 12, Varebeholdning = 77 }
                };
                return bestilling;
            }
            
        }

        public bool leggTilBestilling(int id)
        {
            if(id == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool settVare(int id, Vare vare)
        {
            if(vare.Varenavn == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool slettBestilling(int slettID)
        {
            if (slettID == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
