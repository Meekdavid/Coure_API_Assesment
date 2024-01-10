using Coure_API_Assesment.Helpers.Database;
using Coure_API_Assesment.Interfaces;
using Coure_API_Assesment.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coure_API_Assesment.Repositories
{
    public class CountryRetreiver : ICountryRetreiver
    {
        public async Task<CountryResponseDetails> RetreiveDetails(string countryCode, string phoneNumber)
        {
            var countryResponseDetails = new CountryResponseDetails();

            //Retreive specific country from in memory table
            CountryTable country = Countries.CountriesTable().Where(i => i.CountryCode == countryCode).FirstOrDefault();

            //Retreive all details tied to the retrived country above
            var countryDetails = Countries.CountriesDetailsTable().Where(i => i.CountryId == country?.Id);

            //Create an object of countrydetail to store relevant information retreived from the country details above
            var countryDetailsHolder = new List<Countrydetail>();
            foreach (CountryDetailTable detailsTable in countryDetails)
            {
                countryDetailsHolder.Add(new Countrydetail
                {
                    _operator = detailsTable.Operator,
                    operatorCode = detailsTable.OperatorCode
                });
            }

            //Assign the remaining properies their respective values
            countryResponseDetails.number = phoneNumber;
            countryResponseDetails.country = new Country
            {
                countryCode = country.CountryCode,
                name = country.Name,
                countryIso = country.CountryIso,
                countryDetails = countryDetailsHolder.ToArray()

            };

            //Return the result
            return countryResponseDetails;
        }
    }
}
