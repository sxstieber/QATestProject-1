using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profiles.Business
{
    public class ProfileCollection
    {
        #region [ Fields ]

        private IDatabaseService _databaseService = null;

        #endregion


        #region [ Constructors ]

        public ProfileCollection(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        #endregion


        #region [ Methods ]

        public Profile GetProfile(int ID)
        {
            return (String.IsNullOrWhiteSpace(FilterText))
                   ? _databaseService.Profiles.First()
                   : GetFilteredProfile(ID);
        }

        private Profile GetFilteredProfile(int id)
        {
            return _databaseService.Profiles.Where(p => p.ID == id).FirstOrDefault();
        }

        #endregion


        #region [ Properties ]

        public List<Profile> ProfileList
        {
            get
            {
                return _databaseService.Profiles;
            }
        }

        public string FilterText
        {
            get;
            set;
        }

        public List<Profile> FilteredList
        {
            get
            {
                return (String.IsNullOrWhiteSpace(FilterText))
                       ? _databaseService.Profiles
                       : _databaseService.Profiles.Where(p => p.FirstName.IndexOf(FilterText, StringComparison.OrdinalIgnoreCase) >= 0
                                                         || p.LastName.IndexOf(FilterText, StringComparison.OrdinalIgnoreCase) >= 0
                                                         || String.Equals(FilterText, p.Company, StringComparison.OrdinalIgnoreCase)).ToList();
            }
        }

        #endregion
    }
}
