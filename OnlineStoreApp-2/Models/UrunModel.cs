namespace OnlineStoreApp_2.Models
{
    public class UrunModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int Stars { get; set; }
        //Stok
        public int Piece { get; set; }
    }
}