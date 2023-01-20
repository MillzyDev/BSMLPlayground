using BSMLPlayground.UI;
using BSMLPlayground.UI.FlowCoordinators;
using BSMLPlayground.UI.ViewControllers;
using Zenject;

namespace BSMLPlayground.Installers
{
    public class MenuInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.Bind<PlaygroundViewController>().FromNewComponentAsViewController().AsSingle();
            Container.Bind<ToolsViewController>().FromNewComponentAsViewController().AsSingle();
            Container.BindInterfacesAndSelfTo<UIManager>().AsSingle();
            Container.BindInterfacesAndSelfTo<PlaygroundFlowCoordinator>().FromNewComponentOnNewGameObject().AsSingle();

        }
    }
}
