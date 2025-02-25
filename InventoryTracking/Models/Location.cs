﻿using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace InventoryTracking.Models
{
    public class Location
    {
        [Display(Name = "ID")]
        public int LocationId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        [DataType(DataType.Text)]
        public string City { get; set; }

        [Display(Name = "Post code")]
        [DataType(DataType.PostalCode)]
        public string PostCode { get; set; }

        public Location()
        {
        }
    }
}

