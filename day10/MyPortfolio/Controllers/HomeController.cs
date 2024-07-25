using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Data;
using MyPortfolio.Helper;
using MyPortfolio.Models;
using System.Diagnostics;
using System.Security.Cryptography; // 암호화 

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        //public HomeController(ILogger<HomeController> logger, AppDbContext _context)
        //{
        //    _logger = logger;
        //    AppDbContext context; // DB를 연결해서 사용하겠다는 초기화 설정
        //}

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet] // 디폴트 값이라 생략가능하지만 지금은 작성 
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            // userEmail, password md5로 암호화
            // DB에 있는 값과 비교
            var mdHash = MD5.Create();
            user.Password = Common.GetMd5Hash(mdHash, user.Password); // 로그인창에 입력한 암호를 암호화

            var result = _context.User.FirstOrDefault(u => u.UserEmail == user.UserEmail && u.Password == user.Password);

            if (result == null) // 로그인 할 사람이 없다
            {
                return View(user);
            }
            else
            {
                // 로그인 세션처리
                HttpContext.Session.SetInt32("USER_LOGIN_KEY", result.Id);
                HttpContext.Session.SetString("USER_NAME", result.UserName);
                HttpContext.Session.SetString("USER_EMAIL", result.UserEmail);

                return RedirectToAction("Index", "Home"); // 로그인 완료
            }
        }

        [HttpGet]
        public IActionResult Logout()
        {
            // 로그인시 생선된 세션 삭제
            HttpContext.Session.Remove("USER_LOGIN_KEY");
            HttpContext.Session.Remove("USER_NAME");
            HttpContext.Session.Remove("USER_EMAIL");

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // 회원로그인으로 새로추가 
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // 회원등록 페이지를 열기 
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        // 회원등록 페이지 내용을 DB에 저장 
        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            if (user.Password != user.PasswordCheck)
            {
                // 패스워드 두 개가 일치하지 않을 때, 일부러 검증에러를 발생시킴 
                ModelState.AddModelError("passwordCheck", "패스워드가 일치하지 않습니다.");
            }

            if (ModelState.IsValid)
            {
                user.RegDate = DateTime.Now; // 회원 등록 날짜를 오늘로 저장

                var mdHash = MD5.Create();
                user.Password = Common.GetMd5Hash(mdHash, user.Password);
                user.PasswordCheck = null;

                _context.Add(user); // Insert
                await _context.SaveChangesAsync();  // Commit 
                return RedirectToAction("Login");
            }
            return View(user);
        }
    }
}
