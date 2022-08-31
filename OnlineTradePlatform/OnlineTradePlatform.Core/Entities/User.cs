namespace OnlineTradePlatform.Core.Entities
{
    public class User : EntityBase
    {
        public string Name { get; set; }

        string Email { get; set; }

        string PhoneNumber { get; set; }
    }
}
