using Microsoft.AspNetCore.Antiforgery;
using Sdt.Controllers;

namespace Sdt.Web.Host.Controllers
{
    public class AntiForgeryController : SdtControllerBase
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
