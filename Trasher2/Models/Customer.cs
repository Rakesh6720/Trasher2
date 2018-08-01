using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Configuration;
using System.Security.Permissions;
using System.Web;
using System.Data.Entity;

namespace Trasher2.Models
{
    public class Customer
    {
        
        public int CustomerId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(5)]
        [Display(Name = "Zip Code")]
        public string ZipCode{ get; set; }
        [Required]
        [Display(Name = "Collection Day")]
        public string PickupDay { get; set; }
        //add authorization
        [Display(Name = "Collected")]
        public bool IsDayOnePickedUp { get; set; }
        //Make sure this can be null
        [Display(Name = "Additional Collection Day")]
        public string PickupDayTwo { get; set; }
        //add authorization
        [Display(Name = "Collected")]
        public bool IsDayTwoPickedUp { get; set; }
        //add authorization
        public float AmountDue { get; set; }

    }

}