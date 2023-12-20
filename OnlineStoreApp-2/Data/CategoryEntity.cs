namespace OnlineStoreApp_2.Data
{
    public class CategoryEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<ProductEntity> Products { get; set; }
    }
}
