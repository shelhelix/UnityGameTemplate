using Com.Shelinc.SceneTransitionEffects;
using Com.Shelinc.SceneTransitionEffects.Transitions;
using Com.Shelinc.SceneTransitionEffects.Transitions.Implementations;
using VContainer;
using VContainer.Unity;

namespace GameJamEntry.Gameplay {
	public class GameplayScope : LifetimeScope {
		
		protected override void Configure(IContainerBuilder builder) {
			base.Configure(builder);
			builder.RegisterInstance<ISceneTransition>(FadeSceneTransition.Instance);
			builder.Register<SceneLoader>(Lifetime.Scoped);
			builder.RegisterEntryPoint<GameplayStarter>();
		}
	}
}