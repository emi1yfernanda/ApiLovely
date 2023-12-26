using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLovely.Model
{
    public class Categoria
    {
        public string CorpoBanho { get; set;} = "Corpo e Banho";
        public string Cabelo {get; set;} = "Cabelo";
        public string Rosto {get; set;} = "Rosto";
        public string PerfumesFemininos {get; set;} = "Perfumes Femininos";
        public string PerfumesMasculinos {get; set;} = "Perfumes Masculinos";
    }
}