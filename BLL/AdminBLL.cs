using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NettButikk_Oppg2.DAL;
using NettButikk_Oppg2.Model;

namespace NettButikk_Oppg2.BLL
{
    public class AdminBLL
    {

        public bool adminsjekk(Admin admin)
        {
            var bll = new AdminDal();
            return bll.Adminsjekk(admin);
        }
        public List<Admin> HentAlleAdmins()
        {
            var AdminDAL = new AdminDal();
            List<Admin> alleAdmin = AdminDAL.HentAdmins();
            return alleAdmin;
        }

        public bool leggTilAdmin(Admin innAdmin)
        {
            var AdminDAL = new AdminDal();
            return AdminDAL.leggTilAdmin(innAdmin);
        }

        public bool endreAdmin(int id, Admin admin)
        {
            var AdminDAL = new AdminDal();
            return AdminDAL.endreAdmin(id, admin);
        }

        public bool slettAdmin(int slettId)
        {
            var AdminDAL = new AdminDal();
            return AdminDAL.slettAdmin(slettId);
        }

        public Admin hentEnAdmin(int id)
        {
            var AdminDAL = new AdminDal();
            return AdminDAL.hentEnAdmin(id);
        }
    }
}
