namespace ConfigurationsHomeWork2
{
    public class Program
    {
        //�������� 2
        //������� MVC �������, ���� ��������� �����, ��� ���� ���������� email �����������.
        //� ���� ������ ���� �������� � ���������, ����, �����������.
        //��� ���������� ����������� ������������� �� ������� ��������� ������.
        //���� �������� ������� ��������� �����������, ������������ ������ ����� ��������� �������.
        //��� ��� ���������� ���������� �� ������� ������� � ��������������� ����.
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
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
