using Microsoft.AspNetCore.Mvc;
using OnlineTradePlatform.Application.IServices;
using OnlineTradePlatform.Application.Mapping;

namespace OnlineTradePlatform.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUsersService _usersService;

        private readonly Mapper _mapper = new();

        public UserController(IUsersService usersService)
        {
            this._usersService = usersService;
        }
    }
}
