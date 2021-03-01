﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LockersHub.DALS.Entities
{
    public partial class Country
    {
        public Country()
        {
            States = new HashSet<State>();
        }

        [Key]
        [StringLength(4)]
        public string Code { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [InverseProperty(nameof(State.CountryCodeNavigation))]
        public virtual ICollection<State> States { get; set; }
    }
}