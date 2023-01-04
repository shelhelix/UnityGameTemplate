using GameComponentAttributes.Attributes;
using GameJamEntry.Gameplay;
using GameJamEntry.MainMenu.ScreenControl;
using GameJamEntry.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace GameJamEntry.MainMenu.UI.Settings {
	public class SettingsScreen : BaseScreen {
		[NotNullReference] [SerializeField] Button             ReturnButton;
		[NotNullReference] [SerializeField] SoundSettingsBlock masterSettingsBlocks;
		[NotNullReference] [SerializeField] SoundSettingsBlock musicSettingsBlocks;
		[NotNullReference] [SerializeField] SoundSettingsBlock sfxSettingsBlocks;
		
		public void Init(ScreenHelper helper, SystemSettingsController settingsController) {
			ReturnButton.RemoveAllAndAddListener(helper.ShowMainMenuScreen);
			masterSettingsBlocks.Init(settingsController, MixerParamName.MasterVolume);
			musicSettingsBlocks.Init(settingsController, MixerParamName.MusicVolume);
			sfxSettingsBlocks.Init(settingsController, MixerParamName.SfxVolume);
		}
	}
}