using Cysharp.Threading.Tasks;
using DG.Tweening;
using GameComponentAttributes;
using GameComponentAttributes.Attributes;
using NaughtyAttributes;
using UnityEngine;

namespace GameJamEntry.MainMenu.ScreenControl {
	public class BaseScreen : GameComponent {
		[BoxGroup("transition params")]
		[NotNull] public CanvasGroup CanvasGroup;

		public async UniTask Show() {
			CanvasGroup.blocksRaycasts = false;
			 await CanvasGroup.DOFade(1, 0.5f);
			 CanvasGroup.blocksRaycasts = true;
		}

		public async UniTask Hide() {
			CanvasGroup.blocksRaycasts = false;
			await CanvasGroup.DOFade(0, 0.5f);
		}
	}
}