namespace TPH_TPT_EF_Core_Mapping.Model.TPH_MappingModels
{
    public class Client : Person
    {
        public string Email { get; set; }
        public string NationalCode { get; set; }
    }

    //آنکه ارث بری کرده نباید چیز های  reqirued  داشته باشد
}
