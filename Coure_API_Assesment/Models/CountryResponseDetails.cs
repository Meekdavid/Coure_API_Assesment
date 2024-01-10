namespace Coure_API_Assesment.Models
{
    public class CountryResponseDetails
    {
        public string number { get; set; }
        public Country country { get; set; }
    }

    public class Country
    {
        public string countryCode { get; set; }
        public string name { get; set; }
        public string countryIso { get; set; }
        public Countrydetail[] countryDetails { get; set; }
    }

    public class Countrydetail
    {
        public string _operator { get; set; }
        public string operatorCode { get; set; }
    }

}
