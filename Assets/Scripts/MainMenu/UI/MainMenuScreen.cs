using Com.Shelinc.FullscreenCanvasController.Modules.FullscreenCanvasController;
using Com.Shelinc.SceneTransitionEffects.Modules.SceneTransitionEffects;
using Cysharp.Threading.Tasks;
using GameComponentAttributes.Attributes;
using GameJamEntry.Scripts.Utils.UI;
using UnityEditor;
using UnityEngine;
#if UNITY_EDITOR
#endif

namespace  GameJamEntry.Scripts.MainMenu.UI {
	public class MainMenuScreen : BaseScreen {
		const string JamLink = "add link to jam here";
		
		[NotNullReference] [SerializeField] ButtonWrapper PlayButton;
		[NotNullReference] [SerializeField] ButtonWrapper SettingsButton;
		[NotNullReference] [SerializeField] ButtonWrapper JamLinkButton;
		[NotNullReference] [SerializeField] ButtonWrapper ExitButton;

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