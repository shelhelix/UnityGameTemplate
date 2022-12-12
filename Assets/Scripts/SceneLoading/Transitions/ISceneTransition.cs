using Cysharp.Threading.Tasks;

namespace GameJamEntry {
	public interface ISceneTransition {
		public UniTask HideScenes();
		public UniTask ShowScenes();
	}
}