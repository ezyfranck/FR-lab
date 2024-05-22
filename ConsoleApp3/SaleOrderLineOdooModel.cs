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
        /// order_id - many2one - sale.order <br />
        /// Required: True, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("order_id")]
        public long? OrderId { get; set; }


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

        [JsonProperty("product_packaging_id")]
        public long? ProductPackagingId { get; set; }

        /// <summary>
        /// product_packaging_qty - float  <br />
        /// Required: False, Readonly: False, Store: True, Sortable: True <br />
        /// </summary>
        [JsonProperty("product_packaging_qty")]
        public double? ProductPackagingQty { get; set; }

        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("product_qty")]
        public double? ProductQty { get; set; }

        /// <summary>
        /// reached_milestones_ids - one2many - project.milestone (sale_line_id) <br />
        /// Required: False, Readonly: False, Store: True, Sortable: False <br />
        /// </summary>
        [JsonProperty("reached_milestones_ids")]
        public long[]? ReachedMilestonesIds { get; set; }
        long IOdooModel.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

}
