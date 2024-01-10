using Coure_API_Assesment.Models;
using System.Collections.Generic;

namespace Coure_API_Assesment.Helpers.Database
{
    //Create the In-Memory database 
    public static class Countries
    {
        public static List<CountryTable> CountriesTable()
        {
            var countries = new List<CountryTable>();
            countries.Add(new CountryTable()
            {
                Id = 1,
                CountryCode = "234",
                Name = "Nigeria",
                CountryIso = "NG"
            });

            countries.Add(new CountryTable()
            {
                Id = 2,
                CountryCode = "233",
                Name = "Ghana",
                CountryIso = "GH"
            });

            countries.Add(new CountryTable()
            {
                Id = 3,
                CountryCode = "229",
                Name = "Benin Republic",
                CountryIso = "BN"
            });

            countries.Add(new CountryTable()
            {
                Id = 3,
                CountryCode = "225",
                Name = "Côte d'Ivoire",
                CountryIso = "CIV"
            });

            return countries;
        }

        public static List<CountryDetailTable> CountriesDetailsTable()
        {
            var countryDetails = new List<CountryDetailTable>();

            countryDetails.Add(new CountryDetailTable()
            {
                Id = 1,
                CountryId = 1,
                Operator = "MTN Nigeria",
                OperatorCode = "MTN NG",
            });

            countryDetails.Add(new CountryDetailTable()
            {
                Id = 2,
                CountryId = 1,
                Operator = "Airtel Nigeria",
                OperatorCode = "ANG",
            });
            
            countryDetails.Add(new CountryDetailTable()
            {
                Id = 3,
                CountryId = 1,
                Operator = "9 Mobile Nigeria",
                OperatorCode = "ETN",
            });

            countryDetails.Add(new CountryDetailTable()
            {
                Id = 4,
                CountryId = 1,
                Operator = "Globacom Nigeria",
                OperatorCode = "GLO NG",
            });

            countryDetails.Add(new CountryDetailTable()
            {
                Id = 5,
                CountryId = 2,
                Operator = "Vodafone Ghana",
                OperatorCode = "Vodafone GH",
            });

            countryDetails.Add(new CountryDetailTable()
            {
                Id = 5,
                CountryId = 2,
                Operator = "Vodafone Ghana",
                OperatorCode = "Vodafone GH",
            });
            
            countryDetails.Add(new CountryDetailTable()
            {
                Id = 6,
                CountryId = 2,
                Operator = "MTN Ghana",
                OperatorCode = "MTN Ghana",
            });

            countryDetails.Add(new CountryDetailTable()
            {
                Id = 7,
                CountryId = 2,
                Operator = "Tigo Ghana",
                OperatorCode = "Tigo Ghana",
            });

            countryDetails.Add(new CountryDetailTable()
            {
                Id = 8,
                CountryId = 3,
                Operator = "MTN Benin",
                OperatorCode = "MTN Benin",
            });
            
            countryDetails.Add(new CountryDetailTable()
            {
                Id = 9,
                CountryId = 3,
                Operator = "Moov Benin",
                OperatorCode = "Moov Benin",
            });
            
            countryDetails.Add(new CountryDetailTable()
            {
                Id = 10,
                CountryId = 4,
                Operator = "MTN Côte d'Ivoire",
                OperatorCode = "MTN CIV",
            });

            return countryDetails;
        }
    }
}
