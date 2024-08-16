using Com.Shelinc.Windows;
using Game.Global;
using GameComponentAttributes.Attributes;
using VContainer;
using VContainer.Unity;

namespace Game.MainMenu {
	public class MainMenuScope : LifetimeScope {
		[NotNullReference] public WindowManager WindowManager;
		
		protected override void Configure(IContainerBuilder builder) {
			base.Configure(builder);
			builder.Register<SceneLoader>(Lifetime.Scoped);
			builder.RegisterInstance(WindowManager);
		}
	}
}