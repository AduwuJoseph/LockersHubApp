﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LockersHub.WebApp.Models
{
    public partial class AspNetUserLoginVM
    {
        [Key]
        [StringLength(128)]
        public string LoginProvider { get; set; }
        [Key]
        [StringLength(128)]
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        [Required]
        [StringLength(450)]
        public string UserId { get; set; }

        public virtual AspNetUserVM User { get; set; }
    }
}