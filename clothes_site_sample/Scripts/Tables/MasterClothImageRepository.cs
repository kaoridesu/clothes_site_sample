using System.Collections.Generic;
using clothes_site_sample.scripts.Bases;
namespace clothes_site_sample.Scripts.Tables
{
    public class MasterClothImageRepository : RepositoryBase<MasterClothImageEntity, MasterClothImageRepository>
    {
        public List<MasterClothImageEntity> FindAllById(int id)
        {
            return FindAllBy(x => x.Id == id);
        }
    }
}