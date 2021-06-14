using clothes_site_sample.scripts.Bases;

namespace clothes_site_sample.Scripts.Tables
{
    public class MasterClothEntity : EntityBase
    {
        private int id;
        private string category;
        private string kind;
        private string productName;
        private string code;
        private string material;
        private int price;
        private int pointRate;
        private string videoUrl;
        private string productIntroduction;

        public MasterClothEntity()
        {
        }

        public MasterClothEntity(int id, string category, string kind, string productName, string code, string material,
            int price, int pointRate, string videoUrl, string productIntroduction)
        {
            this.id = id;
            this.category = category;
            this.kind = kind;
            this.productName = productName;
            this.code = code;
            this.material = material;
            this.price = price;
            this.pointRate = pointRate;
            this.videoUrl = videoUrl;
            this.productIntroduction = productIntroduction;
        }

        public int Id => id;

        public string Category => category;

        public string Kind => kind;

        public string ProductName => productName;

        public string Code => code;

        public string Material => material;

        public int Price => price;

        public int PointRate => pointRate;

        public string VideoUrl => videoUrl;

        public string ProductIntroduction => productIntroduction;
    }
}