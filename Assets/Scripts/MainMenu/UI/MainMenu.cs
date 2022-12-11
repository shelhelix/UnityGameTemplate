using GameComponentAttributes;
using GameComponentAttributes.Attributes;
using GameJamEntry.Utils;
#if UNITY_EDITOR
using UnityEditor;
#endif
// ReSharper disable once RedundantUsingDirective
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace  GameJamEntry.MainMenu.UI {
	public class MainMenu : GameComponent {
		[NotNull] public Button PlayButton;
		[NotNull] public Button SettingsButton;
		[NotNull] public Button ExitButton;

		protected void Start() {
			PlayButton.RemoveAllAndAddListener(() => SceneManager.LoadScene("Gameplay"));
			//TODO: remove this line and add an action to the settings button 
			SettingsButton.gameObject.SetActive(false);
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