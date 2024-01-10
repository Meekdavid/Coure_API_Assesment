using Coure_API_Assesment.Helpers.InputOperations;
using Coure_API_Assesment.Interfaces;
using Coure_API_Assesment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Coure_API_Assesment.Controllers
{
    public class CountryController : Controller
    {
        private string className = string.Empty;
        private readonly ILogger<CountryController> _logger;
        private readonly ICountryRetreiver _countryRetreiver;
        public CountryController(ILogger<CountryController> logger, ICountryRetreiver countryRetreiver)
        {
            _logger = logger;
            _countryRetreiver = countryRetreiver;
        }


        [ProducesResponseType(typeof(CountryApiResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(NotSuccessfulResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(NotSuccessfulResponse), StatusCodes.Status500InternalServerError)]
        [Consumes("application/json")]
        [HttpGet("Retreive Country Details")]
        public async Task<ActionResult<CountryApiResponse>> RetrieveCountryDetails(string phoneNumber)
        {
            var response = new CountryApiResponse();
            var returnHttpStatusCode = StatusCodes.Status200OK;
            string countryCode = string.Empty;

            try
            {
                //First check and validate input against attacks/injections
                SanitizeInputs.ProcessObjectAgainstInputThreats(phoneNumber);

                // Remove any non-digit characters
                string cleanedNumber = new string(phoneNumber.Where(char.IsDigit).ToArray());

                if (cleanedNumber.Length > 1)                    
                {
                    // Extract and return the country code
                    countryCode = cleanedNumber.Substring(0, 3);

                    var countryDetails = await _countryRetreiver.RetreiveDetails(countryCode, phoneNumber);

                    response.responseCode = "00";
                    response.responseMessage = $"Request Successful";
                    response.Output = countryDetails;
                }
                else
                {
                    response.responseCode = "01";
                    response.responseMessage = $"Country code not found in the phone number";                    
                }
            }
            catch(Exception ex)
            {
                response.responseCode = "02";
                response.responseMessage = $"An Error Occured: {ex.Message}";
            }
            return StatusCode(returnHttpStatusCode, response);
        }
    }
}
