using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NettButikk_Oppg2.DAL;
using NettButikk_Oppg2.Model;

namespace DAL
{
    public class VareDALStub : IVareDAL
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
                

            };
            vareListe.Add(vare);
            vareListe.Add(vare);
            vareListe.Add(vare);
            return vareListe;
        }

        public Vare hentEnVare(int id)
        {
            throw new NotImplementedException();
        }

        public bool leggTilVare(Vare innVare)
        {
            throw new NotImplementedException();
        }

        public bool slettVare(int slettId)
        {
            throw new NotImplementedException();
        }
    }
}
