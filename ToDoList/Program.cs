// using Microsoft.AspNetCore.Builder;
// using Microsoft.Extensions.DependencyInjection;

// To do this ^^ we need to configure our application to use implicit using directives. To do this open up your project's .csproj and add <ImplicitUsings>enable</ImplicitUsings> to our <PropertyGroup> tags.

// Note that it's also possible to list global using directives that are applied to an entire project. To learn more about implicit and global using directives, visit the MS documentation on implicit using directives (which also includes global using directives).

//namespace ToDoList
// {
  //  if a file has multiple classes in it, the namespace statement will apply to all classes. This means that we cannot use namespace statements when a single file has multiple namespaces in it.
// namespace ToDoList;

// class Program << ---These are also not necessary
// {
//     static void Main(string[] args) << --- These are also not necessary
//     {  Note that we do not have to name our the entry point file of our program Program.cs. However, for top level statements to work, we can only use it in one file. This includes console applications as well as ASP.NET Core applications. To learn more about top level statements visit the MS Documentation on top level statements.
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews();

      WebApplication app = builder.Build();

      app.UseHttpsRedirection();
      app.UseStaticFiles();
      app.UseRouting();

      app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );

      app.Run();
  //   }
  // }
// }