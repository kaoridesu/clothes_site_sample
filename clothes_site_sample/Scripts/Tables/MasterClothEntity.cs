using System.Collections.Generic;
using System.Text.Json.Serialization;
using clothes_site_sample.scripts.Bases;

namespace clothes_site_sample.Scripts.Tables
{
    public class MasterClothEntity : EntityBase
    {
        [JsonPropertyName("id")] [JsonInclude] public int Id { get; private set; }
        [JsonPropertyName("category")] [JsonInclude] public string Category { get; private set; }
        [JsonPropertyName("kind")] [JsonInclude] public string Kind { get; private set; }
        [JsonPropertyName("product_name")] [JsonInclude] public string ProductName { get; private set; }
        [JsonPropertyName("code")] [JsonInclude] public string Code { get; private set; }
        [JsonPropertyName("material")] [JsonInclude] public string Material { get; private set; }
        [JsonPropertyName("price")] [JsonInclude] public int Price { get; private set; }
        [JsonPropertyName("point_rate")] [JsonInclude] public int PointRate { get; private set; }
        [JsonPropertyName("video_url")] [JsonInclude] public string VideoUrl { get; private set; }
        [JsonPropertyName("product_introduction")] [JsonInclude] public string ProductIntroduction { get; private set; }

        public string DisplayPrice()
        {
            return "¥" + Price;
        }
        public string DisplayRate()
        {
            return PointRate + "%off";
        }
        
    }
}