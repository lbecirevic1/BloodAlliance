﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodAlliance.Models
{
    public class ObavijestBolnica //:Obavijest
    {
        public int ObavijestBolnicaId { get; set; }
      //  [Display(Name = "Krvna grupa")]
        public string KrvnaGrupa { get; set; }
        public int Kolicina { get; set; }
        public DateTime Datum { get; set; }

        public string Obavijest { get; set; }

        public int BolnicaId { get; set; }
        public virtual ICollection<Donacija> Donacije { get; set; }
        public virtual Bolnica Bolnica { get; set; }

        public ObavijestBolnica() { }

        public ObavijestBolnica(string krvnaGrupa, int kolicina, DateTime datum, string obavijest, int id)
        {
            KrvnaGrupa = krvnaGrupa;
            Kolicina = kolicina;
            Datum = datum;
            Obavijest = obavijest;
            BolnicaId = id;
        }

    }
}
