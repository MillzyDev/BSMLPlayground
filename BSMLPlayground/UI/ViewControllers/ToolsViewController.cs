using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.ViewControllers;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace BSMLPlayground.UI.ViewControllers
{
    [ViewDefinition("BSMLPlayground.UI.Views.ToolsView.bsml")]
    public class ToolsViewController : BSMLAutomaticViewController
    {
        [UIAction("open-location")]
        public void OpenLocation()
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = Path.GetDirectoryName(Playground.PlaygroundBSML),
                UseShellExecute = true,
                Verb = "open"
            });
        }
    }
}
