using VContainer;
using VContainer.Unity;

namespace GameJamEntry.Gameplay {
	public class GameplayScope : LifetimeScope {
		protected override void Configure(IContainerBuilder builder) {
			base.Configure(builder);
			// TODO: register your classes here
			builder.RegisterEntryPoint<GameplayStarter>();
		}
	}
}