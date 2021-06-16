using System.Text.Json.Serialization;
using clothes_site_sample.scripts.Bases;

namespace clothes_site_sample.Scripts.Tables
{
    public class MasterClothColorEntity : EntityBase
    {
        [JsonPropertyName("id")] [JsonInclude] public int Id { get; private set; }
        [JsonPropertyName("master_cloth_id")] [JsonInclude] public int MasterClothesId { get; private set; }
        [JsonPropertyName("color")] [JsonInclude] public string Color { get; private set; }
        [JsonPropertyName("image_url")] [JsonInclude] public string ImageIrl { get; private set; }

        public MasterClothColorEntity()
        {
        }
    }
}