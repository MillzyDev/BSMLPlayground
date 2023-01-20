using BSMLPlayground.Installers;
using IPA;
using IPA.Logging;
using SiraUtil.Zenject;
using System.IO;
using System.Reflection;

namespace BSMLPlayground
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {

        [Init]
        public void Init(Logger logger, Zenjector zenjector)
        {
            string playgroundBSML = Playground.PlaygroundBSML;
            if (!File.Exists(playgroundBSML))
            {
                File.WriteAllText(playgroundBSML, GetDefaultPlaygroundBSML());
            }

            zenjector.UseLogger(logger);
            zenjector.UseMetadataBinder<Plugin>();

            zenjector.Install<MenuInstaller>(Location.Menu);
        }

        private string GetDefaultPlaygroundBSML()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "BSMLPlayground.UI.Views.Playground.bsml";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
