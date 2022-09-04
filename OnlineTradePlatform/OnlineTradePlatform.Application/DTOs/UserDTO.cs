using OnlineTradePlatform.Core.Entities;

namespace OnlineTradePlatform.Application.DTOs
{
    public class UserDTO
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public IEnumerable<Ad> Ads { get; set; }
    }
}
