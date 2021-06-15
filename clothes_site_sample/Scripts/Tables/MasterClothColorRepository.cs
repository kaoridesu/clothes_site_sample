using System.Collections.Generic;
using clothes_site_sample.scripts.Bases;

namespace clothes_site_sample.Scripts.Tables
{
    public class MasterClothColorRepository : RepositoryBase<MasterClothColorEntity, MasterClothColorRepository>
    {
        protected override List<MasterClothColorEntity> EntityList { get; } = new();
    }
}