using Cysharp.Threading.Tasks;

namespace Modules.SceneTransitionEffects.Transitions  {
	public interface ISceneTransition {
		public UniTask HideScenes();
		public UniTask ShowScenes();
	}
}