using System.Text.Json.Serialization;
using clothes_site_sample.scripts.Bases;

namespace clothes_site_sample.Scripts.Tables
{
    public class MasterClothImageEntity : EntityBase
    {
        [JsonPropertyName("id")] [JsonInclude] public int Id { get; private set; }
        [JsonPropertyName("master_clothes_id")] [JsonInclude] public int MasterClothId { get; private set; }
        [JsonPropertyName("url")] [JsonInclude] public string Url { get; private set; }

        public MasterClothImageEntity()
        {
        }
    }
}