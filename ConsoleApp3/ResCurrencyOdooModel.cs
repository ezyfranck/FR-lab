﻿using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using PortaCapena.OdooJsonRpcClient.Attributes;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System.Runtime.Serialization;


namespace ConsoleApp3
{
    [OdooTableName("res.currency")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ResCurrencyOdooModel : IOdooModel
    {

        /// <summary>
        /// name - char  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Currency Code (ISO 4217) <br />
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// full_name - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// symbol - char  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Currency sign, to be used when printing amounts. <br />
        /// </summary>
        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        /// <summary>
        /// rate - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: The rate of the currency to the currency of rate 1. <br />
        /// </summary>
        [JsonProperty("rate")]
        public double? Rate { get; set; }

        /// <summary>
        /// inverse_rate - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: The currency of rate 1 to the rate of the currency. <br />
        /// </summary>
        [JsonProperty("inverse_rate")]
        public double? InverseRate { get; set; }

        /// <summary>
        /// rate_string - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("rate_string")]
        public string? RateString { get; set; }

        /// <summary>
        /// rate_ids - one2many - res.currency.rate (currency_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("rate_ids")]
        public long[]? RateIds { get; set; }

        /// <summary>
        /// rounding - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Amounts in this currency are rounded off to the nearest multiple of the rounding factor. <br />
        /// </summary>
        [JsonProperty("rounding")]
        public double? Rounding { get; set; }

        /// <summary>
        /// decimal_places - integer  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: Decimal places taken into account for operations on amounts in this currency. It is determined by the rounding factor. <br />
        /// </summary>
        [JsonProperty("decimal_places")]
        public int? DecimalPlaces { get; set; }

        /// <summary>
        /// active - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// position - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Determines where the currency symbol should be placed after or before the amount. <br />
        /// </summary>
        [JsonProperty("position")]
        public SymbolPositionResCurrencyOdooEnum? Position { get; set; }

        /// <summary>
        /// date - date  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// currency_unit_label - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("currency_unit_label")]
        public string? CurrencyUnitLabel { get; set; }

        /// <summary>
        /// currency_subunit_label - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("currency_subunit_label")]
        public string? CurrencySubunitLabel { get; set; }

        /// <summary>
        /// is_current_company_currency - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("is_current_company_currency")]
        public bool? IsCurrentCompanyCurrency { get; set; }

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
        /// display_rounding_warning - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: The warning informs a rounding factor change might be dangerous on res.currency's form view. <br />
        /// </summary>
        [JsonProperty("display_rounding_warning")]
        public bool? DisplayRoundingWarning { get; set; }
    }


    /// <summary>
    /// Help: Determines where the currency symbol should be placed after or before the amount.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SymbolPositionResCurrencyOdooEnum
    {
        [EnumMember(Value = "after")]
        AfterAmount = 1,

        [EnumMember(Value = "before")]
        BeforeAmount = 2,
    }
}
