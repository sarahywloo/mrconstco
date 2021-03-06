﻿using MrConstruction.Domain;
using MrConstruction.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MrConstruction.Services
{
    public class JobDetailDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ProjectTitle { get; set; }

        public ContractorUserDTO Contractor { get; set; }

        public decimal? Estimate { get; set; }

        public DateTime Deadline { get; set; }

        public string Description { get; set; }

        public string State { get; set; }

    }
}