using System.Collections.Generic;
using clothes_site_sample.scripts.Bases;

namespace clothes_site_sample.Scripts.Tables
{
    public class MasterProductRepository : RepositoryBase<MasterProductEntity, MasterProductRepository>
    {
        protected override List<MasterProductEntity> EntityList { get; } = new();
    }
}