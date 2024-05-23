using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System.Runtime.Serialization;
using PortaCapena.OdooJsonRpcClient.Attributes;

namespace ConsoleApp3
{
    [OdooTableName("purchase.order.line")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class PurchaseOrderLineOdooModel : IOdooModel
    {

        /// <summary>
        /// name - text  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// sequence - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        /// <summary>
        /// product_qty - float  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("product_qty")]
        public double ProductQty { get; set; }

        /// <summary>
        /// product_uom_qty - float  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("product_uom_qty")]
        public double? ProductUomQty { get; set; }

        /// <summary>
        /// date_planned - datetime  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Delivery date expected from vendor. This date respectively defaults to vendor pricelist lead time then today's date. <br />
        /// </summary>
        [JsonProperty("date_planned")]
        public DateTime? DatePlanned { get; set; }

        /// <summary>
        /// taxes_id - many2many - account.tax <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("taxes_id")]
        public long[]? TaxesId { get; set; }

        /// <summary>
        /// product_uom - many2one - uom.uom <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("product_uom")]
        public long? ProductUom { get; set; }

        /// <summary>
        /// product_uom_category_id - many2one - uom.category <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Conversion between Units of Measure can only occur if they belong to the same category. The conversion will be made based on the ratios. <br />
        /// </summary>
        [JsonProperty("product_uom_category_id")]
        public long? ProductUomCategoryId { get; set; }

        /// <summary>
        /// product_id - many2one - product.product <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("product_id")]
        public long? ProductId { get; set; }

        /// <summary>
        /// price_unit - float  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("price_unit")]
        public double PriceUnit { get; set; }

        /// <summary>
        /// price_subtotal - monetary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("price_subtotal")]
        public decimal? PriceSubtotal { get; set; }

        /// <summary>
        /// price_total - monetary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("price_total")]
        public decimal? PriceTotal { get; set; }

        /// <summary>
        /// price_tax - float  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("price_tax")]
        public double? PriceTax { get; set; }

        /// <summary>
        /// order_id - many2one - purchase.order <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("order_id")]
        public long OrderId { get; set; }

        /// <summary>
        /// account_analytic_id - many2one - account.analytic.account <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("account_analytic_id")]
        public long? AccountAnalyticId { get; set; }

        /// <summary>
        /// analytic_tag_ids - many2many - account.analytic.tag <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("analytic_tag_ids")]
        public long[]? AnalyticTagIds { get; set; }

        /// <summary>
        /// company_id - many2one - res.company <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

        /// <summary>
        /// state - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("state")]
        public StatusPurchaseOrderLineOdooEnum? State { get; set; }

        /// <summary>
        /// invoice_lines - one2many - account.move.line (purchase_line_id) <br />
        /// Required: False, Readonly: True, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("invoice_lines")]
        public long[]? InvoiceLines { get; set; }

        /// <summary>
        /// qty_invoiced - float  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("qty_invoiced")]
        public double? QtyInvoiced { get; set; }

        /// <summary>
        /// qty_received - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("qty_received")]
        public double? QtyReceived { get; set; }

        /// <summary>
        /// qty_received_manual - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("qty_received_manual")]
        public double? QtyReceivedManual { get; set; }

        /// <summary>
        /// qty_to_invoice - float  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("qty_to_invoice")]
        public double? QtyToInvoice { get; set; }

        /// <summary>
        /// partner_id - many2one - res.partner <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: You can find a vendor by its Name, TIN, Email or Internal Reference. <br />
        /// </summary>
        [JsonProperty("partner_id")]
        public long? PartnerId { get; set; }

        /// <summary>
        /// currency_id - many2one - res.currency <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("currency_id")]
        public long? CurrencyId { get; set; }

        /// <summary>
        /// date_order - datetime  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Depicts the date within which the Quotation should be confirmed and converted into a purchase order. <br />
        /// </summary>
        [JsonProperty("date_order")]
        public DateTime? DateOrder { get; set; }

        /// <summary>
        /// display_type - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Technical field for UX purpose. <br />
        /// </summary>
        [JsonProperty("display_type")]
        public DisplayTypePurchaseOrderLineOdooEnum? DisplayType { get; set; }

        /// <summary>
        /// product_supplier_code - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("product_supplier_code")]
        public string? ProductSupplierCode { get; set; }

        /// <summary>
        /// is_deposit - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Deposit payments are made when creating bills from a purhcase order. They are not copied when duplicating a purchase order. <br />
        /// </summary>
        [JsonProperty("is_deposit")]
        public bool? IsDeposit { get; set; }

        /// <summary>
        /// qty_received_method - selection  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: According to product configuration, the received quantity can be automatically computed by mechanism :;   - Manual: the quantity is set manually on the line;   - Stock Moves: the quantity comes from confirmed pickings;  <br />
        /// </summary>
        [JsonProperty("qty_received_method")]
        public ReceivedQtyMethodPurchaseOrderLineOdooEnum? QtyReceivedMethod { get; set; }

        /// <summary>
        /// move_ids - one2many - stock.move (purchase_line_id) <br />
        /// Required: False, Readonly: True, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("move_ids")]
        public long[]? MoveIds { get; set; }

        /// <summary>
        /// orderpoint_id - many2one - stock.warehouse.orderpoint <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("orderpoint_id")]
        public long? OrderpointId { get; set; }

        /// <summary>
        /// move_dest_ids - one2many - stock.move (created_purchase_line_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("move_dest_ids")]
        public long[]? MoveDestIds { get; set; }

        /// <summary>
        /// product_description_variants - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("product_description_variants")]
        public string? ProductDescriptionVariants { get; set; }

        /// <summary>
        /// propagate_cancel - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("propagate_cancel")]
        public bool? PropagateCancel { get; set; }

        /// <summary>
        /// supplier_date_planned - datetime  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("supplier_date_planned")]
        public DateTime? SupplierDatePlanned { get; set; }

        /// <summary>
        /// report_date_planned - datetime  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("report_date_planned")]
        public DateTime? ReportDatePlanned { get; set; }

        /// <summary>
        /// last_date_received - datetime  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("last_date_received")]
        public DateTime? LastDateReceived { get; set; }

        /// <summary>
        /// last_bill_date - datetime  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("last_bill_date")]
        public DateTime? LastBillDate { get; set; }

        /// <summary>
        /// uigr_qty - float  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("uigr_qty")]
        public double? UigrQty { get; set; }

        /// <summary>
        /// bo_qty - float  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("bo_qty")]
        public double? BoQty { get; set; }

        /// <summary>
        /// uigr_value - monetary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("uigr_value")]
        public decimal? UigrValue { get; set; }

        /// <summary>
        /// bo_value - monetary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("bo_value")]
        public decimal? BoValue { get; set; }

        /// <summary>
        /// product_type - selection  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: A storable product is a product for which you manage stock. The Inventory app has to be installed.; A consumable product is a product for which stock is not managed.; A service is a non-material product you provide. <br />
        /// </summary>
        [JsonProperty("product_type")]
        public ProductTypePurchaseOrderLineOdooEnum? ProductType { get; set; }

        /// <summary>
        /// discount - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("discount")]
        public double? Discount { get; set; }

        /// <summary>
        /// qty_refunded - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("qty_refunded")]
        public double? QtyRefunded { get; set; }

        /// <summary>
        /// qty_returned - float  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: This is ONLY the returned quantity that is refundable. <br />
        /// </summary>
        [JsonProperty("qty_returned")]
        public double? QtyReturned { get; set; }

        /// <summary>
        /// sale_order_id - many2one - sale.order <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("sale_order_id")]
        public long? SaleOrderId { get; set; }

        /// <summary>
        /// sale_line_id - many2one - sale.order.line <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("sale_line_id")]
        public long? SaleLineId { get; set; }

        /// <summary>
        /// orderpoint_ids - many2many - stock.warehouse.orderpoint <br />
        /// Required: False, Readonly: True, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("orderpoint_ids")]
        public long[]? OrderpointIds { get; set; }

        /// <summary>
        /// id - integer  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

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
        /// __last_update - datetime  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("__last_update")]
        public DateTime? LastUpdate { get; set; }
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusPurchaseOrderLineOdooEnum
    {
        [EnumMember(Value = "draft")]
        RFQ = 1,

        [EnumMember(Value = "sent")]
        RFQSent = 2,

        [EnumMember(Value = "to approve")]
        ToApprove = 3,

        [EnumMember(Value = "approved")]
        Approved = 4,

        [EnumMember(Value = "purchase")]
        PurchaseOrder = 5,

        [EnumMember(Value = "done")]
        Locked = 6,

        [EnumMember(Value = "cancel")]
        Cancelled = 7,
    }


    /// <summary>
    /// Help: Technical field for UX purpose.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DisplayTypePurchaseOrderLineOdooEnum
    {
        [EnumMember(Value = "line_section")]
        Section = 1,

        [EnumMember(Value = "line_note")]
        Note = 2,
    }


    /// <summary>
    /// Help: According to product configuration, the received quantity can be automatically computed by mechanism : <br />
    ///   - Manual: the quantity is set manually on the line <br />
    ///   - Stock Moves: the quantity comes from confirmed pickings <br />
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReceivedQtyMethodPurchaseOrderLineOdooEnum
    {
        [EnumMember(Value = "manual")]
        Manual = 1,

        [EnumMember(Value = "stock_moves")]
        StockMoves = 2,
    }


    /// <summary>
    /// Help: A storable product is a product for which you manage stock. The Inventory app has to be installed. <br />
    /// A consumable product is a product for which stock is not managed. <br />
    /// A service is a non-material product you provide.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductTypePurchaseOrderLineOdooEnum
    {
        [EnumMember(Value = "consu")]
        Consumable = 1,

        [EnumMember(Value = "service")]
        Service = 2,

        [EnumMember(Value = "product")]
        StorableProduct = 3,
    }
}
