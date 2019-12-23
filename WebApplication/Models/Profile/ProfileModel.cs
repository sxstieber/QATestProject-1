using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Profiles.Business;

namespace WebApplication.Models.Profile
{
    public class ProfileModel
    {
        public ProfileModel(int ID, string filter = "")
        {
            DatabaseService service = new DatabaseService();
            ProfileCollection collection = new ProfileCollection(service)
            {
                FilterText = filter
            };

            Profiles.Business.Profile userProfile = collection.GetProfile(ID);

            FullName = userProfile.FirstName + " " + userProfile.LastName;
            SPIERole = userProfile.SPIERole;
            Company = userProfile.Company;
            JobTitle = userProfile.JobTitle;
            PictureFileName = userProfile.PictureFileName;
        }


        public string FullName;
        public string SPIERole;
        public string Company;
        public string JobTitle;
        public string PictureFileName;
    }
}