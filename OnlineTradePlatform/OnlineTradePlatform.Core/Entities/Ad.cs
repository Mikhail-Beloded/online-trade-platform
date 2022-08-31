namespace OnlineTradePlatform.Core.Entities
{
    public class Ad : EntityBase
    {
        public User User { get; set; }

        string AdName { get; set; }
    }
}
