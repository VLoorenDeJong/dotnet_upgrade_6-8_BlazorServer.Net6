using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Migration.Net_6_8_BlazorServer.Net_6;
using Migration.Net_6_8_BlazorServer.Net_6.Data;
using Migration.Net_6_8_BlazorServer.Net_6.Pages;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAntiforgery();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
