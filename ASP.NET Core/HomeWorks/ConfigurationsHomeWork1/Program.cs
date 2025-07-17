using ConfigurationsHomeWork1.ConfogurationModel;

namespace ConfigurationsHomeWork1
{
    //�������� 1
    //�������� MVC ������� � ����� ��������.������� �� ���������� �����������, ��� ����������� � ���� ������������.
    //������ ���, ��� �������� ���������� ����������� � ������, ���� �������� ���������� � ���������������� ����.
    //��� ��������� ����� � ������ �������� �� ������� ���������������.

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //��'���� ������ ���������������� ����� � ������������� �����
            builder.Services.Configure<ConnectionModel>(builder.Configuration.GetSection("connection"));

            var app = builder.Build();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
