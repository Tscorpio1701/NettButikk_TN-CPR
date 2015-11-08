using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NettButikk_Oppg2.DAL;
using NettButikk_Oppg2.Model;


namespace NettButikk_Oppg2.DAL
{
    public class VareDALStub : DAL.IVareDAL
    {
        public bool endreVare(int id, Vare vare)
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

        public List<Vare> HentAlleVarer()
        {
            var vareListe = new List<Vare>();
            var vare = new Vare()
            {
                ID = 1,
                Varenavn = "eple",
                Pris = 5,
                Varebeholdning = 77
                

            };
            vareListe.Add(vare);
            vareListe.Add(vare);
            vareListe.Add(vare);
            return vareListe;
        }

        public Vare hentEnVare(int id)
        {
            if (id == 0)
            {
                var vare = new Vare();
                vare.ID = 0;
                return vare;
            }
            else
            {
                var vare = new Vare()
                {
                    ID = 1,
                    Pris = 5,
                    Varebeholdning = 77
                };
                return vare;
            }
        }

        public bool leggTilVare(Vare innVare)
        {
            if(innVare.Varenavn == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool slettVare(int slettId)
        {
            if(slettId == 0)
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
