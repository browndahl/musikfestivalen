using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using festival.Client.Services;
using festival.Client;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


//Data1 - Koordinator service
builder.Services.AddHttpClient<IKoordinatorService, KoordinatorService>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

//Data2 - Vagt service
builder.Services.AddHttpClient<IVagtService, VagtService>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});
//Data3 - Frivillige service 
builder.Services.AddHttpClient<IFrivilligeService, FrivilligeService>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

//Data4 - Arbejdsplads service 
builder.Services.AddHttpClient<IArbejdspladsService, ArbejdspladsService>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

//Data5 - Musik service 
builder.Services.AddHttpClient<IMusikService, MusikService>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});



await builder.Build().RunAsync();



