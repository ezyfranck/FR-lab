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
        /// main_exception_id - many2one - exception.rule <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("main_exception_id")]
        public long? MainExceptionId { get; set; }

        /// <summary>
        /// exceptions_summary - html  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("exceptions_summary")]
        public string? ExceptionsSummary { get; set; }

        /// <summary>
        /// exception_ids - many2many - exception.rule <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("exception_ids")]
        public long[]? ExceptionIds { get; set; }

        /// <summary>
        /// ignore_exception - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("ignore_exception")]
        public bool? IgnoreException { get; set; }

        /// <summary>
        /// campaign_id - many2one - utm.campaign <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: This is a name that helps you keep track of your different campaign efforts, e.g. Fall_Drive, Christmas_Special <br />
        /// </summary>
        [JsonProperty("campaign_id")]
        public long? CampaignId { get; set; }

        /// <summary>
        /// source_id - many2one - utm.source <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: This is the source of the link, e.g. Search Engine, another domain, or name of email list <br />
        /// </summary>
        [JsonProperty("source_id")]
        public long? SourceId { get; set; }

        /// <summary>
        /// medium_id - many2one - utm.medium <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: This is the method of delivery, e.g. Postcard, Email, or Banner Ad <br />
        /// </summary>
        [JsonProperty("medium_id")]
        public long? MediumId { get; set; }

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
        public ActivityStateSaleOrderOdooEnum? ActivityState { get; set; }

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
        /// activity_summary - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("activity_summary")]
        public string? ActivitySummary { get; set; }

        /// <summary>
        /// activity_exception_decoration - selection  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Type of the exception activity on record. <br />
        /// </summary>
        [JsonProperty("activity_exception_decoration")]
        public ActivityExceptionDecorationSaleOrderOdooEnum? ActivityExceptionDecoration { get; set; }

        /// <summary>
        /// activity_exception_icon - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Icon to indicate an exception activity. <br />
        /// </summary>
        [JsonProperty("activity_exception_icon")]
        public string? ActivityExceptionIcon { get; set; }

        /// <summary>
        /// activity_calendar_event_id - many2one - calendar.event <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("activity_calendar_event_id")]
        public long? ActivityCalendarEventId { get; set; }

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
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_partner_ids")]
        public long[]? MessagePartnerIds { get; set; }

        /// <summary>
        /// message_ids - one2many - mail.message (res_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("message_ids")]
        public long[]? MessageIds { get; set; }

        /// <summary>
        /// has_message - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("has_message")]
        public bool? HasMessage { get; set; }

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
        /// Help: Number of messages requiring action <br />
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
        /// client_order_ref - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("client_order_ref")]
        public string? ClientOrderRef { get; set; }

        /// <summary>
        /// create_date - datetime  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("create_date")]
        public DateTime? CreateDate { get; set; }

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
        /// origin - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Reference of the document that generated this sales order request <br />
        /// </summary>
        [JsonProperty("origin")]
        public string? Origin { get; set; }

        /// <summary>
        /// reference - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: The payment communication of this sale order. <br />
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference { get; set; }

        /// <summary>
        /// require_signature - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Request a online signature and/or payment to the customer in order to confirm orders automatically. <br />
        /// </summary>
        [JsonProperty("require_signature")]
        public bool? RequireSignature { get; set; }

        /// <summary>
        /// require_payment - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("require_payment")]
        public bool? RequirePayment { get; set; }

        /// <summary>
        /// signature - binary  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// signed_by - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("signed_by")]
        public string? SignedBy { get; set; }

        /// <summary>
        /// signed_on - datetime  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("signed_on")]
        public DateTime? SignedOn { get; set; }

        /// <summary>
        /// validity_date - date  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("validity_date")]
        public DateTime? ValidityDate { get; set; }

        /// <summary>
        /// note - html  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("note")]
        public string? Note { get; set; }

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
        /// fiscal_position_id - many2one - account.fiscal.position <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Fiscal positions are used to adapt taxes and accounts for particular customers or sales orders/invoices.The default value comes from the customer. <br />
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
        /// pricelist_id - many2one - product.pricelist <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: If you change the pricelist, only newly added lines will be affected. <br />
        /// </summary>
        [JsonProperty("pricelist_id")]
        public long? PricelistId { get; set; }

        /// <summary>
        /// currency_id - many2one - res.currency <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("currency_id")]
        public long? CurrencyId { get; set; }

        /// <summary>
        /// currency_rate - float  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("currency_rate")]
        public double? CurrencyRate { get; set; }

        /// <summary>
        /// user_id - many2one - res.users <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        /// <summary>
        /// team_id - many2one - crm.team <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("team_id")]
        public long? TeamId { get; set; }

        /// <summary>
        /// order_line - one2many - sale.order.line (order_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("order_line")]
        public long[]? OrderLine { get; set; }

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
        /// invoice_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("invoice_count")]
        public int? InvoiceCount { get; set; }

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
        /// authorized_transaction_ids - many2many - payment.transaction <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("authorized_transaction_ids")]
        public long[]? AuthorizedTransactionIds { get; set; }

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
        /// amount_undiscounted - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("amount_undiscounted")]
        public double? AmountUndiscounted { get; set; }

        /// <summary>
        /// country_code - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: The ISO country code in two chars. ; You can use this field for quick search. <br />
        /// </summary>
        [JsonProperty("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// expected_date - datetime  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Delivery date you can promise to the customer, computed from the minimum lead time of the order lines in case of Service products. In case of shipping, the shipping policy of the order will be taken into account to either use the minimum or maximum lead time of the order lines. <br />
        /// </summary>
        [JsonProperty("expected_date")]
        public DateTime? ExpectedDate { get; set; }

        /// <summary>
        /// is_expired - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("is_expired")]
        public bool? IsExpired { get; set; }

        /// <summary>
        /// partner_credit_warning - text  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("partner_credit_warning")]
        public string? PartnerCreditWarning { get; set; }

        /// <summary>
        /// tax_country_id - many2one - res.country <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("tax_country_id")]
        public long? TaxCountryId { get; set; }

        /// <summary>
        /// tax_totals - binary  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("tax_totals")]
        public string? TaxTotals { get; set; }

        /// <summary>
        /// terms_type - selection  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("terms_type")]
        public TermsConditionsFormatSaleOrderOdooEnum? TermsType { get; set; }

        /// <summary>
        /// type_name - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("type_name")]
        public string? TypeName { get; set; }

        /// <summary>
        /// show_update_fpos - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("show_update_fpos")]
        public bool? ShowUpdateFpos { get; set; }

        /// <summary>
        /// show_update_pricelist - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("show_update_pricelist")]
        public bool? ShowUpdatePricelist { get; set; }

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
        [JsonProperty("write_uid")]
        public long? WriteUid { get; set; }

        /// <summary>
        /// write_date - datetime  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("write_date")]
        public DateTime? WriteDate { get; set; }

        /// <summary>
        /// url - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Renseigner une URL valide <br />
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// opportunity_id - many2one - crm.lead <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("opportunity_id")]
        public long? OpportunityId { get; set; }

        /// <summary>
        /// applied_coupon_ids - many2many - loyalty.card <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("applied_coupon_ids")]
        public long[]? AppliedCouponIds { get; set; }

        /// <summary>
        /// code_enabled_rule_ids - many2many - loyalty.rule <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("code_enabled_rule_ids")]
        public long[]? CodeEnabledRuleIds { get; set; }

        /// <summary>
        /// coupon_point_ids - one2many - sale.order.coupon.points (order_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("coupon_point_ids")]
        public long[]? CouponPointIds { get; set; }

        /// <summary>
        /// reward_amount - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("reward_amount")]
        public double? RewardAmount { get; set; }

        /// <summary>
        /// sale_order_template_id - many2one - sale.order.template <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("sale_order_template_id")]
        public long? SaleOrderTemplateId { get; set; }

        /// <summary>
        /// sale_order_option_ids - one2many - sale.order.option (order_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("sale_order_option_ids")]
        public long[]? SaleOrderOptionIds { get; set; }

        /// <summary>
        /// purchase_order_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("purchase_order_count")]
        public int? PurchaseOrderCount { get; set; }

        /// <summary>
        /// incoterm - many2one - account.incoterms <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: International Commercial Terms are a series of predefined commercial terms used in international transactions. <br />
        /// </summary>
        [JsonProperty("incoterm")]
        public long? Incoterm { get; set; }

        /// <summary>
        /// incoterm_location - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("incoterm_location")]
        public string? IncotermLocation { get; set; }

        /// <summary>
        /// picking_policy - selection  <br />
        /// Required: True, Readonly: True, Store: True, Sortable: True <br />
        /// Help: If you deliver all products at once, the delivery order will be scheduled based on the greatest product lead time. Otherwise, it will be based on the shortest. <br />
        /// </summary>
        [JsonProperty("picking_policy")]
        public ShippingPolicySaleOrderOdooEnum PickingPolicy { get; set; }

        /// <summary>
        /// warehouse_id - many2one - stock.warehouse <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("warehouse_id")]
        public long WarehouseId { get; set; }

        /// <summary>
        /// picking_ids - one2many - stock.picking (sale_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("picking_ids")]
        public long[]? PickingIds { get; set; }

        /// <summary>
        /// delivery_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("delivery_count")]
        public int? DeliveryCount { get; set; }

        /// <summary>
        /// delivery_status - selection  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("delivery_status")]
        public DeliveryStatusSaleOrderOdooEnum? DeliveryStatus { get; set; }

        /// <summary>
        /// procurement_group_id - many2one - procurement.group <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("procurement_group_id")]
        public long? ProcurementGroupId { get; set; }

        /// <summary>
        /// effective_date - datetime  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: Completion date of the first delivery order. <br />
        /// </summary>
        [JsonProperty("effective_date")]
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// json_popover - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("json_popover")]
        public string? JsonPopover { get; set; }

        /// <summary>
        /// show_json_popover - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("show_json_popover")]
        public bool? ShowJsonPopover { get; set; }

        /// <summary>
        /// website_order_line - one2many - sale.order.line <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("website_order_line")]
        public long[]? WebsiteOrderLine { get; set; }

        /// <summary>
        /// cart_quantity - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("cart_quantity")]
        public int? CartQuantity { get; set; }

        /// <summary>
        /// only_services - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("only_services")]
        public bool? OnlyServices { get; set; }

        /// <summary>
        /// is_abandoned_cart - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("is_abandoned_cart")]
        public bool? IsAbandonedCart { get; set; }

        /// <summary>
        /// cart_recovery_email_sent - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("cart_recovery_email_sent")]
        public bool? CartRecoveryEmailSent { get; set; }

        /// <summary>
        /// website_id - many2one - website <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: Website through which this order was placed for eCommerce orders. <br />
        /// </summary>
        [JsonProperty("website_id")]
        public long? WebsiteId { get; set; }

        /// <summary>
        /// shop_warning - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("shop_warning")]
        public string? ShopWarning { get; set; }

        /// <summary>
        /// carrier_id - many2one - delivery.carrier <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Fill this field if you plan to invoice the shipping based on picking. <br />
        /// </summary>
        [JsonProperty("carrier_id")]
        public long? CarrierId { get; set; }

        /// <summary>
        /// delivery_message - char  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("delivery_message")]
        public string? DeliveryMessage { get; set; }

        /// <summary>
        /// delivery_rating_success - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("delivery_rating_success")]
        public bool? DeliveryRatingSuccess { get; set; }

        /// <summary>
        /// delivery_set - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("delivery_set")]
        public bool? DeliverySet { get; set; }

        /// <summary>
        /// recompute_delivery_price - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("recompute_delivery_price")]
        public bool? RecomputeDeliveryPrice { get; set; }

        /// <summary>
        /// is_all_service - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("is_all_service")]
        public bool? IsAllService { get; set; }

        /// <summary>
        /// pos_order_line_ids - one2many - pos.order.line (sale_order_origin_id) <br />
        /// Required: False, Readonly: True, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("pos_order_line_ids")]
        public long[]? PosOrderLineIds { get; set; }

        /// <summary>
        /// pos_order_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("pos_order_count")]
        public int? PosOrderCount { get; set; }

        /// <summary>
        /// amount_unpaid - monetary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: The amount due from the sale order. <br />
        /// </summary>
        [JsonProperty("amount_unpaid")]
        public decimal? AmountUnpaid { get; set; }

        /// <summary>
        /// workflow_process_id - many2one - sale.workflow.process <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("workflow_process_id")]
        public long? WorkflowProcessId { get; set; }

        /// <summary>
        /// all_qty_delivered - boolean  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("all_qty_delivered")]
        public bool? AllQtyDelivered { get; set; }

        /// <summary>
        /// mrp_production_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("mrp_production_count")]
        public int? MrpProductionCount { get; set; }

        /// <summary>
        /// mrp_production_ids - many2many - mrp.production <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("mrp_production_ids")]
        public long[]? MrpProductionIds { get; set; }

        /// <summary>
        /// report_grids - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("report_grids")]
        public bool? ReportGrids { get; set; }

        /// <summary>
        /// grid_product_tmpl_id - many2one - product.template <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("grid_product_tmpl_id")]
        public long? GridProductTmplId { get; set; }

        /// <summary>
        /// grid_update - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("grid_update")]
        public bool? GridUpdate { get; set; }

        /// <summary>
        /// grid - char  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Technical local storage of grid. ; If grid_update, will be loaded on the SO.; If not, represents the matrix to open. <br />
        /// </summary>
        [JsonProperty("grid")]
        public string? Grid { get; set; }

        /// <summary>
        /// tasks_ids - many2many - project.task <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("tasks_ids")]
        public long[]? TasksIds { get; set; }

        /// <summary>
        /// tasks_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("tasks_count")]
        public int? TasksCount { get; set; }

        /// <summary>
        /// visible_project - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("visible_project")]
        public bool? VisibleProject { get; set; }

        /// <summary>
        /// project_id - many2one - project.project <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: Select a non billable project on which tasks can be created. <br />
        /// </summary>
        [JsonProperty("project_id")]
        public long? ProjectId { get; set; }

        /// <summary>
        /// project_ids - many2many - project.project <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Projects used in this sales order. <br />
        /// </summary>
        [JsonProperty("project_ids")]
        public long[]? ProjectIds { get; set; }

        /// <summary>
        /// project_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("project_count")]
        public int? ProjectCount { get; set; }

        /// <summary>
        /// milestone_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("milestone_count")]
        public int? MilestoneCount { get; set; }

        /// <summary>
        /// is_product_milestone - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("is_product_milestone")]
        public bool? IsProductMilestone { get; set; }

        /// <summary>
        /// disabled_auto_rewards - many2many - loyalty.reward <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("disabled_auto_rewards")]
        public long[]? DisabledAutoRewards { get; set; }

        /// <summary>
        /// default_tracking_url - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: This is the default tracking url for this carrier. <br />
        /// </summary>
        [JsonProperty("default_tracking_url")]
        public string? DefaultTrackingUrl { get; set; }

        /// <summary>
        /// dropoff_site_required - boolean  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("dropoff_site_required")]
        public bool? DropoffSiteRequired { get; set; }

        /// <summary>
        /// final_shipping_partner_id - many2one - res.partner <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: It is the partner that will pick up the parcel in the dropoff site. <br />
        /// </summary>
        [JsonProperty("final_shipping_partner_id")]
        public long? FinalShippingPartnerId { get; set; }

        /// <summary>
        /// sub_total_ht_without_carrier - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("sub_total_ht_without_carrier")]
        public double? SubTotalHtWithoutCarrier { get; set; }

        /// <summary>
        /// sub_total_ht_carrier - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("sub_total_ht_carrier")]
        public double? SubTotalHtCarrier { get; set; }

        /// <summary>
        /// dropship_picking_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("dropship_picking_count")]
        public int? DropshipPickingCount { get; set; }

        /// <summary>
        /// amount_delivery - monetary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// Help: The amount without tax. <br />
        /// </summary>
        [JsonProperty("amount_delivery")]
        public decimal? AmountDelivery { get; set; }

        /// <summary>
        /// fully_delivered - boolean  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("fully_delivered")]
        public bool? FullyDelivered { get; set; }

        /// <summary>
        /// idcanal - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("idcanal")]
        public IDCANALLogisticsSaleOrderOdooEnum? Idcanal { get; set; }

        /// <summary>
        /// typecmd - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("typecmd")]
        public string? Typecmd { get; set; }

        /// <summary>
        /// idgroup - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("idgroup")]
        public string? Idgroup { get; set; }
        long IOdooModel.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }


    /// <summary>
    /// Help: Status based on activities <br />
    /// Overdue: Due date is already passed <br />
    /// Today: Activity date is today <br />
    /// Planned: Future activities.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActivityStateSaleOrderOdooEnum
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
    public enum ActivityExceptionDecorationSaleOrderOdooEnum
    {
        [EnumMember(Value = "warning")]
        Alert = 1,

        [EnumMember(Value = "danger")]
        Error = 2,
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
    public enum TermsConditionsFormatSaleOrderOdooEnum
    {
        [EnumMember(Value = "plain")]
        AddANote = 1,

        [EnumMember(Value = "html")]
        AddALinkToAWebPage = 2,
    }


    /// <summary>
    /// Help: If you deliver all products at once, the delivery order will be scheduled based on the greatest product lead time. Otherwise, it will be based on the shortest.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShippingPolicySaleOrderOdooEnum
    {
        [EnumMember(Value = "direct")]
        AsSoonAsPossible = 1,

        [EnumMember(Value = "one")]
        WhenAllProductsAreReady = 2,
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


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IDCANALLogisticsSaleOrderOdooEnum
    {
        [EnumMember(Value = "WEB")]
        WEB = 1,

        [EnumMember(Value = "PRO")]
        PRO = 2,

        [EnumMember(Value = "MARKETPLACE")]
        MARKETPLACE = 3,

        [EnumMember(Value = "DISTRIBUTEUR")]
        DISTRIBUTEUR = 4,

        [EnumMember(Value = "REASSORT")]
        REASSORT = 5,

        [EnumMember(Value = "SPECIAL")]
        SPECIAL = 6,
    }
}
