using System;
using System.Reflection;
using System.Threading.Tasks;
using Alexa.NET.Request;
using Alexa.NET.RequestHandlers;
using Alexa.NET.Response;
using libc.translation;

namespace alexa_dotnet_lambda_helloworld.utils
{
    public static class LocalizationManager
    {
        public static string CurrentLocale;
        private static Localizer Localizer;
        public static void Init(string locale)
        {
            CurrentLocale = locale;
            Localizer = StartLocalizer(CurrentLocale);
        }

        public static string Translate(string key)
        {
            return Localizer.Get(CurrentLocale, key);
        }

        private static Localizer StartLocalizer(String locale)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.Location);
            ILocalizationSource source = new LocalizationSource(assembly, "alexa_dotnet_lambda_helloworld.locales.locales.json");
            return new Localizer(source: source, fallbackCulture: "en");

        }
    }
}
