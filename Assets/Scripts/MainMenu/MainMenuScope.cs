using Com.Shelinc.FullscreenCanvasController.Modules.FullscreenCanvasController;
using Com.Shelinc.SceneTransitionEffects.Modules.SceneTransitionEffects;
using Com.Shelinc.SceneTransitionEffects.Modules.SceneTransitionEffects.Transitions;
using Com.Shelinc.SceneTransitionEffects.Modules.SceneTransitionEffects.Transitions.Implementations;
using GameComponentAttributes.Attributes;
using GameJamEntry.Scripts.MainMenu.UI;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace GameJamEntry.Scripts.MainMenu {
	public class MainMenuScope : LifetimeScope {
		[NotNullReference] [SerializeField] ScreenManager ScreenManager;
		
		protected override void Configure(IContainerBuilder builder) {
			base.Configure(builder);
			builder.RegisterInstance(FadeSceneTransition.Instance).As<ISceneTransition>();
			builder.Register<SceneLoader>(Lifetime.Scoped);
			builder.RegisterInstance(ScreenManager);
			builder.Register<MainMenuScreenHelper>(Lifetime.Scoped);
		}
	}
}