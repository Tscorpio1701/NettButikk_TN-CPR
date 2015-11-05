using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NettButikk_Oppg2.DAL;
using NettButikk_Oppg2.Model;

namespace NettButikk_Oppg2.DAL
{
    public class KundeDALStub : IKundeDAL
    {
        public bool endreKunde(int id, Kunde innKunde)
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

        public List<Kunde> hentAlle()
        {
            var kundeListe = new List<Kunde>();
            var kunde = new Kunde()
            {
                ID = 1,
                Fornavn = "Per",
                Etternavn = "Olsen",
                Adresse = "Osloveien 82"

            };
            kundeListe.Add(kunde);
            kundeListe.Add(kunde);
            kundeListe.Add(kunde);
            return kundeListe;
        }

        public Kunde hentEnKunde(int id)
        {
            if (id == 0)
            {
                var kunde = new Kunde();
                kunde.ID = 0;
                return kunde;
            }
            else
            {
                var kunde = new Kunde()
                {
                    ID = 1,
                    Fornavn = "Per",
                    Etternavn = "Olsen",
                    Adresse = "Osloveien 82"
                    
                };
                return kunde;
            }

        }

        public bool settInn(Kunde innKunde)
        {
            if (innKunde.Fornavn == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool slettKunde(int id)
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
    }
}
