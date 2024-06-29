using GameJamEntry.General;
using GameJamEntry.Global;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace GameJamEntry {
	// Base scope that is created when the game starts
	public class GlobalScope : LifetimeScope {
		protected override void Configure(IContainerBuilder builder) {
			base.Configure(builder);
			var soundPrefab = Resources.Load<AudioElements>("AudioPlayer");
			builder.RegisterComponentInNewPrefab(soundPrefab, Lifetime.Singleton).DontDestroyOnLoad();
			builder.Register<SoundSettingsController>(Lifetime.Singleton);
			builder.Register<AudioPlayer>(Lifetime.Singleton);
			builder.Register<BgmManager>(Lifetime.Singleton);
		}
	}
}