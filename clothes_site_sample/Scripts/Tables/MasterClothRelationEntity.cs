using System.Text.Json.Serialization;
using clothes_site_sample.scripts.Bases;

namespace clothes_site_sample.Scripts.Tables
{
    public class MasterClothRelationEntity : EntityBase
    {
        [JsonPropertyName("id")] [JsonInclude] public int Id { get; private set; }

        public MasterClothRelationEntity()
        {
        }
    }
}