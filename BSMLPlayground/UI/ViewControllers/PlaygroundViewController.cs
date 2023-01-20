using BeatSaberMarkupLanguage.ViewControllers;

namespace BSMLPlayground.UI.ViewControllers
{
#pragma warning disable CS0618 // Type or member is obsolete
    public class PlaygroundViewController : HotReloadableViewController
#pragma warning restore CS0618 // Type or member is obsolete
    {
        public override string ResourceName => "BSMLPlayground.UI.Views.Playground.bsml";

        public override string ContentFilePath => Playground.PlaygroundBSML;
    }
}
