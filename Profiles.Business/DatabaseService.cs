using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profiles.Business
{
    public class DatabaseService : IDatabaseService
    {
        static private List<Profile> profileList;

        private void LoadData()
        {
            profileList = new List<Profile>()
            {
                new Profile()
                {
                    ID = 1,
                    FirstName = "Jim",
                    LastName = "Bob",
                    Company = "SPIE",
                    SPIERole = "SPIE Member",
                    JobTitle = "UX/UI Designer",
                    PictureFileName = "jimbob.jpg"
                },
                new Profile()
                {
                    ID = 2,
                    FirstName = "Samantha",
                    LastName = "Johnson",
                    Company = "SPIE",
                    SPIERole = "SPIE Fellow",
                    JobTitle = "Optics & Photonics Researcher",
                    PictureFileName = "samanthajohnson.jpg"
                },
                new Profile()
                {
                    ID = 3,
                    FirstName = "Jackie",
                    LastName = "Zope",
                    Company = "NASA",
                    SPIERole = "SPIE Conference Chair",
                    JobTitle = "Astrophysicist",
                    PictureFileName = "jackiezope.jpg"
                },
                 new Profile()
                {
                    ID = 4,
                    FirstName = "Jonathon",
                    LastName = "Watkinson",
                    Company = "Blue Origins",
                    SPIERole = "SPIE Member",
                    JobTitle = "Embedded Optical Engineer",
                    PictureFileName = "jonathonwatkinson.jpg"
                },
                new Profile()
                {
                    ID = 5,
                    FirstName = "Allen",
                    LastName = "Smith",
                    Company = "Smith Gardens",
                    SPIERole = "SPIE Member",
                    JobTitle = "Astrophysicist",
                    PictureFileName = "allensmith.jpg"
                },
                new Profile()
                {
                    ID = 6,
                    FirstName = "Jim",
                    LastName = "Bean",
                    Company = "Applied Sciences",
                    SPIERole = "SPIE Conference Chair",
                    JobTitle = "Technical Lead",
                    PictureFileName = "jimbean.jpg"
                },
                new Profile()
                {
                    ID = 7,
                    FirstName = "John",
                    LastName = "Brown",
                    Company = "Applied Sciences",
                    SPIERole = "Researcher",
                    JobTitle = "Astrophysicist",
                    PictureFileName = "johnbrown.jpg"
                },
                new Profile()
                {
                    ID = 8,
                    FirstName = "Cheryl",
                    LastName = "Yeh",
                    Company = "General Dynamics",
                    SPIERole = "Researcher",
                    JobTitle = "Astrophysicist",
                    PictureFileName = "cherylyeh.jpg"
                },
                new Profile()
                {
                    ID = 9,
                    FirstName = "Mas",
                    LastName = "Samuelsson",
                    Company = "General Dynamics",
                    SPIERole = "Researcher",
                    JobTitle = "Astrophysicist",
                    PictureFileName = "massamuelsson.jpg"
                },
            };
        }


        public List<Profile> GetProfiles()
        {
            return Profiles;
        }


        public List<Profile> Profiles
        {
            get
            {
                if (profileList == null)
                {
                    LoadData();
                }

                return profileList;
            }
        }
    }
}
