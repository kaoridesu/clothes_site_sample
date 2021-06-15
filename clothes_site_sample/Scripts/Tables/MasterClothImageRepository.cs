using System.Collections.Generic;
using clothes_site_sample.scripts.Bases;

namespace clothes_site_sample.Scripts.Tables
{
    public class MasterClothImageRepository : RepositoryBase<MasterClothImageEntity, MasterClothImageRepository>
    {
        protected override List<MasterClothImageEntity> EntityList { get; } = new();
    }
}