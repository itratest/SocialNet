using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SocialNet.Models
{
    public class SocialNetEntities:DbContext
    {
        public DbSet<Cities> SetOfCities { get; set; }
        public DbSet<UsersDataModel> UsersData { get; set; }
    }
}