using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace NettButikk_Oppg2.Model
{
    public class Bestilling
    {
        [Key]
        public int BestillingID { get; set; }

        public System.DateTime OrdreDato { get; set; }

        public int Total { get; set; }

        public virtual Vare Vare { get; set; }
        
    }
}