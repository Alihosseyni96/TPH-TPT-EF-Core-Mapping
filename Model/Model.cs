namespace TPH_TPT_EF_Core_Mapping.Model
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
