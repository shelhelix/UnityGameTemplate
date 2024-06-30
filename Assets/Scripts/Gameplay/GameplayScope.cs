using Com.Shelinc.SceneTransitionEffects.Modules.SceneTransitionEffects;
using Com.Shelinc.SceneTransitionEffects.Modules.SceneTransitionEffects.Transitions;
using Com.Shelinc.SceneTransitionEffects.Modules.SceneTransitionEffects.Transitions.Implementations;
using VContainer;
using VContainer.Unity;

namespace GameJamEntry.Scripts.Gameplay {
	public class GameplayScope : LifetimeScope {
		
		protected override void Configure(IContainerBuilder builder) {
			base.Configure(builder);
			builder.RegisterInstance<ISceneTransition>(FadeSceneTransition.Instance);
			builder.Register<SceneLoader>(Lifetime.Scoped);
			builder.RegisterEntryPoint<GameplayStarter>();
		}
	}
}