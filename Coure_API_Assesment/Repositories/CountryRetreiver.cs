using Coure_API_Assesment.Controllers;
using Coure_API_Assesment.Helpers.Database;
using Coure_API_Assesment.Interfaces;
using Coure_API_Assesment.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;

namespace Coure_API_Assesment.Repositories
{
    public class CountryRetreiver : ICountryRetreiver
    {
        private readonly ILogger<CountryRetreiver> _logger;
        public CountryRetreiver(ILogger<CountryRetreiver> logger)
        {
            _logger= logger;
        }
        public async Task<CountryResponseDetails> RetreiveDetails(string countryCode, string phoneNumber)
        {
            var countryResponseDetails = new CountryResponseDetails();

            try
            {
                //Retreive specific country from in memory table
                CountryTable country = Countries.CountriesTable().Where(i => i.CountryCode == countryCode).FirstOrDefault();
                _logger.LogInformation($" Country information successfully retreived as: {JsonConvert.SerializeObject(country)}");

                //Retreive all details tied to the retrived country above
                var countryDetails = Countries.CountriesDetailsTable().Where(i => i.CountryId == country?.Id);
                _logger.LogInformation($" Country details successfully retreived as: {JsonConvert.SerializeObject(country)}");

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
            }
            catch(Exception ex)
            {
                countryResponseDetails = null;
                _logger.LogInformation($" An exception occured while retreiving details for number: {phoneNumber}\r\n {JsonConvert.SerializeObject(ex)}");
            }

            //Return the result
            return countryResponseDetails;
        }
    }
}
