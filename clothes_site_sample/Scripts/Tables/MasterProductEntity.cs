using System.Text.Json.Serialization;
using clothes_site_sample.scripts.Bases;

namespace clothes_site_sample.Scripts.Tables
{
    public class MasterProductEntity : EntityBase
    {
        [JsonPropertyName("id")] [JsonInclude] public int Id { get; private set; }
        [JsonPropertyName("master_clothes_id")] [JsonInclude] public int MasterClothId { get; private set; }
        [JsonPropertyName("size")] [JsonInclude] public string Size { get; private set; }
        [JsonPropertyName("master_clothes_color_id")] [JsonInclude] public int MasterClothColorId { get; private set; }
        [JsonPropertyName("price")] [JsonInclude] public int Price { get; private set; }
        [JsonPropertyName("quantity")] [JsonInclude] public int Quantity { get; private set; }
        [JsonPropertyName("is_pre_order")] [JsonInclude] public bool IsPreOrder { get; private set; }
        [JsonPropertyName("arrival_date")] [JsonInclude] public string ArrivalDate { get; private set; }

        public MasterProductEntity()
        {
        }
    }
}