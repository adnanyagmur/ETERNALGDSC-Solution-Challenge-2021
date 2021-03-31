﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyDuty.Web.Business.Models.Authentication
{
    public class EmployeeLoginResponse
    {
        public bool IsValid { get; set; }
        public Data.Entity.Personnel Personnel { get; set; }
        public string ErrorMessage { get; set; }
    }
}
