using CleanArcMvc.Domain.Account;
using Microsoft.AspNetCore.Mvc;

namespace CleanArcMvc.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthenticate _authentication;

        public AccountController(IAuthenticate authentication)
        {
            _authentication = authentication;
        }
    }
}
