using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using System.Runtime.Serialization;
using PortaCapena.OdooJsonRpcClient.Attributes;

namespace ConsoleApp3
{

    [OdooTableName("product.product")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class ProductProductOdooModel : IOdooModel
    {

    /// image_ids - one2many - base_multi_image.image (owner_id) Required: False, Readonly: False, Store: False, Sortable: False
    [JsonProperty("image_ids")]
    public long[]? ImageIds { get; set; }

    /// activity_ids - one2many - mail.activity (res_id) Required: False, Readonly: False, Store: True, Sortable: False
    [JsonProperty("activity_ids")]
    public long[]? ActivityIds { get; set; }
    
    /// activity_state - selection  Required: False, Readonly: True, Store: False, Sortable: False 
    [JsonProperty("activity_state")]
    public ActivityStateProductProductOdooEnum? ActivityState { get; set; }

    /// activity_user_id - many2one - res.users Required: False, Readonly: False, Store: False, Sortable: False
    [JsonProperty("activity_user_id")]
    public long? ActivityUserId { get; set; }

    /// activity_type_id - many2one - mail.activity.type Required: False, Readonly: False, Store: False, Sortable: False
    [JsonProperty("activity_type_id")]
    public long? ActivityTypeId { get; set; }

    /// activity_type_icon - char  Required: False, Readonly: True, Store: False, Sortable: False
    [JsonProperty("activity_type_icon")]
    public string? ActivityTypeIcon { get; set; }

    /// activity_date_deadline - date  Required: False, Readonly: True, Store: False, Sortable: False
    [JsonProperty("activity_date_deadline")]
    public DateTime? ActivityDateDeadline { get; set; }

    /// my_activity_date_deadline - date  Required: False, Readonly: True, Store: False, Sortable: False
    [JsonProperty("my_activity_date_deadline")]
    public DateTime? MyActivityDateDeadline { get; set; }
    
    /// activity_summary - char  Required: False, Readonly: False, Store: False, Sortable: False   
    [JsonProperty("activity_summary")]
    public string? ActivitySummary { get; set; }
    
    /// activity_exception_decoration - selection  Required: False, Readonly: True, Store: False, Sortable: False 
    [JsonProperty("activity_exception_decoration")]
    public ActivityExceptionDecorationProductProductOdooEnum? ActivityExceptionDecoration { get; set; }
     
    /// activity_exception_icon - char Required: False, Readonly: True, Store: False, Sortable: False     
    [JsonProperty("activity_exception_icon")]
    public string? ActivityExceptionIcon { get; set; }
    
    /// activity_calendar_event_id - many2one - calendar.event Required: False, Readonly: True, Store: False, Sortable: False 01
    [JsonProperty("activity_calendar_event_id")]
    public long? ActivityCalendarEventId { get; set; }
    
    /// message_is_follower - boolean Required: False, Readonly: True, Store: False, Sortable: False  
    [JsonProperty("message_is_follower")]
    public bool? MessageIsFollower { get; set; }
    
    /// message_follower_ids - one2many - mail.followers (res_id) Required: False, Readonly: False, Store: True, Sortable: False 
    [JsonProperty("message_follower_ids")]
    public long[]? MessageFollowerIds { get; set; }
    
    /// message_partner_ids - many2many - res.partner Required: False, Readonly: False, Store: False, Sortable: False 
    [JsonProperty("message_partner_ids")]
    public long[]? MessagePartnerIds { get; set; }
   
    /// message_ids - one2many - mail.message (res_id) Required: False, Readonly: False, Store: True, Sortable: False 
    [JsonProperty("message_ids")]
    public long[]? MessageIds { get; set; }
   
    /// has_message - boolean Required: False, Readonly: True, Store: False, Sortable: False  
    [JsonProperty("has_message")]
    public bool? HasMessage { get; set; }
    
    /// message_needaction - boolean Required: False, Readonly: True, Store: False, Sortable: False    
    [JsonProperty("message_needaction")]
    public bool? MessageNeedaction { get; set; }
    
    /// message_needaction_counter - integer Required: False, Readonly: True, Store: False, Sortable: False   
    [JsonProperty("message_needaction_counter")]
    public int? MessageNeedactionCounter { get; set; }
    
    /// message_has_error - boolean Required: False, Readonly: True, Store: False, Sortable: False  
    [JsonProperty("message_has_error")]
    public bool? MessageHasError { get; set; }
    
    /// message_has_error_counter - integer  Required: False, Readonly: True, Store: False, Sortable: False 
    [JsonProperty("message_has_error_counter")]
    public int? MessageHasErrorCounter { get; set; }
    
    /// message_attachment_count - integer  Required: False, Readonly: True, Store: False, Sortable: False  
    [JsonProperty("message_attachment_count")]
    public int? MessageAttachmentCount { get; set; }
    
    /// message_main_attachment_id - many2one - ir.attachment Required: False, Readonly: False, Store: True, Sortable: True    
    [JsonProperty("message_main_attachment_id")]
    public long? MessageMainAttachmentId { get; set; }
     
    /// website_message_ids - one2many - mail.message (res_id)  Required: False, Readonly: False, Store: True, Sortable: False     
    [JsonProperty("website_message_ids")]
    public long[]? WebsiteMessageIds { get; set; }
     
    /// message_has_sms_error - boolean Required: False, Readonly: True, Store: False, Sortable: False         
    [JsonProperty("message_has_sms_error")]
    public bool? MessageHasSmsError { get; set; }
    
    /// price_extra - float  Required: False, Readonly: True, Store: False, Sortable: False      
    [JsonProperty("price_extra")]
    public double? PriceExtra { get; set; }
 
    /// lst_price - float Required: False, Readonly: False, Store: False, Sortable: False       
    [JsonProperty("lst_price")]
    public double? LstPrice { get; set; }
    
    /// default_code - char  Required: False, Readonly: False, Store: True, Sortable: True   
    [JsonProperty("default_code")]
    public string? DefaultCode { get; set; }
    
    /// code - char Required: False, Readonly: True, Store: False, Sortable: False    
    [JsonProperty("code")]
    public string? Code { get; set; }
    
    /// partner_ref - char  Required: False, Readonly: True, Store: False, Sortable: False   
    [JsonProperty("partner_ref")]
    public string? PartnerRef { get; set; }

    /// active - boolean  Required: False, Readonly: False, Store: True, Sortable: True    
    [JsonProperty("active")]
    public bool? Active { get; set; }
    
    /// product_tmpl_id - many2one - product.template  Required: True, Readonly: False, Store: True, Sortable: True  
    [JsonProperty("product_tmpl_id")]
    public long ProductTmplId { get; set; }
    
    /// barcode - char Required: False, Readonly: False, Store: True, Sortable: True    
    [JsonProperty("barcode")]
    public string? Barcode { get; set; }
    
    /// product_template_attribute_value_ids - many2many - product.template.attribute.value  Required: False, Readonly: False, Store: True, Sortable: False  
    [JsonProperty("product_template_attribute_value_ids")]
    public long[]? ProductTemplateAttributeValueIds { get; set; }

    /// product_template_variant_value_ids - many2many - product.template.attribute.value Required: False, Readonly: False, Store: True, Sortable: False   
    [JsonProperty("product_template_variant_value_ids")]
    public long[]? ProductTemplateVariantValueIds { get; set; }
        
    /// combination_indices - char Required: False, Readonly: True, Store: True, Sortable: True    
    [JsonProperty("combination_indices")]
    public string? CombinationIndices { get; set; }
    
    /// is_product_variant - boolean  Required: False, Readonly: True, Store: False, Sortable: False     
    [JsonProperty("is_product_variant")]
    public bool? IsProductVariant { get; set; }
    
    /// standard_price - float Required: False, Readonly: False, Store: False, Sortable: False    
    [JsonProperty("standard_price")]
    public double? StandardPrice { get; set; }
   
    /// volume - float Required: False, Readonly: False, Store: True, Sortable: True       
    [JsonProperty("volume")]
    public double? Volume { get; set; }
   
    /// weight - float Required: False, Readonly: False, Store: True, Sortable: True      
    [JsonProperty("weight")]
    public double? Weight { get; set; }
  
    /// pricelist_item_count - integer Required: False, Readonly: True, Store: False, Sortable: False    
    [JsonProperty("pricelist_item_count")]
    public int? PricelistItemCount { get; set; }
    
    /// packaging_ids - one2many - product.packaging (product_id) Required: False, Readonly: False, Store: True, Sortable: False   
    [JsonProperty("packaging_ids")]
    public long[]? PackagingIds { get; set; }

     
    /// additional_product_tag_ids - many2many - product.tag  Required: False, Readonly: False, Store: True, Sortable: False  
    [JsonProperty("additional_product_tag_ids")]
    public long[]? AdditionalProductTagIds { get; set; }
    
    /// all_product_tag_ids - many2many - product.tag  Required: False, Readonly: True, Store: False, Sortable: False  
    [JsonProperty("all_product_tag_ids")]
    public long[]? AllProductTagIds { get; set; }
    
    /// image_variant_1920 - binary Required: False, Readonly: False, Store: True, Sortable: False     
    [JsonProperty("image_variant_1920")]
    public string? ImageVariant1920 { get; set; }
    
    /// image_variant_1024 - binary  Required: False, Readonly: True, Store: True, Sortable: False   
    [JsonProperty("image_variant_1024")]
    public string? ImageVariant1024 { get; set; }
    
    /// image_variant_512 - binary  Required: False, Readonly: True, Store: True, Sortable: False   
    [JsonProperty("image_variant_512")]
    public string? ImageVariant512 { get; set; }
   
    /// image_variant_256 - binary   Required: False, Readonly: True, Store: True, Sortable: False   
    [JsonProperty("image_variant_256")]
    public string? ImageVariant256 { get; set; }
    
    /// image_variant_128 - binary  Required: False, Readonly: True, Store: True, Sortable: False   
    [JsonProperty("image_variant_128")]
    public string? ImageVariant128 { get; set; }
    
    /// can_image_variant_1024_be_zoomed - boolean  Required: False, Readonly: True, Store: True, Sortable: True    
    [JsonProperty("can_image_variant_1024_be_zoomed")]
    public bool? CanImageVariant1024BeZoomed { get; set; }
   
    /// image_1920 - binary Required: False, Readonly: False, Store: False, Sortable: False    
    [JsonProperty("image_1920")]
    public string? Image1920 { get; set; }
    
    /// image_1024 - binary  Required: False, Readonly: True, Store: False, Sortable: False   
    [JsonProperty("image_1024")]
    public string? Image1024 { get; set; }

     
    /// image_512 - binary   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("image_512")]
    public string? Image512 { get; set; }

     
    /// image_256 - binary   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("image_256")]
    public string? Image256 { get; set; }

     
    /// image_128 - binary   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("image_128")]
    public string? Image128 { get; set; }

     
    /// can_image_1024_be_zoomed - boolean   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("can_image_1024_be_zoomed")]
    public bool? CanImage1024BeZoomed { get; set; }

     
    /// id - integer   
    /// Required: False, Readonly: True, Store: True, Sortable: True  
     
    [JsonProperty("id")]
    public long Id { get; set; }

     
    /// __last_update - datetime   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("__last_update")]
    public DateTime? LastUpdate { get; set; }

     
    /// display_name - char   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("display_name")]
    public string? DisplayName { get; set; }

     
    /// create_uid - many2one - res.users  
    /// Required: False, Readonly: True, Store: True, Sortable: True  
     
    [JsonProperty("create_uid")]
    public long? CreateUid { get; set; }

     
    /// create_date - datetime   
    /// Required: False, Readonly: True, Store: True, Sortable: True  
     
    [JsonProperty("create_date")]
    public DateTime? CreateDate { get; set; }

     
    /// write_uid - many2one - res.users  
    /// Required: False, Readonly: True, Store: True, Sortable: True  
     
    [JsonProperty("write_uid")]
    public long? WriteUid { get; set; }

     
    /// write_date - datetime   
    /// Required: False, Readonly: True, Store: True, Sortable: True  
     
    [JsonProperty("write_date")]
    public DateTime? WriteDate { get; set; }

     
    /// product_length - float   
    /// Required: False, Readonly: False, Store: True, Sortable: True  
     
    [JsonProperty("product_length")]
    public double? ProductLength { get; set; }

     
    /// product_height - float   
    /// Required: False, Readonly: False, Store: True, Sortable: True  
     
    [JsonProperty("product_height")]
    public double? ProductHeight { get; set; }

     
    /// product_width - float   
    /// Required: False, Readonly: False, Store: True, Sortable: True  
     
    [JsonProperty("product_width")]
    public double? ProductWidth { get; set; }

     
    /// dimensional_uom_id - many2one - uom.uom  
    /// Required: False, Readonly: False, Store: True, Sortable: True  
    /// Help: UoM for length, height, width  
     
    [JsonProperty("dimensional_uom_id")]
    public long? DimensionalUomId { get; set; }

     
    /// tax_string - char   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("tax_string")]
    public string? TaxString { get; set; }

     
    /// stock_quant_ids - one2many - stock.quant (product_id)  
    /// Required: False, Readonly: False, Store: True, Sortable: False  
     
    [JsonProperty("stock_quant_ids")]
    public long[]? StockQuantIds { get; set; }

     
    /// stock_move_ids - one2many - stock.move (product_id)  
    /// Required: False, Readonly: False, Store: True, Sortable: False  
     
    [JsonProperty("stock_move_ids")]
    public long[]? StockMoveIds { get; set; }

     
    /// qty_available - float   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
    /// Help: Current quantity of products.; In a context with a single Stock Location, this includes goods stored at this Location, or any of its children.; In a context with a single Warehouse, this includes goods stored in the Stock Location of this Warehouse, or any of its children.; stored in the Stock Location of the Warehouse of this Shop, or any of its children.; Otherwise, this includes goods stored in any Stock Location with 'internal' type.  
     
    [JsonProperty("qty_available")]
    public double? QtyAvailable { get; set; }

     
    /// virtual_available - float   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
    /// Help: Forecast quantity (computed as Quantity On Hand - Outgoing + Incoming); In a context with a single Stock Location, this includes goods stored in this location, or any of its children.; In a context with a single Warehouse, this includes goods stored in the Stock Location of this Warehouse, or any of its children.; Otherwise, this includes goods stored in any Stock Location with 'internal' type.  
     
    [JsonProperty("virtual_available")]
    public double? VirtualAvailable { get; set; }

     
    /// free_qty - float   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
    /// Help: Forecast quantity (computed as Quantity On Hand - reserved quantity); In a context with a single Stock Location, this includes goods stored in this location, or any of its children.; In a context with a single Warehouse, this includes goods stored in the Stock Location of this Warehouse, or any of its children.; Otherwise, this includes goods stored in any Stock Location with 'internal' type.  
     
    [JsonProperty("free_qty")]
    public double? FreeQty { get; set; }

     
    /// incoming_qty - float   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
    /// Help: Quantity of planned incoming products.; In a context with a single Stock Location, this includes goods arriving to this Location, or any of its children.; In a context with a single Warehouse, this includes goods arriving to the Stock Location of this Warehouse, or any of its children.; Otherwise, this includes goods arriving to any Stock Location with 'internal' type.  
     
    [JsonProperty("incoming_qty")]
    public double? IncomingQty { get; set; }

     
    /// outgoing_qty - float   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
    /// Help: Quantity of planned outgoing products.; In a context with a single Stock Location, this includes goods leaving this Location, or any of its children.; In a context with a single Warehouse, this includes goods leaving the Stock Location of this Warehouse, or any of its children.; Otherwise, this includes goods leaving any Stock Location with 'internal' type.  
     
    [JsonProperty("outgoing_qty")]
    public double? OutgoingQty { get; set; }

     
    /// orderpoint_ids - one2many - stock.warehouse.orderpoint (product_id)  
    /// Required: False, Readonly: False, Store: True, Sortable: False  
     
    [JsonProperty("orderpoint_ids")]
    public long[]? OrderpointIds { get; set; }

     
    /// nbr_moves_in - integer   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
    /// Help: Number of incoming stock moves in the past 12 months  
     
    [JsonProperty("nbr_moves_in")]
    public int? NbrMovesIn { get; set; }

     
    /// nbr_moves_out - integer   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
    /// Help: Number of outgoing stock moves in the past 12 months  
     
    [JsonProperty("nbr_moves_out")]
    public int? NbrMovesOut { get; set; }

     
    /// nbr_reordering_rules - integer   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("nbr_reordering_rules")]
    public int? NbrReorderingRules { get; set; }

     
    /// reordering_min_qty - float   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("reordering_min_qty")]
    public double? ReorderingMinQty { get; set; }

     
    /// reordering_max_qty - float   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("reordering_max_qty")]
    public double? ReorderingMaxQty { get; set; }

     
    /// putaway_rule_ids - one2many - stock.putaway.rule (product_id)  
    /// Required: False, Readonly: False, Store: True, Sortable: False  
     
    [JsonProperty("putaway_rule_ids")]
    public long[]? PutawayRuleIds { get; set; }

     
    /// storage_category_capacity_ids - one2many - stock.storage.category.capacity (product_id)  
    /// Required: False, Readonly: False, Store: True, Sortable: False  
     
    [JsonProperty("storage_category_capacity_ids")]
    public long[]? StorageCategoryCapacityIds { get; set; }

     
    /// show_on_hand_qty_status_button - boolean   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("show_on_hand_qty_status_button")]
    public bool? ShowOnHandQtyStatusButton { get; set; }

     
    /// show_forecasted_qty_status_button - boolean   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("show_forecasted_qty_status_button")]
    public bool? ShowForecastedQtyStatusButton { get; set; }

     
    /// valid_ean - boolean   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("valid_ean")]
    public bool? ValidEan { get; set; }

     
    /// variant_bom_ids - one2many - mrp.bom (product_id)  
    /// Required: False, Readonly: False, Store: True, Sortable: False  
     
    [JsonProperty("variant_bom_ids")]
    public long[]? VariantBomIds { get; set; }

     
    /// bom_line_ids - one2many - mrp.bom.line (product_id)  
    /// Required: False, Readonly: False, Store: True, Sortable: False  
     
    [JsonProperty("bom_line_ids")]
    public long[]? BomLineIds { get; set; }

     
    /// bom_count - integer   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("bom_count")]
    public int? BomCount { get; set; }

     
    /// used_in_bom_count - integer   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("used_in_bom_count")]
    public int? UsedInBomCount { get; set; }

     
    /// mrp_product_qty - float   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("mrp_product_qty")]
    public double? MrpProductQty { get; set; }

     
    /// is_kits - boolean   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("is_kits")]
    public bool? IsKits { get; set; }

     
    /// purchased_product_qty - float   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("purchased_product_qty")]
    public double? PurchasedProductQty { get; set; }

     
    /// value_svl - float   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("value_svl")]
    public double? ValueSvl { get; set; }

     
    /// quantity_svl - float   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("quantity_svl")]
    public double? QuantitySvl { get; set; }

     
    /// avg_cost - monetary   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("avg_cost")]
    public decimal? AvgCost { get; set; }

     
    /// total_value - monetary   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("total_value")]
    public decimal? TotalValue { get; set; }

     
    /// company_currency_id - many2one - res.currency  
    /// Required: False, Readonly: True, Store: False, Sortable: False  
    /// Help: Technical field to correctly show the currently selected company's currency that corresponds to the totaled value of the product's valuation layers  
     
    [JsonProperty("company_currency_id")]
    public long? CompanyCurrencyId { get; set; }

     
    /// stock_valuation_layer_ids - one2many - stock.valuation.layer (product_id)  
    /// Required: False, Readonly: False, Store: True, Sortable: False  
     
    [JsonProperty("stock_valuation_layer_ids")]
    public long[]? StockValuationLayerIds { get; set; }

     
    /// valuation - selection   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
    /// Help: Manual: The accounting entries to value the inventory are not posted automatically.;         Automated: An accounting entry is automatically created to value the inventory when a product enters or leaves the company.;           
     
    [JsonProperty("valuation")]
    public InventoryValuationProductProductOdooEnum? Valuation { get; set; }

     
    /// cost_method - selection   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
    /// Help: Standard Price: The products are valued at their standard cost defined on the product.;         Average Cost (AVCO): The products are valued at weighted average cost.;         First In First Out (FIFO): The products are valued supposing those that enter the company first will also leave it first.;           
     
    [JsonProperty("cost_method")]
    public CostingMethodProductProductOdooEnum? CostMethod { get; set; }

     
    /// purchase_order_line_ids - one2many - purchase.order.line (product_id)  
    /// Required: False, Readonly: False, Store: True, Sortable: False  
     
    [JsonProperty("purchase_order_line_ids")]
    public long[]? PurchaseOrderLineIds { get; set; }

     
    /// sales_count - float   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("sales_count")]
    public double? SalesCount { get; set; }

     
    /// website_id - many2one - website  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
    /// Help: Restrict publishing to this website.  
     
    [JsonProperty("website_id")]
    public long? WebsiteId { get; set; }

     
    /// product_variant_image_ids - one2many - product.image (product_variant_id)  
    /// Required: False, Readonly: False, Store: True, Sortable: False  
     
    [JsonProperty("product_variant_image_ids")]
    public long[]? ProductVariantImageIds { get; set; }

     
    /// website_url - char   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
    /// Help: The full URL to access the document through the website.  
     
    [JsonProperty("website_url")]
    public string? WebsiteUrl { get; set; }

     
    /// base_unit_count - float   
    /// Required: True, Readonly: False, Store: True, Sortable: True  
    /// Help: Display base unit price on your eCommerce pages. Set to 0 to hide it for this product.  
     
    [JsonProperty("base_unit_count")]
    public double BaseUnitCount { get; set; }

     
    /// base_unit_id - many2one - website.base.unit  
    /// Required: False, Readonly: False, Store: True, Sortable: True  
    /// Help: Define a custom unit to display in the price per unit of measure field.  
     
    [JsonProperty("base_unit_id")]
    public long? BaseUnitId { get; set; }

     
    /// base_unit_price - monetary   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("base_unit_price")]
    public decimal? BaseUnitPrice { get; set; }

     
    /// base_unit_name - char   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
    /// Help: Displays the custom unit for the products if defined or the selected unit of measure otherwise.  
     
    [JsonProperty("base_unit_name")]
    public string? BaseUnitName { get; set; }

     
    /// stock_notification_partner_ids - many2many - res.partner  
    /// Required: False, Readonly: False, Store: True, Sortable: False  
     
    [JsonProperty("stock_notification_partner_ids")]
    public long[]? StockNotificationPartnerIds { get; set; }

     
    /// refart_no_export - boolean   
    /// Required: False, Readonly: False, Store: True, Sortable: True  
     
    [JsonProperty("refart_no_export")]
    public bool? RefartNoExport { get; set; }

     
    /// rating_ids - one2many - rating.rating  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
     
    [JsonProperty("rating_ids")]
    public long[]? RatingIds { get; set; }

     
    /// rating_last_value - float   
    /// Required: False, Readonly: True, Store: False, Sortable: True  
     
    [JsonProperty("rating_last_value")]
    public double? RatingLastValue { get; set; }

     
    /// rating_last_feedback - text   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("rating_last_feedback")]
    public string? RatingLastFeedback { get; set; }

     
    /// rating_last_image - binary   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("rating_last_image")]
    public string? RatingLastImage { get; set; }

     
    /// rating_count - integer   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("rating_count")]
    public int? RatingCount { get; set; }

     
    /// rating_avg - float   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("rating_avg")]
    public double? RatingAvg { get; set; }

     
    /// rating_avg_text - selection   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("rating_avg_text")]
    public RatingAvgTextProductProductOdooEnum? RatingAvgText { get; set; }

     
    /// rating_percentage_satisfaction - float   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("rating_percentage_satisfaction")]
    public double? RatingPercentageSatisfaction { get; set; }

     
    /// rating_last_text - selection   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("rating_last_text")]
    public RatingTextProductProductOdooEnum? RatingLastText { get; set; }

     
    /// website_published - boolean   
    /// Required: False, Readonly: False, Store: False, Sortable: False  
     
    [JsonProperty("website_published")]
    public bool? WebsitePublished { get; set; }

     
    /// is_published - boolean   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("is_published")]
    public bool? IsPublished { get; set; }

     
    /// can_publish - boolean   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("can_publish")]
    public bool? CanPublish { get; set; }

     
    /// is_seo_optimized - boolean   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("is_seo_optimized")]
    public bool? IsSeoOptimized { get; set; }

     
    /// website_meta_title - char   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("website_meta_title")]
    public string? WebsiteMetaTitle { get; set; }

     
    /// website_meta_description - text   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("website_meta_description")]
    public string? WebsiteMetaDescription { get; set; }

     
    /// website_meta_keywords - char   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("website_meta_keywords")]
    public string? WebsiteMetaKeywords { get; set; }

     
    /// website_meta_og_img - char   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("website_meta_og_img")]
    public string? WebsiteMetaOgImg { get; set; }

     
    /// seo_name - char   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("seo_name")]
    public string? SeoName { get; set; }

     
    /// name - char   
    /// Required: True, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("name")]
    public string? Name { get; set; }

     
    /// sequence - integer   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: Gives the sequence order when displaying a product list  
     
    [JsonProperty("sequence")]
    public int? Sequence { get; set; }

     
    /// description - html   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("description")]
    public string? Description { get; set; }

     
    /// description_purchase - text   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("description_purchase")]
    public string? DescriptionPurchase { get; set; }

     
    /// description_sale - text   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: A description of the Product that you want to communicate to your customers. This description will be copied to every Sales Order, Delivery Order and Customer Invoice/Credit Note  
     
    [JsonProperty("description_sale")]
    public string? DescriptionSale { get; set; }

     
    /// detailed_type - selection   
    /// Required: True, Readonly: False, Store: False, Sortable: True  
    /// Help: A storable product is a product for which you manage stock. The Inventory app has to be installed.; A consumable product is a product for which stock is not managed.; A service is a non-material product you provide.  
     
    [JsonProperty("detailed_type")]
    public ProductTypeProductProductOdooEnum DetailedType { get; set; }

     
    /// type - selection   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("type")]
    public TypeProductProductOdooEnum? Type { get; set; }

     
    /// categ_id - many2one - product.category  
    /// Required: True, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("categ_id")]
    public long CategId { get; set; }

     
    /// currency_id - many2one - res.currency  
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("currency_id")]
    public long? CurrencyId { get; set; }

     
    /// cost_currency_id - many2one - res.currency  
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("cost_currency_id")]
    public long? CostCurrencyId { get; set; }

     
    /// list_price - float   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: Price at which the product is sold to customers.  
     
    [JsonProperty("list_price")]
    public double? ListPrice { get; set; }

     
    /// volume_uom_name - char   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("volume_uom_name")]
    public string? VolumeUomName { get; set; }

     
    /// weight_uom_name - char   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("weight_uom_name")]
    public string? WeightUomName { get; set; }

     
    /// sale_ok - boolean   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("sale_ok")]
    public bool? SaleOk { get; set; }

     
    /// purchase_ok - boolean   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("purchase_ok")]
    public bool? PurchaseOk { get; set; }

     
    /// uom_id - many2one - uom.uom  
    /// Required: True, Readonly: False, Store: False, Sortable: True  
    /// Help: Default unit of measure used for all stock operations.  
     
    [JsonProperty("uom_id")]
    public long UomId { get; set; }

     
    /// uom_name - char   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("uom_name")]
    public string? UomName { get; set; }

     
    /// uom_po_id - many2one - uom.uom  
    /// Required: True, Readonly: False, Store: False, Sortable: True  
    /// Help: Default unit of measure used for purchase orders. It must be in the same category as the default unit of measure.  
     
    [JsonProperty("uom_po_id")]
    public long UomPoId { get; set; }

     
    /// company_id - many2one - res.company  
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("company_id")]
    public long? CompanyId { get; set; }

     
    /// seller_ids - one2many - product.supplierinfo  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
     
    [JsonProperty("seller_ids")]
    public long[]? SellerIds { get; set; }

     
    /// variant_seller_ids - one2many - product.supplierinfo  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
     
    [JsonProperty("variant_seller_ids")]
    public long[]? VariantSellerIds { get; set; }

     
    /// color - integer   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("color")]
    public int? Color { get; set; }

     
    /// attribute_line_ids - one2many - product.template.attribute.line  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
     
    [JsonProperty("attribute_line_ids")]
    public long[]? AttributeLineIds { get; set; }

     
    /// valid_product_template_attribute_line_ids - many2many - product.template.attribute.line  
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("valid_product_template_attribute_line_ids")]
    public long[]? ValidProductTemplateAttributeLineIds { get; set; }

     
    /// product_variant_ids - one2many - product.product  
    /// Required: True, Readonly: False, Store: False, Sortable: False  
     
    [JsonProperty("product_variant_ids")]
    public long[]? ProductVariantIds { get; set; }

     
    /// product_variant_id - many2one - product.product  
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("product_variant_id")]
    public long? ProductVariantId { get; set; }

     
    /// product_variant_count - integer   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("product_variant_count")]
    public int? ProductVariantCount { get; set; }

     
    /// has_configurable_attributes - boolean   
    /// Required: False, Readonly: True, Store: False, Sortable: True  
     
    [JsonProperty("has_configurable_attributes")]
    public bool? HasConfigurableAttributes { get; set; }

     
    /// product_tooltip - char   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("product_tooltip")]
    public string? ProductTooltip { get; set; }

     
    /// priority - selection   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("priority")]
    public FavoriteProductProductOdooEnum? Priority { get; set; }

     
    /// product_tag_ids - many2many - product.tag  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
     
    [JsonProperty("product_tag_ids")]
    public long[]? ProductTagIds { get; set; }

     
    /// hs_code_id - many2one - hs.code  
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: Harmonised System Code. Nomenclature is available from the World Customs Organisation, see http://www.wcoomd.org/. You can leave this field empty and configure the H.S. code on the product category.  
     
    [JsonProperty("hs_code_id")]
    public long? HsCodeId { get; set; }

     
    /// origin_country_id - many2one - res.country  
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: Country of origin of the product i.e. product 'made in ____'.  
     
    [JsonProperty("origin_country_id")]
    public long? OriginCountryId { get; set; }

     
    /// categ_ids - many2many - product.category  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
     
    [JsonProperty("categ_ids")]
    public long[]? CategIds { get; set; }

     
    /// product_images_ids - many2many - ir.attachment  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
     
    [JsonProperty("product_images_ids")]
    public long[]? ProductImagesIds { get; set; }

     
    /// ref_supplier - char   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("ref_supplier")]
    public string? RefSupplier { get; set; }

     
    /// ean_supplier - char   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("ean_supplier")]
    public string? EanSupplier { get; set; }

     
    /// concat_url_field - char   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("concat_url_field")]
    public string? ConcatUrlField { get; set; }

     
    /// taxes_id - many2many - account.tax  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
    /// Help: Default taxes used when selling the product.  
     
    [JsonProperty("taxes_id")]
    public long[]? TaxesId { get; set; }

     
    /// supplier_taxes_id - many2many - account.tax  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
    /// Help: Default taxes used when buying the product.  
     
    [JsonProperty("supplier_taxes_id")]
    public long[]? SupplierTaxesId { get; set; }

     
    /// property_account_income_id - many2one - account.account  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
    /// Help: Keep this field empty to use the default value from the product category.  
     
    [JsonProperty("property_account_income_id")]
    public long? PropertyAccountIncomeId { get; set; }

     
    /// property_account_expense_id - many2one - account.account  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
    /// Help: Keep this field empty to use the default value from the product category. If anglo-saxon accounting with automated valuation method is configured, the expense account on the product category will be used.  
     
    [JsonProperty("property_account_expense_id")]
    public long? PropertyAccountExpenseId { get; set; }

     
    /// account_tag_ids - many2many - account.account.tag  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
    /// Help: Tags to be set on the base and tax journal items created for this product.  
     
    [JsonProperty("account_tag_ids")]
    public long[]? AccountTagIds { get; set; }

     
    /// responsible_id - many2one - res.users  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
    /// Help: This user will be responsible of the next activities related to logistic operations for this product.  
     
    [JsonProperty("responsible_id")]
    public long? ResponsibleId { get; set; }

     
    /// property_stock_production - many2one - stock.location  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
    /// Help: This stock location will be used, instead of the default one, as the source location for stock moves generated by manufacturing orders.  
     
    [JsonProperty("property_stock_production")]
    public long? PropertyStockProduction { get; set; }

     
    /// property_stock_inventory - many2one - stock.location  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
    /// Help: This stock location will be used, instead of the default one, as the source location for stock moves generated when you do an inventory.  
     
    [JsonProperty("property_stock_inventory")]
    public long? PropertyStockInventory { get; set; }

     
    /// sale_delay - float   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: Delivery lead time, in days. It's the number of days, promised to the customer, between the confirmation of the sales order and the delivery.  
     
    [JsonProperty("sale_delay")]
    public double? SaleDelay { get; set; }

     
    /// tracking - selection   
    /// Required: True, Readonly: False, Store: False, Sortable: True  
    /// Help: Ensure the traceability of a storable product in your warehouse.  
     
    [JsonProperty("tracking")]
    public TrackingProductProductOdooEnum Tracking { get; set; }

     
    /// description_picking - text   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("description_picking")]
    public string? DescriptionPicking { get; set; }

     
    /// description_pickingout - text   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("description_pickingout")]
    public string? DescriptionPickingout { get; set; }

     
    /// description_pickingin - text   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("description_pickingin")]
    public string? DescriptionPickingin { get; set; }

     
    /// location_id - many2one - stock.location  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
     
    [JsonProperty("location_id")]
    public long? LocationId { get; set; }

     
    /// warehouse_id - many2one - stock.warehouse  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
     
    [JsonProperty("warehouse_id")]
    public long? WarehouseId { get; set; }

     
    /// has_available_route_ids - boolean   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("has_available_route_ids")]
    public bool? HasAvailableRouteIds { get; set; }

     
    /// route_ids - many2many - stock.route  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
    /// Help: Depending on the modules installed, this will allow you to define the route of the product: whether it will be bought, manufactured, replenished on order, etc.  
     
    [JsonProperty("route_ids")]
    public long[]? RouteIds { get; set; }

     
    /// route_from_categ_ids - many2many - stock.route  
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("route_from_categ_ids")]
    public long[]? RouteFromCategIds { get; set; }

     
    /// bom_ids - one2many - mrp.bom  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
     
    [JsonProperty("bom_ids")]
    public long[]? BomIds { get; set; }

     
    /// produce_delay - float   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: Average lead time in days to manufacture this product. In the case of multi-level BOM, the manufacturing lead times of the components will be added. In case the product is subcontracted, this can be used to determine the date at which components should be sent to the subcontractor.  
     
    [JsonProperty("produce_delay")]
    public double? ProduceDelay { get; set; }

     
    /// days_to_prepare_mo - float   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: Create and confirm Manufacturing Orders this many days in advance, to have enough time to replenish components or manufacture semi-finished products.; Note that security lead times will also be considered when appropriate.  
     
    [JsonProperty("days_to_prepare_mo")]
    public double? DaysToPrepareMo { get; set; }

     
    /// purchase_method - selection   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: On ordered quantities: Control bills based on ordered quantities.; On received quantities: Control bills based on received quantities.  
     
    [JsonProperty("purchase_method")]
    public ControlPolicyProductProductOdooEnum? PurchaseMethod { get; set; }

     
    /// purchase_line_warn - selection   
    /// Required: True, Readonly: False, Store: False, Sortable: True  
    /// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field.  
     
    [JsonProperty("purchase_line_warn")]
    public PurchaseOrderLineWarningProductProductOdooEnum PurchaseLineWarn { get; set; }

     
    /// purchase_line_warn_msg - text   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("purchase_line_warn_msg")]
    public string? PurchaseLineWarnMsg { get; set; }

     
    /// available_in_pos - boolean   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: Check if you want this product to appear in the Point of Sale.  
     
    [JsonProperty("available_in_pos")]
    public bool? AvailableInPos { get; set; }

     
    /// to_weight - boolean   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: Check if the product should be weighted using the hardware scale integration.  
     
    [JsonProperty("to_weight")]
    public bool? ToWeight { get; set; }

     
    /// pos_categ_id - many2one - pos.category  
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: Category used in the Point of Sale.  
     
    [JsonProperty("pos_categ_id")]
    public long? PosCategId { get; set; }

     
    /// service_type - selection   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: Manually set quantities on order: Invoice based on the manually entered quantity, without creating an analytic account.; Timesheets on contract: Invoice based on the tracked hours on the related timesheet.; Create a task and track hours: Create a task on the sales order validation and track the work hours.  
     
    [JsonProperty("service_type")]
    public TrackServiceProductProductOdooEnum? ServiceType { get; set; }

     
    /// sale_line_warn - selection   
    /// Required: True, Readonly: False, Store: False, Sortable: True  
    /// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field.  
     
    [JsonProperty("sale_line_warn")]
    public SalesOrderLineProductProductOdooEnum SaleLineWarn { get; set; }

     
    /// sale_line_warn_msg - text   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("sale_line_warn_msg")]
    public string? SaleLineWarnMsg { get; set; }

     
    /// expense_policy - selection   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: Expenses and vendor bills can be re-invoiced to a customer.With this option, a validated expense can be re-invoice to a customer at its cost or sales price.  
     
    [JsonProperty("expense_policy")]
    public ReInvoiceExpensesProductProductOdooEnum? ExpensePolicy { get; set; }

     
    /// visible_expense_policy - boolean   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("visible_expense_policy")]
    public bool? VisibleExpensePolicy { get; set; }

     
    /// visible_qty_configurator - boolean   
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("visible_qty_configurator")]
    public bool? VisibleQtyConfigurator { get; set; }

     
    /// invoice_policy - selection   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: Ordered Quantity: Invoice quantities ordered by the customer.; Delivered Quantity: Invoice quantities delivered to the customer.  
     
    [JsonProperty("invoice_policy")]
    public InvoicingPolicyProductProductOdooEnum? InvoicePolicy { get; set; }

     
    /// property_account_creditor_price_difference - many2one - account.account  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
    /// Help: This account is used in automated inventory valuation to record the price difference between a purchase order and its related vendor bill when validating this vendor bill.  
     
    [JsonProperty("property_account_creditor_price_difference")]
    public long? PropertyAccountCreditorPriceDifference { get; set; }

     
    /// optional_product_ids - many2many - product.template  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
    /// Help: Optional Products are suggested whenever the customer hits *Add to Cart* (cross-sell strategy, e.g. for computers: warranty, software, etc.).  
     
    [JsonProperty("optional_product_ids")]
    public long[]? OptionalProductIds { get; set; }

     
    /// service_to_purchase - boolean   
    /// Required: False, Readonly: False, Store: False, Sortable: False  
    /// Help: If ticked, each time you sell this product through a SO, a RfQ is automatically created to buy the product. Tip: don't forget to set a vendor on the product.  
     
    [JsonProperty("service_to_purchase")]
    public bool? ServiceToPurchase { get; set; }

     
    /// website_description - html   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("website_description")]
    public string? WebsiteDescription { get; set; }

     
    /// alternative_product_ids - many2many - product.template  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
    /// Help: Suggest alternatives to your customer (upsell strategy). Those products show up on the product page.  
     
    [JsonProperty("alternative_product_ids")]
    public long[]? AlternativeProductIds { get; set; }

     
    /// accessory_product_ids - many2many - product.product  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
    /// Help: Accessories show up when the customer reviews the cart before payment (cross-sell strategy).  
     
    [JsonProperty("accessory_product_ids")]
    public long[]? AccessoryProductIds { get; set; }

     
    /// website_size_x - integer   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("website_size_x")]
    public int? WebsiteSizeX { get; set; }

     
    /// website_size_y - integer   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("website_size_y")]
    public int? WebsiteSizeY { get; set; }

     
    /// website_ribbon_id - many2one - product.ribbon  
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("website_ribbon_id")]
    public long? WebsiteRibbonId { get; set; }

     
    /// website_sequence - integer   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: Determine the display order in the Website E-commerce  
     
    [JsonProperty("website_sequence")]
    public int? WebsiteSequence { get; set; }

     
    /// public_categ_ids - many2many - product.public.category  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
    /// Help: The product will be available in each mentioned eCommerce category. Go to Shop > Edit Click on the page and enable 'Categories' to view all eCommerce categories.  
     
    [JsonProperty("public_categ_ids")]
    public long[]? PublicCategIds { get; set; }

     
    /// product_template_image_ids - one2many - product.image  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
     
    [JsonProperty("product_template_image_ids")]
    public long[]? ProductTemplateImageIds { get; set; }

     
    /// compare_list_price - float   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: The amount will be displayed strikethroughed on the eCommerce product page  
     
    [JsonProperty("compare_list_price")]
    public double? CompareListPrice { get; set; }

     
    /// hs_code - char   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: Standardized code for international shipping and goods declaration. At the moment, only used for the FedEx shipping provider.  
     
    [JsonProperty("hs_code")]
    public string? HsCode { get; set; }

     
    /// country_of_origin - many2one - res.country  
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: Rules of origin determine where goods originate, i.e. not where they have been shipped from, but where they have been produced or manufactured.; As such, the 'origin' is the 'economic nationality' of goods traded in commerce.  
     
    [JsonProperty("country_of_origin")]
    public long? CountryOfOrigin { get; set; }

     
    /// product_add_mode - selection   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: Configurator: choose attribute values to add the matching product variant to the order.; Grid: add several variants at once from the grid of attribute values  
     
    [JsonProperty("product_add_mode")]
    public AddProductModeProductProductOdooEnum? ProductAddMode { get; set; }

     
    /// service_tracking - selection   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
    /// Help: On Sales order confirmation, this product can generate a project and/or task.         From those, you can track the service you are selling.;          'In sale order's project': Will use the sale order's configured project if defined or fallback to         creating a new project based on the selected template.  
     
    [JsonProperty("service_tracking")]
    public CreateOnOrderProductProductOdooEnum? ServiceTracking { get; set; }

     
    /// project_id - many2one - project.project  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
     
    [JsonProperty("project_id")]
    public long? ProjectId { get; set; }

     
    /// project_template_id - many2one - project.project  
    /// Required: False, Readonly: False, Store: False, Sortable: False  
     
    [JsonProperty("project_template_id")]
    public long? ProjectTemplateId { get; set; }

     
    /// service_policy - selection   
    /// Required: False, Readonly: False, Store: False, Sortable: False  
     
    [JsonProperty("service_policy")]
    public ServiceInvoicingPolicyProductProductOdooEnum? ServicePolicy { get; set; }

     
    /// allow_out_of_stock_order - boolean   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("allow_out_of_stock_order")]
    public bool? AllowOutOfStockOrder { get; set; }

     
    /// available_threshold - float   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("available_threshold")]
    public double? AvailableThreshold { get; set; }

     
    /// show_availability - boolean   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("show_availability")]
    public bool? ShowAvailability { get; set; }

     
    /// out_of_stock_message - html   
    /// Required: False, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("out_of_stock_message")]
    
    public string? OutOfStockMessage { get; set; }
        
    }
    

/// Help: Status based on activities  
/// Overdue: Due date is already passed  
/// Today: Activity date is today  
/// Planned: Future activities.
 
[JsonConverter(typeof(StringEnumConverter))]
public enum ActivityStateProductProductOdooEnum
{
    [EnumMember(Value = "overdue")]
    Overdue = 1,

    [EnumMember(Value = "today")]
    Today = 2,

    [EnumMember(Value = "planned")]
    Planned = 3,
}


 
/// Help: Type of the exception activity on record.
 
[JsonConverter(typeof(StringEnumConverter))]
public enum ActivityExceptionDecorationProductProductOdooEnum
{
    [EnumMember(Value = "warning")]
    Alert = 1,

    [EnumMember(Value = "danger")]
    Error = 2,
}


 
/// Help: Manual: The accounting entries to value the inventory are not posted automatically.  
///         Automated: An accounting entry is automatically created to value the inventory when a product enters or leaves the company.  
///
 
[JsonConverter(typeof(StringEnumConverter))]
public enum InventoryValuationProductProductOdooEnum
{
    [EnumMember(Value = "manual_periodic")]
    Manual = 1,

    [EnumMember(Value = "real_time")]
    Automated = 2,
}


 
/// Help: Standard Price: The products are valued at their standard cost defined on the product.  
///         Average Cost (AVCO): The products are valued at weighted average cost.  
///         First In First Out (FIFO): The products are valued supposing those that enter the company first will also leave it first.  
///
 
[JsonConverter(typeof(StringEnumConverter))]
public enum CostingMethodProductProductOdooEnum
{
    [EnumMember(Value = "standard")]
    StandardPrice = 1,

    [EnumMember(Value = "fifo")]
    FirstInFirstOutFIFO = 2,

    [EnumMember(Value = "average")]
    AverageCostAVCO = 3,
}


 
 
[JsonConverter(typeof(StringEnumConverter))]
public enum RatingAvgTextProductProductOdooEnum
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


 
 
[JsonConverter(typeof(StringEnumConverter))]
public enum RatingTextProductProductOdooEnum
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


 
/// Help: A storable product is a product for which you manage stock. The Inventory app has to be installed.  
/// A consumable product is a product for which stock is not managed.  
/// A service is a non-material product you provide.
 
[JsonConverter(typeof(StringEnumConverter))]
public enum ProductTypeProductProductOdooEnum
{
    [EnumMember(Value = "consu")]
    Consumable = 1,

    [EnumMember(Value = "service")]
    Service = 2,

    [EnumMember(Value = "product")]
    StorableProduct = 3,
}


 
 
[JsonConverter(typeof(StringEnumConverter))]
public enum TypeProductProductOdooEnum
{
    [EnumMember(Value = "consu")]
    Consumable = 1,

    [EnumMember(Value = "service")]
    Service = 2,

    [EnumMember(Value = "product")]
    StorableProduct = 3,
}


 
 
[JsonConverter(typeof(StringEnumConverter))]
public enum FavoriteProductProductOdooEnum
{
    [EnumMember(Value = "0")]
    Normal = 1,

    [EnumMember(Value = "1")]
    Favorite = 2,
}


 
/// Help: Ensure the traceability of a storable product in your warehouse.
 
[JsonConverter(typeof(StringEnumConverter))]
public enum TrackingProductProductOdooEnum
{
    [EnumMember(Value = "serial")]
    ByUniqueSerialNumber = 1,

    [EnumMember(Value = "lot")]
    ByLots = 2,

    [EnumMember(Value = "none")]
    NoTracking = 3,
}


 
/// Help: On ordered quantities: Control bills based on ordered quantities.  
/// On received quantities: Control bills based on received quantities.
 
[JsonConverter(typeof(StringEnumConverter))]
public enum ControlPolicyProductProductOdooEnum
{
    [EnumMember(Value = "purchase")]
    OnOrderedQuantities = 1,

    [EnumMember(Value = "receive")]
    OnReceivedQuantities = 2,
}


 
/// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field.
 
[JsonConverter(typeof(StringEnumConverter))]
public enum PurchaseOrderLineWarningProductProductOdooEnum
{
    [EnumMember(Value = "no-message")]
    NoMessage = 1,

    [EnumMember(Value = "warning")]
    Warning = 2,

    [EnumMember(Value = "block")]
    BlockingMessage = 3,
}


 
/// Help: Manually set quantities on order: Invoice based on the manually entered quantity, without creating an analytic account.  
/// Timesheets on contract: Invoice based on the tracked hours on the related timesheet.  
/// Create a task and track hours: Create a task on the sales order validation and track the work hours.
 
[JsonConverter(typeof(StringEnumConverter))]
public enum TrackServiceProductProductOdooEnum
{
    [EnumMember(Value = "manual")]
    ManuallySetQuantitiesOnOrder = 1,

    [EnumMember(Value = "milestones")]
    ProjectMilestones = 2,
}


 
/// Help: Selecting the "Warning" option will notify user with the message, Selecting "Blocking Message" will throw an exception with the message and block the flow. The Message has to be written in the next field.
 
[JsonConverter(typeof(StringEnumConverter))]
public enum SalesOrderLineProductProductOdooEnum
{
    [EnumMember(Value = "no-message")]
    NoMessage = 1,

    [EnumMember(Value = "warning")]
    Warning = 2,

    [EnumMember(Value = "block")]
    BlockingMessage = 3,
}


 
/// Help: Expenses and vendor bills can be re-invoiced to a customer.With this option, a validated expense can be re-invoice to a customer at its cost or sales price.
 
[JsonConverter(typeof(StringEnumConverter))]
public enum ReInvoiceExpensesProductProductOdooEnum
{
    [EnumMember(Value = "no")]
    No = 1,

    [EnumMember(Value = "cost")]
    AtCost = 2,

    [EnumMember(Value = "sales_price")]
    SalesPrice = 3,
}


 
/// Help: Ordered Quantity: Invoice quantities ordered by the customer.  
/// Delivered Quantity: Invoice quantities delivered to the customer.
 
[JsonConverter(typeof(StringEnumConverter))]
public enum InvoicingPolicyProductProductOdooEnum
{
    [EnumMember(Value = "order")]
    OrderedQuantities = 1,

    [EnumMember(Value = "delivery")]
    DeliveredQuantities = 2,
}


 
/// Help: Configurator: choose attribute values to add the matching product variant to the order.  
/// Grid: add several variants at once from the grid of attribute values
 
[JsonConverter(typeof(StringEnumConverter))]
public enum AddProductModeProductProductOdooEnum
{
    [EnumMember(Value = "configurator")]
    ProductConfigurator = 1,

    [EnumMember(Value = "matrix")]
    OrderGridEntry = 2,
}


 
/// Help: On Sales order confirmation, this product can generate a project and/or task.         From those, you can track the service you are selling.  
///          'In sale order's project': Will use the sale order's configured project if defined or fallback to         creating a new project based on the selected template.
 
[JsonConverter(typeof(StringEnumConverter))]
public enum CreateOnOrderProductProductOdooEnum
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


 
 
[JsonConverter(typeof(StringEnumConverter))]
public enum ServiceInvoicingPolicyProductProductOdooEnum
{
    [EnumMember(Value = "ordered_prepaid")]
    PrPayPrixFixe = 1,

    [EnumMember(Value = "delivered_milestones")]
    BasSurLesJalons = 2,

    [EnumMember(Value = "delivered_manual")]
    BasSurLaQuantitLivrEManuelle = 3,
}
    }