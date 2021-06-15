using clothes_site_sample.scripts.Bases;

namespace clothes_site_sample.Scripts.Tables
{
    public class MasterClothColorEntity : EntityBase
    {
        private int id;
        private int masterClothesId;
        private string color;
        private string imageIrl;

        public MasterClothColorEntity()
        {
        }

        public MasterClothColorEntity(int id, int masterClothesId, string color, string imageIrl)
        {
            this.id = id;
            this.masterClothesId = masterClothesId;
            this.color = color;
            this.imageIrl = imageIrl;
        }

        public int Id => id;

        public int MasterClothesId => masterClothesId;

        public string Color => color;

        public string ImageIrl => imageIrl;
    }
}