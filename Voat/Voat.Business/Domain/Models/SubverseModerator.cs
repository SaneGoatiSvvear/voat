﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voat.Domain.Models
{
    public class SubverseModerator
    {
        public string Subverse { get; set; }
        public ModeratorLevel Level { get; set; }

        //public string CreatedBy { get; set; }
        //public Nullable<System.DateTime> CreationDate { get; set; }

    }
}
