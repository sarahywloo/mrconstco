﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MrConstruction.Presentation.Models {
    public class NewPortfolioBindingModel {
        public IList<int> PictureIds { get; set; }
        public int BeforeId { get; set; }
        public int AfterId { get; set; }
    }
}