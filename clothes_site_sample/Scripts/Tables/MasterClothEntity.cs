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

        public MasterClothEntity()
        {
        }

        // public MasterClothEntity(int id, string category, string kind, string productName, string code, string material,
        //     int price, int pointRate, string videoUrl, string productIntroduction)
        // {
        //     this.id = id;
        //     this.category = category;
        //     this.kind = kind;
        //     this.productName = productName;
        //     this.code = code;
        //     this.material = material;
        //     this.price = price;
        //     this.pointRate = pointRate;
        //     this.videoUrl = videoUrl;
        //     this.productIntroduction = productIntroduction;
        // }

        // public int Id => id;
        //
        // public string Category => category;
        //
        // public string Kind => kind;
        //
        // public string ProductName => productName;
        //
        // public string Code => code;
        //
        // public string Material => material;
        //
        // public int Price => price;
        //
        // public int PointRate => pointRate;
        //
        // public string VideoUrl => videoUrl;
        //
        // public string ProductIntroduction => productIntroduction;
    }
}