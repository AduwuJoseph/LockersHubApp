﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LockersHub.WebApp.Models
{
    public partial class StateVM
    {
        [Key]
        [StringLength(4)]
        public string Code { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(4)]
        public string CountryCode { get; set; }

        public virtual CountryVM CountryCodeNavigation { get; set; }
        public virtual ICollection<CityVM> Cities { get; set; }
    }
}