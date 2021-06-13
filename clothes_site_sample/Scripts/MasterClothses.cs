namespace clothes_site_sample.scripts
{
    public class MasterCloth
    {
        public int id;
        public string kind;
        public string product_name;
        public string color;
        public int price;
        public string material;
        public string product_introduction;

        public MasterCloth(int id, string kind, string productName, int price,
            string material, string productIntroduction)
        {
            this.id = id;
            this.kind = kind;
            product_name = productName;
            this.price = price;
            this.material = material;
            product_introduction = productIntroduction;
        }
    }
}