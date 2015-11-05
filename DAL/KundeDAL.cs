using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NettButikk_Oppg2.Model;

namespace NettButikk_Oppg2.DAL
{
    public class KundeDAL : IKundeDAL
    {

   
        public List<Kunde> hentAlle()
        {
            var db = new ButikkContext();
            List<Kunde> alleKunder = db.Kunde.ToList();
            
            //List<Kunde> alleKunder = db.Kunde.ToList();
            return alleKunder;
        }

        public bool leggTilKunde(Kunde innKunde)
        {
            using (var context = new ButikkContext())
            {
                var kunde = new Kunde()
                {
                    Fornavn = innKunde.Fornavn,
                    Etternavn = innKunde.Etternavn,
                    Adresse = innKunde.Adresse,

                };
                context.Kunde.Add(kunde);
                var saved = context.SaveChanges();
                return saved >= 1;
            }
        }
        
        public bool endreKunde(int id, Kunde kunde)
        {
            var db = new ButikkContext();
            try
            {
                Kunde endreKunde = db.Kunde.Find(id);
                endreKunde.Fornavn = kunde.Fornavn;
                endreKunde.Etternavn = kunde.Etternavn;
                endreKunde.Adresse = kunde.Adresse;

                db.SaveChanges();
                return true;
            }       
            catch
            {
                return false;
            }
        }

        public bool slettKunde(int slettId)
        {
            var db = new ButikkContext();
            try
            {
                Kunde slettKunde = db.Kunde.Find(slettId);
                db.Kunde.Remove(slettKunde);
                db.SaveChanges();
                return true;
            }
            catch (Exception feil)
            {
                return false;
            }
        }

        public Kunde hentEnKunde(int id)
        {
            var db = new ButikkContext();

            var enDbKunde = db.Kunde.Find(id);

            if (enDbKunde == null)
            {
                return null;
            }
            else
            {
                var utKunde = new Kunde()
                {
                    Fornavn = enDbKunde.Fornavn,
                    Etternavn = enDbKunde.Etternavn,
                    Adresse = enDbKunde.Adresse,
                    
                };
                return utKunde;
            }
        }

        public bool settInn(Kunde innKunde)
        {
            throw new NotImplementedException();
        }
    }
}

