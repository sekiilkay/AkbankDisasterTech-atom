﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ATOM.Core.Entities
{
    public class HelpPopulation : BaseEntity
    {
        [Column(TypeName = "decimal(8,6)")]
        public decimal Longitude { get; set; }     

        [Column(TypeName = "decimal(8,6)")]
        public decimal Latitude { get; set; } 
        public int People { get; set; }
        public int CategoryId { get; set; }
        public int DistrictId { get; set; }

        [JsonIgnore]
        public Category Category { get; set; }
        
        [JsonIgnore]
        public District District { get; set; }
        public int? GatheringCenterId { get; set; }
        public int? HelpCenterId { get; set; }
    }
}
