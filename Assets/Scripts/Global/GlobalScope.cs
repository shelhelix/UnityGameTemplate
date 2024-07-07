using Game.Global.Sound;
using Game.Utils;
using Modules.Audio;
using Modules.SceneTransitionEffects.Transitions;
using Modules.SceneTransitionEffects.Transitions.Implementations;
using VContainer;
using VContainer.Unity;

namespace Game.Global {
	// Base scope that is created when the game starts
	public class GlobalScope : LifetimeScope {
		protected override void Configure(IContainerBuilder builder) {
			base.Configure(builder);
			builder.RegisterComponentFromResources<AudioElements>("AudioPlayer", Lifetime.Singleton).DontDestroyOnLoad();
			builder.RegisterComponentFromResources<FadeSceneTransition>(FadeSceneTransition.ResourcePath, Lifetime.Singleton)
				.DontDestroyOnLoad()
				.As<ISceneTransition>();
			builder.Register<SoundSettingsController>(Lifetime.Singleton);
			builder.Register<AudioPlayer>(Lifetime.Singleton);
			builder.Register<BgmManager>(Lifetime.Singleton);
		}
	}
}