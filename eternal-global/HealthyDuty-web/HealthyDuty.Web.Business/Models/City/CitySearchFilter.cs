﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyDuty.Web.Business.Models.City
{
    public class CitySearchFilter
    {
        // paging
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }

        // sorting
        public string SortOn { get; set; }
        public string SortDirection { get; set; }

        // filters        
        public string Filter_Name { get; set; }
    }
}
