namespace OnlineTradePlatform.Core.Entities
{
    public class Ad : EntityBase
    {
        public User User { get; set; }

        public string AdName { get; set; }
    }
}
