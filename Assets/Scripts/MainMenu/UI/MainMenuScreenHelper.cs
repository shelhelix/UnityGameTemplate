using Com.Shelinc.FullscreenCanvasController.Modules.FullscreenCanvasController;
using Com.Shelinc.SceneTransitionEffects.Modules.SceneTransitionEffects;
using GameJamEntry.Scripts.Global.Sound;
using GameJamEntry.Scripts.MainMenu.UI.GameSettings;

namespace GameJamEntry.Scripts.MainMenu.UI {
	public class MainMenuScreenHelper {
		readonly ScreenManager            _screenManager;
		readonly SoundSettingsController _soundSettingsController;
		readonly SceneLoader              _sceneLoader;

		public MainMenuScreenHelper(ScreenManager screenManager, SoundSettingsController settingsController, SceneLoader sceneLoader) {
			_screenManager            = screenManager;
			_soundSettingsController = settingsController;
			_sceneLoader              = sceneLoader;
			screenManager.Init();
		}
		
		public void ShowMainMenuScreen() {
			_screenManager.ShowScreen<MainMenuScreen>(x => x.Init(this, _sceneLoader)).Forget();
		}

		public void ShowSettingsScreen() {
			_screenManager.ShowScreen<SettingsScreen>(x => x.Init(this, _soundSettingsController)).Forget();
		}
	}
}