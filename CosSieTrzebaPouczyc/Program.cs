

namespace CosSieTrzebaPouczyc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            /*          
            builder.Services.AddRazorPages();
            */
            builder.Services.AddControllers();
            builder.WebHost.UseUrls($"http://localhost:4200");
            var app = builder.Build();



            /*           
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();*/



            app.UseAuthorization();

            /*            
            app.MapRazorPages()
            ;*/
            app.MapControllers();
            app.Run();
           
        }
    }
}
