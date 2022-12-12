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
		
		public void Init(ScreenHelper helper, SystemSettingsController settingsController) {
			ReturnButton.RemoveAllAndAddListener(helper.ShowMainMenuScreen);
			masterSettingsBlocks.Init(settingsController, MixerParamName.MasterVolume);
			musicSettingsBlocks.Init(settingsController, MixerParamName.MusicVolume);
			sfxSettingsBlocks.Init(settingsController, MixerParamName.SfxVolume);
		}
	}
}