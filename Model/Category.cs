namespace TPH_TPT_EF_Core_Mapping.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
