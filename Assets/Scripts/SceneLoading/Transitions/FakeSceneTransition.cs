using Cysharp.Threading.Tasks;

namespace GameJamEntry.SceneLoading.Transitions {
	public class FakeSceneTransition : SceneTransitionSingleton<FakeSceneTransition> {
		public override UniTask HideScenes() => UniTask.CompletedTask;

		public override UniTask ShowScenes() => UniTask.CompletedTask;
	}
}