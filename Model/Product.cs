namespace TPH_TPT_EF_Core_Mapping.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public Model? Model { get; set; }
    }
}
