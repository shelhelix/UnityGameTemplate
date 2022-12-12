using Cysharp.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace GameJamEntry {
	public class SceneLoader {
		ISceneTransition _transition;

		public SceneLoader(ISceneTransition transition) => _transition = transition;

		public async UniTask LoadScene(string sceneName) {
			await _transition.HideScenes();
			await SceneManager.LoadSceneAsync(sceneName);
			await _transition.ShowScenes();
		}
	}
}