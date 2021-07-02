using System.Collections.Generic;
using clothes_site_sample.scripts.Bases;

namespace clothes_site_sample.Scripts.Tables
{
    public class MasterProductRepository : RepositoryBase<MasterProductEntity, MasterProductRepository>
    {
        public List<MasterProductEntity> FindAllByMasterClothId(int masterClothId)
        {
            return FindAllBy(x => x.MasterClothId == masterClothId);
        }

        public List<MasterProductEntity> FindAllByMasterClothColorId(int masterClothColorId)
        {
            return FindAllBy(x => x.MasterClothColorId == masterClothColorId);
        }

        public List<MasterProductEntity> FindAllByMasterClothIdAndColorId(int masterClothId, int masterClothColorId)
        {
            return FindAllBy(x => x.MasterClothId == 15 && x.MasterClothColorId == 1);
        }

    }
}