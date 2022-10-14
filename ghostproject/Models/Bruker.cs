﻿using System.Collections.Generic;

namespace ghostproject.Models
{
    public class Bruker
    {
        public int Id { get; set; }
        public int Personnr { get; set; }
        public string Fornavn { get; set; }
        public string Etternavn { get; set; }
        public string Adresse { get; set; }
        public virtual Poststeder Poststeder { get; set; }
        public virtual List<Transaksjoner> Transaksjoner { get; set; }
    }
}