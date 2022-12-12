using GameComponentAttributes;
using GameComponentAttributes.Attributes;
using GameJamEntry.MainMenu.ScreenControl;
using GameJamEntry.MainMenu.UI;
using UnityEngine;

namespace GameJamEntry.MainMenu {
	public class MainMenuStarter : GameComponent {
		[NotNull] [SerializeField] ScreenManager ScreenManager;
		[NotNull] [SerializeField] SoundHelper   SoundHelper;

		SystemSettingsController SettingsController => GameState.Instance.SystemSettingsController;

		SceneLoader _sceneLoader;

		ScreenHelper _screenHelper;
		
		protected void Start() {
			_sceneLoader  = new SceneLoader(FadeSceneTransition.Instance);
			_screenHelper = new ScreenHelper(ScreenManager, SettingsController, _sceneLoader);
			ScreenManager.Init();
			SoundHelper.Init(SettingsController);
			_screenHelper.ShowMainMenuScreen();
		}

		protected void OnDestroy() {
			SoundHelper.Deinit();
		}
	}
}