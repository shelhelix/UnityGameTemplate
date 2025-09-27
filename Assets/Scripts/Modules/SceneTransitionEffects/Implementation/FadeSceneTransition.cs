using Cysharp.Threading.Tasks;
using DG.Tweening;
using TriInspector;
using UnityEngine;

namespace Com.Shelinc.SceneTransitionEffects.Modules.SceneTransitionEffects.Implementation {
	public class FadeSceneTransition :  MonoBehaviour, ISceneTransition {
		public const string ResourcePath = "SceneTransitions/FadeSceneTransition";
		
		[Required] public Canvas      Canvas;
		[Required] public CanvasGroup CanvasGroup;
		
		protected void Start() {
			Canvas.gameObject.SetActive(false);
			CanvasGroup.alpha  = 0;
		}

		void OnCameraChanged(Camera cam) {
			Canvas.worldCamera = cam;
		}

		public async UniTask HideScenes() {
			Canvas.gameObject.SetActive(true);
			await CanvasGroup.DOFade(1, 0.2f);
		}

		public async UniTask ShowScenes() {
			await CanvasGroup.DOFade(0, 0.2f);
			Canvas.gameObject.SetActive(false);
		}
	}
}