namespace clothes_site_sample.scripts
{
    public class Master_clothses
    {
        public int id;
        public string kind;
        public string product_name;
        public string size;
        public string color;
        public int price;
        public string material;
        public string product_introduction;
       
        public Master_clothses(int id, string kind, string productName, string size, string color, int price, string material, string productIntroduction)
        {
            this.id = id;
            this.kind = kind;
            product_name = productName;
            this.size = size;
            this.color = color;
            this.price = price;
            this.material = material;
            product_introduction = productIntroduction;
        }

        
    }
}