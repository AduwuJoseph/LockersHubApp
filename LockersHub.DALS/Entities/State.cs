﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LockersHub.DALS.Entities
{
    public partial class State
    {
        public State()
        {
            Cities = new HashSet<City>();
        }

        [Key]
        [StringLength(4)]
        public string Code { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(4)]
        public string CountryCode { get; set; }

        [ForeignKey(nameof(CountryCode))]
        [InverseProperty(nameof(Country.States))]
        public virtual Country CountryCodeNavigation { get; set; }
        [InverseProperty(nameof(City.StateCodeNavigation))]
        public virtual ICollection<City> Cities { get; set; }
    }
}