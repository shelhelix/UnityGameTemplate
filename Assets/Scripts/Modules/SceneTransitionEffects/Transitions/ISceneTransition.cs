using Cysharp.Threading.Tasks;

namespace Com.Shelinc.SceneTransitionEffects.Modules.SceneTransitionEffects.Transitions  {
	public interface ISceneTransition {
		public UniTask HideScenes();
		public UniTask ShowScenes();
	}
}