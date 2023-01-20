using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.MenuButtons;
using BSMLPlayground.UI.FlowCoordinators;
using System;
using Zenject;

namespace BSMLPlayground.UI
{
    public class UIManager : IInitializable, IDisposable
    {
        private readonly MainFlowCoordinator _mainFlowCoordinator;
        private readonly PlaygroundFlowCoordinator _playgroundFlowCoordinator;
        private readonly MenuButton _menuButton;

        public UIManager(MainFlowCoordinator mainFlowCoordinator, PlaygroundFlowCoordinator playgroundFlowCoordinator)
        {
            _mainFlowCoordinator = mainFlowCoordinator;
            _playgroundFlowCoordinator = playgroundFlowCoordinator;
            _menuButton = new MenuButton("BSMLPlayground", ShowFlow);
        }

        void IInitializable.Initialize()
        {
            MenuButtons.instance.RegisterButton(_menuButton);
        }

        public void ShowFlow()
        {
            _mainFlowCoordinator.YoungestChildFlowCoordinatorOrSelf().PresentFlowCoordinator(_playgroundFlowCoordinator);
        }

        void IDisposable.Dispose()
        {
            MenuButtons.instance.UnregisterButton(_menuButton);
        }
    }
}
