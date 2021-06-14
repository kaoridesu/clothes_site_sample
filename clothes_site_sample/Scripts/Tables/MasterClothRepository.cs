using System.Collections.Generic;
using clothes_site_sample.scripts.Bases;

namespace clothes_site_sample.Scripts.Tables
{
    public class MasterClothRepository : RepositoryBase<MasterClothEntity, MasterClothRepository>
    {
        protected override List<MasterClothEntity> EntityList { get; } = new();
    }
}