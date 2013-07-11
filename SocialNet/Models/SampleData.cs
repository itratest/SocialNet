using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SocialNet.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<UsersContext>
    {
        protected override void Seed(UsersContext context)
        {
            var cities = new List<Cities>
            {
                new Cities {CityId=1, Name = "Минск" },
                new Cities {CityId=2, Name = "Гродно" },
                new Cities {CityId=3, Name = "Брест" }
            };

            new List<UsersDataModel>
                {
                    new UsersDataModel { Id = 1,
                        Name = "Veronika",
                        FirstName = "Yankovskaya",
                        Nik = "Kusya",
                        City = cities.Single(a => a.Name == "Барановичи")                    
                    }                    
                }.ForEach(a => context.UserData.Add(a));
        }
    }
}