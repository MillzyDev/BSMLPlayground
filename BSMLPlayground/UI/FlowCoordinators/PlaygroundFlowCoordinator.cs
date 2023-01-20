using BeatSaberMarkupLanguage;
using BSMLPlayground.UI.ViewControllers;
using HMUI;
using Zenject;

namespace BSMLPlayground.UI.FlowCoordinators
{
    public class PlaygroundFlowCoordinator : FlowCoordinator
    {
        private MainFlowCoordinator _mainFlowCoordinator;
        private PlaygroundViewController _playgroundViewController;
        private ToolsViewController _toolsViewController;

        [Inject]
        public void Inject(MainFlowCoordinator mainFlowCoordinator, PlaygroundViewController playgroundViewController, ToolsViewController toolsViewController)
        {
            _mainFlowCoordinator = mainFlowCoordinator;
            _playgroundViewController = playgroundViewController;
            _toolsViewController = toolsViewController;
        }

        protected override void DidActivate(bool firstActivation, bool addedToHierarchy, bool screenSystemEnabling)
        {
            if (!firstActivation) return;
            showBackButton = true;
            SetTitle("BSMLPlayground");
            ProvideInitialViewControllers(_playgroundViewController, _toolsViewController);
        }

        protected override void BackButtonWasPressed(ViewController _)
        {
            _mainFlowCoordinator.DismissFlowCoordinator(this);
        }
    }
}
