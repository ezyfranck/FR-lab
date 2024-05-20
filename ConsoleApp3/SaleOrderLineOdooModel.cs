using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System.Runtime.Serialization;
using PortaCapena.OdooJsonRpcClient.Attributes;

namespace ConsoleApp3
{
    [OdooTableName("sale.order.line")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class SaleOrderLineOdooModel : IOdooModel
    {

        /// <summary>
        /// analytic_distribution - json  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("analytic_distribution")]
        public string? AnalyticDistribution { get; set; }

        /// <summary>
        /// analytic_distribution_search - json  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("analytic_distribution_search")]
        public string? AnalyticDistributionSearch { get; set; }

        /// <summary>
        /// analytic_precision - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("analytic_precision")]
        public int? AnalyticPrecision { get; set; }

        /// <summary>
        /// order_id - many2one - sale.order <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("order_id")]
        public long? OrderId { get; set; }

        /// <summary>
        /// sequence - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        /// <summary>
        /// company_id - many2one - res.company <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

        /// <summary>
        /// currency_id - many2one - res.currency <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("currency_id")]
        public long? CurrencyId { get; set; }

        /// <summary>
        /// order_partner_id - many2one - res.partner <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("order_partner_id")]
        public long? OrderPartnerId { get; set; }

        /// <summary>
        /// salesman_id - many2one - res.users <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("salesman_id")]
        public long? SalesmanId { get; set; }

        /// <summary>
        /// state - selection  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("state")]
        public OrderStatusSaleOrderLineOdooEnum? State { get; set; }

        /// <summary>
        /// display_type - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("display_type")]
        public DisplayTypeSaleOrderLineOdooEnum? DisplayType { get; set; }

        /// <summary>
        /// is_downpayment - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Down payments are made when creating invoices from a sales order. They are not copied when duplicating a sales order. <br />
        /// </summary>
        [JsonProperty("is_downpayment")]
        public bool? IsDownpayment { get; set; }

        /// <summary>
        /// is_expense - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Is true if the sales order line comes from an expense or a vendor bills <br />
        /// </summary>
        [JsonProperty("is_expense")]
        public bool? IsExpense { get; set; }

        /// <summary>
        /// product_id - many2one - product.product <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("product_id")]
        public long? ProductId { get; set; }

        /// <summary>
        /// product_template_id - many2one - product.template <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_template_id")]
        public long? ProductTemplateId { get; set; }

        /// <summary>
        /// product_uom_category_id - many2one - uom.category <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Conversion between Units of Measure can only occur if they belong to the same category. The conversion will be made based on the ratios. <br />
        /// </summary>
        [JsonProperty("product_uom_category_id")]
        public long? ProductUomCategoryId { get; set; }

        /// <summary>
        /// product_custom_attribute_value_ids - one2many - product.attribute.custom.value (sale_order_line_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_custom_attribute_value_ids")]
        public long[]? ProductCustomAttributeValueIds { get; set; }

        /// <summary>
        /// product_no_variant_attribute_value_ids - many2many - product.template.attribute.value <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_no_variant_attribute_value_ids")]
        public long[]? ProductNoVariantAttributeValueIds { get; set; }

        /// <summary>
        /// name - text  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// product_uom_qty - float  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("product_uom_qty")]
        public double ProductUomQty { get; set; }

        /// <summary>
        /// product_uom - many2one - uom.uom <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("product_uom")]
        public long? ProductUom { get; set; }

        /// <summary>
        /// tax_id - many2many - account.tax <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("tax_id")]
        public long[]? TaxId { get; set; }

        /// <summary>
        /// pricelist_item_id - many2one - product.pricelist.item <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("pricelist_item_id")]
        public long? PricelistItemId { get; set; }

        /// <summary>
        /// price_unit - float  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("price_unit")]
        public double? PriceUnitpublic { get; set; }

        /// <summary>
        /// discount - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("discount")]
        public double? Discount { get; set; }

        /// <summary>
        /// price_reduce - float  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("price_reduce")]
        public double? PriceReduce { get; set; }

        /// <summary>
        /// price_subtotal - monetary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("price_subtotal")]
        public decimal? PriceSubtotal { get; set; }

        /// <summary>
        /// price_tax - float  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("price_tax")]
        public double? PriceTax { get; set; }

        /// <summary>
        /// price_total - monetary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("price_total")]
        public decimal? PriceTotal { get; set; }

        /// <summary>
        /// price_reduce_taxexcl - monetary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("price_reduce_taxexcl")]
        public decimal? PriceReduceTaxexcl { get; set; }

        /// <summary>
        /// price_reduce_taxinc - monetary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("price_reduce_taxinc")]
        public decimal? PriceReduceTaxinc { get; set; }

        /// <summary>
        /// product_packaging_id - many2one - product.packaging <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("product_packaging_id")]
        public long? ProductPackagingId { get; set; }

        /// <summary>
        /// product_packaging_qty - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("product_packaging_qty")]
        public double? ProductPackagingQty { get; set; }

        /// <summary>
        /// customer_lead - float  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Number of days between the order confirmation and the shipping of the products to the customer <br />
        /// </summary>
        [JsonProperty("customer_lead")]
        public double? CustomerLead { get; set; }

        /// <summary>
        /// qty_delivered_method - selection  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: According to product configuration, the delivered quantity can be automatically computed by mechanism :;   - Manual: the quantity is set manually on the line;   - Analytic From expenses: the quantity is the quantity sum from posted expenses;   - Timesheet: the quantity is the sum of hours recorded on tasks linked to this sale line;   - Stock Moves: the quantity comes from confirmed pickings;  <br />
        /// </summary>
        [JsonProperty("qty_delivered_method")]
        public MethodToUpdateDeliveredQtySaleOrderLineOdooEnum? QtyDeliveredMethod { get; set; }

        /// <summary>
        /// qty_delivered - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("qty_delivered")]
        public double? QtyDelivered { get; set; }

        /// <summary>
        /// qty_invoiced - float  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("qty_invoiced")]
        public double? QtyInvoiced { get; set; }

        /// <summary>
        /// qty_to_invoice - float  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("qty_to_invoice")]
        public double? QtyToInvoice { get; set; }

        /// <summary>
        /// analytic_line_ids - one2many - account.analytic.line (so_line) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("analytic_line_ids")]
        public long[]? AnalyticLineIds { get; set; }

        /// <summary>
        /// invoice_lines - many2many - account.move.line <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("invoice_lines")]
        public long[]? InvoiceLines { get; set; }

        /// <summary>
        /// invoice_status - selection  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("invoice_status")]
        public InvoiceStatusSaleOrderLineOdooEnum? InvoiceStatus { get; set; }

        /// <summary>
        /// untaxed_amount_invoiced - monetary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("untaxed_amount_invoiced")]
        public decimal? UntaxedAmountInvoiced { get; set; }

        /// <summary>
        /// untaxed_amount_to_invoice - monetary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("untaxed_amount_to_invoice")]
        public decimal? UntaxedAmountToInvoice { get; set; }

        /// <summary>
        /// product_type - selection  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: A storable product is a product for which you manage stock. The Inventory app has to be installed.; A consumable product is a product for which stock is not managed.; A service is a non-material product you provide. <br />
        /// </summary>
        [JsonProperty("product_type")]
        public ProductTypeSaleOrderLineOdooEnum? ProductType { get; set; }

        /// <summary>
        /// product_updatable - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_updatable")]
        public bool? ProductUpdatable { get; set; }

        /// <summary>
        /// product_uom_readonly - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_uom_readonly")]
        public bool? ProductUomReadonly { get; set; }

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
        /// exception_ids - many2many - exception.rule <br />
        /// Required: False, Readonly: True, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("exception_ids")]
        public long[]? ExceptionIds { get; set; }

        /// <summary>
        /// exceptions_summary - html  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("exceptions_summary")]
        public string? ExceptionsSummary { get; set; }

        /// <summary>
        /// ignore_exception - boolean  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("ignore_exception")]
        public bool? IgnoreException { get; set; }

        /// <summary>
        /// is_exception_danger - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("is_exception_danger")]
        public bool? IsExceptionDanger { get; set; }

        /// <summary>
        /// is_reward_line - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("is_reward_line")]
        public bool? IsRewardLine { get; set; }

        /// <summary>
        /// reward_id - many2one - loyalty.reward <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("reward_id")]
        public long? RewardId { get; set; }

        /// <summary>
        /// coupon_id - many2one - loyalty.card <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("coupon_id")]
        public long? CouponId { get; set; }

        /// <summary>
        /// reward_identifier_code - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: ;         Technical field used to link multiple reward lines from the same reward together.;      <br />
        /// </summary>
        [JsonProperty("reward_identifier_code")]
        public string? RewardIdentifierCode { get; set; }

        /// <summary>
        /// points_cost - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: How much point this reward cost on the loyalty card. <br />
        /// </summary>
        [JsonProperty("points_cost")]
        public double? PointsCost { get; set; }

        /// <summary>
        /// sale_order_option_ids - one2many - sale.order.option (line_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("sale_order_option_ids")]
        public long[]? SaleOrderOptionIds { get; set; }

        /// <summary>
        /// is_configurable_product - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("is_configurable_product")]
        public bool? IsConfigurableProduct { get; set; }

        /// <summary>
        /// product_template_attribute_value_ids - many2many - product.template.attribute.value <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_template_attribute_value_ids")]
        public long[]? ProductTemplateAttributeValueIds { get; set; }

        /// <summary>
        /// purchase_line_ids - one2many - purchase.order.line (sale_line_id) <br />
        /// Required: False, Readonly: True, Store: True, Sortable: False <br />
        /// Help: Purchase line generated by this Sales item on order confirmation, or when the quantity was increased. <br />
        /// </summary>
        [JsonProperty("purchase_line_ids")]
        public long[]? PurchaseLineIds { get; set; }

        /// <summary>
        /// purchase_line_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("purchase_line_count")]
        public int? PurchaseLineCount { get; set; }

        /// <summary>
        /// route_id - many2one - stock.route <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("route_id")]
        public long? RouteId { get; set; }

        /// <summary>
        /// move_ids - one2many - stock.move (sale_line_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("move_ids")]
        public long[]? MoveIds { get; set; }

        /// <summary>
        /// virtual_available_at_date - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("virtual_available_at_date")]
        public double? VirtualAvailableAtDate { get; set; }

        /// <summary>
        /// scheduled_date - datetime  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("scheduled_date")]
        public DateTime? ScheduledDate { get; set; }

        /// <summary>
        /// forecast_expected_date - datetime  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("forecast_expected_date")]
        public DateTime? ForecastExpectedDate { get; set; }

        /// <summary>
        /// free_qty_today - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("free_qty_today")]
        public double? FreeQtyToday { get; set; }

        /// <summary>
        /// qty_available_today - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("qty_available_today")]
        public double? QtyAvailableToday { get; set; }

        /// <summary>
        /// warehouse_id - many2one - stock.warehouse <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("warehouse_id")]
        public long? WarehouseId { get; set; }

        /// <summary>
        /// qty_to_deliver - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("qty_to_deliver")]
        public double? QtyToDeliver { get; set; }

        /// <summary>
        /// is_mto - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("is_mto")]
        public bool? IsMto { get; set; }

        /// <summary>
        /// display_qty_widget - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("display_qty_widget")]
        public bool? DisplayQtyWidget { get; set; }

        /// <summary>
        /// linked_line_id - many2one - sale.order.line <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("linked_line_id")]
        public long? LinkedLineId { get; set; }

        /// <summary>
        /// option_line_ids - one2many - sale.order.line (linked_line_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("option_line_ids")]
        public long[]? OptionLineIds { get; set; }

        /// <summary>
        /// name_short - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("name_short")]
        public string? NameShort { get; set; }

        /// <summary>
        /// shop_warning - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("shop_warning")]
        public string? ShopWarning { get; set; }

        /// <summary>
        /// is_delivery - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("is_delivery")]
        public bool? IsDelivery { get; set; }

        /// <summary>
        /// product_qty - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_qty")]
        public double? ProductQty { get; set; }

        /// <summary>
        /// recompute_delivery_price - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("recompute_delivery_price")]
        public bool? RecomputeDeliveryPrice { get; set; }

        /// <summary>
        /// pos_order_line_ids - one2many - pos.order.line (sale_order_line_id) <br />
        /// Required: False, Readonly: True, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("pos_order_line_ids")]
        public long[]? PosOrderLineIds { get; set; }

        /// <summary>
        /// product_add_mode - selection  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Configurator: choose attribute values to add the matching product variant to the order.; Grid: add several variants at once from the grid of attribute values <br />
        /// </summary>
        [JsonProperty("product_add_mode")]
        public AddProductModeSaleOrderLineOdooEnum? ProductAddMode { get; set; }

        /// <summary>
        /// project_id - many2one - project.project <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("project_id")]
        public long? ProjectId { get; set; }

        /// <summary>
        /// task_id - many2one - project.task <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("task_id")]
        public long? TaskId { get; set; }

        /// <summary>
        /// is_service - boolean  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("is_service")]
        public bool? IsService { get; set; }

        /// <summary>
        /// reached_milestones_ids - one2many - project.milestone (sale_line_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("reached_milestones_ids")]
        public long[]? ReachedMilestonesIds { get; set; }
        long IOdooModel.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderStatusSaleOrderLineOdooEnum
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
    public enum DisplayTypeSaleOrderLineOdooEnum
    {
        [EnumMember(Value = "line_section")]
        Section = 1,

        [EnumMember(Value = "line_note")]
        Note = 2,
    }


    /// <summary>
    /// Help: According to product configuration, the delivered quantity can be automatically computed by mechanism : <br />
    ///   - Manual: the quantity is set manually on the line <br />
    ///   - Analytic From expenses: the quantity is the quantity sum from posted expenses <br />
    ///   - Timesheet: the quantity is the sum of hours recorded on tasks linked to this sale line <br />
    ///   - Stock Moves: the quantity comes from confirmed pickings <br />
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MethodToUpdateDeliveredQtySaleOrderLineOdooEnum
    {
        [EnumMember(Value = "manual")]
        Manual = 1,

        [EnumMember(Value = "analytic")]
        AnalyticFromExpenses = 2,

        [EnumMember(Value = "stock_move")]
        StockMoves = 3,

        [EnumMember(Value = "milestones")]
        Milestones = 4,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoiceStatusSaleOrderLineOdooEnum
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
    /// Help: A storable product is a product for which you manage stock. The Inventory app has to be installed. <br />
    /// A consumable product is a product for which stock is not managed. <br />
    /// A service is a non-material product you provide.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductTypeSaleOrderLineOdooEnum
    {
        [EnumMember(Value = "consu")]
        Consumable = 1,

        [EnumMember(Value = "service")]
        Service = 2,

        [EnumMember(Value = "product")]
        StorableProduct = 3,
    }


    /// <summary>
    /// Help: Configurator: choose attribute values to add the matching product variant to the order. <br />
    /// Grid: add several variants at once from the grid of attribute values
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AddProductModeSaleOrderLineOdooEnum
    {
        [EnumMember(Value = "configurator")]
        ProductConfigurator = 1,

        [EnumMember(Value = "matrix")]
        OrderGridEntry = 2,
    }
}
