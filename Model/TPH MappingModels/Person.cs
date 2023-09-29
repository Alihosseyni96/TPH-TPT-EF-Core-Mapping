namespace TPH_TPT_EF_Core_Mapping.Model.TPH_MappingModels
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public Gender Gender { get; set; }
    }



    public enum Gender
    {
        male,
        female,
    }
}
