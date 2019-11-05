using System.Threading.Tasks;
using ItSutra.DemoGame.Configuration.Dto;

namespace ItSutra.DemoGame.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
