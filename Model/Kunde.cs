﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations.Schema;

namespace NettButikk_Oppg2.Model
{    
    public class Kunde
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Fornavn må oppgis!")]
        public string Fornavn { get; set; }

        [Required(ErrorMessage = "Etternavn må oppgis!")]
        public string Etternavn { get; set; }

        [Required(ErrorMessage = "Adresse må oppgis!")]
        public string Adresse { get; set; }

    }

    
}