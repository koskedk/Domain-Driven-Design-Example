﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eCommerce.Helpers.Domain;

namespace eCommerce.DomainModelLayer.Customers
{
    public class CustomerChangedEmail : IDomainEvent
    {
        public Customer Customer { get; set; }
    }
}
