using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using NettButikk_Oppg2.Model;

namespace NettButikk_Oppg2.DAL
{
    public class BestillingDAL : IBestillingDAL
    {
        public List<Bestilling> hentAlleBestillinger()
        {
            var db = new ButikkContext();
            List<Bestilling> alleBestillinger = db.Bestillinger.ToList();
            return alleBestillinger;
        }

        public bool leggTilBestilling(int id)
        {
            using (var context = new ButikkContext())
            {
                VareDAL vare = new VareDAL();
                Vare nyvare = vare.hentEnVare(id);
                var bestilling = new Bestilling()
                {
                    OrdreDato = System.DateTime.Now,
                    Total = nyvare.Pris,
                    Vare = nyvare
                };
                context.Bestillinger.Add(bestilling);
                var saved = context.SaveChanges();
                return saved >= 1;
            }
        }


        public bool settVare(int id, Vare vare)
        {
            Bestilling bestilling = hentEnBestilling(id);
            bestilling.Vare = vare;
            if (bestilling.Vare == null) return false;
            return true;
        }

        public bool endreBestilling(int id, Bestilling bestilling)
        {
            var db = new ButikkContext();

            try
            {
                Bestilling endreBestilling = db.Bestillinger.Find(id);
                endreBestilling.OrdreDato = bestilling.OrdreDato;
                endreBestilling.Total = bestilling.Total;
                endreBestilling.Vare = bestilling.Vare;

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool slettBestilling(int slettID)
        {
            var db = new ButikkContext();

            try
            {
                Bestilling bestilling = db.Bestillinger.Find(slettID);
                db.Bestillinger.Remove(bestilling);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Bestilling hentEnBestilling(int id)
        {
            var db = new ButikkContext();
            var enDbBestilling = db.Bestillinger.Find(id);

            if (enDbBestilling == null)
            {
                return null;
            }
            else
            {
                var utBestilling = new Bestilling()
                {
                    OrdreDato = enDbBestilling.OrdreDato,
                    Total = enDbBestilling.Total,
                    Vare = enDbBestilling.Vare
                };
                return utBestilling;
            }

        }

    }
}
