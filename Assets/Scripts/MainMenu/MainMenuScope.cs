using GameComponentAttributes.Attributes;
using GameJamEntry.General;
using GameJamEntry.MainMenu.SceneLoading;
using GameJamEntry.MainMenu.SceneLoading.Transitions;
using GameJamEntry.MainMenu.ScreenControl;
using GameJamEntry.MainMenu.UI;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace GameJamEntry.MainMenu {
	public class MainMenuScope : LifetimeScope {
		[NotNullReference] [SerializeField] ScreenManager ScreenManager;
		
		protected override void Configure(IContainerBuilder builder) {
			base.Configure(builder);
			builder.RegisterInstance(GameState.Instance.SystemSettingsController);
			builder.RegisterInstance(FadeSceneTransition.Instance).As<ISceneTransition>();
			builder.Register<SceneLoader>(Lifetime.Scoped);
			builder.RegisterInstance(ScreenManager);
			builder.Register<ScreenHelper>(Lifetime.Scoped);
			builder.RegisterEntryPoint<MainMenuStarter>();
		}
	}
}