﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ATOM.Core.DTOs.Request
{
    public class AddHelpDemandDto
    {
        public AddHelpDemandDto()
        {
            this.Date = DateTime.Now;
        }

        public float Longitude { get; set; }        //boylam
        public float Latitude { get; set; }         //enlem
        public string DistrictName { get; set; }
        public string CountyName { get; set; }      //???

        [JsonIgnore]
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }
    }
}