using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Options;

namespace _12_AutentificationAvtorization
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(
                options =>
                {
                    options.LoginPath = "/registre/signin";
                });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            // ��������� � �������� ������� ������ middleware �������������� �� �����������
            // �� ����� ���� ���� �������� ����������� �� ���������� ������� (� ������ ������� - Cookies)

            // ��� ��������������, ������� ��������� �������� Cookie ��������������, 
            // ������ �������� � ����� ��� ��� ����������� �� ��������� �� � ����������� ��'��� 
            // � �������� ������� ������. (HttpContext.User)
            app.UseAuthentication();

            // �� ���� ����������� ������� ���������, �� � � ����������� ������ �� �������, ���� ����������
            // ���������, ���� ������������������ ���������� ���������� �� ������ 䳿, ������������� 
            // ��������� Authorize, ����� �� ������ ����������� �� ������� ���������� ���������� �� ������� ��� �����
            app.UseAuthorization();//

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
