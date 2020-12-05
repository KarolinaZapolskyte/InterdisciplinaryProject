using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Plantify.Models
{
    public class Customer
    {

        public int CustomerId { get; set; }
        public string Firstname { get; set;  }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }

        // constructor
        public Customer() { }
        public Customer(int customerId, string firstName, string lastName, string address, string zip, string city, int phone)
        {
            CustomerId = customerId;
            Firstname = firstName;
            Lastname = lastName;
            Address = address;
            Zip = zip;
            City = city;
            Phone = phone;
        }

    }
}