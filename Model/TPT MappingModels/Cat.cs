using System.ComponentModel.DataAnnotations.Schema;

namespace TPH_TPT_EF_Core_Mapping.Model.TPT_MappingModels
{
    //[Table("Cats")]
    public class Cat : Animal
    {
        public string Color { get; set; }

    }
}
