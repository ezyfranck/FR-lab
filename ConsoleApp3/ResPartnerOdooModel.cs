using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System.Runtime.Serialization;
using PortaCapena.OdooJsonRpcClient.Attributes;

namespace ConsoleApp3
{
    [OdooTableName("res.partner")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ResPartnerOdooModel : IOdooModel
    {

        /// <summary>
        /// name - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// street - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("street")]
        public string? Street { get; set; }

        /// <summary>
        /// street2 - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("street2")]
        public string? Street2 { get; set; }

        /// <summary>
        /// zip - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("zip")]
        public string? Zip { get; set; }

        /// <summary>
        /// city - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        /// email - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// phone - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// mobile - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("mobile")]
        public string? Mobile { get; set; }

        /// <summary>
        /// id - integer  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// sale_order_ids - one2many - sale.order (partner_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>

        long IOdooModel.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

}
