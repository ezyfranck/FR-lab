using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System.Runtime.Serialization;
using PortaCapena.OdooJsonRpcClient.Attributes;

namespace ConsoleApp3
{
    [OdooTableName("purchase.order")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class PurchaseOrderOdooModel : IOdooModel
    {

        /// <summary>
        /// activity_ids - one2many - mail.activity (res_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("activity_ids")]
        public long[]? ActivityIds { get; set; }

        /// <summary>
        /// activity_state - selection  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Status based on activities; Overdue: Due date is already passed; Today: Activity date is today; Planned: Future activities. <br />
        /// </summary>
        [JsonProperty("activity_state")]
        public ActivityStatePurchaseOrderOdooEnum? ActivityState { get; set; }

        /// <summary>
        /// activity_date_deadline - date  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("activity_date_deadline")]
        public DateTime? ActivityDateDeadline { get; set; }

        /// <summary>
        /// my_activity_date_deadline - date  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("my_activity_date_deadline")]
        public DateTime? MyActivityDateDeadline { get; set; }

        /// <summary>
        /// activity_exception_decoration - selection  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Type of the exception activity on record. <br />
        /// </summary>
        [JsonProperty("activity_exception_decoration")]
        public ActivityExceptionDecorationPurchaseOrderOdooEnum? ActivityExceptionDecoration { get; set; }

        /// <summary>
        /// activity_exception_icon - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Icon to indicate an exception activity. <br />
        /// </summary>
        [JsonProperty("activity_exception_icon")]
        public string? ActivityExceptionIcon { get; set; }

        /// <summary>
        /// access_url - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Customer Portal URL <br />
        /// </summary>
        [JsonProperty("access_url")]
        public string? AccessUrl { get; set; }

        /// <summary>
        /// access_token - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("access_token")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// access_warning - text  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("access_warning")]
        public string? AccessWarning { get; set; }

        /// <summary>
        /// message_is_follower - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_is_follower")]
        public bool? MessageIsFollower { get; set; }

        /// <summary>
        /// message_follower_ids - one2many - mail.followers (res_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_follower_ids")]
        public long[]? MessageFollowerIds { get; set; }

        /// <summary>
        /// message_partner_ids - many2many - res.partner <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_partner_ids")]
        public long[]? MessagePartnerIds { get; set; }

        /// <summary>
        /// message_channel_ids - many2many - mail.channel <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_channel_ids")]
        public long[]? MessageChannelIds { get; set; }

        /// <summary>
        /// message_ids - one2many - mail.message (res_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_ids")]
        public long[]? MessageIds { get; set; }

        /// <summary>
        /// message_unread - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: If checked, new messages require your attention. <br />
        /// </summary>
        [JsonProperty("message_unread")]
        public bool? MessageUnread { get; set; }

        /// <summary>
        /// message_unread_counter - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Number of unread messages <br />
        /// </summary>
        [JsonProperty("message_unread_counter")]
        public int? MessageUnreadCounter { get; set; }

        /// <summary>
        /// message_needaction - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: If checked, new messages require your attention. <br />
        /// </summary>
        [JsonProperty("message_needaction")]
        public bool? MessageNeedaction { get; set; }

        /// <summary>
        /// message_needaction_counter - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Number of messages which requires an action <br />
        /// </summary>
        [JsonProperty("message_needaction_counter")]
        public int? MessageNeedactionCounter { get; set; }

        /// <summary>
        /// message_has_error - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: If checked, some messages have a delivery error. <br />
        /// </summary>
        [JsonProperty("message_has_error")]
        public bool? MessageHasError { get; set; }

        /// <summary>
        /// message_has_error_counter - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Number of messages with delivery error <br />
        /// </summary>
        [JsonProperty("message_has_error_counter")]
        public int? MessageHasErrorCounter { get; set; }

        /// <summary>
        /// message_attachment_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_attachment_count")]
        public int? MessageAttachmentCount { get; set; }

        /// <summary>
        /// message_main_attachment_id - many2one - ir.attachment <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("message_main_attachment_id")]
        public long? MessageMainAttachmentId { get; set; }

        /// <summary>
        /// failed_message_ids - one2many - mail.message (res_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("failed_message_ids")]
        public long[]? FailedMessageIds { get; set; }

        /// <summary>
        /// website_message_ids - one2many - mail.message (res_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: Website communication history <br />
        /// </summary>
        [JsonProperty("website_message_ids")]
        public long[]? WebsiteMessageIds { get; set; }

        /// <summary>
        /// message_has_sms_error - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: If checked, some messages have a delivery error. <br />
        /// </summary>
        [JsonProperty("message_has_sms_error")]
        public bool? MessageHasSmsError { get; set; }

        /// <summary>
        /// name - char  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// priority - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("priority")]
        public PriorityPurchaseOrderOdooEnum? Priority { get; set; }

        /// <summary>
        /// partner_ref - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Reference of the sales order or bid sent by the vendor. It's used to do the matching when you receive the products as this reference is usually written on the delivery order sent by your vendor. <br />
        /// </summary>
        [JsonProperty("partner_ref")]
        public string? PartnerRef { get; set; }

        /// <summary>
        /// date_approve - datetime  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("date_approve")]
        public DateTime? DateApprove { get; set; }

        /// <summary>
        /// notes - text  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// invoice_count - integer  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("invoice_count")]
        public int? InvoiceCount { get; set; }

        /// <summary>
        /// invoice_ids - many2many - account.move <br />
        /// Required: False, Readonly: True, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("invoice_ids")]
        public long[]? InvoiceIds { get; set; }

        /// <summary>
        /// invoice_status - selection  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("invoice_status")]
        public BillingStatusPurchaseOrderOdooEnum? InvoiceStatus { get; set; }

        /// <summary>
        /// date_planned - datetime  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Delivery date promised by vendor. This date is used to determine expected arrival of products. <br />
        /// </summary>
        [JsonProperty("date_planned")]
        public DateTime? DatePlanned { get; set; }

        /// <summary>
        /// date_calendar_start - datetime  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("date_calendar_start")]
        public DateTime? DateCalendarStart { get; set; }

        /// <summary>
        /// amount_untaxed - monetary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("amount_untaxed")]
        public decimal? AmountUntaxed { get; set; }

        /// <summary>
        /// amount_tax - monetary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("amount_tax")]
        public decimal? AmountTax { get; set; }

        /// <summary>
        /// amount_total - monetary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("amount_total")]
        public decimal? AmountTotal { get; set; }

        /// <summary>
        /// fiscal_position_id - many2one - account.fiscal.position <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("fiscal_position_id")]
        public long? FiscalPositionId { get; set; }

        /// <summary>
        /// payment_term_id - many2one - account.payment.term <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("payment_term_id")]
        public long? PaymentTermId { get; set; }

        /// <summary>
        /// product_id - many2one - product.product <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_id")]
        public long? ProductId { get; set; }

        /// <summary>
        /// user_id - many2one - res.users <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        /// <summary>
        /// currency_rate - float  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: Ratio between the purchase order currency and the company currency <br />
        /// </summary>
        [JsonProperty("currency_rate")]
        public double? CurrencyRate { get; set; }

        /// <summary>
        /// mail_reminder_confirmed - boolean  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: True if the reminder email is confirmed by the vendor. <br />
        /// </summary>
        [JsonProperty("mail_reminder_confirmed")]
        public bool? MailReminderConfirmed { get; set; }

        /// <summary>
        /// mail_reception_confirmed - boolean  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: True if PO reception is confirmed by the vendor. <br />
        /// </summary>
        [JsonProperty("mail_reception_confirmed")]
        public bool? MailReceptionConfirmed { get; set; }

        /// <summary>
        /// receipt_reminder_email - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Automatically send a confirmation email to the vendor X days before the expected receipt date, asking him to confirm the exact date. <br />
        /// </summary>
        [JsonProperty("receipt_reminder_email")]
        public bool? ReceiptReminderEmail { get; set; }

        /// <summary>
        /// reminder_date_before_receipt - integer  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Number of days to send reminder email before the promised receipt date <br />
        /// </summary>
        [JsonProperty("reminder_date_before_receipt")]
        public int? ReminderDateBeforeReceipt { get; set; }

        /// <summary>
        /// account_payment_ids - one2many - account.payment (purchase_id) <br />
        /// Required: False, Readonly: True, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("account_payment_ids")]
        public long[]? AccountPaymentIds { get; set; }

        /// <summary>
        /// amount_residual - float  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("amount_residual")]
        public double? AmountResidual { get; set; }

        /// <summary>
        /// payment_line_ids - many2many - account.move.line <br />
        /// Required: False, Readonly: True, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("payment_line_ids")]
        public long[]? PaymentLineIds { get; set; }

        /// <summary>
        /// advance_payment_status - selection  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("advance_payment_status")]
        public AdvancePaymentStatusPurchaseOrderOdooEnum? AdvancePaymentStatus { get; set; }

        /// <summary>
        /// commercial_partner_id - many2one - res.partner <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("commercial_partner_id")]
        public long? CommercialPartnerId { get; set; }

        /// <summary>
        /// fop_reached - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Free-Of-Payment shipping reached <br />
        /// </summary>
        [JsonProperty("fop_reached")]
        public bool? FopReached { get; set; }

        /// <summary>
        /// force_order_under_fop - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Force confirm purchase order under Free-Of-Payment shipping <br />
        /// </summary>
        [JsonProperty("force_order_under_fop")]
        public bool? ForceOrderUnderFop { get; set; }

        /// <summary>
        /// fop_shipping - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Min purchase order amount for Free-Of-Payment shipping <br />
        /// </summary>
        [JsonProperty("fop_shipping")]
        public double? FopShipping { get; set; }

        /// <summary>
        /// force_invoiced - boolean  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: When you set this field, the purchase order will be considered as fully billed, even when there may be ordered or delivered quantities pending to bill. To use this field, the order must be in 'Locked' state <br />
        /// </summary>
        [JsonProperty("force_invoiced")]
        public bool? ForceInvoiced { get; set; }

        /// <summary>
        /// amount_uninvoiced - monetary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("amount_uninvoiced")]
        public decimal? AmountUninvoiced { get; set; }

        /// <summary>
        /// reception_status - selection  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("reception_status")]
        public ReceptionStatusPurchaseOrderOdooEnum? ReceptionStatus { get; set; }

        /// <summary>
        /// force_received - boolean  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: If true, the reception status will be forced to Fully Received, even if some lines are not fully received. To be able to modify this field, you must first lock the order. <br />
        /// </summary>
        [JsonProperty("force_received")]
        public bool? ForceReceived { get; set; }

        /// <summary>
        /// incoterm_id - many2one - account.incoterms <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: International Commercial Terms are a series of predefined commercial terms used in international transactions. <br />
        /// </summary>
        [JsonProperty("incoterm_id")]
        public long? IncotermId { get; set; }

        /// <summary>
        /// picking_count - integer  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("picking_count")]
        public int? PickingCount { get; set; }

        /// <summary>
        /// picking_ids - many2many - stock.picking <br />
        /// Required: False, Readonly: True, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("picking_ids")]
        public long[]? PickingIds { get; set; }

        /// <summary>
        /// default_location_dest_id_usage - selection  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Technical field used to display the Drop Ship Address <br />
        /// </summary>
        [JsonProperty("default_location_dest_id_usage")]
        public DestinationLocationTypePurchaseOrderOdooEnum? DefaultLocationDestIdUsage { get; set; }

        /// <summary>
        /// group_id - many2one - procurement.group <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("group_id")]
        public long? GroupId { get; set; }

        /// <summary>
        /// is_shipped - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("is_shipped")]
        public bool? IsShipped { get; set; }

        /// <summary>
        /// effective_date - datetime  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: Completion date of the first receipt order. <br />
        /// </summary>
        [JsonProperty("effective_date")]
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// on_time_rate - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Over the past x days; the number of products received on time divided by the number of ordered products.x is either the System Parameter purchase_stock.on_time_delivery_days or the default 365 <br />
        /// </summary>
        [JsonProperty("on_time_rate")]
        public double? OnTimeRate { get; set; }

        /// <summary>
        /// tag_ids - many2many - purchase.tag <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("tag_ids")]
        public long[]? TagIds { get; set; }

        /// <summary>
        /// supplier_partner_bank_id - many2one - res.partner.bank <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Select the bank account of your supplier on which your company should send the payment. This field is copied from the partner and will be copied to the supplier invoice. <br />
        /// </summary>
        [JsonProperty("supplier_partner_bank_id")]
        public long? SupplierPartnerBankId { get; set; }

        /// <summary>
        /// payment_mode_id - many2one - account.payment.mode <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("payment_mode_id")]
        public long? PaymentModeId { get; set; }

        /// <summary>
        /// subcontract_production_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("subcontract_production_count")]
        public int? SubcontractProductionCount { get; set; }

        /// <summary>
        /// subcontract_production_ids - one2many - mrp.production (purchase_order_id) <br />
        /// Required: False, Readonly: True, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("subcontract_production_ids")]
        public long[]? SubcontractProductionIds { get; set; }

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
        /// mrp_production_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("mrp_production_count")]
        public int? MrpProductionCount { get; set; }

        /// <summary>
        /// state - selection  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("state")]
        public StatusPurchaseOrderOdooEnum? State { get; set; }

        /// <summary>
        /// origin - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Reference of the document that generated this purchase order request (e.g. a sales order) <br />
        /// </summary>
        [JsonProperty("origin")]
        public string? Origin { get; set; }

        /// <summary>
        /// date_order - datetime  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Depicts the date within which the Quotation should be confirmed and converted into a purchase order. <br />
        /// </summary>
        [JsonProperty("date_order")]
        public DateTime DateOrder { get; set; }

        /// <summary>
        /// partner_id - many2one - res.partner <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: You can find a vendor by its Name, TIN, Email or Internal Reference. <br />
        /// </summary>
        [JsonProperty("partner_id")]
        public long PartnerId { get; set; }

        /// <summary>
        /// dest_address_id - many2one - res.partner <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Put an address if you want to deliver directly from the vendor to the customer. Otherwise, keep empty to deliver to your own company. <br />
        /// </summary>
        [JsonProperty("dest_address_id")]
        public long? DestAddressId { get; set; }

        /// <summary>
        /// currency_id - many2one - res.currency <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("currency_id")]
        public long CurrencyId { get; set; }

        /// <summary>
        /// order_line - one2many - purchase.order.line (order_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("order_line")]
        public long[]? OrderLine { get; set; }

        /// <summary>
        /// company_id - many2one - res.company <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("company_id")]
        public long CompanyId { get; set; }

        /// <summary>
        /// picking_type_id - many2one - stock.picking.type <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: This will determine operation type of incoming shipment <br />
        /// </summary>
        [JsonProperty("picking_type_id")]
        public long PickingTypeId { get; set; }

        /// <summary>
        /// incoterm_address_id - many2one - res.partner <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Address where goods responsibility is transferred to the buyer <br />
        /// </summary>
        [JsonProperty("incoterm_address_id")]
        public long? IncotermAddressId { get; set; }

        /// <summary>
        /// picking_state - selection  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: Overall status based on all pickings <br />
        /// </summary>
        [JsonProperty("picking_state")]
        public PickingStatusPurchaseOrderOdooEnum? PickingState { get; set; }

        /// <summary>
        /// invoice_refund_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("invoice_refund_count")]
        public int? InvoiceRefundCount { get; set; }

        /// <summary>
        /// sale_order_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("sale_order_count")]
        public int? SaleOrderCount { get; set; }

        /// <summary>
        /// subcontracting_resupply_picking_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Count of Subcontracting Resupply for component <br />
        /// </summary>
        [JsonProperty("subcontracting_resupply_picking_count")]
        public int? SubcontractingResupplyPickingCount { get; set; }

        /// <summary>
        /// activity_user_id - many2one - res.users <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("activity_user_id")]
        public long? ActivityUserId { get; set; }

        /// <summary>
        /// activity_type_id - many2one - mail.activity.type <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("activity_type_id")]
        public long? ActivityTypeId { get; set; }

        /// <summary>
        /// activity_type_icon - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Font awesome icon e.g. fa-tasks <br />
        /// </summary>
        [JsonProperty("activity_type_icon")]
        public string? ActivityTypeIcon { get; set; }

        /// <summary>
        /// activity_summary - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("activity_summary")]
        public string? ActivitySummary { get; set; }

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
    /// Help: Status based on activities <br />
    /// Overdue: Due date is already passed <br />
    /// Today: Activity date is today <br />
    /// Planned: Future activities.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActivityStatePurchaseOrderOdooEnum
    {
        [EnumMember(Value = "overdue")]
        Overdue = 1,

        [EnumMember(Value = "today")]
        Today = 2,

        [EnumMember(Value = "planned")]
        Planned = 3,
    }


    /// <summary>
    /// Help: Type of the exception activity on record.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActivityExceptionDecorationPurchaseOrderOdooEnum
    {
        [EnumMember(Value = "warning")]
        Alert = 1,

        [EnumMember(Value = "danger")]
        Error = 2,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PriorityPurchaseOrderOdooEnum
    {
        [EnumMember(Value = "0")]
        Normal = 1,

        [EnumMember(Value = "1")]
        Urgent = 2,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BillingStatusPurchaseOrderOdooEnum
    {
        [EnumMember(Value = "no")]
        NothingToBill = 1,

        [EnumMember(Value = "to invoice")]
        WaitingBills = 2,

        [EnumMember(Value = "invoiced")]
        FullyBilled = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AdvancePaymentStatusPurchaseOrderOdooEnum
    {
        [EnumMember(Value = "not_paid")]
        NotPaid = 1,

        [EnumMember(Value = "paid")]
        Paid = 2,

        [EnumMember(Value = "partial")]
        PartiallyPaid = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReceptionStatusPurchaseOrderOdooEnum
    {
        [EnumMember(Value = "no")]
        NothingReceived = 1,

        [EnumMember(Value = "partial")]
        PartiallyReceived = 2,

        [EnumMember(Value = "received")]
        FullyReceived = 3,
    }


    /// <summary>
    /// Help: Technical field used to display the Drop Ship Address
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DestinationLocationTypePurchaseOrderOdooEnum
    {
        [EnumMember(Value = "supplier")]
        VendorLocation = 1,

        [EnumMember(Value = "view")]
        View = 2,

        [EnumMember(Value = "internal")]
        InternalLocation = 3,

        [EnumMember(Value = "customer")]
        CustomerLocation = 4,

        [EnumMember(Value = "inventory")]
        InventoryLoss = 5,

        [EnumMember(Value = "production")]
        Production = 6,

        [EnumMember(Value = "transit")]
        TransitLocation = 7,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusPurchaseOrderOdooEnum
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
    /// Help: Overall status based on all pickings
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PickingStatusPurchaseOrderOdooEnum
    {
        [EnumMember(Value = "draft")]
        None = 1,

        [EnumMember(Value = "cancel")]
        Cancelled = 2,

        [EnumMember(Value = "not_received")]
        NotReceived = 3,

        [EnumMember(Value = "partially_received")]
        PartiallyReceived = 4,

        [EnumMember(Value = "done")]
        Transferred = 5,
    }

}
