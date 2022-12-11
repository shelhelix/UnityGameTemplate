using GameComponentAttributes.Attributes;
using GameJamEntry.MainMenu.ScreenControl;
using GameJamEntry.Utils;
#if UNITY_EDITOR
using UnityEditor;
#endif
// ReSharper disable once RedundantUsingDirective
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace  GameJamEntry.MainMenu.UI {
	public class MainMenuScreen : BaseScreen {
		[NotNull] public Button PlayButton;
		[NotNull] public Button SettingsButton;
		[NotNull] public Button ExitButton;

		ScreenManager _screenManager;

		public void Init(ScreenManager screenManager) {
			_screenManager = screenManager;
			PlayButton.RemoveAllAndAddListener(() => SceneManager.LoadScene("Gameplay"));
			SettingsButton.RemoveAllAndAddListener(ShowSettingsWindow);
			ExitButton.RemoveAllAndAddListener(Exit);
		}

		void ShowSettingsWindow() {
			_screenManager.ShowScreen<SettingsScreen>(x => x.Init(_screenManager)).Forget();
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