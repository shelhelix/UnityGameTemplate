using System.Collections.Generic;
using Com.Shelinc.Windows;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Game.Global;
using Game.MainMenu.UI.GameSettings;
using Game.Utils.UI;
using GameComponentAttributes.Attributes;
using Modules.Audio;
using UnityEditor;
using UnityEngine;
using VContainer;

namespace Game.MainMenu {
	public class MainMenuStarter : MonoBehaviour {
		const string JamLink = "add link to jam here";
		
		[NotNullReference] public List<AudioClip> Bgms;

		// canvas group for animation
		[NotNullReference] public CanvasGroup Group;
		
		[NotNullReference] public ButtonWrapper PlayButton;
		[NotNullReference] public ButtonWrapper SettingsButton;
		[NotNullReference] public ButtonWrapper JamLinkButton;
		[NotNullReference] public ButtonWrapper ExitButton;

		[Inject]
		public void Init(BgmManager bgmManager, SceneLoader sceneLoader, WindowManager windowManager) {
			bgmManager.PlayBgms(Bgms);
			PlayButton.RemoveAllAndAddListener(() => sceneLoader.LoadScene(SceneLoader.GameplayScene).Forget());
			SettingsButton.RemoveAllAndAddListener(() =>ShowSettingsWindow(windowManager));
			JamLinkButton.RemoveAllAndAddListener(() => Application.OpenURL(JamLink));
			ExitButton.RemoveAllAndAddListener(Exit);
		}

		async UniTask ShowSettingsWindow(WindowManager windowManager) {
			Group.interactable = false;
			var hidingTask  = Group.DOFade(0, 0.3f).ToUniTask();
			var shownWindow = windowManager.ShowWindow(SettingsWindow.CreateShowRequest());
			await shownWindow.HideStarted.AwaitTrigger();
			await hidingTask;
			// return to normal after window and main screen view is hidden
			Group.interactable = true;
			await Group.DOFade(1, 0.3f).ToUniTask();
		}
		
		void Exit() {
#if UNITY_EDITOR
			EditorApplication.isPlaying = false;
#else
			Application.Quit();
#endif
		}
	}
}