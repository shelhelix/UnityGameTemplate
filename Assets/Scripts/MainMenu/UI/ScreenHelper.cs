using GameJamEntry.Gameplay;
using GameJamEntry.MainMenu.ScreenControl;
using GameJamEntry.MainMenu.UI.Settings;
using GameJamEntry.SceneLoading;

namespace GameJamEntry.MainMenu.UI {
	public class ScreenHelper {
		readonly ScreenManager            _screenManager;
		readonly SystemSettingsController _systemSettingsController;
		readonly SceneLoader              _sceneLoader;

		public ScreenHelper(ScreenManager screenManager, SystemSettingsController settingsController, SceneLoader sceneLoader) {
			_screenManager            = screenManager;
			_systemSettingsController = settingsController;
			_sceneLoader              = sceneLoader;
		}
		
		public void ShowMainMenuScreen() {
			_screenManager.ShowScreen<MainMenuScreen>(x => x.Init(this, _systemSettingsController, _sceneLoader)).Forget();
		}

		public void ShowSettingsScreen() {
			_screenManager.ShowScreen<SettingsScreen>(x => x.Init(this, _systemSettingsController)).Forget();
		}
	}
}