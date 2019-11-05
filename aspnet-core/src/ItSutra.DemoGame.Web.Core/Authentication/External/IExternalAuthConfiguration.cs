using System.Collections.Generic;

namespace ItSutra.DemoGame.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
