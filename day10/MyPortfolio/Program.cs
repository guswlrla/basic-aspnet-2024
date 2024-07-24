using Microsoft.EntityFrameworkCore;
using MyPortfolio.Data;
using Westwind.AspNetCore.Markdown;

namespace MyPortfolio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            // DbContext 종속성 주입
            builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(
                builder.Configuration.GetConnectionString("MyConnection")
                ));

            // 로그인 세션 설정
            builder.Services.AddSession(options =>
            {
                options.Cookie.Name = "ASPNETPortfolioSession"; // 웹앱 세션 쿠키이름
                options.IdleTimeout = TimeSpan.FromMinutes(20); // 세션 지속시간 20~30분이 적당
            }).AddControllersWithViews(); // 세션의 내용을 cshtml에도 적용

            // MarkDown 관련 설정
            builder.Services.AddMarkdown();
            builder.Services.AddMvc().AddApplicationPart(typeof(MarkdownPageProcessorMiddleware).Assembly);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseMarkdown();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession(); // 세션 사용
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                // URL패턴 : https://localhost:port/controller이름/action이름/[id](옵션)
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
