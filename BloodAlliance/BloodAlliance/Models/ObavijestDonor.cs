﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodAlliance.Models
{
    public class ObavijestDonor //:Obavijest
    {
        public int ObavijestDonorId { get; set; }
        public string Obavijest { get; set; }
        public DateTime DatumObavijesti { get; set; }

        public int DonorId { get; set; }
        public virtual Donor Donor { get; set; }

        public ObavijestDonor()
        {
            Obavijest = "Ponovno mozete donirati krv. :)";
            DatumObavijesti = DateTime.Now;
        }

    }
}
