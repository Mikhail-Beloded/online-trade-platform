using System.ComponentModel.DataAnnotations;

namespace OnlineTradePlatform.Core
{
    public class EntityBase
    {
        [Key]

        public int Id { get; set; }
    }
}
