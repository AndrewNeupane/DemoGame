using Microsoft.AspNetCore.Antiforgery;
using ItSutra.DemoGame.Controllers;

namespace ItSutra.DemoGame.Web.Host.Controllers
{
    public class AntiForgeryController : DemoGameControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
