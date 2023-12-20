namespace OnlineStoreApp_2.Data
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int Stars { get; set; }
        public int Piece { get; set; }
        public int CategoryId { get; set; }

        public CategoryEntity Category { get; set; }
    }
}
