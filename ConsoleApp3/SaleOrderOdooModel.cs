using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System.Runtime.Serialization;
using PortaCapena.OdooJsonRpcClient.Attributes;

namespace ConsoleApp3
{
    [OdooTableName("sale.order")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class SaleOrderOdooModel : IOdooModel
    {

        /// <summary>
        /// name - char  <br />
        /// Required: True, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// company_id - many2one - res.company <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("company_id")]
        public long CompanyId { get; set; }

        /// <summary>
        /// partner_id - many2one - res.partner <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("partner_id")]
        public long PartnerId { get; set; }

        /// <summary>
        /// state - selection  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("state")]
        public StatusSaleOrderOdooEnum? State { get; set; }

        /// <summary>
        /// commitment_date - datetime  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: This is the delivery date promised to the customer. If set, the delivery order will be scheduled based on this date rather than product lead times. <br />
        /// </summary>
        [JsonProperty("commitment_date")]
        public DateTime? CommitmentDate { get; set; }

        /// <summary>
        /// date_order - datetime  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Creation date of draft/sent orders,; Confirmation date of confirmed orders. <br />
        /// </summary>
        [JsonProperty("date_order")]
        public DateTime DateOrder { get; set; }

        /// <summary>
        /// partner_invoice_id - many2one - res.partner <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("partner_invoice_id")]
        public long? PartnerInvoiceId { get; set; }

        /// <summary>
        /// partner_shipping_id - many2one - res.partner <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("partner_shipping_id")]
        public long? PartnerShippingId { get; set; }
     
        /// <summary>
        /// currency_id - many2one - res.currency <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("currency_id")]
        public long? CurrencyId { get; set; }

        /// <summary>
        /// order_line - one2many - sale.order.line (order_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("order_line")]
        public long[]? OrderLine { get; set; }

        /// <summary>
        /// invoice_ids - many2many - account.move <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("invoice_ids")]
        public long[]? InvoiceIds { get; set; }

        /// <summary>
        /// invoice_status - selection  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("invoice_status")]
        public InvoiceStatusSaleOrderOdooEnum? InvoiceStatus { get; set; }

        /// <summary>
        /// transaction_ids - many2many - payment.transaction <br />
        /// Required: False, Readonly: True, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("transaction_ids")]
        public long[]? TransactionIds { get; set; }

        /// <summary>
        /// analytic_account_id - many2one - account.analytic.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("analytic_account_id")]
        public long? AnalyticAccountId { get; set; }

        /// <summary>
        /// tag_ids - many2many - crm.tag <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("tag_ids")]
        public long[]? TagIds { get; set; }

        /// <summary>
        /// id - integer  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }

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
        /// write_uid - many2one - res.users <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        
        [JsonProperty("carrier_id")]
        public long? CarrierId { get; set; }

        /// <summary>
        /// idgroup - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("idgroup")]
        public string? Idgroup { get; set; }
        long IOdooModel.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusSaleOrderOdooEnum
    {
        [EnumMember(Value = "draft")]
        Quotation = 1,

        [EnumMember(Value = "sent")]
        QuotationSent = 2,

        [EnumMember(Value = "sale")]
        SalesOrder = 3,

        [EnumMember(Value = "done")]
        Locked = 4,

        [EnumMember(Value = "cancel")]
        Cancelled = 5,
    }

    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoiceStatusSaleOrderOdooEnum
    {
        [EnumMember(Value = "upselling")]
        UpsellingOpportunity = 1,

        [EnumMember(Value = "invoiced")]
        FullyInvoiced = 2,

        [EnumMember(Value = "to invoice")]
        ToInvoice = 3,

        [EnumMember(Value = "no")]
        NothingToInvoice = 4,
    }

    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeliveryStatusSaleOrderOdooEnum
    {
        [EnumMember(Value = "pending")]
        NotDelivered = 1,

        [EnumMember(Value = "partial")]
        PartiallyDelivered = 2,

        [EnumMember(Value = "full")]
        FullyDelivered = 3,

        [EnumMember(Value = "refused_by_logistics")]
        RefusedByLogistics = 4,

        [EnumMember(Value = "preparation_to_do")]
        PreparationToDoAcceptedByLogistics = 5,

        [EnumMember(Value = "cancelled_by_logistics")]
        CancelledByLogistics = 6,

        [EnumMember(Value = "preparation_in_progress")]
        PreparationInProgress = 7,

        [EnumMember(Value = "preparation_done")]
        PreparationDone = 8,

        [EnumMember(Value = "waiting_for_shipping")]
        WaitingForShipping = 9,
    }
}
