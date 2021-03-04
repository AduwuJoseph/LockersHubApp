using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LockersHub.WebApp.Models
{
    public class CityVM
    {
        [Key]
        [JsonProperty(PropertyName = "CityId")]
        public int CityId { get; set; }
        [Required]
        [StringLength(150)]
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }
        [StringLength(4)]
        [JsonProperty(PropertyName = "StateCode")]
        public string StateCode { get; set; }

    }
}
