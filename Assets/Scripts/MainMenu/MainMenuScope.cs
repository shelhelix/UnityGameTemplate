using Game.MainMenu.UI;
using GameComponentAttributes.Attributes;
using Modules.FullscreenCanvasController;
using Modules.SceneTransitionEffects;
using VContainer;
using VContainer.Unity;

namespace Game.MainMenu {
	public class MainMenuScope : LifetimeScope {
		[NotNullReference] public ScreenManager ScreenManager;
		
		protected override void Configure(IContainerBuilder builder) {
			base.Configure(builder);
			builder.Register<SceneLoader>(Lifetime.Scoped);
			builder.RegisterInstance(ScreenManager);
			builder.Register<MainMenuScreenHelper>(Lifetime.Scoped);
		}
	}
}