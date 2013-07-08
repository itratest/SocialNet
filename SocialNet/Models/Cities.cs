using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SocialNet.Models
{
    public class Cities
    {
        [Key]
        public int CityId { get; set; }
        public string Name { get; set; }
    }
}