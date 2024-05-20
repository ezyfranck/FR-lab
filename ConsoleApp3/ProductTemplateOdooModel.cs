using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using PortaCapena.OdooJsonRpcClient.Attributes;

namespace ConsoleApp3
{
    [OdooTableName("product.template")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ProductTemplateOdooModel : IOdooModel
    {

        /// <summary>
        /// rating_ids - one2many - rating.rating (res_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("rating_ids")]
        public long[]? RatingIds { get; set; }

        /// <summary>
        /// rating_last_value - float  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("rating_last_value")]
        public double? RatingLastValue { get; set; }

        /// <summary>
        /// rating_last_feedback - text  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("rating_last_feedback")]
        public string? RatingLastFeedback { get; set; }

        /// <summary>
        /// rating_last_image - binary  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("rating_last_image")]
        public string? RatingLastImage { get; set; }

        /// <summary>
        /// rating_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("rating_count")]
        public int? RatingCount { get; set; }

        /// <summary>
        /// rating_avg - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("rating_avg")]
        public double? RatingAvg { get; set; }

        /// <summary>
        /// rating_avg_text - selection  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("rating_avg_text")]
        public RatingAvgTextProductTemplateOdooEnum? RatingAvgText { get; set; }

        /// <summary>
        /// rating_percentage_satisfaction - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("rating_percentage_satisfaction")]
        public double? RatingPercentageSatisfaction { get; set; }

        /// <summary>
        /// rating_last_text - selection  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("rating_last_text")]
        public RatingTextProductTemplateOdooEnum? RatingLastText { get; set; }

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
        /// is_seo_optimized - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("is_seo_optimized")]
        public bool? IsSeoOptimized { get; set; }

        /// <summary>
        /// website_meta_title - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("website_meta_title")]
        public string? WebsiteMetaTitle { get; set; }

        /// <summary>
        /// website_meta_description - text  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("website_meta_description")]
        public string? WebsiteMetaDescription { get; set; }

        /// <summary>
        /// website_meta_keywords - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("website_meta_keywords")]
        public string? WebsiteMetaKeywords { get; set; }

        /// <summary>
        /// website_meta_og_img - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("website_meta_og_img")]
        public string? WebsiteMetaOgImg { get; set; }

        /// <summary>
        /// seo_name - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("seo_name")]
        public string? SeoName { get; set; }

        /// <summary>
        /// image_ids - one2many - base_multi_image.image (owner_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("image_ids")]
        public long[]? ImageIds { get; set; }

        /// <summary>
        /// image_1920 - binary  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("image_1920")]
        public string? Image1920 { get; set; }

        /// <summary>
        /// image_1024 - binary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("image_1024")]
        public string? Image1024 { get; set; }

        /// <summary>
        /// image_512 - binary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("image_512")]
        public string? Image512 { get; set; }

        /// <summary>
        /// image_256 - binary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("image_256")]
        public string? Image256 { get; set; }

        /// <summary>
        /// image_128 - binary  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("image_128")]
        public string? Image128 { get; set; }

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
        public ActivityStateProductTemplateOdooEnum? ActivityState { get; set; }

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
        public ActivityExceptionDecorationProductTemplateOdooEnum? ActivityExceptionDecoration { get; set; }

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
        /// name - char  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// sequence - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Gives the sequence order when displaying a product list <br />
        /// </summary>
        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        /// <summary>
        /// description - html  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// description_purchase - text  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("description_purchase")]
        public string? DescriptionPurchase { get; set; }

        /// <summary>
        /// description_sale - text  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: A description of the Product that you want to communicate to your customers. This description will be copied to every Sales Order, Delivery Order and Customer Invoice/Credit Note <br />
        /// </summary>
        [JsonProperty("description_sale")]
        public string? DescriptionSale { get; set; }

        /// <summary>
        /// detailed_type - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: A storable product is a product for which you manage stock. The Inventory app has to be installed.; A consumable product is a product for which stock is not managed.; A service is a non-material product you provide. <br />
        /// </summary>
        [JsonProperty("detailed_type")]
        public ProductTypeProductTemplateOdooEnum DetailedType { get; set; }

        /// <summary>
        /// type - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("type")]
        public TypeProductTemplateOdooEnum? Type { get; set; }

        /// <summary>
        /// categ_id - many2one - product.category <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("categ_id")]
        public long CategId { get; set; }

        /// <summary>
        /// currency_id - many2one - res.currency <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("currency_id")]
        public long? CurrencyId { get; set; }

        /// <summary>
        /// cost_currency_id - many2one - res.currency <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("cost_currency_id")]
        public long? CostCurrencyId { get; set; }

        /// <summary>
        /// list_price - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Price at which the product is sold to customers. <br />
        /// </summary>
        [JsonProperty("list_price")]
        public double? ListPrice { get; set; }

        /// <summary>
        /// standard_price - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: In Standard Price & AVCO: value of the product (automatically computed in AVCO).;         In FIFO: value of the next unit that will leave the stock (automatically computed).;         Used to value the product when the purchase cost is not known (e.g. inventory adjustment).;         Used to compute margins on sale orders. <br />
        /// </summary>
        [JsonProperty("standard_price")]
        public double? StandardPrice { get; set; }

        /// <summary>
        /// volume - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// volume_uom_name - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("volume_uom_name")]
        public string? VolumeUomName { get; set; }

        /// <summary>
        /// weight - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// weight_uom_name - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("weight_uom_name")]
        public string? WeightUomName { get; set; }

        /// <summary>
        /// sale_ok - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("sale_ok")]
        public bool? SaleOk { get; set; }

        /// <summary>
        /// purchase_ok - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("purchase_ok")]
        public bool? PurchaseOk { get; set; }

        /// <summary>
        /// uom_id - many2one - uom.uom <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Default unit of measure used for all stock operations. <br />
        /// </summary>
        [JsonProperty("uom_id")]
        public long UomId { get; set; }

        /// <summary>
        /// uom_name - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("uom_name")]
        public string? UomName { get; set; }

        /// <summary>
        /// uom_po_id - many2one - uom.uom <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Default unit of measure used for purchase orders. It must be in the same category as the default unit of measure. <br />
        /// </summary>
        [JsonProperty("uom_po_id")]
        public long? UomPoId { get; set; }

        /// <summary>
        /// company_id - many2one - res.company <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("company_id")]
        public long? CompanyId { get; set; }

        /// <summary>
        /// packaging_ids - one2many - product.packaging <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Gives the different ways to package the same product. <br />
        /// </summary>
        [JsonProperty("packaging_ids")]
        public long[]? PackagingIds { get; set; }

        /// <summary>
        /// seller_ids - one2many - product.supplierinfo (product_tmpl_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("seller_ids")]
        public long[]? SellerIds { get; set; }

        /// <summary>
        /// variant_seller_ids - one2many - product.supplierinfo (product_tmpl_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("variant_seller_ids")]
        public long[]? VariantSellerIds { get; set; }

        /// <summary>
        /// active - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: If unchecked, it will allow you to hide the product without removing it. <br />
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// color - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("color")]
        public int? Color { get; set; }

        /// <summary>
        /// is_product_variant - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("is_product_variant")]
        public bool? IsProductVariant { get; set; }

        /// <summary>
        /// attribute_line_ids - one2many - product.template.attribute.line (product_tmpl_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("attribute_line_ids")]
        public long[]? AttributeLineIds { get; set; }

        /// <summary>
        /// valid_product_template_attribute_line_ids - many2many - product.template.attribute.line <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("valid_product_template_attribute_line_ids")]
        public long[]? ValidProductTemplateAttributeLineIds { get; set; }

        /// <summary>
        /// product_variant_ids - one2many - product.product (product_tmpl_id) <br />
        /// Required: True, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_variant_ids")]
        public long[]? ProductVariantIds { get; set; }

        /// <summary>
        /// product_variant_id - many2one - product.product <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_variant_id")]
        public long? ProductVariantId { get; set; }

        /// <summary>
        /// product_variant_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_variant_count")]
        public int? ProductVariantCount { get; set; }

        /// <summary>
        /// barcode - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("barcode")]
        public string? Barcode { get; set; }

        /// <summary>
        /// default_code - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("default_code")]
        public string? DefaultCode { get; set; }

        /// <summary>
        /// pricelist_item_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("pricelist_item_count")]
        public int? PricelistItemCount { get; set; }

        /// <summary>
        /// can_image_1024_be_zoomed - boolean  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("can_image_1024_be_zoomed")]
        public bool? CanImage1024BeZoomed { get; set; }

        /// <summary>
        /// has_configurable_attributes - boolean  <br />
        /// Required: False, Readonly: True, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("has_configurable_attributes")]
        public bool? HasConfigurableAttributes { get; set; }

        /// <summary>
        /// product_tooltip - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_tooltip")]
        public string? ProductTooltip { get; set; }

        /// <summary>
        /// priority - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("priority")]
        public FavoriteProductTemplateOdooEnum? Priority { get; set; }

        /// <summary>
        /// product_tag_ids - many2many - product.tag <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_tag_ids")]
        public long[]? ProductTagIds { get; set; }

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
        /// dimensional_uom_id - many2one - uom.uom <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: UoM for length, height, width <br />
        /// </summary>
        [JsonProperty("dimensional_uom_id")]
        public long? DimensionalUomId { get; set; }

        /// <summary>
        /// product_length - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_length")]
        public double? ProductLength { get; set; }

        /// <summary>
        /// product_height - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_height")]
        public double? ProductHeight { get; set; }

        /// <summary>
        /// product_width - float  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_width")]
        public double? ProductWidth { get; set; }

        /// <summary>
        /// hs_code_id - many2one - hs.code <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Harmonised System Code. Nomenclature is available from the World Customs Organisation, see http://www.wcoomd.org/. You can leave this field empty and configure the H.S. code on the product category. <br />
        /// </summary>
        [JsonProperty("hs_code_id")]
        public long? HsCodeId { get; set; }

        /// <summary>
        /// origin_country_id - many2one - res.country <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Country of origin of the product i.e. product 'made in ____'. <br />
        /// </summary>
        [JsonProperty("origin_country_id")]
        public long? OriginCountryId { get; set; }

        /// <summary>
        /// categ_ids - many2many - product.category <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("categ_ids")]
        public long[]? CategIds { get; set; }

        /// <summary>
        /// product_images_ids - many2many - ir.attachment <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_images_ids")]
        public long[]? ProductImagesIds { get; set; }

        /// <summary>
        /// ref_supplier - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("ref_supplier")]
        public string? RefSupplier { get; set; }

        /// <summary>
        /// ean_supplier - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("ean_supplier")]
        public string? EanSupplier { get; set; }

        /// <summary>
        /// concat_url_field - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("concat_url_field")]
        public string? ConcatUrlField { get; set; }

        /// <summary>
        /// taxes_id - many2many - account.tax <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: Default taxes used when selling the product. <br />
        /// </summary>
        [JsonProperty("taxes_id")]
        public long[]? TaxesId { get; set; }

        /// <summary>
        /// tax_string - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("tax_string")]
        public string? TaxString { get; set; }

        /// <summary>
        /// supplier_taxes_id - many2many - account.tax <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: Default taxes used when buying the product. <br />
        /// </summary>
        [JsonProperty("supplier_taxes_id")]
        public long[]? SupplierTaxesId { get; set; }

        /// <summary>
        /// property_account_income_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Keep this field empty to use the default value from the product category. <br />
        /// </summary>
        [JsonProperty("property_account_income_id")]
        public long? PropertyAccountIncomeId { get; set; }

        /// <summary>
        /// property_account_expense_id - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: Keep this field empty to use the default value from the product category. If anglo-saxon accounting with automated valuation method is configured, the expense account on the product category will be used. <br />
        /// </summary>
        [JsonProperty("property_account_expense_id")]
        public long? PropertyAccountExpenseId { get; set; }

        /// <summary>
        /// account_tag_ids - many2many - account.account.tag <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: Tags to be set on the base and tax journal items created for this product. <br />
        /// </summary>
        [JsonProperty("account_tag_ids")]
        public long[]? AccountTagIds { get; set; }

        /// <summary>
        /// responsible_id - many2one - res.users <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: This user will be responsible of the next activities related to logistic operations for this product. <br />
        /// </summary>
        [JsonProperty("responsible_id")]
        public long? ResponsibleId { get; set; }

        /// <summary>
        /// property_stock_production - many2one - stock.location <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: This stock location will be used, instead of the default one, as the source location for stock moves generated by manufacturing orders. <br />
        /// </summary>
        [JsonProperty("property_stock_production")]
        public long? PropertyStockProduction { get; set; }

        /// <summary>
        /// property_stock_inventory - many2one - stock.location <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: This stock location will be used, instead of the default one, as the source location for stock moves generated when you do an inventory. <br />
        /// </summary>
        [JsonProperty("property_stock_inventory")]
        public long? PropertyStockInventory { get; set; }

        /// <summary>
        /// sale_delay - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Delivery lead time, in days. It's the number of days, promised to the customer, between the confirmation of the sales order and the delivery. <br />
        /// </summary>
        [JsonProperty("sale_delay")]
        public double? SaleDelay { get; set; }

        /// <summary>
        /// tracking - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Ensure the traceability of a storable product in your warehouse. <br />
        /// </summary>
        [JsonProperty("tracking")]
        public TrackingProductTemplateOdooEnum Tracking { get; set; }

        /// <summary>
        /// description_picking - text  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("description_picking")]
        public string? DescriptionPicking { get; set; }

        /// <summary>
        /// description_pickingout - text  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("description_pickingout")]
        public string? DescriptionPickingout { get; set; }

        /// <summary>
        /// description_pickingin - text  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("description_pickingin")]
        public string? DescriptionPickingin { get; set; }

        /// <summary>
        /// qty_available - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("qty_available")]
        public double? QtyAvailable { get; set; }

        /// <summary>
        /// virtual_available - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("virtual_available")]
        public double? VirtualAvailable { get; set; }

        /// <summary>
        /// incoming_qty - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("incoming_qty")]
        public double? IncomingQty { get; set; }

        /// <summary>
        /// outgoing_qty - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("outgoing_qty")]
        public double? OutgoingQty { get; set; }

        /// <summary>
        /// location_id - many2one - stock.location <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("location_id")]
        public long? LocationId { get; set; }

        /// <summary>
        /// warehouse_id - many2one - stock.warehouse <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("warehouse_id")]
        public long? WarehouseId { get; set; }

        /// <summary>
        /// has_available_route_ids - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("has_available_route_ids")]
        public bool? HasAvailableRouteIds { get; set; }

        /// <summary>
        /// route_ids - many2many - stock.route <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: Depending on the modules installed, this will allow you to define the route of the product: whether it will be bought, manufactured, replenished on order, etc. <br />
        /// </summary>
        [JsonProperty("route_ids")]
        public long[]? RouteIds { get; set; }

        /// <summary>
        /// nbr_moves_in - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Number of incoming stock moves in the past 12 months <br />
        /// </summary>
        [JsonProperty("nbr_moves_in")]
        public int? NbrMovesIn { get; set; }

        /// <summary>
        /// nbr_moves_out - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Number of outgoing stock moves in the past 12 months <br />
        /// </summary>
        [JsonProperty("nbr_moves_out")]
        public int? NbrMovesOut { get; set; }

        /// <summary>
        /// nbr_reordering_rules - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("nbr_reordering_rules")]
        public int? NbrReorderingRules { get; set; }

        /// <summary>
        /// reordering_min_qty - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("reordering_min_qty")]
        public double? ReorderingMinQty { get; set; }

        /// <summary>
        /// reordering_max_qty - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("reordering_max_qty")]
        public double? ReorderingMaxQty { get; set; }

        /// <summary>
        /// route_from_categ_ids - many2many - stock.route <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("route_from_categ_ids")]
        public long[]? RouteFromCategIds { get; set; }

        /// <summary>
        /// show_on_hand_qty_status_button - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("show_on_hand_qty_status_button")]
        public bool? ShowOnHandQtyStatusButton { get; set; }

        /// <summary>
        /// show_forecasted_qty_status_button - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("show_forecasted_qty_status_button")]
        public bool? ShowForecastedQtyStatusButton { get; set; }

        /// <summary>
        /// bom_line_ids - one2many - mrp.bom.line (product_tmpl_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("bom_line_ids")]
        public long[]? BomLineIds { get; set; }

        /// <summary>
        /// bom_ids - one2many - mrp.bom (product_tmpl_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("bom_ids")]
        public long[]? BomIds { get; set; }

        /// <summary>
        /// bom_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("bom_count")]
        public int? BomCount { get; set; }

        /// <summary>
        /// used_in_bom_count - integer  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("used_in_bom_count")]
        public int? UsedInBomCount { get; set; }

        /// <summary>
        /// mrp_product_qty - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("mrp_product_qty")]
        public double? MrpProductQty { get; set; }

        /// <summary>
        /// produce_delay - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Average lead time in days to manufacture this product. In the case of multi-level BOM, the manufacturing lead times of the components will be added. In case the product is subcontracted, this can be used to determine the date at which components should be sent to the subcontractor. <br />
        /// </summary>
        [JsonProperty("produce_delay")]
        public double? ProduceDelay { get; set; }

        /// <summary>
        /// is_kits - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("is_kits")]
        public bool? IsKits { get; set; }

        /// <summary>
        /// days_to_prepare_mo - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Create and confirm Manufacturing Orders this many days in advance, to have enough time to replenish components or manufacture semi-finished products.; Note that security lead times will also be considered when appropriate. <br />
        /// </summary>
        [JsonProperty("days_to_prepare_mo")]
        public double? DaysToPrepareMo { get; set; }

        /// <summary>
        /// purchased_product_qty - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("purchased_product_qty")]
        public double? PurchasedProductQty { get; set; }

        /// <summary>
        /// purchase_method - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: On ordered quantities: Control bills based on ordered quantities.; On received quantities: Control bills based on received quantities. <br />
        /// </summary>
        [JsonProperty("purchase_method")]
        public ControlPolicyProductTemplateOdooEnum? PurchaseMethod { get; set; }

        /// <summary>
        /// purchase_line_warn - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field. <br />
        /// </summary>
        [JsonProperty("purchase_line_warn")]
        public PurchaseOrderLineWarningProductTemplateOdooEnum PurchaseLineWarn { get; set; }

        /// <summary>
        /// purchase_line_warn_msg - text  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("purchase_line_warn_msg")]
        public string? PurchaseLineWarnMsg { get; set; }

        /// <summary>
        /// cost_method - selection  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Standard Price: The products are valued at their standard cost defined on the product.;         Average Cost (AVCO): The products are valued at weighted average cost.;         First In First Out (FIFO): The products are valued supposing those that enter the company first will also leave it first.;          <br />
        /// </summary>
        [JsonProperty("cost_method")]
        public CostingMethodProductTemplateOdooEnum? CostMethod { get; set; }

        /// <summary>
        /// valuation - selection  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Manual: The accounting entries to value the inventory are not posted automatically.;         Automated: An accounting entry is automatically created to value the inventory when a product enters or leaves the company.;          <br />
        /// </summary>
        [JsonProperty("valuation")]
        public InventoryValuationProductTemplateOdooEnum? Valuation { get; set; }

        /// <summary>
        /// available_in_pos - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Check if you want this product to appear in the Point of Sale. <br />
        /// </summary>
        [JsonProperty("available_in_pos")]
        public bool? AvailableInPos { get; set; }

        /// <summary>
        /// to_weight - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Check if the product should be weighted using the hardware scale integration. <br />
        /// </summary>
        [JsonProperty("to_weight")]
        public bool? ToWeight { get; set; }

        /// <summary>
        /// pos_categ_id - many2one - pos.category <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Category used in the Point of Sale. <br />
        /// </summary>
        [JsonProperty("pos_categ_id")]
        public long? PosCategId { get; set; }

        /// <summary>
        /// service_type - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Manually set quantities on order: Invoice based on the manually entered quantity, without creating an analytic account.; Timesheets on contract: Invoice based on the tracked hours on the related timesheet.; Create a task and track hours: Create a task on the sales order validation and track the work hours. <br />
        /// </summary>
        [JsonProperty("service_type")]
        public TrackServiceProductTemplateOdooEnum? ServiceType { get; set; }

        /// <summary>
        /// sale_line_warn - selection  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field. <br />
        /// </summary>
        [JsonProperty("sale_line_warn")]
        public SalesOrderLineProductTemplateOdooEnum SaleLineWarn { get; set; }

        /// <summary>
        /// sale_line_warn_msg - text  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("sale_line_warn_msg")]
        public string? SaleLineWarnMsg { get; set; }

        /// <summary>
        /// expense_policy - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Expenses and vendor bills can be re-invoiced to a customer.With this option, a validated expense can be re-invoice to a customer at its cost or sales price. <br />
        /// </summary>
        [JsonProperty("expense_policy")]
        public ReInvoiceExpensesProductTemplateOdooEnum? ExpensePolicy { get; set; }

        /// <summary>
        /// visible_expense_policy - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("visible_expense_policy")]
        public bool? VisibleExpensePolicy { get; set; }

        /// <summary>
        /// sales_count - float  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("sales_count")]
        public double? SalesCount { get; set; }

        /// <summary>
        /// visible_qty_configurator - boolean  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("visible_qty_configurator")]
        public bool? VisibleQtyConfigurator { get; set; }

        /// <summary>
        /// invoice_policy - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Ordered Quantity: Invoice quantities ordered by the customer.; Delivered Quantity: Invoice quantities delivered to the customer. <br />
        /// </summary>
        [JsonProperty("invoice_policy")]
        public InvoicingPolicyProductTemplateOdooEnum? InvoicePolicy { get; set; }

        /// <summary>
        /// property_account_creditor_price_difference - many2one - account.account <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: This account is used in automated inventory valuation to record the price difference between a purchase order and its related vendor bill when validating this vendor bill. <br />
        /// </summary>
        [JsonProperty("property_account_creditor_price_difference")]
        public long? PropertyAccountCreditorPriceDifference { get; set; }

        /// <summary>
        /// optional_product_ids - many2many - product.template <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: Optional Products are suggested whenever the customer hits *Add to Cart* (cross-sell strategy, e.g. for computers: warranty, software, etc.). <br />
        /// </summary>
        [JsonProperty("optional_product_ids")]
        public long[]? OptionalProductIds { get; set; }

        /// <summary>
        /// service_to_purchase - boolean  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// Help: If ticked, each time you sell this product through a SO, a RfQ is automatically created to buy the product. Tip: don't forget to set a vendor on the product. <br />
        /// </summary>
        [JsonProperty("service_to_purchase")]
        public bool? ServiceToPurchase { get; set; }

        /// <summary>
        /// website_description - html  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("website_description")]
        public string? WebsiteDescription { get; set; }

        /// <summary>
        /// alternative_product_ids - many2many - product.template <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: Suggest alternatives to your customer (upsell strategy). Those products show up on the product page. <br />
        /// </summary>
        [JsonProperty("alternative_product_ids")]
        public long[]? AlternativeProductIds { get; set; }

        /// <summary>
        /// accessory_product_ids - many2many - product.product <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: Accessories show up when the customer reviews the cart before payment (cross-sell strategy). <br />
        /// </summary>
        [JsonProperty("accessory_product_ids")]
        public long[]? AccessoryProductIds { get; set; }

        /// <summary>
        /// website_size_x - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("website_size_x")]
        public int? WebsiteSizeX { get; set; }

        /// <summary>
        /// website_size_y - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("website_size_y")]
        public int? WebsiteSizeY { get; set; }

        /// <summary>
        /// website_ribbon_id - many2one - product.ribbon <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("website_ribbon_id")]
        public long? WebsiteRibbonId { get; set; }

        /// <summary>
        /// website_sequence - integer  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Determine the display order in the Website E-commerce <br />
        /// </summary>
        [JsonProperty("website_sequence")]
        public int? WebsiteSequence { get; set; }

        /// <summary>
        /// public_categ_ids - many2many - product.public.category <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// Help: The product will be available in each mentioned eCommerce category. Go to Shop > Edit Click on the page and enable 'Categories' to view all eCommerce categories. <br />
        /// </summary>
        [JsonProperty("public_categ_ids")]
        public long[]? PublicCategIds { get; set; }

        /// <summary>
        /// product_template_image_ids - one2many - product.image (product_tmpl_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("product_template_image_ids")]
        public long[]? ProductTemplateImageIds { get; set; }

        /// <summary>
        /// base_unit_count - float  <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Display base unit price on your eCommerce pages. Set to 0 to hide it for this product. <br />
        /// </summary>
        [JsonProperty("base_unit_count")]
        public double BaseUnitCount { get; set; }

        /// <summary>
        /// base_unit_id - many2one - website.base.unit <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Define a custom unit to display in the price per unit of measure field. <br />
        /// </summary>
        [JsonProperty("base_unit_id")]
        public long? BaseUnitId { get; set; }

        /// <summary>
        /// base_unit_price - monetary  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("base_unit_price")]
        public decimal? BaseUnitPrice { get; set; }

        /// <summary>
        /// base_unit_name - char  <br />
        /// Required: False, Readonly: True, Store: False, Sortable: False <br />
        /// Help: Displays the custom unit for the products if defined or the selected unit of measure otherwise. <br />
        /// </summary>
        [JsonProperty("base_unit_name")]
        public string? BaseUnitName { get; set; }

        /// <summary>
        /// compare_list_price - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: The amount will be displayed strikethroughed on the eCommerce product page <br />
        /// </summary>
        [JsonProperty("compare_list_price")]
        public double? CompareListPrice { get; set; }

        /// <summary>
        /// hs_code - char  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Standardized code for international shipping and goods declaration. At the moment, only used for the FedEx shipping provider. <br />
        /// </summary>
        [JsonProperty("hs_code")]
        public string? HsCode { get; set; }

        /// <summary>
        /// country_of_origin - many2one - res.country <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Rules of origin determine where goods originate, i.e. not where they have been shipped from, but where they have been produced or manufactured.; As such, the 'origin' is the 'economic nationality' of goods traded in commerce. <br />
        /// </summary>
        [JsonProperty("country_of_origin")]
        public long? CountryOfOrigin { get; set; }

        /// <summary>
        /// product_add_mode - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: Configurator: choose attribute values to add the matching product variant to the order.; Grid: add several variants at once from the grid of attribute values <br />
        /// </summary>
        [JsonProperty("product_add_mode")]
        public AddProductModeProductTemplateOdooEnum? ProductAddMode { get; set; }

        /// <summary>
        /// service_tracking - selection  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// Help: On Sales order confirmation, this product can generate a project and/or task.         From those, you can track the service you are selling.;          'In sale order's project': Will use the sale order's configured project if defined or fallback to         creating a new project based on the selected template. <br />
        /// </summary>
        [JsonProperty("service_tracking")]
        public CreateOnOrderProductTemplateOdooEnum? ServiceTracking { get; set; }

        /// <summary>
        /// project_id - many2one - project.project <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("project_id")]
        public long? ProjectId { get; set; }

        /// <summary>
        /// project_template_id - many2one - project.project <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("project_template_id")]
        public long? ProjectTemplateId { get; set; }

        /// <summary>
        /// service_policy - selection  <br />
        /// Required: False, Readonly: False, Store: False, Sortable: False <br />
        /// </summary>
        [JsonProperty("service_policy")]
        public ServiceInvoicingPolicyProductTemplateOdooEnum? ServicePolicy { get; set; }

        /// <summary>
        /// allow_out_of_stock_order - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("allow_out_of_stock_order")]
        public bool? AllowOutOfStockOrder { get; set; }

        /// <summary>
        /// available_threshold - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("available_threshold")]
        public double? AvailableThreshold { get; set; }

        /// <summary>
        /// show_availability - boolean  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("show_availability")]
        public bool? ShowAvailability { get; set; }

        /// <summary>
        /// out_of_stock_message - html  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("out_of_stock_message")]
        public string? OutOfStockMessage { get; set; }
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RatingAvgTextProductTemplateOdooEnum
    {
        [EnumMember(Value = "top")]
        Satisfied = 1,

        [EnumMember(Value = "ok")]
        Okay = 2,

        [EnumMember(Value = "ko")]
        Dissatisfied = 3,

        [EnumMember(Value = "none")]
        NoRatingYet = 4,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RatingTextProductTemplateOdooEnum
    {
        [EnumMember(Value = "top")]
        Satisfied = 1,

        [EnumMember(Value = "ok")]
        Okay = 2,

        [EnumMember(Value = "ko")]
        Dissatisfied = 3,

        [EnumMember(Value = "none")]
        NoRatingYet = 4,
    }


    /// <summary>
    /// Help: Status based on activities <br />
    /// Overdue: Due date is already passed <br />
    /// Today: Activity date is today <br />
    /// Planned: Future activities.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActivityStateProductTemplateOdooEnum
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
    public enum ActivityExceptionDecorationProductTemplateOdooEnum
    {
        [EnumMember(Value = "warning")]
        Alert = 1,

        [EnumMember(Value = "danger")]
        Error = 2,
    }


    /// <summary>
    /// Help: A storable product is a product for which you manage stock. The Inventory app has to be installed. <br />
    /// A consumable product is a product for which stock is not managed. <br />
    /// A service is a non-material product you provide.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductTypeProductTemplateOdooEnum
    {
        [EnumMember(Value = "consu")]
        Consumable = 1,

        [EnumMember(Value = "service")]
        Service = 2,

        [EnumMember(Value = "product")]
        StorableProduct = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeProductTemplateOdooEnum
    {
        [EnumMember(Value = "consu")]
        Consumable = 1,

        [EnumMember(Value = "service")]
        Service = 2,

        [EnumMember(Value = "product")]
        StorableProduct = 3,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FavoriteProductTemplateOdooEnum
    {
        [EnumMember(Value = "0")]
        Normal = 1,

        [EnumMember(Value = "1")]
        Favorite = 2,
    }


    /// <summary>
    /// Help: Ensure the traceability of a storable product in your warehouse.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TrackingProductTemplateOdooEnum
    {
        [EnumMember(Value = "serial")]
        ByUniqueSerialNumber = 1,

        [EnumMember(Value = "lot")]
        ByLots = 2,

        [EnumMember(Value = "none")]
        NoTracking = 3,
    }


    /// <summary>
    /// Help: On ordered quantities: Control bills based on ordered quantities. <br />
    /// On received quantities: Control bills based on received quantities.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ControlPolicyProductTemplateOdooEnum
    {
        [EnumMember(Value = "purchase")]
        OnOrderedQuantities = 1,

        [EnumMember(Value = "receive")]
        OnReceivedQuantities = 2,
    }


    /// <summary>
    /// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PurchaseOrderLineWarningProductTemplateOdooEnum
    {
        [EnumMember(Value = "no-message")]
        NoMessage = 1,

        [EnumMember(Value = "warning")]
        Warning = 2,

        [EnumMember(Value = "block")]
        BlockingMessage = 3,
    }


    /// <summary>
    /// Help: Standard Price: The products are valued at their standard cost defined on the product. <br />
    ///         Average Cost (AVCO): The products are valued at weighted average cost. <br />
    ///         First In First Out (FIFO): The products are valued supposing those that enter the company first will also leave it first. <br />
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CostingMethodProductTemplateOdooEnum
    {
        [EnumMember(Value = "standard")]
        StandardPrice = 1,

        [EnumMember(Value = "fifo")]
        FirstInFirstOutFIFO = 2,

        [EnumMember(Value = "average")]
        AverageCostAVCO = 3,
    }


    /// <summary>
    /// Help: Manual: The accounting entries to value the inventory are not posted automatically. <br />
    ///         Automated: An accounting entry is automatically created to value the inventory when a product enters or leaves the company. <br />
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InventoryValuationProductTemplateOdooEnum
    {
        [EnumMember(Value = "manual_periodic")]
        Manual = 1,

        [EnumMember(Value = "real_time")]
        Automated = 2,
    }


    /// <summary>
    /// Help: Manually set quantities on order: Invoice based on the manually entered quantity, without creating an analytic account. <br />
    /// Timesheets on contract: Invoice based on the tracked hours on the related timesheet. <br />
    /// Create a task and track hours: Create a task on the sales order validation and track the work hours.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TrackServiceProductTemplateOdooEnum
    {
        [EnumMember(Value = "manual")]
        ManuallySetQuantitiesOnOrder = 1,

        [EnumMember(Value = "milestones")]
        ProjectMilestones = 2,
    }


    /// <summary>
    /// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SalesOrderLineProductTemplateOdooEnum
    {
        [EnumMember(Value = "no-message")]
        NoMessage = 1,

        [EnumMember(Value = "warning")]
        Warning = 2,

        [EnumMember(Value = "block")]
        BlockingMessage = 3,
    }


    /// <summary>
    /// Help: Expenses and vendor bills can be re-invoiced to a customer.With this option, a validated expense can be re-invoice to a customer at its cost or sales price.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReInvoiceExpensesProductTemplateOdooEnum
    {
        [EnumMember(Value = "no")]
        No = 1,

        [EnumMember(Value = "cost")]
        AtCost = 2,

        [EnumMember(Value = "sales_price")]
        SalesPrice = 3,
    }


    /// <summary>
    /// Help: Ordered Quantity: Invoice quantities ordered by the customer. <br />
    /// Delivered Quantity: Invoice quantities delivered to the customer.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoicingPolicyProductTemplateOdooEnum
    {
        [EnumMember(Value = "order")]
        OrderedQuantities = 1,

        [EnumMember(Value = "delivery")]
        DeliveredQuantities = 2,
    }


    /// <summary>
    /// Help: Configurator: choose attribute values to add the matching product variant to the order. <br />
    /// Grid: add several variants at once from the grid of attribute values
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AddProductModeProductTemplateOdooEnum
    {
        [EnumMember(Value = "configurator")]
        ProductConfigurator = 1,

        [EnumMember(Value = "matrix")]
        OrderGridEntry = 2,
    }


    /// <summary>
    /// Help: On Sales order confirmation, this product can generate a project and/or task.         From those, you can track the service you are selling. <br />
    ///          'In sale order's project': Will use the sale order's configured project if defined or fallback to         creating a new project based on the selected template.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreateOnOrderProductTemplateOdooEnum
    {
        [EnumMember(Value = "no")]
        Nothing = 1,

        [EnumMember(Value = "task_global_project")]
        Task = 2,

        [EnumMember(Value = "task_in_project")]
        ProjectTask = 3,

        [EnumMember(Value = "project_only")]
        Project = 4,
    }


    /// <summary>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServiceInvoicingPolicyProductTemplateOdooEnum
    {
        [EnumMember(Value = "ordered_prepaid")]
        PrPayPrixFixe = 1,

        [EnumMember(Value = "delivered_milestones")]
        BasSurLesJalons = 2,

        [EnumMember(Value = "delivered_manual")]
        BasSurLaQuantitLivrEManuelle = 3,
    }
}
