using Cysharp.Threading.Tasks;

namespace GameJamEntry.SceneLoading.Transitions {
	public interface ISceneTransition {
		public UniTask HideScenes();
		public UniTask ShowScenes();
	}
}