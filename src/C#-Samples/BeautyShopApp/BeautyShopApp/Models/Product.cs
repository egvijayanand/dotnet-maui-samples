namespace BeautyShopApp.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public bool IsEmpty()
        {
            return Name == null && Image == null && Description == null;
        }
    }
}