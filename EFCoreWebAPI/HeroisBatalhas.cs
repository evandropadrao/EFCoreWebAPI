﻿using System;
using System.Collections.Generic;

namespace EFCoreWebAPI
{
    public partial class HeroisBatalhas
    {
        public int HeroiId { get; set; }
        public int BatalhaId { get; set; }

        public Batalhas Batalha { get; set; }
        public Herois Heroi { get; set; }
    }
}
