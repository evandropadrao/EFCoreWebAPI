using System;
using System.Collections.Generic;

namespace EFCoreWebAPI
{
    public partial class IdentidadeSecretas
    {
        public int Id { get; set; }
        public string NomeReal { get; set; }
        public int HeroiId { get; set; }

        public Herois Heroi { get; set; }
    }
}
