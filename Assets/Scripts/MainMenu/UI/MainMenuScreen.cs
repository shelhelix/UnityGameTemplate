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
		const string JamLink           = "add link to jam here";
		const string GameplaySceneName = "Gameplay";
		
		[NotNull] [SerializeField] Button PlayButton;
		[NotNull] [SerializeField] Button SettingsButton;
		[NotNull] [SerializeField] Button JamLinkButton;
		[NotNull] [SerializeField] Button ExitButton;

		public void Init(ScreenManager screenManager, SystemSettingsController settingsController) {
			PlayButton.RemoveAllAndAddListener(() => SceneManager.LoadScene(GameplaySceneName));
			SettingsButton.RemoveAllAndAddListener(() => screenManager.ShowScreen<SettingsScreen>(x => x.Init(screenManager, settingsController)).Forget());
			JamLinkButton.RemoveAllAndAddListener(() => Application.OpenURL(JamLink));
			ExitButton.RemoveAllAndAddListener(Exit);
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