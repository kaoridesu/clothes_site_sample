using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using clothes_site_sample.scripts.Bases;

namespace clothes_site_sample.Scripts.Tables
{
    public class MasterClothRepository : RepositoryBase<MasterClothEntity, MasterClothRepository>
    {
        public List<MasterClothEntity> Test()
        {
            return FindAll();
        }
    }
}
