using Game.Global;
using VContainer;
using VContainer.Unity;

namespace Game.Gameplay {
	public class GameplayScope : LifetimeScope {
		protected override void Configure(IContainerBuilder builder) {
			builder.Register<SceneLoader>(Lifetime.Scoped);
			builder.RegisterEntryPoint<GameplayStarter>();
		}
	}
}