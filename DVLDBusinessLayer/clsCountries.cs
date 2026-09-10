using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLDBusinessLayer
{
    public class clsCountries
    {
       public int CountryID { get; set; }
        public string CountryName { get; set; }

        public clsCountries()
        {
            CountryID = -1;
            CountryName = "";
        }
        private clsCountries(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }
        public static clsCountries GetCountryName(int countryID)
        {
            string countryName = "";
            if (DVLDDataAccessLayer.CountriesData.getCountryNameByID(countryID, ref countryName)) {
                return new clsCountries(countryID, countryName);
            }

            return new clsCountries();
        }
    }
}
