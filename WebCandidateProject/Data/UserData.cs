using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebCandidateProject.Models;

namespace WebCandidateProject.Data
{
    public static class UserData
    {
        public static IEnumerable<User> Get() { 
            return new List<User> {
                new User{
                    UserId = 1,
                    FirstName = "Bugs",
                    LastName = "Bunny",
                    Address = "No Name Street",
                    City = "Turnersville",
                    State = "New Jersey",
                    Zip = "08012",
                    ProfileImage = "BugsBunny.png"
                },
                new User{
                    UserId = 2,
                    FirstName = "Daffy",
                    LastName = "Duck",
                    Address = "Any Street",
                    City = "Poughkeepsie",
                    State = "New Jersey",
                    Zip = "12603",
                    ProfileImage = "DaffyDuck.png"
                },
                new User{
                    UserId = 3,
                    FirstName = "Porky",
                    LastName = "Pig",
                    Address = "Slaughterhouse Rd",
                    City = "Pikeville",
                    State = "Tennessee",
                    Zip = "37367",
                    ProfileImage = "PorkyPig.png"
                },
                new User{
                    UserId = 4,
                    FirstName = "Speedy",
                    LastName = "Gonzales",
                    Address = "Lightning Strike Drive",
                    City = "Sevierville",
                    State = "Tennessee",
                    Zip = "37862",
                    ProfileImage = "SpeedyGonzales.png"
                },
                new User{
                    UserId = 5,
                    FirstName = "Yosemite",
                    LastName = "Sam",
                    Address = "Gunpowder Lane",
                    City = "Marietta",
                    State = "Georgia",
                    Zip = "30068",
                    ProfileImage = "YosemiteSam.png"
                },
            };
        }
    }
}