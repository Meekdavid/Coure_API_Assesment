namespace Coure_API_Assesment.Models
{
    public class CountryApiResponse
    {
        public string responseCode { get; set; }
        public string responseMessage { get; set; }
        public CountryResponseDetails Output { get; set; }
    }

    public class NotSuccessfulResponse
    {
        public string StatusCode​ { get; set; }
        public string StatusMessage { get; set; }
    }
}
