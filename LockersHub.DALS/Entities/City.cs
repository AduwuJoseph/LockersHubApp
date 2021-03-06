﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LockersHub.DALS.Entities
{
    public partial class City
    {
        public City()
        {
            Lockers = new HashSet<Locker>();
        }

        [Key]
        public int CityId { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(4)]
        public string StateCode { get; set; }

        [ForeignKey(nameof(StateCode))]
        [InverseProperty(nameof(State.Cities))]
        public virtual State StateCodeNavigation { get; set; }
        [InverseProperty(nameof(Locker.City))]
        public virtual ICollection<Locker> Lockers { get; set; }
    }
}