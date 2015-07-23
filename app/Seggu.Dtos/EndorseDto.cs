﻿using System;
using System.Collections.Generic;

namespace Seggu.Dtos
{
    [Serializable]
    public class EndorseDto : EntityWithIdDto
    {
        public string AnnulationDate { get; set; }
        public string Asegurado { get; set; }  
      
        public string Motivo { get; set; }        
        public string ClientId { get; set; }  
        public string CompanyId { get; set; }
      
        public string EndDate { get; set; }        
        public string EmissionDate { get; set; } 
        public string EndorseType { get; set; }

        public string FilePath { get; set; }
        public bool IsAnnulled { get; set; }
        public bool IsRemoved { get; set; }

        public string Notes { get; set; }
        public string Número { get; set; }

        public string PolicyId { get; set; }
        public string PolicyNumber { get; set; }
        public decimal? Prima { get; set; }
        public decimal? Premium { get; set; }
        public string ProducerId { get; set; }

        public string RequestDate { get; set; }        
        public string ReceptionDate { get; set; }        
        public string RiskId { get; set; }

        public string StartDate { get; set; }        
        public decimal? Surcharge { get; set; }

        public string TipoRiesgo { get; set; }

        public decimal? Value { get; set; }
        public IEnumerable<VehicleDto> Vehicles { get; set; }

    }
}
