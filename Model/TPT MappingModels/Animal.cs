namespace TPH_TPT_EF_Core_Mapping.Model.TPT_MappingModels
{
    //[Table("Animals")] // first way to declare to ef to create tpt Model is data Annotation
    // Second way is Fluent Api
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
