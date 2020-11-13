using System;
using System.Collections.Generic;           // IEnumerable<T>
using System.Linq;                          // ToArray()
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;  // PageModel
using Packt.Shared;                         // Employee

namespace PacktFeatures.Pages
{
    public class CustomerPageModel : PageModel
    {
        public CustomerPageModel(Northwind injectedContext)
        {        
            //ID = id;    
            db = injectedContext;
        }
        public string ID { get; set; }
        private Northwind db { get; set; }
        public Customer Customer { get; set; }
        public void OnGet(string id)
        {
            ID = id;
            var model = db.Customers.SingleOrDefault(c => c.CustomerID == ID);
            if (model != null)
            {
                /*cust = new Customer
                {
                    CustomerID = model.CustomerID,
                    CompanyName = model.CompanyName,
                    ContactName = model.ContactName
                };*/
                Customer = model;
            }                
        }
    }
}