namespace OnlineStoreApp_2.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int Stars { get; set; }
        //Stok
        public int Piece { get; set; }

        public int CategoryId { get; set; }
    }
}