using Coure_API_Assesment.Models;
using System.Threading.Tasks;

namespace Coure_API_Assesment.Interfaces
{
    public interface ICountryRetreiver
    {
        Task<CountryResponseDetails> RetreiveDetails(string countryCode, string phoneNumber);
    }
}
