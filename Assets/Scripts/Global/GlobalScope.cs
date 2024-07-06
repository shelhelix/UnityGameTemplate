using Com.Shelinc.SceneTransitionEffects.Modules.SceneTransitionEffects.Transitions.Implementations;
using GameJamEntry.Scripts.Global.Sound;
using GameJamEntry.Scripts.Utils;
using Modules.Audio;
using VContainer;
using VContainer.Unity;

namespace GameJamEntry.Scripts.Global {
	// Base scope that is created when the game starts
	public class GlobalScope : LifetimeScope {
		protected override void Configure(IContainerBuilder builder) {
			base.Configure(builder);
			builder.RegisterComponentFromResources<AudioElements>("AudioPlayer", Lifetime.Singleton).DontDestroyOnLoad();
			builder.RegisterComponentFromResources<FakeSceneTransition>(FakeSceneTransition.ResourcePath, Lifetime.Singleton).DontDestroyOnLoad();
			builder.Register<SoundSettingsController>(Lifetime.Singleton);
			builder.Register<AudioPlayer>(Lifetime.Singleton);
			builder.Register<BgmManager>(Lifetime.Singleton);
		}
	}
}