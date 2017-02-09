﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MerchantWebAPI.Models
{
    public class Address
    {
        public string country { get; set; }
        public string state { get; set; }
        public string suburb { get; set; }
        public string postcode { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }

    }
}