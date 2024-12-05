namespace KimHien.BusinessObject
{
    public class Product
    {
        public int id { get; set; }
        public string product_name { get; set; }

        public string image { get; set; }

        public float weight { get; set; }
        
        public float price { get; set; }

        public int category_id { get; set; }

        public string status {get; set; }

        public string material { get; set; }

        public string description { get; set; }

        public string type { get; set; }

        }
    }
