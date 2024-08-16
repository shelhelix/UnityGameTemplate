using System.Threading;
using Cysharp.Threading.Tasks;
using Game.Utils;
using GameComponentAttributes.Attributes;
using UnityEngine;

namespace Com.Shelinc.Windows {
	public abstract class BaseWindow : MonoBehaviour {
		[NotNullReference] public BaseWindowAnimationProvider AnimationProvider;

		CancellationTokenSource _source = new();

		public readonly EventWrapper HideFinished = new();
		public readonly EventWrapper HideStarted = new();
		protected void OnDestroy() {
			_source.Cancel();
			_source.Dispose();
		}

		public virtual UniTask Show() => AnimationProvider.StartShowAnimation(_source.Token);

		public UniTask Hide() => HideInternal(_source.Token, false).ContinueWith(HideFinished.Fire);

		public void HideImmediately()  {
			HideInternal(_source.Token, true).ContinueWith(HideFinished.Fire);
		}

		protected virtual UniTask HideInternal(CancellationToken token, bool isImmediately) {
			HideStarted.Fire();
			if ( !isImmediately ) {
				return AnimationProvider.StartHideAnimation(token);
			}
			AnimationProvider.HideWindowImmediately();
			return UniTask.CompletedTask;
		}
	}
}