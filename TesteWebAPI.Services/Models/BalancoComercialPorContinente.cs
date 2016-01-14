using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteWebAPI.Services.Models
{
    public class BalancoComercialPorContinente
    {
        public int AnoBase { get; set; }
        public string Continente { get; set; }
        public double ValorExportado { get; set; }
        public double ValorImportado { get; set; }
    }
}