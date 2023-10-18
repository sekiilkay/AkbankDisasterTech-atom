﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOM.Core.DTOs.Response
{
    public class PeopleLocationDto
    {

        [Column(TypeName = "decimal(8,6)")]
        public decimal Longitude { get; set; }  

        [Column(TypeName = "decimal(8,6)")]
        public decimal Latitude { get; set; }    
    }
}
