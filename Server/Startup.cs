using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;

using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;

namespace app.Server
{

public class Startup
{
  public void ConfigureServices( IServiceCollection services )
  {
    services
      .AddBlazorise( options =>
      {
        options.ChangeTextOnKeyPress = true; // optional
      } )
      .AddBootstrapProviders()
      .AddFontAwesomeIcons();

    // other services
  }

  public void Configure( IComponentsApplicationBuilder app )
  {
    // other settings
    
    app.UseRouting();
    
    app.ApplicationServices
      .UseBootstrapProviders()
      .UseFontAwesomeIcons();

    app.UseEndpoints( endpoints =>
    {
        endpoints.MapBlazorHub();
        endpoints.MapFallbackToPage( "/_Host" );
    } );
  }
}
}
