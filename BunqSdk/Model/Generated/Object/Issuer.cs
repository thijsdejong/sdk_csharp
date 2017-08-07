using Newtonsoft.Json;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class Issuer : BunqModel
    {
        /// <summary>
        /// The BIC code.
        /// </summary>
        [JsonProperty(PropertyName = "bic")]
        public string Bic { get; set; }

        /// <summary>
        /// The name of the bank.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        public Issuer(string bic)
        {
            Bic = bic;
        }
    }
}