using Com.Shelinc.SceneTransitionEffects.Modules.SceneTransitionEffects;
using VContainer;
using VContainer.Unity;

namespace GameJamEntry.Scripts.Gameplay {
	public class GameplayScope : LifetimeScope {
		
		protected override void Configure(IContainerBuilder builder) {
			builder.Register<SceneLoader>(Lifetime.Scoped);
			builder.RegisterEntryPoint<GameplayStarter>();
		}
	}
}