using GameJamEntry.General;
using VContainer;
using VContainer.Unity;

namespace GameJamEntry {
	public class GameStartScope : LifetimeScope {
		protected override void Configure(IContainerBuilder builder) {
			base.Configure(builder);
			var globalGameState = new GameState();
			builder.RegisterInstance(globalGameState);
			builder.RegisterInstance(globalGameState.SystemSettingsController);
		}
	}
}