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

    [JsonProperty("default_code")]
    public string? DefaultCode { get; set; }

    /// description - html
    /// Required: False, Readonly: False, Store: False, Sortable: True

    /// lst_price - float Required: False, Readonly: False, Store: False, Sortable: False
    [JsonProperty("lst_price")]
    public double? LstPrice { get; set; }
    [JsonProperty("description")]
    public string? Description { get; set; }

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
     
    /// id - integer   
    /// Required: False, Readonly: True, Store: True, Sortable: True  
     
    [JsonProperty("id")]
    public long Id { get; set; }

    /// name - char   
    /// Required: True, Readonly: False, Store: False, Sortable: True  
     
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// currency_id - many2one - res.currency  
    /// Required: False, Readonly: True, Store: False, Sortable: False  
     
    [JsonProperty("currency_id")]
    public long? CurrencyId { get; set; }
  
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
      
    }
    

}