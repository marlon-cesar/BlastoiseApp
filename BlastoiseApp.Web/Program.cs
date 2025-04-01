using BlastoiseApp.Config;

var builder = WebApplication.CreateBuilder(args);

WebDependencies.Init(builder.Services, builder.Configuration, builder.Environment);

builder.Services.AddControllersWithViews();

var app = builder.Build();


if (app.Environment.IsProduction())
{
    app.UseExceptionHandler("/Erro/Index");
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

//app.UseResponseCompression();
app.UseRouting();
//app.UseAuthentication();
//app.UseAuthorization();
app.UseResponseCaching();
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id:guid?}");


app.Run();
