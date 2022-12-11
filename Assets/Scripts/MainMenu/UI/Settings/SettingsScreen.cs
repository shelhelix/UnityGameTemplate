using GameComponentAttributes.Attributes;
using GameJamEntry.MainMenu.ScreenControl;
using GameJamEntry.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace GameJamEntry.MainMenu.UI {
	public class SettingsScreen : BaseScreen {
		[NotNull] [SerializeField] Button             ReturnButton;
		[NotNull] [SerializeField] SoundSettingsBlock masterSettingsBlocks;
		[NotNull] [SerializeField] SoundSettingsBlock musicSettingsBlocks;
		[NotNull] [SerializeField] SoundSettingsBlock sfxSettingsBlocks;

		ScreenManager            _screenManager;
		SystemSettingsController _systemSettingsController;
		
		public void Init(ScreenManager manager, SystemSettingsController settingsController) {
			_screenManager            = manager;
			_systemSettingsController = settingsController;
			ReturnButton.RemoveAllAndAddListener(ShowMainMenu);
			masterSettingsBlocks.Init(settingsController, MixerParamName.MasterVolume);
			musicSettingsBlocks.Init(settingsController, MixerParamName.MusicVolume);
			sfxSettingsBlocks.Init(settingsController, MixerParamName.SfxVolume);
		}

		void ShowMainMenu() {
			_screenManager.ShowScreen<MainMenuScreen>(x => x.Init(_screenManager, _systemSettingsController)).Forget();
		}
	}
}