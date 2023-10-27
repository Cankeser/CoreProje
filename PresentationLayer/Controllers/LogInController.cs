using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;
using DataAccessLayer.Entityframework;
using DataAccessLayer.Concrete;
using System.Linq;
using Tools;

namespace PresentationLayer.Controllers
{
    [Authorize, Route("[controller]/[action]/{id?}")]
    public class LogInController : Controller
    {
       AdminManager adminManager =new AdminManager(new EfAdminDal());
       

        [Route("/admin/giris"), AllowAnonymous]
        public IActionResult Login(string ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        [Route("/admin/giris"), AllowAnonymous, HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string ReturnUrl, string username, string password, bool remember)
        {
            Admin admin = adminManager.GetBy(g => g.UserName == username && g.Password == GeneralTool.getMD5(password)) ?? null;
            if (admin != null)
            {

                ClaimsIdentity claimsIdentity = new ClaimsIdentity("CoreProje");
                claimsIdentity.AddClaim(new Claim(ClaimTypes.Name, admin.Name + " " + admin.Surname));
                claimsIdentity.AddClaim(new Claim(ClaimTypes.PrimarySid, admin.ID.ToString()));
                //claimsIdentity.AddClaim(new Claim("Iskonto", "20"));

                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal();
                claimsPrincipal.AddIdentity(claimsIdentity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal, new AuthenticationProperties() { IsPersistent = remember });

                if (string.IsNullOrEmpty(ReturnUrl)) return Redirect("/dashboard"); else return Redirect(ReturnUrl);
            }
            else ViewBag.mesaj = "Hatalı Kullanıcı Adı veya Şifre";
            return View();
        }

        [Route("/admin/cikis")]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/admin/giris");
        }
    }
}
