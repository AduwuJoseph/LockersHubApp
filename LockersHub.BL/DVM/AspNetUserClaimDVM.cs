﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LockersHub.BL.DVM
{
    public partial class AspNetUserClaimDVM
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(450)]
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual AspNetUserDVM User { get; set; }
    }
}