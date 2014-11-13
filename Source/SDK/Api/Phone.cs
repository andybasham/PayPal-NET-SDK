//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;

namespace PayPal.Api
{
    public class Phone : PayPalSerializableObject
    {
        /// <summary>
        /// Country code (from in E.164 format)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "country_code")]
        public string country_code { get; set; }

        /// <summary>
        /// In-country phone number (from in E.164 format)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "national_number")]
        public string national_number { get; set; }

        /// <summary>
        /// Phone extension
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extension")]
        public string extension { get; set; }
    }
}