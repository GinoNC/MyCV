using Microsoft.FluentUI.AspNetCore.Components;
using WebBlazor.Components;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorComponents().AddInteractiveServerComponents();
builder.Services.AddServerSideBlazor(options =>
{
	options.DisconnectedCircuitRetentionPeriod = TimeSpan.FromHours(12);
	options.DetailedErrors = builder.Environment.IsDevelopment();
});

builder.Services.AddFluentUIComponents();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
	.AddInteractiveServerRenderMode();

app.Run();