using System.Runtime.Serialization;
using clothes_site_sample.scripts.Bases;

namespace clothes_site_sample.Scripts.Tables
{
    public class MasterClothEntity : EntityBase
    {
        [DataMember(Name = "id")] public int Id { get; init; }
        [DataMember(Name = "category")] public string Category { get; init; }
        [DataMember(Name = "kind")] public string Kind { get; init; }
        [DataMember(Name = "product_name")] public string ProductName { get; init; }
        [DataMember(Name = "code")] public string Code { get; init; }
        [DataMember(Name = "material")] public string Material { get; init; }
        [DataMember(Name = "price")] public int Price { get; init; }
        [DataMember(Name = "point_rate")] public int PointRate { get; init; }
        [DataMember(Name = "video_url")] public string VideoUrl { get; init; }
        [DataMember(Name = "product_introduction")] public string ProductIntroduction { get; init; }

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