﻿using VContainer;
using VContainer.Unity;

namespace GameJamEntry {
	public class GameStartScope : LifetimeScope {
		protected override void Configure(IContainerBuilder builder) {
			base.Configure(builder);
			// TODO: add your game-wide necessary classes
		}
	}
}