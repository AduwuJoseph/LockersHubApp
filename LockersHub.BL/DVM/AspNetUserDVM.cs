﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LockersHub.BL.DVM
{
    public partial class AspNetUserDVM
    {
        [Key]
        public string Id { get; set; }
        public int? ProviderId { get; set; }
        public int? LabProviderId { get; set; }
        [StringLength(450)]
        public string PatientId { get; set; }
        [StringLength(256)]
        public string UserName { get; set; }
        [StringLength(256)]
        public string Password { get; set; }
        [StringLength(256)]
        public string OldPassword { get; set; }
        [StringLength(256)]
        public string NewPassword { get; set; }
        [StringLength(256)]
        public string NormalizedUserName { get; set; }
        [StringLength(256)]
        public string Email { get; set; }
        [StringLength(256)]
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        public bool RememberMe { get; set; } = false;

        public virtual CustomerDVM Customer { get; set; }
        public virtual ServiceProviderDVM Provider { get; set; }

        public List<string> Roles { get; set; }
    }
}