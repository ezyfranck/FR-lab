using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    [OdooTableName("delivery.carrier")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class DeliveryCarrierOdooModel : IOdooModel
    {

        /// <summary>
        /// website_id - many2one - website <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Restrict publishing to this website. <br />
        /// </summary>
        [JsonProperty("website_id")]
        public long? WebsiteId { get; set; }

        /// <summary>
        /// website_published - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("website_published")]
        public bool? WebsitePublished { get; set; }

        /// <summary>
        /// is_published - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("is_published")]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// can_publish - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("can_publish")]
        public bool? CanPublish { get; set; }

        /// <summary>
        /// website_url - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: The full URL to access the document through the website. <br />
        /// </summary>
        [JsonProperty("website_url")]
        public string? WebsiteUrl { get; set; }

        /// <summary>
        /// name - char  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// active - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// sequence - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Determine the display order <br />
        /// </summary>
        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        /// <summary>
        /// delivery_type - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("delivery_type")]
        public ProviderDeliveryCarrierOdooEnum DeliveryType { get; set; }

        /// <summary>
        /// integration_level - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Action while validating Delivery Orders <br />
        /// </summary>
        [JsonProperty("integration_level")]
        public IntegrationLevelDeliveryCarrierOdooEnum? IntegrationLevel { get; set; }

        /// <summary>
        /// prod_environment - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Set to True if your credentials are certified for production. <br />
        /// </summary>
        [JsonProperty("prod_environment")]
        public bool? ProdEnvironment { get; set; }

        /// <summary>
        /// debug_logging - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Log requests in order to ease debugging <br />
        /// </summary>
        [JsonProperty("debug_logging")]
        public bool? DebugLogging { get; set; }

        /// <summary>
        /// company_id - many2one - res.company <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

        /// <summary>
        /// product_id - many2one - product.product <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// invoice_policy - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Estimated Cost: the customer will be invoiced the estimated cost of the shipping.; Real Cost: the customer will be invoiced the real cost of the shipping, the cost of the shipping will be updated on the SO after the delivery. <br />
        /// </summary>
        [JsonProperty("invoice_policy")]
        public InvoicingPolicyDeliveryCarrierOdooEnum InvoicePolicy { get; set; }

        /// <summary>
        /// country_ids - many2many - res.country <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("country_ids")]
        public long[]? CountryIds { get; set; }

        /// <summary>
        /// state_ids - many2many - res.country.state <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("state_ids")]
        public long[]? StateIds { get; set; }

        /// <summary>
        /// zip_prefix_ids - many2many - delivery.zip.prefix <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: Prefixes of zip codes that this carrier applies to. Note that regular expressions can be used to support countries with varying zip code lengths, i.e. '$' can be added to end of prefix to match the exact zip (e.g. '100$' will only match '100' and not '1000') <br />
        /// </summary>
        [JsonProperty("zip_prefix_ids")]
        public long[]? ZipPrefixIds { get; set; }

        /// <summary>
        /// carrier_description - text  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: A description of the delivery method that you want to communicate to your customers on the Sales Order and sales confirmation email.E.g. instructions for customers to follow. <br />
        /// </summary>
        [JsonProperty("carrier_description")]
        public string? CarrierDescription { get; set; }

        /// <summary>
        /// margin - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: This percentage will be added to the shipping price. <br />
        /// </summary>
        [JsonProperty("margin")]
        public double? Margin { get; set; }

        /// <summary>
        /// free_over - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: If the order total amount (shipping excluded) is above or equal to this value, the customer benefits from a free shipping <br />
        /// </summary>
        [JsonProperty("free_over")]
        public bool? FreeOver { get; set; }

        /// <summary>
        /// amount - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Amount of the order to benefit from a free shipping, expressed in the company currency <br />
        /// </summary>
        [JsonProperty("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// can_generate_return - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("can_generate_return")]
        public bool? CanGenerateReturn { get; set; }

        /// <summary>
        /// return_label_on_delivery - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: The return label is automatically generated at the delivery. <br />
        /// </summary>
        [JsonProperty("return_label_on_delivery")]
        public bool? ReturnLabelOnDelivery { get; set; }

        /// <summary>
        /// get_return_label_from_portal - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: The return label can be downloaded by the customer from the customer portal. <br />
        /// </summary>
        [JsonProperty("get_return_label_from_portal")]
        public bool? GetReturnLabelFromPortal { get; set; }

        /// <summary>
        /// supports_shipping_insurance - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("supports_shipping_insurance")]
        public bool? SupportsShippingInsurance { get; set; }

        /// <summary>
        /// shipping_insurance - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Shipping insurance is a service which may reimburse senders whose parcels are lost, stolen, and/or damaged in transit. <br />
        /// </summary>
        [JsonProperty("shipping_insurance")]
        public int? ShippingInsurance { get; set; }

        /// <summary>
        /// fixed_price - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("fixed_price")]
        public double? FixedPrice { get; set; }

        /// <summary>
        /// id - integer  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// __last_update - datetime  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("__last_update")]
        public DateTime? LastUpdate { get; set; }

        /// <summary>
        /// display_name - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// create_uid - many2one - res.users <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("create_uid")]
        public long? CreateUid { get; set; }

        /// <summary>
        /// create_date - datetime  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("create_date")]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// write_uid - many2one - res.users <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("write_uid")]
        public long? WriteUid { get; set; }

        /// <summary>
        /// write_date - datetime  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("write_date")]
        public DateTime? WriteDate { get; set; }

        /// <summary>
        /// price_rule_ids - one2many - delivery.price.rule (carrier_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("price_rule_ids")]
        public long[]? PriceRuleIds { get; set; }

        /// <summary>
        /// default_tracking_url - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: This is the default tracking url for this carrier. <br />
        /// </summary>
        [JsonProperty("default_tracking_url")]
        public string? DefaultTrackingUrl { get; set; }

        /// <summary>
        /// with_dropoff_site - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("with_dropoff_site")]
        public bool? WithDropoffSite { get; set; }

        /// <summary>
        /// dropoff_site_ids - one2many - dropoff.site (carrier_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("dropoff_site_ids")]
        public long[]? DropoffSiteIds { get; set; }

        /// <summary>
        /// website_description - text  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: A description of the Product that you want to communicate to your customers. This description will be copied to every Sales Order, Delivery Order and Customer Invoice/Credit Note <br />
        /// </summary>
        [JsonProperty("website_description")]
        public string? WebsiteDescription { get; set; }

        /// <summary>
        /// name_l4 - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("name_l4")]
        public string? NameL4 { get; set; }

        /// <summary>
        /// name_l4_key2 - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("name_l4_key2")]
        public string? NameL4Key2 { get; set; }
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProviderDeliveryCarrierOdooEnum
    {
        [EnumMember(Value = "fixed")]
        FixedPrice = 1,

        [EnumMember(Value = "base_on_rule")]
        BasedOnRules = 2,
    }


    /// <summary>
    /// Help: Action while validating Delivery Orders
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IntegrationLevelDeliveryCarrierOdooEnum
    {
        [EnumMember(Value = "rate")]
        GetRate = 1,

        [EnumMember(Value = "rate_and_ship")]
        GetRateAndCreateShipment = 2,
    }


    /// <summary>
    /// Help: Estimated Cost: the customer will be invoiced the estimated cost of the shipping. <br />
    /// Real Cost: the customer will be invoiced the real cost of the shipping, the cost of the shipping will be updated on the SO after the delivery.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoicingPolicyDeliveryCarrierOdooEnum
    {
        [EnumMember(Value = "estimated")]
        EstimatedCost = 1,

        [EnumMember(Value = "real")]
        RealCost = 2,
    }
}
