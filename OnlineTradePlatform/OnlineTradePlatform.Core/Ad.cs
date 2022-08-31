namespace OnlineTradePlatform.Core
{
    public class Ad : EntityBase
    {
        User User { get; set; }

        string AdName { get; set; }
    }
}
