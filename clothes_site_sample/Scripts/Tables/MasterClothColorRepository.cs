using System.Collections.Generic;
using clothes_site_sample.scripts.Bases;

namespace clothes_site_sample.Scripts.Tables
{
    public class MasterClothColorRepository : RepositoryBase<MasterClothColorEntity, MasterClothColorRepository>
    {
        public List<MasterClothColorEntity> FindAllBymMasterClothColorId(int id)
        {
            return FindAllBy(x => x.MasterClothesId == id);
        }
    }
}