namespace OnlineTradePlatform.Core.Entities
{
    public class User : EntityBase
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public IEnumerable<Ad> Ads { get; set; }
    }
}
