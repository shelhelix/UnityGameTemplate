using Cysharp.Threading.Tasks;
using Game.Utils.UI;
using GameComponentAttributes.Attributes;
using Modules.FullscreenCanvasController;
using Modules.SceneTransitionEffects;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace  Game.MainMenu.UI {
	public class MainMenuScreen : BaseScreen {
		const string JamLink = "add link to jam here";
		
		[NotNullReference] public ButtonWrapper PlayButton;
		[NotNullReference] public ButtonWrapper SettingsButton;
		[NotNullReference] public ButtonWrapper JamLinkButton;
		[NotNullReference] public ButtonWrapper ExitButton;

		public void Init(MainMenuScreenHelper mainMenuScreenHelper, SceneLoader sceneLoader) {
			PlayButton.RemoveAllAndAddListener(() => sceneLoader.LoadScene(SceneLoader.GameplaySceneName).Forget());
			SettingsButton.RemoveAllAndAddListener(mainMenuScreenHelper.ShowSettingsScreen);
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