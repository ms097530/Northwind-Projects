using System;
using System.Collections.Generic;           // IEnumerable<T>
using System.Linq;                          // ToArray()
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;  // PageModel
using Packt.Shared;                         // Employee


namespace PacktFeatures.Pages
{
    public class CustomersPageModel : PageModel
    {
        private Northwind db;
        public IEnumerable<Customer> Customers { get; set; }
        public CustomersPageModel(Northwind injectedContext)
        {
            db = injectedContext;
        }
        public void OnGet()
        {
            Customers = db.Customers.OrderBy(c => c.Country).ToArray();
        }
    }
}
