using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ItSutra.DemoGame.Localization
{
    public static class DemoGameLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(DemoGameConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(DemoGameLocalizationConfigurer).GetAssembly(),
                        "ItSutra.DemoGame.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
