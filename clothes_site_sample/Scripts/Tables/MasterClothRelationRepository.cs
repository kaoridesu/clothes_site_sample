using System.Collections.Generic;
using clothes_site_sample.scripts.Bases;

namespace clothes_site_sample.Scripts.Tables
{
    public class
        MasterClothRelationRepository : RepositoryBase<MasterClothRelationEntity, MasterClothRelationRepository>
    {
        public List<MasterClothRelationEntity> FindAllByMasterClothId(int masterClothId)
        {
            return FindAllBy(x => x.MasterClothId == masterClothId);
        }
    }
}
